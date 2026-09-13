
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ChunkMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ChunkMetricsTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ChunkMetricsTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MetricsResponseMinutesInState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ChunkMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode2), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode3), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode4), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode?), TypeInfoPropertyName = "NullableGetVideoRequestMetricsResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode2?), TypeInfoPropertyName = "NullableGetVideoRequestMetricsResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode3?), TypeInfoPropertyName = "NullableGetVideoRequestMetricsResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode4?), TypeInfoPropertyName = "NullableGetVideoRequestMetricsResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ChunkMetricsTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ChunkMetrics>))]
    internal sealed partial class GetRequestMetricsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRequestMetricsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GetRequestMetricsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GetRequestMetricsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode2)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode2?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode3)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode3?)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode4)

                    || typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode4?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode2))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode2?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode3))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode3?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode4))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode4?))
                {
                    return new global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode4NullableJsonConverter();
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
                    0 => new GetRequestMetricsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}