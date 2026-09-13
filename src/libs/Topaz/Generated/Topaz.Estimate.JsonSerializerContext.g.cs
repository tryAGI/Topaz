
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGANRequestCategory), TypeInfoPropertyName = "EstimateGANRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGANRequestModel), TypeInfoPropertyName = "EstimateGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGANRequestOutputFormat), TypeInfoPropertyName = "EstimateGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGenRequestCategory), TypeInfoPropertyName = "EstimateGenRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGenRequestModel), TypeInfoPropertyName = "EstimateGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGenRequestOutputFormat), TypeInfoPropertyName = "EstimateGenRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.EstimateBulkRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateBulkRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateBulkRequestItemCategory), TypeInfoPropertyName = "EstimateBulkRequestItemCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateBulkRequestItemModel), TypeInfoPropertyName = "EstimateBulkRequestItemModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateBulkRequestItemOutputFormat), TypeInfoPropertyName = "EstimateBulkRequestItemOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>), TypeInfoPropertyName = "OneOfEstimationBulkResponseItemVariant1EstimationBulkResponseItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant1Status), TypeInfoPropertyName = "EstimationBulkResponseItemVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant2Status), TypeInfoPropertyName = "EstimationBulkResponseItemVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateGenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateGenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateGenResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateGenResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateGenResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateBulkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateBulkResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateBulkResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateBulkResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEstimateBulkResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGANRequestCategory?), TypeInfoPropertyName = "NullableEstimateGANRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGANRequestModel?), TypeInfoPropertyName = "NullableEstimateGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGANRequestOutputFormat?), TypeInfoPropertyName = "NullableEstimateGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGenRequestCategory?), TypeInfoPropertyName = "NullableEstimateGenRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGenRequestModel?), TypeInfoPropertyName = "NullableEstimateGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateGenRequestOutputFormat?), TypeInfoPropertyName = "NullableEstimateGenRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateBulkRequestItemCategory?), TypeInfoPropertyName = "NullableEstimateBulkRequestItemCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateBulkRequestItemModel?), TypeInfoPropertyName = "NullableEstimateBulkRequestItemModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimateBulkRequestItemOutputFormat?), TypeInfoPropertyName = "NullableEstimateBulkRequestItemOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>?), TypeInfoPropertyName = "NullableOneOfEstimationBulkResponseItemVariant1EstimationBulkResponseItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant1Status?), TypeInfoPropertyName = "NullableEstimationBulkResponseItemVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant2Status?), TypeInfoPropertyName = "NullableEstimationBulkResponseItemVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.EstimateBulkRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>))]
    internal sealed partial class EstimateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EstimateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EstimateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EstimateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Topaz.JsonConverters.OneOfJsonConverter<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>());
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
                    typeToConvert == typeof(global::Topaz.EstimateGANRequestCategory)

                    || typeToConvert == typeof(global::Topaz.EstimateGANRequestCategory?)

                    || typeToConvert == typeof(global::Topaz.EstimateGANRequestModel)

                    || typeToConvert == typeof(global::Topaz.EstimateGANRequestModel?)

                    || typeToConvert == typeof(global::Topaz.EstimateGANRequestOutputFormat)

                    || typeToConvert == typeof(global::Topaz.EstimateGANRequestOutputFormat?)

                    || typeToConvert == typeof(global::Topaz.EstimateGenRequestCategory)

                    || typeToConvert == typeof(global::Topaz.EstimateGenRequestCategory?)

                    || typeToConvert == typeof(global::Topaz.EstimateGenRequestModel)

                    || typeToConvert == typeof(global::Topaz.EstimateGenRequestModel?)

                    || typeToConvert == typeof(global::Topaz.EstimateGenRequestOutputFormat)

                    || typeToConvert == typeof(global::Topaz.EstimateGenRequestOutputFormat?)

                    || typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemCategory)

                    || typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemCategory?)

                    || typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemModel)

                    || typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemModel?)

                    || typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemOutputFormat)

                    || typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemOutputFormat?)

                    || typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant1Status)

                    || typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant1Status?)

                    || typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant2Status)

                    || typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant2Status?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Topaz.EstimateGANRequestCategory))
                {
                    return new global::Topaz.JsonConverters.EstimateGANRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGANRequestCategory?))
                {
                    return new global::Topaz.JsonConverters.EstimateGANRequestCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGANRequestModel))
                {
                    return new global::Topaz.JsonConverters.EstimateGANRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGANRequestModel?))
                {
                    return new global::Topaz.JsonConverters.EstimateGANRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGANRequestOutputFormat))
                {
                    return new global::Topaz.JsonConverters.EstimateGANRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGANRequestOutputFormat?))
                {
                    return new global::Topaz.JsonConverters.EstimateGANRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGenRequestCategory))
                {
                    return new global::Topaz.JsonConverters.EstimateGenRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGenRequestCategory?))
                {
                    return new global::Topaz.JsonConverters.EstimateGenRequestCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGenRequestModel))
                {
                    return new global::Topaz.JsonConverters.EstimateGenRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGenRequestModel?))
                {
                    return new global::Topaz.JsonConverters.EstimateGenRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGenRequestOutputFormat))
                {
                    return new global::Topaz.JsonConverters.EstimateGenRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateGenRequestOutputFormat?))
                {
                    return new global::Topaz.JsonConverters.EstimateGenRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemCategory))
                {
                    return new global::Topaz.JsonConverters.EstimateBulkRequestItemCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemCategory?))
                {
                    return new global::Topaz.JsonConverters.EstimateBulkRequestItemCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemModel))
                {
                    return new global::Topaz.JsonConverters.EstimateBulkRequestItemModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemModel?))
                {
                    return new global::Topaz.JsonConverters.EstimateBulkRequestItemModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemOutputFormat))
                {
                    return new global::Topaz.JsonConverters.EstimateBulkRequestItemOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimateBulkRequestItemOutputFormat?))
                {
                    return new global::Topaz.JsonConverters.EstimateBulkRequestItemOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant1Status))
                {
                    return new global::Topaz.JsonConverters.EstimationBulkResponseItemVariant1StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant1Status?))
                {
                    return new global::Topaz.JsonConverters.EstimationBulkResponseItemVariant1StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant2Status))
                {
                    return new global::Topaz.JsonConverters.EstimationBulkResponseItemVariant2StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Topaz.EstimationBulkResponseItemVariant2Status?))
                {
                    return new global::Topaz.JsonConverters.EstimationBulkResponseItemVariant2StatusNullableJsonConverter();
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
                    0 => new EstimateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}