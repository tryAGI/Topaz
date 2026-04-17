#nullable enable

namespace Topaz
{
    public partial interface IDeleteFilesClient
    {
        /// <summary>
        /// Delete Video Files<br/>
        /// This endpoint will delete your source and enhanced video files associated with the request from Topaz Labs storage, if any exists.<br/>
        /// Note: All videos are automatically deleted after 7 days unless you request a shorter TTL.
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVideoFilesAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}