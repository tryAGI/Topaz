
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetCancelEstimateResponseError
    {
        /// <summary>
        /// Example: field
        /// </summary>
        /// <example>field</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: source.container
        /// </summary>
        /// <example>source.container</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Example: body
        /// </summary>
        /// <example>body</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Example: container must be one of mp4, mov, mkv
        /// </summary>
        /// <example>container must be one of mp4, mov, mkv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCancelEstimateResponseError" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: field
        /// </param>
        /// <param name="path">
        /// Example: source.container
        /// </param>
        /// <param name="location">
        /// Example: body
        /// </param>
        /// <param name="msg">
        /// Example: container must be one of mp4, mov, mkv
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCancelEstimateResponseError(
            string? type,
            string? path,
            string? location,
            string? msg,
            object? value)
        {
            this.Type = type;
            this.Path = path;
            this.Location = location;
            this.Msg = msg;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCancelEstimateResponseError" /> class.
        /// </summary>
        public GetCancelEstimateResponseError()
        {
        }

    }
}