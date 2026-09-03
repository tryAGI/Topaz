#nullable enable

namespace Topaz
{
    public partial interface IGetRequestClient
    {
        /// <summary>
        /// Get Video Request<br/>
        /// Retrieve the full record of a single request, in the same shape as the entries returned by `GET /video/history`.<br/>
        /// Use this endpoint when you need the details of the request itself — the `filters` and `output` you submitted, the corrected source metrics, the credit transactions, and the signed download URLs. For progress polling, use `GET /video/{requestId}/status` instead: it reports `progress`, live processing statistics, and upload URLs, none of which are returned here.<br/>
        /// The `source` metrics start as the values you supplied and are corrected once the system analyzes the file. `estimates` holds the initial cost and time estimate and is absent until the request has been costed — express requests are costed after the source has been received and analyzed.<br/>
        /// Unlike `GET /video/history`, this endpoint also returns requests that are still in the `requested` state.
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.VideoRequestRecord> GetVideoRequestAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Video Request<br/>
        /// Retrieve the full record of a single request, in the same shape as the entries returned by `GET /video/history`.<br/>
        /// Use this endpoint when you need the details of the request itself — the `filters` and `output` you submitted, the corrected source metrics, the credit transactions, and the signed download URLs. For progress polling, use `GET /video/{requestId}/status` instead: it reports `progress`, live processing statistics, and upload URLs, none of which are returned here.<br/>
        /// The `source` metrics start as the values you supplied and are corrected once the system analyzes the file. `estimates` holds the initial cost and time estimate and is absent until the request has been costed — express requests are costed after the source has been received and analyzed.<br/>
        /// Unlike `GET /video/history`, this endpoint also returns requests that are still in the `requested` state.
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.VideoRequestRecord>> GetVideoRequestAsResponseAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}