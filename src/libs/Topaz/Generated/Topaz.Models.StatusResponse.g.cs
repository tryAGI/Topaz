
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StatusResponse
    {
        /// <summary>
        /// Unique identifier of the image processing job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("process_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcessId { get; set; }

        /// <summary>
        /// Unique identifier of the source image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// Name of the file being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Format of the input file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFormat { get; set; }

        /// <summary>
        /// Height of the input image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputHeight { get; set; }

        /// <summary>
        /// Width of the input image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputWidth { get; set; }

        /// <summary>
        /// Format of the output file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputFormat { get; set; }

        /// <summary>
        /// Height of the output image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputHeight { get; set; }

        /// <summary>
        /// Width of the output image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputWidth { get; set; }

        /// <summary>
        /// Category of model used for processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// Type of model used for processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelType { get; set; }

        /// <summary>
        /// Model used for processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Level of subject detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_detection")]
        public string? SubjectDetection { get; set; }

        /// <summary>
        /// Whether face enhancement is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement")]
        public bool? FaceEnhancement { get; set; }

        /// <summary>
        /// Level of face enhancement creativity (if enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement_creativity")]
        public double? FaceEnhancementCreativity { get; set; }

        /// <summary>
        /// Level of face enhancement strength (if enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement_strength")]
        public double? FaceEnhancementStrength { get; set; }

        /// <summary>
        /// Whether cropping to fill is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_to_fill")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CropToFill { get; set; }

        /// <summary>
        /// Additional options in JSON format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options_json")]
        public string? OptionsJson { get; set; }

        /// <summary>
        /// Status of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.StatusResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.StatusResponseStatus Status { get; set; }

        /// <summary>
        /// Progress of the job as a percentage. Useful for displaying a progress bar or loading spinners etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Progress { get; set; }

        /// <summary>
        /// Estimated time of arrival (ETA) for the process to complete in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Eta { get; set; }

        /// <summary>
        /// Creation time of the job in Unix epoch format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreationTime { get; set; }

        /// <summary>
        /// Last modification time of the job in Unix epoch format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modification_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModificationTime { get; set; }

        /// <summary>
        /// Credits (to be) consumed on image processing completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponse" /> class.
        /// </summary>
        /// <param name="processId">
        /// Unique identifier of the image processing job.
        /// </param>
        /// <param name="filename">
        /// Name of the file being processed.
        /// </param>
        /// <param name="inputFormat">
        /// Format of the input file.
        /// </param>
        /// <param name="inputHeight">
        /// Height of the input image in pixels.
        /// </param>
        /// <param name="inputWidth">
        /// Width of the input image in pixels.
        /// </param>
        /// <param name="outputFormat">
        /// Format of the output file.
        /// </param>
        /// <param name="outputHeight">
        /// Height of the output image in pixels.
        /// </param>
        /// <param name="outputWidth">
        /// Width of the output image in pixels.
        /// </param>
        /// <param name="category">
        /// Category of model used for processing.
        /// </param>
        /// <param name="modelType">
        /// Type of model used for processing.
        /// </param>
        /// <param name="model">
        /// Model used for processing.
        /// </param>
        /// <param name="cropToFill">
        /// Whether cropping to fill is enabled.
        /// </param>
        /// <param name="status">
        /// Status of the job.
        /// </param>
        /// <param name="progress">
        /// Progress of the job as a percentage. Useful for displaying a progress bar or loading spinners etc.
        /// </param>
        /// <param name="eta">
        /// Estimated time of arrival (ETA) for the process to complete in Unix time.
        /// </param>
        /// <param name="creationTime">
        /// Creation time of the job in Unix epoch format.
        /// </param>
        /// <param name="modificationTime">
        /// Last modification time of the job in Unix epoch format.
        /// </param>
        /// <param name="credits">
        /// Credits (to be) consumed on image processing completion.
        /// </param>
        /// <param name="sourceId">
        /// Unique identifier of the source image.
        /// </param>
        /// <param name="subjectDetection">
        /// Level of subject detection.
        /// </param>
        /// <param name="faceEnhancement">
        /// Whether face enhancement is enabled.
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// Level of face enhancement creativity (if enabled).
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// Level of face enhancement strength (if enabled).
        /// </param>
        /// <param name="optionsJson">
        /// Additional options in JSON format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatusResponse(
            string processId,
            string filename,
            string inputFormat,
            int inputHeight,
            int inputWidth,
            string outputFormat,
            int outputHeight,
            int outputWidth,
            string category,
            string modelType,
            string model,
            bool cropToFill,
            global::Topaz.StatusResponseStatus status,
            int progress,
            int eta,
            int creationTime,
            int modificationTime,
            int credits,
            string? sourceId,
            string? subjectDetection,
            bool? faceEnhancement,
            double? faceEnhancementCreativity,
            double? faceEnhancementStrength,
            string? optionsJson)
        {
            this.ProcessId = processId ?? throw new global::System.ArgumentNullException(nameof(processId));
            this.SourceId = sourceId;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.InputFormat = inputFormat ?? throw new global::System.ArgumentNullException(nameof(inputFormat));
            this.InputHeight = inputHeight;
            this.InputWidth = inputWidth;
            this.OutputFormat = outputFormat ?? throw new global::System.ArgumentNullException(nameof(outputFormat));
            this.OutputHeight = outputHeight;
            this.OutputWidth = outputWidth;
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.ModelType = modelType ?? throw new global::System.ArgumentNullException(nameof(modelType));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SubjectDetection = subjectDetection;
            this.FaceEnhancement = faceEnhancement;
            this.FaceEnhancementCreativity = faceEnhancementCreativity;
            this.FaceEnhancementStrength = faceEnhancementStrength;
            this.CropToFill = cropToFill;
            this.OptionsJson = optionsJson;
            this.Status = status;
            this.Progress = progress;
            this.Eta = eta;
            this.CreationTime = creationTime;
            this.ModificationTime = modificationTime;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponse" /> class.
        /// </summary>
        public StatusResponse()
        {
        }
    }
}