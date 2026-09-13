
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequestModel), TypeInfoPropertyName = "SharpenGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequestOutputFormat), TypeInfoPropertyName = "SharpenGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequestModel), TypeInfoPropertyName = "SharpenGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequestOutputFormat), TypeInfoPropertyName = "SharpenGenRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequestModel?), TypeInfoPropertyName = "NullableSharpenGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequestOutputFormat?), TypeInfoPropertyName = "NullableSharpenGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequestModel?), TypeInfoPropertyName = "NullableSharpenGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequestOutputFormat?), TypeInfoPropertyName = "NullableSharpenGenRequestOutputFormat2")]
    internal sealed partial class SharpenSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SharpenSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SharpenSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SharpenSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Topaz.SharpenGANRequestModel)

                    || typeToConvert == typeof(global::Topaz.SharpenGANRequestModel?)

                    || typeToConvert == typeof(global::Topaz.SharpenGANRequestOutputFormat)

                    || typeToConvert == typeof(global::Topaz.SharpenGANRequestOutputFormat?)

                    || typeToConvert == typeof(global::Topaz.SharpenGenRequestModel)

                    || typeToConvert == typeof(global::Topaz.SharpenGenRequestModel?)

                    || typeToConvert == typeof(global::Topaz.SharpenGenRequestOutputFormat)

                    || typeToConvert == typeof(global::Topaz.SharpenGenRequestOutputFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.SharpenGANRequestModel))
                {
                    return new global::Topaz.JsonConverters.SharpenGANRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.SharpenGANRequestModel?))
                {
                    return new global::Topaz.JsonConverters.SharpenGANRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.SharpenGANRequestOutputFormat))
                {
                    return new global::Topaz.JsonConverters.SharpenGANRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.SharpenGANRequestOutputFormat?))
                {
                    return new global::Topaz.JsonConverters.SharpenGANRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.SharpenGenRequestModel))
                {
                    return new global::Topaz.JsonConverters.SharpenGenRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.SharpenGenRequestModel?))
                {
                    return new global::Topaz.JsonConverters.SharpenGenRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.SharpenGenRequestOutputFormat))
                {
                    return new global::Topaz.JsonConverters.SharpenGenRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.SharpenGenRequestOutputFormat?))
                {
                    return new global::Topaz.JsonConverters.SharpenGenRequestOutputFormatNullableJsonConverter();
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
                    0 => new SharpenSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}