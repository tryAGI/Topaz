#nullable enable

namespace Topaz
{
    public partial interface IImageStatusClient
    {
        /// <summary>
        /// Delete All Statuses<br/>
        /// Remove all image processing job statuses. This operation can be used to delete the statuses of finished jobs, cleaning up the response of `Get All Statuses`, for example.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.DeleteAllStatusesResponse> DeleteAllStatusesAsync(
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete All Statuses<br/>
        /// Remove all image processing job statuses. This operation can be used to delete the statuses of finished jobs, cleaning up the response of `Get All Statuses`, for example.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.DeleteAllStatusesResponse>> DeleteAllStatusesAsResponseAsync(
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}