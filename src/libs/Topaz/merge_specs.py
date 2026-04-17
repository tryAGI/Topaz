#!/usr/bin/env python3
"""Merge Topaz Labs Image and Video OpenAPI specs into a single spec.

Both APIs share base host https://api.topazlabs.com:
  - Image: https://api.topazlabs.com/image/v1/*
  - Video: https://api.topazlabs.com/video/*

The merged spec uses the shared host and prefixes image paths with /image/v1.
Tag and schema conflicts are resolved by prefixing video-side names with 'Video'
and image-side ambiguous names with 'Image'.
"""
import copy
import yaml


def prefix_refs(node, mapping):
    """Recursively rewrite $ref values using mapping (old_name -> new_name)."""
    if isinstance(node, dict):
        for k, v in list(node.items()):
            if k == "$ref" and isinstance(v, str):
                for category in ("schemas", "responses"):
                    prefix = f"#/components/{category}/"
                    if v.startswith(prefix):
                        name = v[len(prefix):]
                        if name in mapping.get(category, {}):
                            node[k] = prefix + mapping[category][name]
            else:
                prefix_refs(v, mapping)
    elif isinstance(node, list):
        for item in node:
            prefix_refs(item, mapping)


def rename_tags(spec, rename_map):
    """Rename tags in tag definitions and path operations."""
    for t in spec.get("tags", []):
        if t["name"] in rename_map:
            t["name"] = rename_map[t["name"]]
    for _, item in spec.get("paths", {}).items():
        for method, op in item.items():
            if not isinstance(op, dict):
                continue
            tags = op.get("tags")
            if tags:
                op["tags"] = [rename_map.get(t, t) for t in tags]


def rename_components(spec, category, rename_map):
    """Rename components (schemas, responses) and update all $ref strings."""
    comps = spec.get("components", {}).get(category, {})
    new = {}
    for k, v in comps.items():
        new[rename_map.get(k, k)] = v
    spec["components"][category] = new
    prefix_refs(spec, {category: rename_map})


def main():
    with open("image-api.yaml") as f:
        img = yaml.safe_load(f)
    with open("video-api.yaml") as f:
        vid = yaml.safe_load(f)

    # Rename image 'Status' tag to 'ImageStatus' to avoid clash with video 'Status'.
    rename_tags(img, {"Status": "ImageStatus"})
    # Rename video 'Status' tag to 'VideoStatus' so both sides have unique names.
    rename_tags(vid, {"Status": "VideoStatus"})

    # Schema conflicts: 'StatusResponse'. Prefix video-side as 'VideoStatusResponse'.
    rename_components(vid, "schemas", {"StatusResponse": "VideoStatusResponse"})

    # Response conflicts: prefix video-side with 'Video'.
    response_rename = {
        "BadRequest": "VideoBadRequest",
        "Unauthorized": "VideoUnauthorized",
        "PaymentRequired": "VideoPaymentRequired",
        "Forbidden": "VideoForbidden",
        "NotFound": "VideoNotFound",
        "InternalServerError": "VideoInternalServerError",
        "ServiceUnavailable": "VideoServiceUnavailable",
    }
    rename_components(vid, "responses", response_rename)

    # Prefix image paths with /image/v1 so both fit under the shared host.
    new_paths = {}
    for p, item in img.get("paths", {}).items():
        new_paths["/image/v1" + p] = item
    # Video paths keep their /video/... prefix (already present in spec).
    for p, item in vid.get("paths", {}).items():
        new_paths[p] = item

    merged = {
        "openapi": "3.1.0",
        "info": {
            "title": "Topaz Labs API",
            "version": "1.0.0",
            "description": (
                "Unified Topaz Labs API covering both image enhancement "
                "(upscale, sharpen, denoise, restore, lighting, matting) "
                "and video enhancement (upscale, denoise, frame interpolation)."
            ),
        },
        "servers": [
            {"url": "https://api.topazlabs.com", "description": "Production"},
        ],
        "tags": img.get("tags", []) + vid.get("tags", []),
        "paths": new_paths,
        "components": {
            "schemas": {**img["components"].get("schemas", {}), **vid["components"].get("schemas", {})},
            "responses": {**img["components"].get("responses", {}), **vid["components"].get("responses", {})},
            "requestBodies": {
                **img["components"].get("requestBodies", {}),
                **vid["components"].get("requestBodies", {}),
            },
            "parameters": {
                **img["components"].get("parameters", {}),
                **vid["components"].get("parameters", {}),
            },
            "securitySchemes": {
                "apiKeyAuth": {
                    "type": "apiKey",
                    "in": "header",
                    "name": "X-API-Key",
                    "description": "Authentication via the Topaz-generated API key in the X-API-Key header.",
                }
            },
        },
        "security": [{"apiKeyAuth": []}],
    }

    with open("openapi.yaml", "w") as f:
        yaml.dump(merged, f, default_flow_style=False, sort_keys=False, allow_unicode=True, width=200)
    print("Merged spec written to openapi.yaml")
    print(f"  paths: {len(merged['paths'])}")
    print(f"  schemas: {len(merged['components']['schemas'])}")
    print(f"  responses: {len(merged['components']['responses'])}")


if __name__ == "__main__":
    main()
