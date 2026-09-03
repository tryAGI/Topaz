
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Full record of a request, as returned by `GET /video/{requestId}` and for each entry of `GET /video/history`.
    /// </summary>
    public sealed partial class VideoRequestRecord
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public double? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.VideoRequestRecordStatusJsonConverter))]
        public global::Topaz.VideoRequestRecordStatus? Status { get; set; }

        /// <summary>
        /// Timestamp the request reached the state, if applicable, in milliseconds since UTC epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        public global::Topaz.VideoRequestRecordTs? Ts { get; set; }

        /// <summary>
        /// Timestamp of the last event, in milliseconds since UTC epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastEventTs")]
        public double? LastEventTs { get; set; }

        /// <summary>
        /// Non-zero when the request was created on your behalf by a Topaz Labs administrator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminId")]
        public double? AdminId { get; set; }

        /// <summary>
        /// Identifier of the client that created the request<br/>
        /// Example: api
        /// </summary>
        /// <example>api</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Bookkeeping from the processing pipeline. Populated only for requests handled by the generative pipeline; an empty object for every other request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        public global::Topaz.VideoRequestRecordProcessing? Processing { get; set; }

        /// <summary>
        /// Array of UpscaleFilter or FrameInterpolationFilter objects<br/>
        /// Example: [{"model":"prob-4","videoType":"Progressive","auto":"Auto","fieldOrder":"Auto","focusFixLevel":"Normal","compression":0.1,"details":0.2,"prenoise":0.01,"noise":0.3,"halo":0.4,"preblur":0.5,"blur":0.6,"grain":0.02,"grainSize":1,"recoverOriginalDetailValue":0.7}, {"model":"apo-8","slowmo":2,"fps":60,"duplicate":true,"duplicateThreshold":0.01}]
        /// </summary>
        /// <example>[{"model":"prob-4","videoType":"Progressive","auto":"Auto","fieldOrder":"Auto","focusFixLevel":"Normal","compression":0.1,"details":0.2,"prenoise":0.01,"noise":0.3,"halo":0.4,"preblur":0.5,"blur":0.6,"grain":0.02,"grainSize":1,"recoverOriginalDetailValue":0.7}, {"model":"apo-8","slowmo":2,"fps":60,"duplicate":true,"duplicateThreshold":0.01}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>? Filters { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Topaz.OutputInformationVideo? Output { get; set; }

        /// <summary>
        /// Source details. `frameCount`, `frameRate`, `resolution`, `size` and `duration` start as the values you supplied and are corrected once the system analyzes the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Topaz.VideoRequestRecordSource? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public global::Topaz.VideoRequestRecordDestination? Destination { get; set; }

        /// <summary>
        /// Initial cost and time estimate, recorded when the request is costed. Absent until then — express requests are costed after the source has been received and analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimates")]
        public global::Topaz.InitialEstimates? Estimates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactions")]
        public global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecordTransaction>? Transactions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::Topaz.VideoRequestRecordOverrides? Overrides { get; set; }

        /// <summary>
        /// Present only if the request failed. The `errorCode` originates from the processing pipeline and may take values beyond the synchronous API error codes returned in HTTP error responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Topaz.VideoRequestRecordError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecord" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique request identifier
        /// </param>
        /// <param name="userId"></param>
        /// <param name="status"></param>
        /// <param name="ts">
        /// Timestamp the request reached the state, if applicable, in milliseconds since UTC epoch
        /// </param>
        /// <param name="lastEventTs">
        /// Timestamp of the last event, in milliseconds since UTC epoch
        /// </param>
        /// <param name="adminId">
        /// Non-zero when the request was created on your behalf by a Topaz Labs administrator
        /// </param>
        /// <param name="version">
        /// Identifier of the client that created the request<br/>
        /// Example: api
        /// </param>
        /// <param name="processing">
        /// Bookkeeping from the processing pipeline. Populated only for requests handled by the generative pipeline; an empty object for every other request.
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
        /// <param name="source">
        /// Source details. `frameCount`, `frameRate`, `resolution`, `size` and `duration` start as the values you supplied and are corrected once the system analyzes the file.
        /// </param>
        /// <param name="destination"></param>
        /// <param name="estimates">
        /// Initial cost and time estimate, recorded when the request is costed. Absent until then — express requests are costed after the source has been received and analyzed.
        /// </param>
        /// <param name="transactions"></param>
        /// <param name="overrides"></param>
        /// <param name="error">
        /// Present only if the request failed. The `errorCode` originates from the processing pipeline and may take values beyond the synchronous API error codes returned in HTTP error responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecord(
            global::System.Guid? id,
            double? userId,
            global::Topaz.VideoRequestRecordStatus? status,
            global::Topaz.VideoRequestRecordTs? ts,
            double? lastEventTs,
            double? adminId,
            string? version,
            global::Topaz.VideoRequestRecordProcessing? processing,
            global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>? filters,
            global::Topaz.OutputInformationVideo? output,
            global::Topaz.VideoRequestRecordSource? source,
            global::Topaz.VideoRequestRecordDestination? destination,
            global::Topaz.InitialEstimates? estimates,
            global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecordTransaction>? transactions,
            global::Topaz.VideoRequestRecordOverrides? overrides,
            global::Topaz.VideoRequestRecordError? error)
        {
            this.Id = id;
            this.UserId = userId;
            this.Status = status;
            this.Ts = ts;
            this.LastEventTs = lastEventTs;
            this.AdminId = adminId;
            this.Version = version;
            this.Processing = processing;
            this.Filters = filters;
            this.Output = output;
            this.Source = source;
            this.Destination = destination;
            this.Estimates = estimates;
            this.Transactions = transactions;
            this.Overrides = overrides;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecord" /> class.
        /// </summary>
        public VideoRequestRecord()
        {
        }

    }
}