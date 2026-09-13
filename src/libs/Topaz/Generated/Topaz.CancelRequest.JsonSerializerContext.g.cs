
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode), TypeInfoPropertyName = "CancelVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.CancelVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode2), TypeInfoPropertyName = "CancelVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode3), TypeInfoPropertyName = "CancelVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode4), TypeInfoPropertyName = "CancelVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode5), TypeInfoPropertyName = "CancelVideoRequestResponseErrorCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode?), TypeInfoPropertyName = "NullableCancelVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode2?), TypeInfoPropertyName = "NullableCancelVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode3?), TypeInfoPropertyName = "NullableCancelVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode4?), TypeInfoPropertyName = "NullableCancelVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponseErrorCode5?), TypeInfoPropertyName = "NullableCancelVideoRequestResponseErrorCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CancelVideoRequestResponseError>))]
    internal sealed partial class CancelRequestSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelRequestSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CancelRequestSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CancelRequestSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode?)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode2)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode2?)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode3)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode3?)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode4)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode4?)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode5)

                    || typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode5?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode?))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode2))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode2?))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode3))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode3?))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode4))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode4?))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode5))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.CancelVideoRequestResponseErrorCode5?))
                {
                    return new global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode5NullableJsonConverter();
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
                    0 => new CancelRequestSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}