#nullable enable

namespace Topaz
{
    public partial interface ICreateRequestClient
    {
        /// <summary>
        /// Create Video Request<br/>
        /// Create a new video enhancement request.<br/>
        /// Send information about the video and desired enhancements then receive cost and time estimates.<br/>
        /// Calling this endpoint does NOT consume credits.<br/>
        /// Calling this endpoint does NOT start processing.<br/>
        /// Estimations are based on values provided, and the calculation is rerun once the system receives the source video. If the second estimate is significantly different than the initial values, the request is failed and the credits are fully refunded.<br/>
        /// The lower bound value of the cost estimate is billed.<br/>
        /// Time estimates are in development and may not be accurate.<br/>
        /// Output encoder settings are validated on this endpoint — the accepted `videoEncoder` / `videoProfile` combinations, along with the container, resolution, and bitrate limits of each, are listed under **Supported encoders and profiles** in **OutputInformationVideo**.<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type** | **Description**                     |<br/>
        /// |---------------|----------|-------------------------------------|<br/>
        /// | **requestId** | UUID     | Unique request identifier           |<br/>
        /// | **estimates** | Object   | Refer to **RequestEstimates** below |<br/>
        /// #### RequestEstimates<br/>
        /// `cost` and `time` are arrays with two integers each, representing lower and upper bounds of the estimate.<br/>
        /// | **Property** | **Type** | **Description**         |<br/>
        /// |--------------|----------|-------------------------|<br/>
        /// | **cost**     | Array    | Cost range (in credits) |<br/>
        /// | **time**     | Array    | Time range (in seconds) |
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.CreateResponse> CreateVideoRequestAsync(

            global::Topaz.CreateVideoRequestRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Video Request<br/>
        /// Create a new video enhancement request.<br/>
        /// Send information about the video and desired enhancements then receive cost and time estimates.<br/>
        /// Calling this endpoint does NOT consume credits.<br/>
        /// Calling this endpoint does NOT start processing.<br/>
        /// Estimations are based on values provided, and the calculation is rerun once the system receives the source video. If the second estimate is significantly different than the initial values, the request is failed and the credits are fully refunded.<br/>
        /// The lower bound value of the cost estimate is billed.<br/>
        /// Time estimates are in development and may not be accurate.<br/>
        /// Output encoder settings are validated on this endpoint — the accepted `videoEncoder` / `videoProfile` combinations, along with the container, resolution, and bitrate limits of each, are listed under **Supported encoders and profiles** in **OutputInformationVideo**.<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type** | **Description**                     |<br/>
        /// |---------------|----------|-------------------------------------|<br/>
        /// | **requestId** | UUID     | Unique request identifier           |<br/>
        /// | **estimates** | Object   | Refer to **RequestEstimates** below |<br/>
        /// #### RequestEstimates<br/>
        /// `cost` and `time` are arrays with two integers each, representing lower and upper bounds of the estimate.<br/>
        /// | **Property** | **Type** | **Description**         |<br/>
        /// |--------------|----------|-------------------------|<br/>
        /// | **cost**     | Array    | Cost range (in credits) |<br/>
        /// | **time**     | Array    | Time range (in seconds) |
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.CreateResponse>> CreateVideoRequestAsResponseAsync(

            global::Topaz.CreateVideoRequestRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Video Request<br/>
        /// Create a new video enhancement request.<br/>
        /// Send information about the video and desired enhancements then receive cost and time estimates.<br/>
        /// Calling this endpoint does NOT consume credits.<br/>
        /// Calling this endpoint does NOT start processing.<br/>
        /// Estimations are based on values provided, and the calculation is rerun once the system receives the source video. If the second estimate is significantly different than the initial values, the request is failed and the credits are fully refunded.<br/>
        /// The lower bound value of the cost estimate is billed.<br/>
        /// Time estimates are in development and may not be accurate.<br/>
        /// Output encoder settings are validated on this endpoint — the accepted `videoEncoder` / `videoProfile` combinations, along with the container, resolution, and bitrate limits of each, are listed under **Supported encoders and profiles** in **OutputInformationVideo**.<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type** | **Description**                     |<br/>
        /// |---------------|----------|-------------------------------------|<br/>
        /// | **requestId** | UUID     | Unique request identifier           |<br/>
        /// | **estimates** | Object   | Refer to **RequestEstimates** below |<br/>
        /// #### RequestEstimates<br/>
        /// `cost` and `time` are arrays with two integers each, representing lower and upper bounds of the estimate.<br/>
        /// | **Property** | **Type** | **Description**         |<br/>
        /// |--------------|----------|-------------------------|<br/>
        /// | **cost**     | Array    | Cost range (in credits) |<br/>
        /// | **time**     | Array    | Time range (in seconds) |
        /// </summary>
        /// <param name="source">
        /// Source details for the video
        /// </param>
        /// <param name="filters">
        /// Array of UpscaleFilter or FrameInterpolationFilter objects<br/>
        /// Example: [{"model":"prob-4","videoType":"Progressive","auto":"Auto","fieldOrder":"Auto","focusFixLevel":"Normal","compression":0.1,"details":0.2,"prenoise":0.01,"noise":0.3,"halo":0.4,"preblur":0.5,"blur":0.6,"grain":0.02,"grainSize":1,"recoverOriginalDetailValue":0.7}, {"model":"apo-8","slowmo":2,"fps":60,"duplicate":true,"duplicateThreshold":0.01}]
        /// </param>
        /// <param name="output">
        /// Desired output settings.<br/>
        /// Some values are adjusted server-side before processing:<br/>
        /// - `resolution` width and height are rounded up to the nearest multiple of 4.<br/>
        /// - `resolution` is forced to the source resolution when no upscale model is present in `filters`.<br/>
        /// - `frameRate` is forced to the source frame rate when no frame interpolation model is present in `filters`, and defaults to it when omitted.<br/>
        /// - With a frame interpolation model, `frameRate` and that filter's `fps` are both set to the greater of the two.<br/>
        /// - `container` is forced to `mov` when `videoEncoder` is `ProRes` and to `mp4` when it is `AV1` or `VP9`, and defaults to `mp4` otherwise.<br/>
        /// The express endpoint supplies no source metadata, so nothing is inferred from the source there: only `resolution` is required, `frameRate` is required only when a frame interpolation filter omits its own `fps`, and the rest of the fields listed as required below take the defaults noted above.<br/>
        /// #### Supported encoders and profiles<br/>
        /// Every accepted `videoEncoder` / `videoProfile` pair is listed below. `videoEncoder` defaults to `H265` and `videoProfile` to the default profile of the chosen encoder. Any other combination is rejected with `400` `INVALID_INPUT`, and the error message lists the profiles the encoder does support.<br/>
        /// | **videoEncoder** | **videoProfile**     | **container**       | **Max resolution** |<br/>
        /// |------------------|----------------------|---------------------|--------------------|<br/>
        /// | AV1              | `8-bit` _(default)_  | `mp4`               | 16384 x 8704       |<br/>
        /// | AV1              | `10-bit`             | `mp4`               | 16384 x 8704       |<br/>
        /// | H264             | `High` _(default)_   | `mp4`, `mov`, `mkv` | 4096 x 4096        |<br/>
        /// | H265             | `Main`               | `mp4`, `mov`, `mkv` | 8192 x 8192        |<br/>
        /// | H265             | `Main10` _(default)_ | `mp4`, `mov`, `mkv` | 8192 x 8192        |<br/>
        /// | ProRes           | `422 Proxy`          | `mov`               | 16386 x 16386      |<br/>
        /// | ProRes           | `422 LT`             | `mov`               | 16386 x 16386      |<br/>
        /// | ProRes           | `422 Std`            | `mov`               | 16386 x 16386      |<br/>
        /// | ProRes           | `422 HQ` _(default)_ | `mov`               | 16386 x 16386      |<br/>
        /// | VP9              | `Good` _(default)_   | `mp4`               | 8192 x 8192        |<br/>
        /// | VP9              | `Best`               | `mp4`               | 8192 x 8192        |<br/>
        /// - Encoder and profile values are matched case-insensitively.<br/>
        /// - **Max resolution** applies in either orientation, so AV1 also accepts 8704 x 16384. Exceeding it is rejected with `400` `INVALID_INPUT`.<br/>
        /// - **container** lists the containers you can receive for that encoder. ProRes, AV1, and VP9 replace whatever `container` you send with the single value shown; H264 and H265 honor your choice among the values shown.<br/>
        /// - `videoBitrate` is capped per encoder — **800 mbps** for AV1, **2000 mbps** for H264, H265, and VP9, and uncapped for ProRes. A higher value is rejected with `400` `INVALID_INPUT` — unless `dynamicCompressionLevel` is also set, in which case `videoBitrate` is discarded and the compression level is used instead.<br/>
        /// - `VP9` requires `videoBitrate`. Selecting it without one is rejected with `400` `INVALID_INPUT`.<br/>
        /// - `dynamicCompressionLevel` maps to a CQP value defined per encoder and profile, and applies to AV1, H264, and H265 only.<br/>
        /// - For ProRes and VP9 the storage portion of the cost estimate is derived from the source file size rather than a predicted output size.
        /// </param>
        /// <param name="destination"></param>
        /// <param name="notifications"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.CreateResponse> CreateVideoRequestAsync(
            global::Topaz.CreateVideoRequestRequestSource source,
            global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>> filters,
            global::Topaz.OutputInformationVideo output,
            global::Topaz.CreateVideoRequestRequestDestination? destination = default,
            global::Topaz.CreateVideoRequestRequestNotifications? notifications = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}