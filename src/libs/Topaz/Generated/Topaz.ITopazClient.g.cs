
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Unified Topaz Labs API covering both image enhancement (upscale, sharpen, denoise, restore, lighting, matting) and video enhancement (upscale, denoise, frame interpolation).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITopazClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Topaz.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// This section allows you to accept the created request's cost and upload the source video.
        /// </summary>
        public AcceptRequestClient AcceptRequest { get; }

        /// <summary>
        /// If an image processing job is no longer needed or was started in error, you can cancel it before it completes. The job must be in a cancellable state (e.g., not already completed or failed) for the request to be successful.
        /// </summary>
        public CancelClient Cancel { get; }

        /// <summary>
        /// This section allows you to cancel a request.
        /// </summary>
        public CancelRequestClient CancelRequest { get; }

        /// <summary>
        /// This section allows you to complete the multi-part upload and start processing.
        /// </summary>
        public CompleteUploadClient CompleteUpload { get; }

        /// <summary>
        /// This section allows you to create an express request.
        /// </summary>
        public CreateExpressRequestClient CreateExpressRequest { get; }

        /// <summary>
        /// This section allows you to create a request and estimate costs.
        /// </summary>
        public CreateRequestClient CreateRequest { get; }

        /// <summary>
        /// This section allows you to delete your source and enhanced files.
        /// </summary>
        public DeleteFilesClient DeleteFiles { get; }

        /// <summary>
        /// Our noise reduction models effectively remove grain and high-ISO noise from your photos, ensuring smooth yet detailed results. This endpoint is particularly beneficial when working with low-light photography or older images scanned from film, as it preserves essential image structure while greatly reducing unwanted noise or artifacts.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public DenoiseClient Denoise { get; }

        /// <summary>
        /// Access presigned URLs for downloading input or processed images. These endpoints allow you to securely retrieve the input or the processed image with an expiring URL.
        /// </summary>
        public DownloadClient Download { get; }

        /// <summary>
        /// Enhance images by removing noise, sharpening, and upscaling while preserving the details of your image, including the faces of important subjects.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_height`<br/>
        ///   - `output_width`<br/>
        ///   - `output_format`<br/>
        ///   - `crop_to_fill`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public EnhanceClient Enhance { get; }

        /// <summary>
        /// Our estimates will allow you to predict the amount of time required and the number of credits that would be consumed in order to run a set of enhancements on a given image with certain input parameters.
        /// </summary>
        public EstimateClient Estimate { get; }

        /// <summary>
        /// This section allows you to get your video request history.
        /// </summary>
        public GetRequestHistoryClient GetRequestHistory { get; }

        /// <summary>
        /// This section allows you to get the metrics for a request.
        /// </summary>
        public GetRequestMetricsClient GetRequestMetrics { get; }

        /// <summary>
        /// This section allows you to get the status of a request.
        /// </summary>
        public GetRequestStatusClient GetRequestStatus { get; }

        /// <summary>
        /// Check and manage the statuses of your image processing jobs. Whether you are handling a single job or managing a queue of bulk image processing tasks, the Status endpoints allow you to monitor the progress and completion of your tasks.<br/>
        /// This is particularly useful for long-running jobs, where you can track progress and retrieve details such as percentage completion, estimated finish time, and current state (e.g., pending, processing, completed).
        /// </summary>
        public ImageStatusClient ImageStatus { get; }

        /// <summary>
        /// Our lighting models are used to adjust and balance your images to elevate it's quality despite the sub-optimal lighting conditions of the original photo.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public LightingClient Lighting { get; }

        /// <summary>
        /// Extract subjects from images using advanced AI matting technology. Generate alpha masks or segmentation maps to isolate objects from their backgrounds with precision.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `mode`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details.
        /// </summary>
        public MattingClient Matting { get; }

        /// <summary>
        /// Our restoration models are designed to enhance photos that are older and of poorer quality.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public RestoreClient Restore { get; }

        /// <summary>
        /// Use our advanced Sharpen models to bring clarity and crisp definition back to your images that appear soft or slightly out of focus. By analyzing the edges, textures, and details, our AI-based Sharpen endpoint intelligently enhances the clarity without introducing unwanted artifacts. Whether your image is suffering from camera shake, slight motion blur, or lens softness, Topaz Labs' Sharpen models help you restore the finer details with minimal effort.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public SharpenClient Sharpen { get; }

        /// <summary>
        /// Specialized image processing tools for specific use cases, including upscaling images with transparent backgrounds upto 4x while preserving alpha channels.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_height`<br/>
        ///   - `output_width`<br/>
        ///   - `output_format`<br/>
        ///   - `crop_to_fill`<br/>
        /// Please see the reference for further details.
        /// </summary>
        public ToolClient Tool { get; }

        /// <summary>
        /// This section informs you about the system status.
        /// </summary>
        public VideoStatusClient VideoStatus { get; }

    }
}