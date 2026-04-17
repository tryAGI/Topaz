
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Unified Topaz Labs API covering both image enhancement (upscale, sharpen, denoise, restore, lighting, matting) and video enhancement (upscale, denoise, frame interpolation).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class TopazClient : global::Topaz.ITopazClient, global::System.IDisposable
    {
        /// <summary>
        /// Production
        /// </summary>
        public const string DefaultBaseUrl = "https://api.topazlabs.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Topaz.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Topaz.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Topaz.SourceGenerationContext.Default;


        /// <summary>
        /// This section allows you to accept the created request's cost and upload the source video.
        /// </summary>
        public AcceptRequestClient AcceptRequest => new AcceptRequestClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// If an image processing job is no longer needed or was started in error, you can cancel it before it completes. The job must be in a cancellable state (e.g., not already completed or failed) for the request to be successful.
        /// </summary>
        public CancelClient Cancel => new CancelClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to cancel a request.
        /// </summary>
        public CancelRequestClient CancelRequest => new CancelRequestClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to complete the multi-part upload and start processing.
        /// </summary>
        public CompleteUploadClient CompleteUpload => new CompleteUploadClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to create an express request.
        /// </summary>
        public CreateExpressRequestClient CreateExpressRequest => new CreateExpressRequestClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to create a request and estimate costs.
        /// </summary>
        public CreateRequestClient CreateRequest => new CreateRequestClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to delete your source and enhanced files.
        /// </summary>
        public DeleteFilesClient DeleteFiles => new DeleteFilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Our noise reduction models effectively remove grain and high-ISO noise from your photos, ensuring smooth yet detailed results. This endpoint is particularly beneficial when working with low-light photography or older images scanned from film, as it preserves essential image structure while greatly reducing unwanted noise or artifacts.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public DenoiseClient Denoise => new DenoiseClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Access presigned URLs for downloading input or processed images. These endpoints allow you to securely retrieve the input or the processed image with an expiring URL.
        /// </summary>
        public DownloadClient Download => new DownloadClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

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
        public EnhanceClient Enhance => new EnhanceClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Our estimates will allow you to predict the amount of time required and the number of credits that would be consumed in order to run a set of enhancements on a given image with certain input parameters.
        /// </summary>
        public EstimateClient Estimate => new EstimateClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to get your video request history.
        /// </summary>
        public GetRequestHistoryClient GetRequestHistory => new GetRequestHistoryClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to get the metrics for a request.
        /// </summary>
        public GetRequestMetricsClient GetRequestMetrics => new GetRequestMetricsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section allows you to get the status of a request.
        /// </summary>
        public GetRequestStatusClient GetRequestStatus => new GetRequestStatusClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Check and manage the statuses of your image processing jobs. Whether you are handling a single job or managing a queue of bulk image processing tasks, the Status endpoints allow you to monitor the progress and completion of your tasks.<br/>
        /// This is particularly useful for long-running jobs, where you can track progress and retrieve details such as percentage completion, estimated finish time, and current state (e.g., pending, processing, completed).
        /// </summary>
        public ImageStatusClient ImageStatus => new ImageStatusClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Our lighting models are used to adjust and balance your images to elevate it's quality despite the sub-optimal lighting conditions of the original photo.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public LightingClient Lighting => new LightingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Extract subjects from images using advanced AI matting technology. Generate alpha masks or segmentation maps to isolate objects from their backgrounds with precision.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `mode`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details.
        /// </summary>
        public MattingClient Matting => new MattingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Our restoration models are designed to enhance photos that are older and of poorer quality.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public RestoreClient Restore => new RestoreClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Use our advanced Sharpen models to bring clarity and crisp definition back to your images that appear soft or slightly out of focus. By analyzing the edges, textures, and details, our AI-based Sharpen endpoint intelligently enhances the clarity without introducing unwanted artifacts. Whether your image is suffering from camera shake, slight motion blur, or lens softness, Topaz Labs' Sharpen models help you restore the finer details with minimal effort.<br/>
        /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
        /// Additional configuration can be optionally provided, specifically:<br/>
        ///   - `model`<br/>
        ///   - `output_format`<br/>
        /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.
        /// </summary>
        public SharpenClient Sharpen => new SharpenClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

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
        public ToolClient Tool => new ToolClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This section informs you about the system status.
        /// </summary>
        public VideoStatusClient VideoStatus => new VideoStatusClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the TopazClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TopazClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Topaz.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the TopazClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TopazClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Topaz.EndPointAuthorization>? authorizations = null,
            global::Topaz.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Topaz.EndPointAuthorization>();
            Options = options ?? new global::Topaz.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}