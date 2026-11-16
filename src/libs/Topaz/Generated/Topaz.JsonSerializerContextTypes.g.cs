
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EnhanceGANRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EnhanceGANRequestModel? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EnhanceGANRequestOutputFormat? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EnhanceGenRequest? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EnhanceGenRequestModel? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EnhanceGenRequestOutputFormat? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.SharpenGANRequest? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.SharpenGANRequestModel? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.SharpenGANRequestOutputFormat? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.SharpenGenRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.SharpenGenRequestModel? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.SharpenGenRequestOutputFormat? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DenoiseGANRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DenoiseGANRequestModel? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DenoiseGANRequestOutputFormat? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.RestoreGenRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.RestoreGenRequestModel? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.RestoreGenRequestOutputFormat? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.LightingGANRequest? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.LightingGANRequestModel? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.LightingGANRequestOutputFormat? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.MattingGANRequest? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.MattingGANRequestModel? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.MattingGANRequestOutputFormat? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ToolGANRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ToolGANRequestModel? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ToolGANRequestOutputFormat? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGANRequest? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGANRequestCategory? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGANRequestModel? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGANRequestOutputFormat? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGenRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGenRequestCategory? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGenRequestModel? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateGenRequestOutputFormat? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.EstimateBulkRequestItem>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateBulkRequestItem? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateBulkRequestItemCategory? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateBulkRequestItemModel? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimateBulkRequestItemOutputFormat? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AsyncResponse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.StatusResponse? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.StatusResponseStatus? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DownloadResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimationResponse? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimationBulkResponseItemVariant1? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimationBulkResponseItemVariant1Status? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimationBulkResponseItemVariant2? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EstimationBulkResponseItemVariant2Status? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PaginationMetadata? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PaginatedStatusesResponse? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.StatusResponse>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptResponse? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelEstimateResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelEstimateResponseStatus? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ChunkMetrics? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.ChunkMetricsTask>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ChunkMetricsTask? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.RequestEstimates? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CredentialsS3? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.EnhancedDownloadSignedUrlResponse? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ExternalStorage? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ExternalStorageProvider? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ExternalStorageMultipart? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.FrameInterpolationFilter? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.FrameInterpolationFilterModel? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.InitialEstimates? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecord? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordStatus? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordTs? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordProcessing? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordProcessingTopserving? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationVideo? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordSource? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordSourceResolution? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordDestination? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecordTransaction>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordTransaction? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordTransactionOperation? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordOverrides? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoRequestRecordError? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilter? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.MetricsResponse? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.MetricsResponseMinutesInState? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.ChunkMetrics>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationImageSequence? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationImageSequenceResolution? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationImageSequenceVideoEncoder? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationImageSequenceContainer? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationVideoResolution? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationVideoAudioCodec? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationVideoAudioTransfer? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationVideoVideoEncoder? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationVideoDynamicCompressionLevel? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OutputInformationVideoContainer? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ProcessingStatIntermediateItem? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.ProcessingStatIntermediateItemStatus? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoStatusResponse? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.VideoStatusResponseStatus? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.SystemStatusResponse? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilterModel? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilterVideoType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilterAuto? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilterFieldOrder? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilterFocusFixLevel? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilterGrainType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.UpscaleFilterTransferFunction? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestRequestSource? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestRequestSourceContainer? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestRequestSourceResolution? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestRequestDestination? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestRequestNotifications? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestRequestSource? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestRequestSourceContainer? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestRequestDestination? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestRequestNotifications? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.CompleteVideoUploadRequestUploadResult>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadRequestUploadResult? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostEnhanceResponse? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostEnhanceGenResponse? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostSharpenResponse? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostSharpenGenResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostDenoiseResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostRestoreGenResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostLightingResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostMattingResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostToolResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OneOf<global::System.Collections.Generic.IList<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetAllStatusesResponse2? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetAllStatusesResponse3? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetAllStatusesResponse4? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetAllStatusesResponse5? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetAllStatusesResponse6? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteAllStatusesResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteAllStatusesResponse2? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteAllStatusesResponse3? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteAllStatusesResponse4? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteAllStatusesResponse5? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetStatusResponse? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteStatusResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetDownloadOutputResponse? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetDownloadInputResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostEstimateResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostEstimateGenResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.PostEstimateBulkResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelTaskResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetSystemStatusResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetSystemStatusResponseErrorCode? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestResponseErrorCode? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.CreateVideoRequestResponseError>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestResponseError? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestResponse2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestResponse3? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateVideoRequestResponse4? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestResponseErrorCode? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.CreateExpressVideoRequestResponseError>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestResponseError? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestResponse2? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestResponse3? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CreateExpressVideoRequestResponse4? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponseErrorCode? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.AcceptVideoRequestResponseError>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponseError? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponse2? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponse3? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponse4? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponse5? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponse6? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.AcceptVideoRequestResponse7? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponse2? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponseErrorCode? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.CompleteVideoUploadResponseError>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponseError? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponse3? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponse4? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponse5? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CompleteVideoUploadResponse6? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetVideoRequestResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetVideoRequestResponseErrorCode? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponse2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponseErrorCode? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.CancelVideoRequestResponseError>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponseError? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponse3? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponse4? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponse5? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.CancelVideoRequestResponse6? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetCancelEstimateResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetCancelEstimateResponseErrorCode? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.GetCancelEstimateResponseError>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetCancelEstimateResponseError? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetCancelEstimateResponse2? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetCancelEstimateResponse3? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetCancelEstimateResponse4? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetCancelEstimateResponse5? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteVideoFilesResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteVideoFilesResponseErrorCode? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.DeleteVideoFilesResponseError>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteVideoFilesResponseError? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteVideoFilesResponse2? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteVideoFilesResponse3? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteVideoFilesResponse4? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.DeleteVideoFilesResponse5? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetVideoRequestStatusResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetVideoRequestStatusResponseErrorCode? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetVideoRequestMetricsResponse? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetVideoRequestMetricsResponseErrorCode? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetHistoryResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecord>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetHistoryResponse2? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetHistoryResponseErrorCode? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Topaz.GetHistoryResponseError>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetHistoryResponseError? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetHistoryResponse3? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetHistoryResponse4? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.GetHistoryResponse5? Type239 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.EstimateBulkRequestItem>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.OneOf<global::Topaz.EstimationBulkResponseItemVariant1, global::Topaz.EstimationBulkResponseItemVariant2>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.StatusResponse>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.ChunkMetricsTask>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.VideoRequestRecordTransaction>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.ChunkMetrics>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.ProcessingStatIntermediateItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.CompleteVideoUploadRequestUploadResult>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Topaz.OneOf<global::System.Collections.Generic.List<global::Topaz.StatusResponse>, global::Topaz.PaginatedStatusesResponse>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.CreateVideoRequestResponseError>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.CreateExpressVideoRequestResponseError>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.AcceptVideoRequestResponseError>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.CompleteVideoUploadResponseError>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.CancelVideoRequestResponseError>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.GetCancelEstimateResponseError>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.DeleteVideoFilesResponseError>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.VideoRequestRecord>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Topaz.GetHistoryResponseError>? ListType20 { get; set; }
    }
}