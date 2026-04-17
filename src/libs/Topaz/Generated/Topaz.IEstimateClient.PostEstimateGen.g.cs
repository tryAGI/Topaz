#nullable enable

namespace Topaz
{
    public partial interface IEstimateClient
    {
        /// <summary>
        /// Estimate Generative<br/>
        /// Validates the request against our generative models and returns the estimated time taken to complete a given processing job and the credits that would be consumed for that job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.EstimationResponse> PostEstimateGenAsync(

            global::Topaz.EstimateGenRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Generative<br/>
        /// Validates the request against our generative models and returns the estimated time taken to complete a given processing job and the credits that would be consumed for that job.
        /// </summary>
        /// <param name="category">
        /// Indicates which category of model is being used.<br/>
        /// Default Value: Enhance
        /// </param>
        /// <param name="model">
        /// The model to use for processing the image.<br/>
        /// Default Value: Redefine
        /// </param>
        /// <param name="inputHeight">
        /// The height of the input image in pixels.
        /// </param>
        /// <param name="inputWidth">
        /// The width of the input image in pixels.
        /// </param>
        /// <param name="outputHeight">
        /// The desired height of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally. Only applicable for Enhance models.
        /// </param>
        /// <param name="outputWidth">
        /// The desired width of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally. Only applicable for Enhance models.
        /// </param>
        /// <param name="cropToFill">
        /// Default behavior is to letterbox the image if a differing aspect ratio is chosen. Enable `crop_to_fill` by setting this to `true` if you instead want to crop the image to fill the dimensions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// The desired format of the output image.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.EstimationResponse> PostEstimateGenAsync(
            int inputHeight,
            int inputWidth,
            global::Topaz.EstimateGenRequestCategory? category = default,
            global::Topaz.EstimateGenRequestModel? model = default,
            int? outputHeight = default,
            int? outputWidth = default,
            bool? cropToFill = default,
            global::Topaz.EstimateGenRequestOutputFormat? outputFormat = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}