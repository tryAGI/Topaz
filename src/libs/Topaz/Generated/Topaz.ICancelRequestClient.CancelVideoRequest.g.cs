#nullable enable

namespace Topaz
{
    public partial interface ICancelRequestClient
    {
        /// <summary>
        /// Cancel Video Request<br/>
        /// Cancel a video enhancement request.<br/>
        /// If the request is canceled before any processing starts, then all reserved credits are refunded.<br/>
        /// If the request is canceled during processing, then a partial refund is issued based on the progress. For example, if the request is 50% complete, then approximately 50% of the reserved credits are refunded.
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.CancelVideoRequestResponse> CancelVideoRequestAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}