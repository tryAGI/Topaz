#nullable enable

namespace Topaz
{
    public partial interface IAcceptRequestClient
    {
        /// <summary>
        /// Accept and Upload Video Request<br/>
        /// Calling this endpoint reserves the estimated credits and returns signed upload URL(s).<br/>
        /// ### Video uploads<br/>
        /// A **single** upload URL is returned when `source.size` is at or under **500 MB**, or when `source.frameCount` is 1,000 or fewer. PUT the whole file to `urls[0]`; there are no part numbers or ETags to collect in that case.<br/>
        /// Every larger source uses multi-part upload. The number of URLs returned is `source.size` divided by the **500 MB** segment size, rounded up — always at least 2 on this path — and capped at 150 URLs. Split the file into `max(500 MB, ceil(source.size / urls.length))`-byte segments and PUT them in order, one per URL: that is a plain 500 MB byte division for anything up to 75 GB, and larger segments for the sources above it where the 150-URL cap binds.<br/>
        /// For example, a 1.2 GB video file returns 3 upload URLs, so 500 MB segments cover it exactly:<br/>
        /// - Upload bytes 0-499,999,999 via HTTP PUT to `urls[0]`<br/>
        /// - Upload bytes 500,000,000-999,999,999 via HTTP PUT to `urls[1]`<br/>
        /// - Upload bytes 1,000,000,000-1,199,999,999 via HTTP PUT to `urls[2]`<br/>
        /// If one of the uploads fail, you may reuse the same URL to retry - the action overwrites any partially uploaded data.<br/>
        /// A successful response from the PUT request returns an `ETag` value in the header for each segment. Retain the part number and ETag pair for the next step (PATCH /video/{requestId}/complete-upload/).<br/>
        /// If the request was created with `source.external`, there is nothing to upload: this endpoint reserves credits, starts processing, and returns `202` with a `message` instead of upload URLs.<br/>
        /// Calling this endpoint again after the URLs have been issued returns the same `uploadId` and `urls`.<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type**   | **Description**                                     |<br/>
        /// |---------------|------------|-----------------------------------------------------|<br/>
        /// | **uploadId**  | String     | Upload ID for completing the upload                 |<br/>
        /// | **urls**      | Array      | Upload URLs                                         |<br/>
        /// | **message**   | String     | Returned instead of the above when `source.external` was used |
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AcceptResponse> AcceptVideoRequestAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Accept and Upload Video Request<br/>
        /// Calling this endpoint reserves the estimated credits and returns signed upload URL(s).<br/>
        /// ### Video uploads<br/>
        /// A **single** upload URL is returned when `source.size` is at or under **500 MB**, or when `source.frameCount` is 1,000 or fewer. PUT the whole file to `urls[0]`; there are no part numbers or ETags to collect in that case.<br/>
        /// Every larger source uses multi-part upload. The number of URLs returned is `source.size` divided by the **500 MB** segment size, rounded up — always at least 2 on this path — and capped at 150 URLs. Split the file into `max(500 MB, ceil(source.size / urls.length))`-byte segments and PUT them in order, one per URL: that is a plain 500 MB byte division for anything up to 75 GB, and larger segments for the sources above it where the 150-URL cap binds.<br/>
        /// For example, a 1.2 GB video file returns 3 upload URLs, so 500 MB segments cover it exactly:<br/>
        /// - Upload bytes 0-499,999,999 via HTTP PUT to `urls[0]`<br/>
        /// - Upload bytes 500,000,000-999,999,999 via HTTP PUT to `urls[1]`<br/>
        /// - Upload bytes 1,000,000,000-1,199,999,999 via HTTP PUT to `urls[2]`<br/>
        /// If one of the uploads fail, you may reuse the same URL to retry - the action overwrites any partially uploaded data.<br/>
        /// A successful response from the PUT request returns an `ETag` value in the header for each segment. Retain the part number and ETag pair for the next step (PATCH /video/{requestId}/complete-upload/).<br/>
        /// If the request was created with `source.external`, there is nothing to upload: this endpoint reserves credits, starts processing, and returns `202` with a `message` instead of upload URLs.<br/>
        /// Calling this endpoint again after the URLs have been issued returns the same `uploadId` and `urls`.<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type**   | **Description**                                     |<br/>
        /// |---------------|------------|-----------------------------------------------------|<br/>
        /// | **uploadId**  | String     | Upload ID for completing the upload                 |<br/>
        /// | **urls**      | Array      | Upload URLs                                         |<br/>
        /// | **message**   | String     | Returned instead of the above when `source.external` was used |
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.AcceptResponse>> AcceptVideoRequestAsResponseAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}