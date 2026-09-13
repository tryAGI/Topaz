
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequestModel), TypeInfoPropertyName = "EnhanceGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequestOutputFormat), TypeInfoPropertyName = "EnhanceGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequestModel), TypeInfoPropertyName = "EnhanceGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequestOutputFormat), TypeInfoPropertyName = "EnhanceGenRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequestModel?), TypeInfoPropertyName = "NullableEnhanceGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequestOutputFormat?), TypeInfoPropertyName = "NullableEnhanceGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequestModel?), TypeInfoPropertyName = "NullableEnhanceGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequestOutputFormat?), TypeInfoPropertyName = "NullableEnhanceGenRequestOutputFormat2")]
    internal sealed partial class EnhanceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnhanceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EnhanceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EnhanceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Topaz.EnhanceGANRequestModel)

                    || typeToConvert == typeof(global::Topaz.EnhanceGANRequestModel?)

                    || typeToConvert == typeof(global::Topaz.EnhanceGANRequestOutputFormat)

                    || typeToConvert == typeof(global::Topaz.EnhanceGANRequestOutputFormat?)

                    || typeToConvert == typeof(global::Topaz.EnhanceGenRequestModel)

                    || typeToConvert == typeof(global::Topaz.EnhanceGenRequestModel?)

                    || typeToConvert == typeof(global::Topaz.EnhanceGenRequestOutputFormat)

                    || typeToConvert == typeof(global::Topaz.EnhanceGenRequestOutputFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.EnhanceGANRequestModel))
                {
                    return new global::Topaz.JsonConverters.EnhanceGANRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EnhanceGANRequestModel?))
                {
                    return new global::Topaz.JsonConverters.EnhanceGANRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EnhanceGANRequestOutputFormat))
                {
                    return new global::Topaz.JsonConverters.EnhanceGANRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EnhanceGANRequestOutputFormat?))
                {
                    return new global::Topaz.JsonConverters.EnhanceGANRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EnhanceGenRequestModel))
                {
                    return new global::Topaz.JsonConverters.EnhanceGenRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EnhanceGenRequestModel?))
                {
                    return new global::Topaz.JsonConverters.EnhanceGenRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EnhanceGenRequestOutputFormat))
                {
                    return new global::Topaz.JsonConverters.EnhanceGenRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EnhanceGenRequestOutputFormat?))
                {
                    return new global::Topaz.JsonConverters.EnhanceGenRequestOutputFormatNullableJsonConverter();
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
                    0 => new EnhanceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}