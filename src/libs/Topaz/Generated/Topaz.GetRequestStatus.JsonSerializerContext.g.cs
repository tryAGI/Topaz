
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.RequestEstimates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhancedDownloadSignedUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ProcessingStatIntermediateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ProcessingStatIntermediateItemStatus), TypeInfoPropertyName = "ProcessingStatIntermediateItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoStatusResponseStatus), TypeInfoPropertyName = "VideoStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode2), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode3), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode4), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ProcessingStatIntermediateItemStatus?), TypeInfoPropertyName = "NullableProcessingStatIntermediateItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoStatusResponseStatus?), TypeInfoPropertyName = "NullableVideoStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode?), TypeInfoPropertyName = "NullableGetVideoRequestStatusResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode2?), TypeInfoPropertyName = "NullableGetVideoRequestStatusResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode3?), TypeInfoPropertyName = "NullableGetVideoRequestStatusResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode4?), TypeInfoPropertyName = "NullableGetVideoRequestStatusResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ProcessingStatIntermediateItem>))]
    internal sealed partial class GetRequestStatusSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRequestStatusSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GetRequestStatusSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GetRequestStatusSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Topaz.ProcessingStatIntermediateItemStatus)

                    || typeToConvert == typeof(global::Topaz.ProcessingStatIntermediateItemStatus?)

                    || typeToConvert == typeof(global::Topaz.VideoStatusResponseStatus)

                    || typeToConvert == typeof(global::Topaz.VideoStatusResponseStatus?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode2)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode2?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode3)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode3?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode4)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode4?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.ProcessingStatIntermediateItemStatus))
                {
                    return new global::Topaz.JsonConverters.ProcessingStatIntermediateItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.ProcessingStatIntermediateItemStatus?))
                {
                    return new global::Topaz.JsonConverters.ProcessingStatIntermediateItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.VideoStatusResponseStatus))
                {
                    return new global::Topaz.JsonConverters.VideoStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.VideoStatusResponseStatus?))
                {
                    return new global::Topaz.JsonConverters.VideoStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode2))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode2?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode3))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode3?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode4))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode4?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode4NullableJsonConverter();
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
                    0 => new GetRequestStatusSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}