#nullable enable

namespace Topaz
{
    public partial interface IImageStatusClient
    {
        /// <summary>
        /// Delete Status<br/>
        /// Remove an image processing job status by its `process_id`. This operation can be used to delete the statuses of finished jobs, cleaning up the response of `GET Status`, for example.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteStatusAsync(
            global::System.Guid processId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Status<br/>
        /// Remove an image processing job status by its `process_id`. This operation can be used to delete the statuses of finished jobs, cleaning up the response of `GET Status`, for example.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse> DeleteStatusAsResponseAsync(
            global::System.Guid processId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}