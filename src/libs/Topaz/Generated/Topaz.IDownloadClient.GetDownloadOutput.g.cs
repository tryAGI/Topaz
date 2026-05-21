#nullable enable

namespace Topaz
{
    public partial interface IDownloadClient
    {
        /// <summary>
        /// Download Output<br/>
        /// A presigned download link to the image is provided in the response, as well as an expiration time (in Unix time). If the image is not ready, this request will fail with a conflict error. Images are stored for **7 days** after the image has been processed.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.DownloadResponse> GetDownloadOutputAsync(
            global::System.Guid processId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Output<br/>
        /// A presigned download link to the image is provided in the response, as well as an expiration time (in Unix time). If the image is not ready, this request will fail with a conflict error. Images are stored for **7 days** after the image has been processed.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.DownloadResponse>> GetDownloadOutputAsResponseAsync(
            global::System.Guid processId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}