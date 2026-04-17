#nullable enable

namespace Topaz
{
    public partial interface ICancelClient
    {
        /// <summary>
        /// Cancel<br/>
        /// Cancel a pending image processing job. If the job has already completed, or if it is not in a cancellable state, this request will fail with a conflict error. Use this to prevent unnecessary costs for jobs started in error.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelTaskAsync(
            global::System.Guid processId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}