#nullable enable

namespace Topaz
{
    public partial interface IGetRequestStatusClient
    {
        /// <summary>
        /// Get Video Request Status<br/>
        /// Get status of the request.<br/>
        /// If processing is complete, the response will include a signed URL to access the enhanced video.<br/>
        /// Make sure to download and save the video within the TTL provided in the response (7 days by default). The signed URL is generated once and then reused: calling this endpoint again returns the same URL and the same expiry rather than issuing a fresh one. We retain your data for only a limited number of days, after which the video is permanently deleted from our system.<br/>
        /// ## Response body<br/>
        /// | **Property**         | **Type**  | **Description**                                   |<br/>
        /// |---------------------|----------|-----------------------------------------------------|<br/>
        /// | **status**           | String   | Current processing status                          |<br/>
        /// | **message**          | String   | Human-readable status message                      |<br/>
        /// | **errorCode**        | String   | Failure code from the processing pipeline, present only when status is failed |<br/>
        /// | **progress**         | Number   | Total request progress (percentage)                |<br/>
        /// | **estimates**        | Object   | Refer to **RequestEstimates**                      |<br/>
        /// | **uploadId**         | String   | Present while the request is awaiting source upload |<br/>
        /// | **urls**             | Array    | Outstanding upload URLs, present while the request is awaiting source upload |<br/>
        /// | **outputSize**       | String   | Size of output video                               |<br/>
        /// | **averageFps**       | Number   | Average FPS of processing nodes                    |<br/>
        /// | **combinedFps**      | Number   | Combined FPS of all nodes                          |<br/>
        /// | **processingJobs**   | Array    | Refer to **VideoProcessingStatIntermediate** below   |<br/>
        /// | **download**         | Object   | Refer to **EnhancedDownloadSignedUrlResponse** below |<br/>
        /// | **comparisonTool**   | String   | URL to a before/after comparison view, present only for free renders |<br/>
        /// `outputSize`, `averageFps`, `combinedFps` and `processingJobs` are reported for chunked enhancement requests. They are absent for requests handled end-to-end by the inference backend.<br/>
        /// ---<br/>
        /// #### RequestEstimates<br/>
        /// `cost` and `time` are arrays with two integers each, representing lower and upper bounds of the estimate.<br/>
        /// | **Property**  | **Type**  | **Description**                                    |<br/>
        /// |---------------|----------|-----------------------------------------------------|<br/>
        /// | **cost**      | Array    | Cost range (in credits)                             |<br/>
        /// | **time**      | Array    | Time range (in seconds)                             |<br/>
        /// ---<br/>
        /// #### VideoProcessingStatIntermediate<br/>
        /// | **Property**         | **Type**  | **Description**                                   |<br/>
        /// |---------------------|----------|-----------------------------------------------------|<br/>
        /// | **chunkId**          | UUID     | Unique chunk identifier                            |<br/>
        /// | **chunkIndex**       | Integer  | Index of the chunk                                 |<br/>
        /// | **taskIndex**        | Integer  | Task index for chunk processing                    |<br/>
        /// | **status**           | String   | Status (queued, processing, complete, etc.)        |<br/>
        /// | **progress**         | Number   | Processing progress (percentage)                   |<br/>
        /// | **averageFps**       | Number   | Processing speed of the node                       |<br/>
        /// | **averageGpuUtilization** | Number | GPU utilization in percentage                    |<br/>
        /// | **averageGpuMemoryUtilization** | Number | GPU memory usage percentage                |<br/>
        /// ---<br/>
        /// #### EnhancedDownloadSignedUrlResponse<br/>
        /// | **Property**   | **Type**  | **Description**                 |<br/>
        /// |----------------|-----------|---------------------------------|<br/>
        /// | **url**        | String    | Signed download URL for the enhanced file |<br/>
        /// | **expiresIn**  | Integer   | TTL in milliseconds                  |<br/>
        /// | **expiresAt**  | Integer   | Time in milliseconds since UTC epoch |
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.VideoStatusResponse> GetVideoRequestStatusAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Video Request Status<br/>
        /// Get status of the request.<br/>
        /// If processing is complete, the response will include a signed URL to access the enhanced video.<br/>
        /// Make sure to download and save the video within the TTL provided in the response (7 days by default). The signed URL is generated once and then reused: calling this endpoint again returns the same URL and the same expiry rather than issuing a fresh one. We retain your data for only a limited number of days, after which the video is permanently deleted from our system.<br/>
        /// ## Response body<br/>
        /// | **Property**         | **Type**  | **Description**                                   |<br/>
        /// |---------------------|----------|-----------------------------------------------------|<br/>
        /// | **status**           | String   | Current processing status                          |<br/>
        /// | **message**          | String   | Human-readable status message                      |<br/>
        /// | **errorCode**        | String   | Failure code from the processing pipeline, present only when status is failed |<br/>
        /// | **progress**         | Number   | Total request progress (percentage)                |<br/>
        /// | **estimates**        | Object   | Refer to **RequestEstimates**                      |<br/>
        /// | **uploadId**         | String   | Present while the request is awaiting source upload |<br/>
        /// | **urls**             | Array    | Outstanding upload URLs, present while the request is awaiting source upload |<br/>
        /// | **outputSize**       | String   | Size of output video                               |<br/>
        /// | **averageFps**       | Number   | Average FPS of processing nodes                    |<br/>
        /// | **combinedFps**      | Number   | Combined FPS of all nodes                          |<br/>
        /// | **processingJobs**   | Array    | Refer to **VideoProcessingStatIntermediate** below   |<br/>
        /// | **download**         | Object   | Refer to **EnhancedDownloadSignedUrlResponse** below |<br/>
        /// | **comparisonTool**   | String   | URL to a before/after comparison view, present only for free renders |<br/>
        /// `outputSize`, `averageFps`, `combinedFps` and `processingJobs` are reported for chunked enhancement requests. They are absent for requests handled end-to-end by the inference backend.<br/>
        /// ---<br/>
        /// #### RequestEstimates<br/>
        /// `cost` and `time` are arrays with two integers each, representing lower and upper bounds of the estimate.<br/>
        /// | **Property**  | **Type**  | **Description**                                    |<br/>
        /// |---------------|----------|-----------------------------------------------------|<br/>
        /// | **cost**      | Array    | Cost range (in credits)                             |<br/>
        /// | **time**      | Array    | Time range (in seconds)                             |<br/>
        /// ---<br/>
        /// #### VideoProcessingStatIntermediate<br/>
        /// | **Property**         | **Type**  | **Description**                                   |<br/>
        /// |---------------------|----------|-----------------------------------------------------|<br/>
        /// | **chunkId**          | UUID     | Unique chunk identifier                            |<br/>
        /// | **chunkIndex**       | Integer  | Index of the chunk                                 |<br/>
        /// | **taskIndex**        | Integer  | Task index for chunk processing                    |<br/>
        /// | **status**           | String   | Status (queued, processing, complete, etc.)        |<br/>
        /// | **progress**         | Number   | Processing progress (percentage)                   |<br/>
        /// | **averageFps**       | Number   | Processing speed of the node                       |<br/>
        /// | **averageGpuUtilization** | Number | GPU utilization in percentage                    |<br/>
        /// | **averageGpuMemoryUtilization** | Number | GPU memory usage percentage                |<br/>
        /// ---<br/>
        /// #### EnhancedDownloadSignedUrlResponse<br/>
        /// | **Property**   | **Type**  | **Description**                 |<br/>
        /// |----------------|-----------|---------------------------------|<br/>
        /// | **url**        | String    | Signed download URL for the enhanced file |<br/>
        /// | **expiresIn**  | Integer   | TTL in milliseconds                  |<br/>
        /// | **expiresAt**  | Integer   | Time in milliseconds since UTC epoch |
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.VideoStatusResponse>> GetVideoRequestStatusAsResponseAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}