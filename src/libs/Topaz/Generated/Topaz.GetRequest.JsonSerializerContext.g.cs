
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhancedDownloadSignedUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilterModel), TypeInfoPropertyName = "FrameInterpolationFilterModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.InitialEstimates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordStatus), TypeInfoPropertyName = "VideoRequestRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordTs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordProcessingTopserving))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordSourceResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecordTransaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordTransaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordTransactionOperation), TypeInfoPropertyName = "VideoRequestRecordTransactionOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>), TypeInfoPropertyName = "AnyOfUpscaleFilterFrameInterpolationFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioCodec), TypeInfoPropertyName = "OutputInformationVideoAudioCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioTransfer), TypeInfoPropertyName = "OutputInformationVideoAudioTransfer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoVideoEncoder), TypeInfoPropertyName = "OutputInformationVideoVideoEncoder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel), TypeInfoPropertyName = "OutputInformationVideoDynamicCompressionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoContainer), TypeInfoPropertyName = "OutputInformationVideoContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterModel), TypeInfoPropertyName = "UpscaleFilterModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterVideoType), TypeInfoPropertyName = "UpscaleFilterVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterAuto), TypeInfoPropertyName = "UpscaleFilterAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterFieldOrder), TypeInfoPropertyName = "UpscaleFilterFieldOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterFocusFixLevel), TypeInfoPropertyName = "UpscaleFilterFocusFixLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterGrainType), TypeInfoPropertyName = "UpscaleFilterGrainType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterTransferFunction), TypeInfoPropertyName = "UpscaleFilterTransferFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode2), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode3), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode4), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilterModel?), TypeInfoPropertyName = "NullableFrameInterpolationFilterModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordStatus?), TypeInfoPropertyName = "NullableVideoRequestRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoRequestRecordTransactionOperation?), TypeInfoPropertyName = "NullableVideoRequestRecordTransactionOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>?), TypeInfoPropertyName = "NullableAnyOfUpscaleFilterFrameInterpolationFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioCodec?), TypeInfoPropertyName = "NullableOutputInformationVideoAudioCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioTransfer?), TypeInfoPropertyName = "NullableOutputInformationVideoAudioTransfer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoVideoEncoder?), TypeInfoPropertyName = "NullableOutputInformationVideoVideoEncoder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel?), TypeInfoPropertyName = "NullableOutputInformationVideoDynamicCompressionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoContainer?), TypeInfoPropertyName = "NullableOutputInformationVideoContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterModel?), TypeInfoPropertyName = "NullableUpscaleFilterModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterVideoType?), TypeInfoPropertyName = "NullableUpscaleFilterVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterAuto?), TypeInfoPropertyName = "NullableUpscaleFilterAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterFieldOrder?), TypeInfoPropertyName = "NullableUpscaleFilterFieldOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterFocusFixLevel?), TypeInfoPropertyName = "NullableUpscaleFilterFocusFixLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterGrainType?), TypeInfoPropertyName = "NullableUpscaleFilterGrainType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterTransferFunction?), TypeInfoPropertyName = "NullableUpscaleFilterTransferFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode?), TypeInfoPropertyName = "NullableGetVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode2?), TypeInfoPropertyName = "NullableGetVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode3?), TypeInfoPropertyName = "NullableGetVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode4?), TypeInfoPropertyName = "NullableGetVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.VideoRequestRecordTransaction>))]
    internal sealed partial class GetRequestSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRequestSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GetRequestSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GetRequestSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Topaz.JsonConverters.AnyOfJsonConverter<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>());
            options.Converters.Add(new global::Topaz.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel)

                    || typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel?)

                    || typeToConvert == typeof(global::Topaz.VideoRequestRecordStatus)

                    || typeToConvert == typeof(global::Topaz.VideoRequestRecordStatus?)

                    || typeToConvert == typeof(global::Topaz.VideoRequestRecordTransactionOperation)

                    || typeToConvert == typeof(global::Topaz.VideoRequestRecordTransactionOperation?)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioCodec)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioCodec?)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioTransfer)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioTransfer?)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoVideoEncoder)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoVideoEncoder?)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel?)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoContainer)

                    || typeToConvert == typeof(global::Topaz.OutputInformationVideoContainer?)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterModel)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterModel?)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterVideoType)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterVideoType?)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterAuto)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterAuto?)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterFieldOrder)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterFieldOrder?)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterFocusFixLevel)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterFocusFixLevel?)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterGrainType)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterGrainType?)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterTransferFunction)

                    || typeToConvert == typeof(global::Topaz.UpscaleFilterTransferFunction?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode2)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode2?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode3)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode3?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode4)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode4?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel))
                {
                    return new global::Topaz.JsonConverters.FrameInterpolationFilterModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel?))
                {
                    return new global::Topaz.JsonConverters.FrameInterpolationFilterModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.VideoRequestRecordStatus))
                {
                    return new global::Topaz.JsonConverters.VideoRequestRecordStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.VideoRequestRecordStatus?))
                {
                    return new global::Topaz.JsonConverters.VideoRequestRecordStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.VideoRequestRecordTransactionOperation))
                {
                    return new global::Topaz.JsonConverters.VideoRequestRecordTransactionOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.VideoRequestRecordTransactionOperation?))
                {
                    return new global::Topaz.JsonConverters.VideoRequestRecordTransactionOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioCodec))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoAudioCodecJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioCodec?))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoAudioCodecNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioTransfer))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoAudioTransferJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoAudioTransfer?))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoAudioTransferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoVideoEncoder))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoVideoEncoderJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoVideoEncoder?))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoVideoEncoderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoDynamicCompressionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel?))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoDynamicCompressionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoContainer))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.OutputInformationVideoContainer?))
                {
                    return new global::Topaz.JsonConverters.OutputInformationVideoContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterModel))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterModel?))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterVideoType))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterVideoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterVideoType?))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterVideoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterAuto))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterAutoJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterAuto?))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterAutoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterFieldOrder))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterFieldOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterFieldOrder?))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterFieldOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterFocusFixLevel))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterFocusFixLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterFocusFixLevel?))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterFocusFixLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterGrainType))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterGrainTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterGrainType?))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterGrainTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterTransferFunction))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterTransferFunctionJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.UpscaleFilterTransferFunction?))
                {
                    return new global::Topaz.JsonConverters.UpscaleFilterTransferFunctionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode2))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode2?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode3))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode3?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode4))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestResponseErrorCode4?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode4NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new GetRequestSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}