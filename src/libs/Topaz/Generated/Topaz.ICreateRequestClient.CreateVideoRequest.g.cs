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
        /// <param name="output"></param>
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