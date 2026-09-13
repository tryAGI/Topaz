
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.RequestEstimates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CredentialsS3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorageProvider), TypeInfoPropertyName = "ExternalStorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorageMultipart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilterModel), TypeInfoPropertyName = "FrameInterpolationFilterModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideo))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestSourceContainer), TypeInfoPropertyName = "CreateVideoRequestRequestSourceContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestSourceResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestNotifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode), TypeInfoPropertyName = "CreateVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.CreateVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode2), TypeInfoPropertyName = "CreateVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode3), TypeInfoPropertyName = "CreateVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode4), TypeInfoPropertyName = "CreateVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorageProvider?), TypeInfoPropertyName = "NullableExternalStorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilterModel?), TypeInfoPropertyName = "NullableFrameInterpolationFilterModel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestSourceContainer?), TypeInfoPropertyName = "NullableCreateVideoRequestRequestSourceContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode?), TypeInfoPropertyName = "NullableCreateVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode2?), TypeInfoPropertyName = "NullableCreateVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode3?), TypeInfoPropertyName = "NullableCreateVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponseErrorCode4?), TypeInfoPropertyName = "NullableCreateVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CreateVideoRequestResponseError>))]
    internal sealed partial class CreateRequestSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRequestSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CreateRequestSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CreateRequestSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Topaz.ExternalStorageProvider)

                    || typeToConvert == typeof(global::Topaz.ExternalStorageProvider?)

                    || typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel)

                    || typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel?)

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

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestRequestSourceContainer)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestRequestSourceContainer?)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode?)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode2)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode2?)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode3)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode3?)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode4)

                    || typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode4?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.ExternalStorageProvider))
                {
                    return new global::Topaz.JsonConverters.ExternalStorageProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.ExternalStorageProvider?))
                {
                    return new global::Topaz.JsonConverters.ExternalStorageProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel))
                {
                    return new global::Topaz.JsonConverters.FrameInterpolationFilterModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.FrameInterpolationFilterModel?))
                {
                    return new global::Topaz.JsonConverters.FrameInterpolationFilterModelNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestRequestSourceContainer))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestRequestSourceContainerJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestRequestSourceContainer?))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestRequestSourceContainerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode?))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode2))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode2?))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode3))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode3?))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode4))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CreateVideoRequestResponseErrorCode4?))
                {
                    return new global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode4NullableJsonConverter();
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
                    0 => new CreateRequestSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}