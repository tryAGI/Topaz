#nullable enable

namespace Topaz
{
    public partial interface ICompleteUploadClient
    {
        /// <summary>
        /// Complete Video Upload<br/>
        /// Send metadata of the multi-part uploads to complete the upload and begin processing the video.<br/>
        /// Optionally include the MD5 hash of the source video file to validate successful upload before processing.<br/>
        /// ## Request body<br/>
        /// | **Property**    | **Type**         | **Description**                                                                                         |<br/>
        /// |-----------------|------------------|---------------------------------------------------------------------------------------------------------|<br/>
        /// | **uploadResults**           | Array   | An array of part number and ETag pairs of the uploaded parts. ETags are returned by S3 upon upload of the part. |<br/>
        /// | **uploadResults.*.partNum** | Integer | Part number of the uploaded part, starting from 1                                                      |<br/>
        /// | **uploadResults.*.eTag**    | String  | eTag value returned by S3 upon upload of the part   
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.CompleteVideoUploadResponse> CompleteVideoUploadAsync(
            global::System.Guid requestId,

            global::Topaz.CompleteVideoUploadRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete Video Upload<br/>
        /// Send metadata of the multi-part uploads to complete the upload and begin processing the video.<br/>
        /// Optionally include the MD5 hash of the source video file to validate successful upload before processing.<br/>
        /// ## Request body<br/>
        /// | **Property**    | **Type**         | **Description**                                                                                         |<br/>
        /// |-----------------|------------------|---------------------------------------------------------------------------------------------------------|<br/>
        /// | **uploadResults**           | Array   | An array of part number and ETag pairs of the uploaded parts. ETags are returned by S3 upon upload of the part. |<br/>
        /// | **uploadResults.*.partNum** | Integer | Part number of the uploaded part, starting from 1                                                      |<br/>
        /// | **uploadResults.*.eTag**    | String  | eTag value returned by S3 upon upload of the part   
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.CompleteVideoUploadResponse>> CompleteVideoUploadAsResponseAsync(
            global::System.Guid requestId,

            global::Topaz.CompleteVideoUploadRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete Video Upload<br/>
        /// Send metadata of the multi-part uploads to complete the upload and begin processing the video.<br/>
        /// Optionally include the MD5 hash of the source video file to validate successful upload before processing.<br/>
        /// ## Request body<br/>
        /// | **Property**    | **Type**         | **Description**                                                                                         |<br/>
        /// |-----------------|------------------|---------------------------------------------------------------------------------------------------------|<br/>
        /// | **uploadResults**           | Array   | An array of part number and ETag pairs of the uploaded parts. ETags are returned by S3 upon upload of the part. |<br/>
        /// | **uploadResults.*.partNum** | Integer | Part number of the uploaded part, starting from 1                                                      |<br/>
        /// | **uploadResults.*.eTag**    | String  | eTag value returned by S3 upon upload of the part   
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="md5Hash">
        /// MD5 hash of the source video file in hex<br/>
        /// Example: 4d186321c1a7f0f354b297e8914ab240
        /// </param>
        /// <param name="uploadResults">
        /// An array of part number and ETag pairs of the uploaded parts. ETags are returned by S3 upon upload of the part.<br/>
        /// Example: [{"partNum":1,"eTag":"ff00a2c854712e4b4765eeefa084baa5-305"}, {"partNum":2,"eTag":"92ee1d92cda0f9f8de4429c9596773aa-34"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.CompleteVideoUploadResponse> CompleteVideoUploadAsync(
            global::System.Guid requestId,
            global::System.Collections.Generic.IList<global::Topaz.CompleteVideoUploadRequestUploadResult> uploadResults,
            string? md5Hash = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}