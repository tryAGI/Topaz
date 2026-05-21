#nullable enable

namespace Topaz
{
    public partial interface IDownloadClient
    {
        /// <summary>
        /// Download Input<br/>
        /// A presigned download link to the input image is provided in the response, as well as an expiration time (in Unix time). Input images are stored for **7 days** after the image has been uploaded.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.DownloadResponse> GetDownloadInputAsync(
            global::System.Guid processId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Input<br/>
        /// A presigned download link to the input image is provided in the response, as well as an expiration time (in Unix time). Input images are stored for **7 days** after the image has been uploaded.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.DownloadResponse>> GetDownloadInputAsResponseAsync(
            global::System.Guid processId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}