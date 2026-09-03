#nullable enable

namespace Topaz
{
    public partial interface IGetRequestHistoryClient
    {
        /// <summary>
        /// Get My Request History<br/>
        /// This endpoint will return your processing history, newest first, up to 50 requests per page. Requests that have not been accepted yet (status `requested`) are omitted — fetch those individually with `GET /video/{requestId}`.<br/>
        /// A page may contain fewer than 50 requests even when more are available, so keep following `nextCursor` until it comes back `null`.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.GetHistoryResponse> GetHistoryAsync(
            string? cursor = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get My Request History<br/>
        /// This endpoint will return your processing history, newest first, up to 50 requests per page. Requests that have not been accepted yet (status `requested`) are omitted — fetch those individually with `GET /video/{requestId}`.<br/>
        /// A page may contain fewer than 50 requests even when more are available, so keep following `nextCursor` until it comes back `null`.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.GetHistoryResponse>> GetHistoryAsResponseAsync(
            string? cursor = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}