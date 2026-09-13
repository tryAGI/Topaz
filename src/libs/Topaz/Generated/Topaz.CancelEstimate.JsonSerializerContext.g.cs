
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelEstimateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelEstimateResponseStatus), TypeInfoPropertyName = "CancelEstimateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode), TypeInfoPropertyName = "GetCancelEstimateResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.GetCancelEstimateResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode2), TypeInfoPropertyName = "GetCancelEstimateResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode3), TypeInfoPropertyName = "GetCancelEstimateResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode4), TypeInfoPropertyName = "GetCancelEstimateResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode5), TypeInfoPropertyName = "GetCancelEstimateResponseErrorCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelEstimateResponseStatus?), TypeInfoPropertyName = "NullableCancelEstimateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode?), TypeInfoPropertyName = "NullableGetCancelEstimateResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode2?), TypeInfoPropertyName = "NullableGetCancelEstimateResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode3?), TypeInfoPropertyName = "NullableGetCancelEstimateResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode4?), TypeInfoPropertyName = "NullableGetCancelEstimateResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetCancelEstimateResponseErrorCode5?), TypeInfoPropertyName = "NullableGetCancelEstimateResponseErrorCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.GetCancelEstimateResponseError>))]
    internal sealed partial class CancelEstimateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelEstimateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CancelEstimateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CancelEstimateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Topaz.CancelEstimateResponseStatus)

                    || typeToConvert == typeof(global::Topaz.CancelEstimateResponseStatus?)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode?)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode2)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode2?)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode3)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode3?)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode4)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode4?)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode5)

                    || typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode5?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.CancelEstimateResponseStatus))
                {
                    return new global::Topaz.JsonConverters.CancelEstimateResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelEstimateResponseStatus?))
                {
                    return new global::Topaz.JsonConverters.CancelEstimateResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode?))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode2))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode2?))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode3))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode3?))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode4))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode4?))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode5))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.GetCancelEstimateResponseErrorCode5?))
                {
                    return new global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode5NullableJsonConverter();
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
                    0 => new CancelEstimateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}