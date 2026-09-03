#nullable enable

namespace Topaz
{
    public partial interface ICancelEstimateClient
    {
        /// <summary>
        /// Estimate Cancellation Outcome<br/>
        /// Preview the credit outcome of canceling a request without actually canceling it.<br/>
        /// This uses the same settlement math as the cancel endpoint (DELETE /video/{requestId}), so the estimate reflects what you would be charged and refunded if you cancel now.<br/>
        /// - If the request has not started processing, canceling refunds all reserved credits and charges nothing.<br/>
        /// - If the request is partially processed, canceling commits a prorated amount (plus a small cancellation penalty) and refunds the remainder.<br/>
        /// - If the request is already canceling or canceled, it is reported as not cancelable with a zeroed estimate.<br/>
        /// Requests that have already completed or failed cannot be canceled and return a 400.<br/>
        /// ## Response body<br/>
        /// | **Property**        | **Type** | **Description**                                              |<br/>
        /// |---------------------|----------|-------------------------------------------------------------|<br/>
        /// | **requestId**       | UUID     | Unique request identifier                                   |<br/>
        /// | **status**          | String   | Current processing status                                   |<br/>
        /// | **cancelable**      | Boolean  | Whether the request can still be canceled                   |<br/>
        /// | **progress**        | Integer  | Processing progress used for settlement (percentage, 0-100) |<br/>
        /// | **creditsReserved** | Integer  | Credits currently reserved for the request                  |<br/>
        /// | **creditsToCommit** | Integer  | Credits that would be charged if canceled now               |<br/>
        /// | **creditsToRefund** | Integer  | Credits that would be refunded if canceled now              |<br/>
        /// | **message**         | String   | Human-readable summary of the cancellation outcome          |
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.CancelEstimateResponse> GetCancelEstimateAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Cancellation Outcome<br/>
        /// Preview the credit outcome of canceling a request without actually canceling it.<br/>
        /// This uses the same settlement math as the cancel endpoint (DELETE /video/{requestId}), so the estimate reflects what you would be charged and refunded if you cancel now.<br/>
        /// - If the request has not started processing, canceling refunds all reserved credits and charges nothing.<br/>
        /// - If the request is partially processed, canceling commits a prorated amount (plus a small cancellation penalty) and refunds the remainder.<br/>
        /// - If the request is already canceling or canceled, it is reported as not cancelable with a zeroed estimate.<br/>
        /// Requests that have already completed or failed cannot be canceled and return a 400.<br/>
        /// ## Response body<br/>
        /// | **Property**        | **Type** | **Description**                                              |<br/>
        /// |---------------------|----------|-------------------------------------------------------------|<br/>
        /// | **requestId**       | UUID     | Unique request identifier                                   |<br/>
        /// | **status**          | String   | Current processing status                                   |<br/>
        /// | **cancelable**      | Boolean  | Whether the request can still be canceled                   |<br/>
        /// | **progress**        | Integer  | Processing progress used for settlement (percentage, 0-100) |<br/>
        /// | **creditsReserved** | Integer  | Credits currently reserved for the request                  |<br/>
        /// | **creditsToCommit** | Integer  | Credits that would be charged if canceled now               |<br/>
        /// | **creditsToRefund** | Integer  | Credits that would be refunded if canceled now              |<br/>
        /// | **message**         | String   | Human-readable summary of the cancellation outcome          |
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.CancelEstimateResponse>> GetCancelEstimateAsResponseAsync(
            global::System.Guid requestId,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}