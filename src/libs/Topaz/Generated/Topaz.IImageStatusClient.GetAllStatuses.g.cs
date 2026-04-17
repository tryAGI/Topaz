#nullable enable

namespace Topaz
{
    public partial interface IImageStatusClient
    {
        /// <summary>
        /// Get All Statuses<br/>
        /// Retrieve the status of all image processing jobs.<br/>
        /// **Pagination (Highly Recommended):**<br/>
        /// For better performance and to handle large numbers of statuses, pagination is highly recommended. Enable pagination by setting `paginated=true`. When pagination is enabled:<br/>
        ///   - Use the `limit` parameter to control the number of results per page (default: 50, maximum: 100)<br/>
        ///   - Use the `cursor` parameter to retrieve subsequent pages<br/>
        ///   - The response will include pagination metadata with `next_cursor` and `has_next_page` fields<br/>
        /// **Non-Paginated Response:**<br/>
        /// When `paginated=false` (default) or omitted, the endpoint returns all statuses **up to 7 days old** as a simple array. This may be slow or fail for accounts with many statuses.
        /// </summary>
        /// <param name="paginated">
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.OneOf<global::System.Collections.Generic.IList<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>> GetAllStatusesAsync(
            bool? paginated = default,
            int? limit = default,
            string? cursor = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}