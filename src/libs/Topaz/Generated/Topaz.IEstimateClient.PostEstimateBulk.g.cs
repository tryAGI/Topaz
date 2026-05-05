#nullable enable

namespace Topaz
{
    public partial interface IEstimateClient
    {
        /// <summary>
        /// Estimate Bulk<br/>
        /// Validates a list of requests and returns the estimated time taken to complete a given processing job and the credits that would be consumed for each job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>> PostEstimateBulkAsync(

            global::System.Collections.Generic.IList<global::Topaz.EstimateBulkRequestItem> request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Bulk<br/>
        /// Validates a list of requests and returns the estimated time taken to complete a given processing job and the credits that would be consumed for each job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>>> PostEstimateBulkAsResponseAsync(

            global::System.Collections.Generic.IList<global::Topaz.EstimateBulkRequestItem> request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}