#nullable enable

namespace Topaz
{
    public partial interface ICreateExpressRequestClient
    {
        /// <summary>
        /// Create Express Video Request<br/>
        /// Simplified interface for creating new video enhancement requests.<br/>
        /// This endpoint skips the need to gather video information and uses a single-URL upload rather than multi-part upload. Calling the accept and complete-upload endpoints are also no longer necessary.<br/>
        /// This endpoint does not return the cost estimates. Once the system receives and analyzes the source video file, cost estimates will appear in the response of the status endpoint. The lower bound value will be billed.<br/>
        /// The endpoint returns a direct upload URL to our cloud storage for you to HTTP PUT the video file to.<br/>
        /// ## Response body<br/>
        /// | **Property**   | **Type** | **Description**            |<br/>
        /// |----------------|----------|----------------------------|<br/>
        /// | **requestId**  | UUID     | Unique request identifier  |<br/>
        /// | **uploadId**   | String   | Upload identifier          |<br/>
        /// | **uploadUrls** | Array    | URL(s) for uploading video |
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.CreateExpressResponse> CreateExpressVideoRequestAsync(

            global::Topaz.CreateExpressVideoRequestRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Express Video Request<br/>
        /// Simplified interface for creating new video enhancement requests.<br/>
        /// This endpoint skips the need to gather video information and uses a single-URL upload rather than multi-part upload. Calling the accept and complete-upload endpoints are also no longer necessary.<br/>
        /// This endpoint does not return the cost estimates. Once the system receives and analyzes the source video file, cost estimates will appear in the response of the status endpoint. The lower bound value will be billed.<br/>
        /// The endpoint returns a direct upload URL to our cloud storage for you to HTTP PUT the video file to.<br/>
        /// ## Response body<br/>
        /// | **Property**   | **Type** | **Description**            |<br/>
        /// |----------------|----------|----------------------------|<br/>
        /// | **requestId**  | UUID     | Unique request identifier  |<br/>
        /// | **uploadId**   | String   | Upload identifier          |<br/>
        /// | **uploadUrls** | Array    | URL(s) for uploading video |
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.CreateExpressResponse>> CreateExpressVideoRequestAsResponseAsync(

            global::Topaz.CreateExpressVideoRequestRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Express Video Request<br/>
        /// Simplified interface for creating new video enhancement requests.<br/>
        /// This endpoint skips the need to gather video information and uses a single-URL upload rather than multi-part upload. Calling the accept and complete-upload endpoints are also no longer necessary.<br/>
        /// This endpoint does not return the cost estimates. Once the system receives and analyzes the source video file, cost estimates will appear in the response of the status endpoint. The lower bound value will be billed.<br/>
        /// The endpoint returns a direct upload URL to our cloud storage for you to HTTP PUT the video file to.<br/>
        /// ## Response body<br/>
        /// | **Property**   | **Type** | **Description**            |<br/>
        /// |----------------|----------|----------------------------|<br/>
        /// | **requestId**  | UUID     | Unique request identifier  |<br/>
        /// | **uploadId**   | String   | Upload identifier          |<br/>
        /// | **uploadUrls** | Array    | URL(s) for uploading video |
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
        global::System.Threading.Tasks.Task<global::Topaz.CreateExpressResponse> CreateExpressVideoRequestAsync(
            global::Topaz.CreateExpressVideoRequestRequestSource source,
            global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>> filters,
            global::Topaz.OutputInformationVideo output,
            global::Topaz.CreateExpressVideoRequestRequestDestination? destination = default,
            global::Topaz.CreateExpressVideoRequestRequestNotifications? notifications = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}