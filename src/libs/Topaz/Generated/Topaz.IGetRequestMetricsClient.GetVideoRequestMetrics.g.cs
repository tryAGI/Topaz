#nullable enable

namespace Topaz
{
    public partial interface IGetRequestMetricsClient
    {
        /// <summary>
        /// Get Video Request Metrics<br/>
        /// Get metrics for the request<br/>
        /// ## Response body<br/>
        /// | **Property**        | **Type** | **Description**                                     |<br/>
        /// |---------------------|----------|-----------------------------------------------------|<br/>
        /// | **minutesInState**  | Object   | Minutes spent in various processing states          |<br/>
        /// | **minutesInState.pendingSourceUpload** | Number    | - |<br/>
        /// | **minutesInState.initializing**        | Number    | - |<br/>
        /// | **minutesInState.preprocessing**       | Number    | - |<br/>
        /// | **minutesInState.processing**          | Number    | - |<br/>
        /// | **minutesInState.postprocessing**      | Number    | - |<br/>
        /// | **minutesToEnhance**| Number   | Time to complete enhancement after source upload    |<br/>
        /// | **inputFrames**     | Integer  | Number of input frames                              |<br/>
        /// | **outputFrames**    | Integer  | Number of output frames                             |<br/>
        /// | **inputSize**       | String   | Size of input video                                 |<br/>
        /// | **outputSize**      | String   | Size of output video                                |<br/>
        /// | **chunks**          | Array    | Refer to **VideoChunkMetrics** below                |<br/>
        /// ---<br/>
        /// #### VideoChunkMetrics<br/>
        /// | **Property**        | **Type**   | **Description**                                  |<br/>
        /// |---------------------|------------|--------------------------------------------------|<br/>
        /// | **chunkIndex**                | Integer   | Index of the chunk                      |<br/>
        /// | **tasks**                     | Array     | List of processing tasks for the chunk  |<br/>
        /// | **tasks.*.minutesProcessing** | Number    | Duration of processing in minutes       |<br/>
        /// | **tasks.*.inputFrames**       | Integer   | Number of input frames                  |<br/>
        /// | **tasks.*.outputFrames**      | Integer   | Number of output frames                 |<br/>
        /// | **tasks.*.inputSize**         | String    | Size of the input file                  |<br/>
        /// | **tasks.*.outputSize**        | String    | Size of the output file                 |
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.MetricsResponse> GetVideoRequestMetricsAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}