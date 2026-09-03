
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

            typeof(global::Topaz.JsonConverters.CancelEstimateResponseStatusJsonConverter),

            typeof(global::Topaz.JsonConverters.CancelEstimateResponseStatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.ExternalStorageProviderJsonConverter),

            typeof(global::Topaz.JsonConverters.ExternalStorageProviderNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.FrameInterpolationFilterModelJsonConverter),

            typeof(global::Topaz.JsonConverters.FrameInterpolationFilterModelNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.VideoRequestRecordStatusJsonConverter),

            typeof(global::Topaz.JsonConverters.VideoRequestRecordStatusNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.VideoRequestRecordTransactionOperationJsonConverter),

            typeof(global::Topaz.JsonConverters.VideoRequestRecordTransactionOperationNullableJsonConverter),

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

            typeof(global::Topaz.JsonConverters.UpscaleFilterGrainTypeJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterGrainTypeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterTransferFunctionJsonConverter),

            typeof(global::Topaz.JsonConverters.UpscaleFilterTransferFunctionNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestRequestSourceContainerJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestRequestSourceContainerNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestRequestSourceContainerJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestRequestSourceContainerNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetSystemStatusResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.GetSystemStatusResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode5JsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode5NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode6JsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode6NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode7JsonConverter),

            typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode7NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode5JsonConverter),

            typeof(global::Topaz.JsonConverters.CompleteVideoUploadResponseErrorCode5NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode5JsonConverter),

            typeof(global::Topaz.JsonConverters.CancelVideoRequestResponseErrorCode5NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode5JsonConverter),

            typeof(global::Topaz.JsonConverters.GetCancelEstimateResponseErrorCode5NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode5JsonConverter),

            typeof(global::Topaz.JsonConverters.DeleteVideoFilesResponseErrorCode5NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCodeJsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCodeNullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCode2JsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCode2NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCode3JsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCode3NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCode4JsonConverter),

            typeof(global::Topaz.JsonConverters.GetHistoryResponseErrorCode4NullableJsonConverter),

            typeof(global::Topaz.JsonConverters.OneOfJsonConverter<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>),

            typeof(global::Topaz.JsonConverters.AnyOfJsonConverter<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>),

            typeof(global::Topaz.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>),

            typeof(global::Topaz.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelEstimateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CancelEstimateResponseStatus), TypeInfoPropertyName = "CancelEstimateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ChunkMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ChunkMetricsTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ChunkMetricsTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.RequestEstimates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CredentialsS3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.EnhancedDownloadSignedUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorageProvider), TypeInfoPropertyName = "ExternalStorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ExternalStorageMultipart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.MetricsResponseMinutesInState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ChunkMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequenceResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequenceVideoEncoder), TypeInfoPropertyName = "OutputInformationImageSequenceVideoEncoder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationImageSequenceContainer), TypeInfoPropertyName = "OutputInformationImageSequenceContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioCodec), TypeInfoPropertyName = "OutputInformationVideoAudioCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoAudioTransfer), TypeInfoPropertyName = "OutputInformationVideoAudioTransfer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoVideoEncoder), TypeInfoPropertyName = "OutputInformationVideoVideoEncoder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoDynamicCompressionLevel), TypeInfoPropertyName = "OutputInformationVideoDynamicCompressionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OutputInformationVideoContainer), TypeInfoPropertyName = "OutputInformationVideoContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ProcessingStatIntermediateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.ProcessingStatIntermediateItemStatus), TypeInfoPropertyName = "ProcessingStatIntermediateItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.VideoStatusResponseStatus), TypeInfoPropertyName = "VideoStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.SystemStatusResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetSystemStatusResponseErrorCode), TypeInfoPropertyName = "GetSystemStatusResponseErrorCode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponseErrorCode), TypeInfoPropertyName = "CreateExpressVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.CreateExpressVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponseErrorCode2), TypeInfoPropertyName = "CreateExpressVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponseErrorCode3), TypeInfoPropertyName = "CreateExpressVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CreateExpressVideoRequestResponseErrorCode4), TypeInfoPropertyName = "CreateExpressVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseErrorCode), TypeInfoPropertyName = "AcceptVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.AcceptVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseErrorCode2), TypeInfoPropertyName = "AcceptVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseErrorCode3), TypeInfoPropertyName = "AcceptVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseErrorCode4), TypeInfoPropertyName = "AcceptVideoRequestResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseErrorCode5), TypeInfoPropertyName = "AcceptVideoRequestResponseErrorCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseErrorCode6), TypeInfoPropertyName = "AcceptVideoRequestResponseErrorCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.AcceptVideoRequestResponseErrorCode7), TypeInfoPropertyName = "AcceptVideoRequestResponseErrorCode72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponseErrorCode), TypeInfoPropertyName = "CompleteVideoUploadResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.CompleteVideoUploadResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponseErrorCode2), TypeInfoPropertyName = "CompleteVideoUploadResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponseErrorCode3), TypeInfoPropertyName = "CompleteVideoUploadResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponseErrorCode4), TypeInfoPropertyName = "CompleteVideoUploadResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.CompleteVideoUploadResponseErrorCode5), TypeInfoPropertyName = "CompleteVideoUploadResponseErrorCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode2), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode3), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestResponseErrorCode4), TypeInfoPropertyName = "GetVideoRequestResponseErrorCode42")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponseErrorCode), TypeInfoPropertyName = "DeleteVideoFilesResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.DeleteVideoFilesResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponseErrorCode2), TypeInfoPropertyName = "DeleteVideoFilesResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponseErrorCode3), TypeInfoPropertyName = "DeleteVideoFilesResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponseErrorCode4), TypeInfoPropertyName = "DeleteVideoFilesResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.DeleteVideoFilesResponseErrorCode5), TypeInfoPropertyName = "DeleteVideoFilesResponseErrorCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode2), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode3), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestStatusResponseErrorCode4), TypeInfoPropertyName = "GetVideoRequestStatusResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode2), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode3), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetVideoRequestMetricsResponseErrorCode4), TypeInfoPropertyName = "GetVideoRequestMetricsResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponseErrorCode), TypeInfoPropertyName = "GetHistoryResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Topaz.GetHistoryResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponseErrorCode2), TypeInfoPropertyName = "GetHistoryResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponseErrorCode3), TypeInfoPropertyName = "GetHistoryResponseErrorCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.GetHistoryResponseErrorCode4), TypeInfoPropertyName = "GetHistoryResponseErrorCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.EstimateBulkRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.StatusResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ChunkMetricsTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.VideoRequestRecordTransaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ChunkMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.ProcessingStatIntermediateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CompleteVideoUploadRequestUploadResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Topaz.OneOf<global::System.Collections.Generic.List<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CreateVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CreateExpressVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.AcceptVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CompleteVideoUploadResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.CancelVideoRequestResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.GetCancelEstimateResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.DeleteVideoFilesResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.VideoRequestRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Topaz.GetHistoryResponseError>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}