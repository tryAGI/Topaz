# CLAUDE.md -- Topaz SDK

## Overview

Auto-generated C# SDK for [Topaz Labs](https://www.topazlabs.com) -- enterprise-grade AI image and video enhancement
(upscale, sharpen, denoise, restore, lighting, matting, frame interpolation, generative enhancement).

A single `TopazClient` unifies Topaz's two official APIs:

- **Image API** (`https://api.topazlabs.com/image/v1/*`) -- single-shot enhancement with Gigapixel,
  Wonder, Bloom, Sharpen, Denoise, Color/Lighting, Matting models.
- **Video API** (`https://api.topazlabs.com/video/*`) -- async video request/upload/enhance workflow with
  Proteus, Starlight, Astra, Nyx, Apollo/Aion/Chronos, and Video Utilities models.

## Build & Test

```bash
dotnet build Topaz.slnx
dotnet test src/tests/IntegrationTests/
```

Tests skip (not fail) if `TOPAZ_API_KEY` is not set.

## Auth

API-key auth via the `X-API-Key` header -- native support via `--security-scheme`:

```csharp
using Topaz;

using var client = new TopazClient(apiKey); // TOPAZ_API_KEY env var
```

## Key Files

- `src/libs/Topaz/image-api.yaml` -- Cached copy of Topaz's Image OpenAPI 3.1 spec
- `src/libs/Topaz/video-api.yaml` -- Cached copy of Topaz's Video OpenAPI 3.0 spec
- `src/libs/Topaz/merge_specs.py` -- Merges the two specs under the shared host `https://api.topazlabs.com`
  (prefixes image paths with `/image/v1`, renames clashing tags/schemas/responses)
- `src/libs/Topaz/openapi.yaml` -- Merged spec consumed by AutoSDK
- `src/libs/Topaz/generate.sh` -- Downloads both specs, runs merge, runs AutoSDK with
  `--security-scheme ApiKey:Header:X-API-Key`
- `src/libs/Topaz/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Topaz/Extensions/TopazClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- API key auth helper
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-Clients

**Image API:**

- `client.Enhance` -- upscale / enhance (GAN + Generative)
- `client.Sharpen` -- Sharpen (GAN + Generative)
- `client.Denoise` -- noise reduction
- `client.Restore` -- generative restoration (dust, scratch, colorization)
- `client.Lighting` -- exposure, color, balance
- `client.Matting` -- alpha / segmentation masks
- `client.Tool` -- specialized tools (transparent upscale, etc.)
- `client.Estimate` -- estimate credits + time before running a job
- `client.ImageStatus` -- job status (`GetStatus`, `GetAllStatuses`, delete)
- `client.Download` -- presigned URLs for input / output images
- `client.Cancel` -- cancel an in-progress image job

**Video API:**

- `client.CreateRequest` -- classic create-request workflow (returns estimates)
- `client.CreateExpressRequest` -- express workflow (single-call)
- `client.AcceptRequest` -- accept estimates, receive upload URLs
- `client.CompleteUpload` -- finalize multipart upload
- `client.CancelRequest` -- cancel an in-progress video job
- `client.DeleteFiles` -- purge source + enhanced media
- `client.GetRequestStatus` -- video job status (progress, FPS, download URL)
- `client.GetRequestMetrics` -- per-chunk metrics
- `client.GetRequestHistory` -- paginated history
- `client.VideoStatus` -- video cloud system status

## Spec Notes

- **Source specs** are published by Topaz at
  <https://developer.topazlabs.com/reference/openapi-specs>:
  - Image YAML: <https://openapi.gitbook.com/o/HctdcUHRfIWXBVA1egPp/spec/image-12-25-updated.yaml>
  - Video YAML: <https://openapi.gitbook.com/o/HctdcUHRfIWXBVA1egPp/spec/video-12-25-updated.yaml>
- `merge_specs.py` combines the two under a single `servers:` entry
  (`https://api.topazlabs.com`) by prefixing image paths with `/image/v1`.
- Tag collision: both specs define a `Status` tag -> renamed to `ImageStatus` / `VideoStatus`.
- Schema collision: `StatusResponse` exists in both -> video's becomes `VideoStatusResponse`.
- Response collision: common HTTP error responses (`Unauthorized`, `NotFound`, etc.) -> video's
  get a `Video`-prefix.
- Auth: native -- `--security-scheme ApiKey:Header:X-API-Key` (no runtime hook required).

## MEAI Integration

`AIFunction` tools live in `Extensions/TopazClient.Tools.cs`:

- `AsEnhanceImageTool()` -- submit an image enhancement job; returns `process_id`
- `AsGetImageStatusTool()` -- poll image job status / progress / ETA
- `AsDownloadImageResultTool()` -- fetch a presigned URL for the enhanced image
- `AsGetVideoStatusTool()` -- poll video job progress, FPS, and download URL

These tools implement the async-job workflow (submit -> poll -> download) so an
`IChatClient` can drive Topaz through natural language.
