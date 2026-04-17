
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Enhance images by removing noise, sharpening, and upscaling while preserving the details of your image, including the faces of important subjects.<br/>
    /// Just pass in an image and our **Autopilot** will automatically determine the best settings for the highest quality.<br/>
    /// Additional configuration can be optionally provided, specifically:<br/>
    ///   - `model`<br/>
    ///   - `output_height`<br/>
    ///   - `output_width`<br/>
    ///   - `output_format`<br/>
    ///   - `crop_to_fill`<br/>
    /// Please see the reference for further details. Check out the [available models](https://developer.topazlabs.com/image-api/available-models) to see which model options you have.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEnhanceClient : global::System.IDisposable
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


    }
}