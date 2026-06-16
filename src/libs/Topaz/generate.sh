#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

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
install_autosdk_cli
rm -rf Generated

# Refresh source specs.
fetch_spec --fail --silent --show-error --location \
  "https://openapi.gitbook.com/o/HctdcUHRfIWXBVA1egPp/spec/image-12-25-updated.yaml" \
  -o image-api.yaml
fetch_spec --fail --silent --show-error --location \
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
