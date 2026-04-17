#nullable enable

namespace Topaz
{
    public partial interface IVideoStatusClient
    {
        /// <summary>
        /// Get System Status<br/>
        /// Get status of the video cloud<br/>
        /// ## Response body<br/>
        /// | **Property**            | **Type** | **Description**            |<br/>
        /// |-------------------------|----------|----------------------------|<br/>
        /// | **isAvailable**         | Boolean  | System availability status |<br/>
        /// | **availabilityMessage** | String   | Availability message       |<br/>
        /// | **supportedModels**     | Array    | List of supported AI models in their shortened format (apo-8 for Apollo v8) |
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.SystemStatusResponse> GetSystemStatusAsync(
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}