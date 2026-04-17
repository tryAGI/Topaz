#nullable enable

namespace Topaz
{
    public partial interface IAcceptRequestClient
    {
        /// <summary>
        /// Accept and Upload Video Request<br/>
        /// Calling this endpoint reserves the estimated credits and returns signed URL(s) for **multi-part upload**.<br/>
        /// ### Video uploads<br/>
        /// The Video API uses multi-part upload to receive the video file for processing. You can use a simple byte-division function to create segments for the API to receive.<br/>
        /// For example, if you have a 900MB video file and the system returns 3 upload URLs. You would then:<br/>
        /// - Upload bytes 0-300,000,000 via HTTP PUT to `urls[0]`<br/>
        /// - Upload bytes 300,000,001-600,000,000 via HTTP PUT to `urls[1]`<br/>
        /// - Upload bytes 600,000,001-900,000,000 via HTTP PUT to `urls[2]`<br/>
        /// If one of the uploads fail, you may reuse the same URL to retry - the action overwrites any partially uploaded data.<br/>
        /// A successful response from the PUT request returns an `ETag` value in the header for each segment. Retain the part number and ETag pair for the next step (PATCH /video/{requestId}/complete-upload/).<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type**   | **Description**                                     |<br/>
        /// |---------------|------------|-----------------------------------------------------|<br/>
        /// | **uploadId**  | String     | Upload ID for multi-part upload                     |<br/>
        /// | **urls**      | Array      | URLs for multi-part uploads                         |
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
    }
}