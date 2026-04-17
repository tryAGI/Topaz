#!/usr/bin/env bash
set -euo pipefail

# Topaz Labs API: two official OpenAPI 3.1 specs published via GitBook at
# https://developer.topazlabs.com/reference/openapi-specs
#   - Image API YAML:  https://openapi.gitbook.com/o/HctdcUHRfIWXBVA1egPp/spec/image-12-25-updated.yaml
#   - Video API YAML:  https://openapi.gitbook.com/o/HctdcUHRfIWXBVA1egPp/spec/video-12-25-updated.yaml
#
# Both share host https://api.topazlabs.com but with different path roots:
#   - Image:  https://api.topazlabs.com/image/v1/*
#   - Video:  https://api.topazlabs.com/video/*
#
# merge_specs.py combines them into a single openapi.yaml under the shared host
# (prefixing image paths with /image/v1 and renaming clashing tags/schemas).

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

# Refresh source specs.
curl --fail --silent --show-error --location \
  "https://openapi.gitbook.com/o/HctdcUHRfIWXBVA1egPp/spec/image-12-25-updated.yaml" \
  -o image-api.yaml
curl --fail --silent --show-error --location \
  "https://openapi.gitbook.com/o/HctdcUHRfIWXBVA1egPp/spec/video-12-25-updated.yaml" \
  -o video-api.yaml

# Merge the two specs into openapi.yaml.
python3 merge_specs.py

# Auth: X-API-Key header (native support via --security-scheme).
autosdk generate openapi.yaml \
  --namespace Topaz \
  --clientClassName TopazClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-Key
