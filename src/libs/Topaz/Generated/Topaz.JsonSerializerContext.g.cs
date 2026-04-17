
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
            typeof(global::Topaz.JsonConverters.EnhanceGANRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.EnhanceGANRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EnhanceGANRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.EnhanceGANRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EnhanceGenRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.EnhanceGenRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EnhanceGenRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.EnhanceGenRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGANRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGANRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGANRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGANRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGenRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGenRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGenRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.SharpenGenRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.DenoiseGANRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.DenoiseGANRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.DenoiseGANRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.DenoiseGANRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.RestoreGenRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.RestoreGenRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.RestoreGenRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.RestoreGenRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.LightingGANRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.LightingGANRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.LightingGANRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.LightingGANRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.MattingGANRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.MattingGANRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.MattingGANRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.MattingGANRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.ToolGANRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.ToolGANRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.ToolGANRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.ToolGANRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGANRequestCategoryJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGANRequestCategoryNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGANRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGANRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGANRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGANRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGenRequestCategoryJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGenRequestCategoryNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGenRequestModelJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGenRequestModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGenRequestOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateGenRequestOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateBulkRequestItemCategoryJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateBulkRequestItemCategoryNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateBulkRequestItemModelJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateBulkRequestItemModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateBulkRequestItemOutputFormatJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimateBulkRequestItemOutputFormatNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.StatusResponseStatusJsonConverter),

            typeof(global::Topaz.JsonConverters.StatusResponseStatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimationBulkResponseItemVariant1StatusJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimationBulkResponseItemVariant1StatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimationBulkResponseItemVariant2StatusJsonConverter),

            typeof(global::Topaz.JsonConverters.EstimationBulkResponseItemVariant2StatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.ExternalStorageProviderJsonConverter),

            typeof(global::Topaz.JsonConverters.ExternalStorageProviderNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.FrameInterpolationFilterModelJsonConverter),

            typeof(global::Topaz.JsonConverters.FrameInterpolationFilterModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.HistoryResponseStatusJsonConverter),

            typeof(global::Topaz.JsonConverters.HistoryResponseStatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.HistoryResponseTransactionOperationJsonConverter),

            typeof(global::Topaz.JsonConverters.HistoryResponseTransactionOperationNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationImageSequenceVideoEncoderJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationImageSequenceVideoEncoderNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationImageSequenceContainerJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationImageSequenceContainerNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioCodecJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioCodecNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioTransferJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioTransferNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoVideoEncoderJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoVideoEncoderNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoDynamicCompressionLevelJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoDynamicCompressionLevelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoContainerJsonConverter),

            typeof(global::Topaz.JsonConverters.OutputInformationVideoContainerNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.ProcessingStatIntermediateItemStatusJsonConverter),

            typeof(global::Topaz.JsonConverters.ProcessingStatIntermediateItemStatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.VideoStatusResponseStatusJsonConverter),

            typeof(global::Topaz.JsonConverters.VideoStatusResponseStatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterModelJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterVideoTypeJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterVideoTypeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterAutoJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterAutoNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterFieldOrderJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterFieldOrderNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterFocusFixLevelJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterFocusFixLevelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestRequestSourceContainerJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestRequestSourceContainerNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestRequestSourceContainerJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestRequestSourceContainerNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OneOfJsonConverter<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>),

            typeof(global::Topaz.JsonConverters.AnyOfJsonConverter<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>),

            typeof(global::Topaz.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>),

            typeof(global::Topaz.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequestModel), TypeInfoPropertyName = "EnhanceGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGANRequestOutputFormat), TypeInfoPropertyName = "EnhanceGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequestModel), TypeInfoPropertyName = "EnhanceGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhanceGenRequestOutputFormat), TypeInfoPropertyName = "EnhanceGenRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequestModel), TypeInfoPropertyName = "SharpenGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGANRequestOutputFormat), TypeInfoPropertyName = "SharpenGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequestModel), TypeInfoPropertyName = "SharpenGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SharpenGenRequestOutputFormat), TypeInfoPropertyName = "SharpenGenRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DenoiseGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DenoiseGANRequestModel), TypeInfoPropertyName = "DenoiseGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DenoiseGANRequestOutputFormat), TypeInfoPropertyName = "DenoiseGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.RestoreGenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.RestoreGenRequestModel), TypeInfoPropertyName = "RestoreGenRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.RestoreGenRequestOutputFormat), TypeInfoPropertyName = "RestoreGenRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.LightingGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.LightingGANRequestModel), TypeInfoPropertyName = "LightingGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.LightingGANRequestOutputFormat), TypeInfoPropertyName = "LightingGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MattingGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MattingGANRequestModel), TypeInfoPropertyName = "MattingGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MattingGANRequestOutputFormat), TypeInfoPropertyName = "MattingGANRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ToolGANRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ToolGANRequestModel), TypeInfoPropertyName = "ToolGANRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ToolGANRequestOutputFormat), TypeInfoPropertyName = "ToolGANRequestOutputFormat2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.StatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.StatusResponseStatus), TypeInfoPropertyName = "StatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DownloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>), TypeInfoPropertyName = "OneOfEstimationBulkResponseItemVariant1EstimationBulkResponseItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant1Status), TypeInfoPropertyName = "EstimationBulkResponseItemVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EstimationBulkResponseItemVariant2Status), TypeInfoPropertyName = "EstimationBulkResponseItemVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PaginationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PaginatedStatusesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.StatusResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ChunkMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ChunkMetricsTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ChunkMetricsTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.RequestEstimates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CredentialsS3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhancedDownloadSignedUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorageProvider), TypeInfoPropertyName = "ExternalStorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.FrameInterpolationFilterModel), TypeInfoPropertyName = "FrameInterpolationFilterModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.HistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.HistoryResponseStatus), TypeInfoPropertyName = "HistoryResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.HistoryResponseTs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.HistoryResponseTransaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.HistoryResponseTransaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.HistoryResponseTransactionOperation), TypeInfoPropertyName = "HistoryResponseTransactionOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.HistoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>), TypeInfoPropertyName = "AnyOfUpscaleFilterFrameInterpolationFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MetricsResponseMinutesInState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ChunkMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequenceResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequenceVideoEncoder), TypeInfoPropertyName = "OutputInformationImageSequenceVideoEncoder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequenceContainer), TypeInfoPropertyName = "OutputInformationImageSequenceContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioCodec), TypeInfoPropertyName = "OutputInformationVideoAudioCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioTransfer), TypeInfoPropertyName = "OutputInformationVideoAudioTransfer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoVideoEncoder), TypeInfoPropertyName = "OutputInformationVideoVideoEncoder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel), TypeInfoPropertyName = "OutputInformationVideoDynamicCompressionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoContainer), TypeInfoPropertyName = "OutputInformationVideoContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ProcessingStatIntermediateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ProcessingStatIntermediateItemStatus), TypeInfoPropertyName = "ProcessingStatIntermediateItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoStatusResponseStatus), TypeInfoPropertyName = "VideoStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SystemStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterModel), TypeInfoPropertyName = "UpscaleFilterModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterVideoType), TypeInfoPropertyName = "UpscaleFilterVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterAuto), TypeInfoPropertyName = "UpscaleFilterAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterFieldOrder), TypeInfoPropertyName = "UpscaleFilterFieldOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.UpscaleFilterFocusFixLevel), TypeInfoPropertyName = "UpscaleFilterFocusFixLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestSourceContainer), TypeInfoPropertyName = "CreateVideoRequestRequestSourceContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestSourceResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestRequestNotifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestRequestSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestRequestSourceContainer), TypeInfoPropertyName = "CreateExpressVideoRequestRequestSourceContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestRequestDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestRequestNotifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.CompleteVideoUploadRequestUploadResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadRequestUploadResult))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceResponse11))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostEnhanceGenResponse11))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenResponse11))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostSharpenGenResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostDenoiseResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostRestoreGenResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostLightingResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostMattingResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.PostToolResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OneOf<global::System.Collections.Generic.IList<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>), TypeInfoPropertyName = "OneOfIListStatusResponsePaginatedStatusesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetAllStatusesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetAllStatusesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetAllStatusesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetAllStatusesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetAllStatusesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteAllStatusesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteAllStatusesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteAllStatusesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteAllStatusesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteAllStatusesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetStatusResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetStatusResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetStatusResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteStatusResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteStatusResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteStatusResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteStatusResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadOutputResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadOutputResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadOutputResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadOutputResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadOutputResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadOutputResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadOutputResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadInputResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadInputResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadInputResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadInputResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadInputResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetDownloadInputResponse6))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelTaskResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelTaskResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelTaskResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelTaskResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelTaskResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelTaskResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetSystemStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelVideoRequestResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.HistoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.EstimateBulkRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.StatusResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ChunkMetricsTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.HistoryResponseTransaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ChunkMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ProcessingStatIntermediateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CompleteVideoUploadRequestUploadResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OneOf<global::System.Collections.Generic.List<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.HistoryResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}