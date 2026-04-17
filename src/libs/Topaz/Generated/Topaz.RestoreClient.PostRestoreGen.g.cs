
#nullable enable

namespace Topaz
{
    public partial class RestoreClient
    {


        private static readonly global::Topaz.EndPointSecurityRequirement s_PostRestoreGenSecurityRequirement0 =
            new global::Topaz.EndPointSecurityRequirement
            {
                Authorizations = new global::Topaz.EndPointAuthorizationRequirement[]
                {                    new global::Topaz.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Topaz.EndPointSecurityRequirement[] s_PostRestoreGenSecurityRequirements =
            new global::Topaz.EndPointSecurityRequirement[]
            {                s_PostRestoreGenSecurityRequirement0,
            };
        partial void PreparePostRestoreGenArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Topaz.RestoreGenRequest request);
        partial void PreparePostRestoreGenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Topaz.RestoreGenRequest request);
        partial void ProcessPostRestoreGenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostRestoreGenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Restore Generative<br/>
        /// The following are our restoration models designed to enhance photos that are older and of poorer quality.<br/>
        /// Returns `process_id` and `eta` to use as an efficient way to track the progress of the image restoration job:<br/>
        ///   - Use the `Status` endpoints to check the status of this job using the returned `process_id`.<br/>
        ///   - Use the `Download` endpoints to download the input or processed image (once it is ready).<br/>
        ///   - Use the `Cancel` endpoint to cancel the job while it is in progress.<br/>
        /// The same `process_id` and `eta` are also returned in the response headers as `X-Process-ID` and `X-ETA` respectively.<br/>
        /// &gt; The `eta` represents when the job is expected to finish in Unix time. We recommend using this to know when you can expect your (bulk) jobs to finish processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Topaz.AsyncResponse> PostRestoreGenAsync(

            global::Topaz.RestoreGenRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PostRestoreGenAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Restore Generative<br/>
        /// The following are our restoration models designed to enhance photos that are older and of poorer quality.<br/>
        /// Returns `process_id` and `eta` to use as an efficient way to track the progress of the image restoration job:<br/>
        ///   - Use the `Status` endpoints to check the status of this job using the returned `process_id`.<br/>
        ///   - Use the `Download` endpoints to download the input or processed image (once it is ready).<br/>
        ///   - Use the `Cancel` endpoint to cancel the job while it is in progress.<br/>
        /// The same `process_id` and `eta` are also returned in the response headers as `X-Process-ID` and `X-ETA` respectively.<br/>
        /// &gt; The `eta` represents when the job is expected to finish in Unix time. We recommend using this to know when you can expect your (bulk) jobs to finish processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.AsyncResponse>> PostRestoreGenAsResponseAsync(

            global::Topaz.RestoreGenRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostRestoreGenArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Topaz.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostRestoreGenSecurityRequirements,
                operationName: "PostRestoreGenAsync");

            using var __timeoutCancellationTokenSource = global::Topaz.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Topaz.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Topaz.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Topaz.PathBuilder(
                                path: "/image/v1/restore-gen/async",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Topaz.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.Image != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Image}"),
                                    name: "\"image\"");
                            } 
                            if (request.SourceId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.SourceId}"),
                                    name: "\"source_id\"");
                            } 
                            if (request.SourceUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.SourceUrl}"),
                                    name: "\"source_url\"");
                            } 
                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Model?.ToValueString()}"),
                                    name: "\"model\"");
                            } 
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.OutputFormat?.ToValueString()}"),
                                    name: "\"output_format\"");
                            } 
                            if (request.WebhookUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.WebhookUrl}"),
                                    name: "\"webhook_url\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::Topaz.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePostRestoreGenRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Topaz.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Topaz.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostRestoreGen",
                                methodName: "PostRestoreGenAsync",
                                pathTemplate: "\"/image/v1/restore-gen/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Topaz.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Topaz.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostRestoreGen",
                                methodName: "PostRestoreGenAsync",
                                pathTemplate: "\"/image/v1/restore-gen/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Topaz.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Topaz.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Topaz.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Topaz.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostRestoreGen",
                                methodName: "PostRestoreGenAsync",
                                pathTemplate: "\"/image/v1/restore-gen/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Topaz.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessPostRestoreGenResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Topaz.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Topaz.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostRestoreGen",
                                methodName: "PostRestoreGenAsync",
                                pathTemplate: "\"/image/v1/restore-gen/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Topaz.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Topaz.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostRestoreGen",
                                methodName: "PostRestoreGenAsync",
                                pathTemplate: "\"/image/v1/restore-gen/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // The request contains malformed data in the body, path, or query parameters.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Topaz.PostRestoreGenResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Topaz.PostRestoreGenResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Topaz.PostRestoreGenResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Authentication is required and has failed or has not yet been provided.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Topaz.PostRestoreGenResponse2? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Topaz.PostRestoreGenResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Topaz.PostRestoreGenResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse2>(
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_401,
                                    ResponseObject = __value_401,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Payment is required to access the resource.
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::Topaz.PostRestoreGenResponse3? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::Topaz.PostRestoreGenResponse3.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::Topaz.PostRestoreGenResponse3.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse3>(
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_402,
                                    ResponseObject = __value_402,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // The API key doesn't have permissions to perform the request.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Topaz.PostRestoreGenResponse4? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Topaz.PostRestoreGenResponse4.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Topaz.PostRestoreGenResponse4.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse4>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // The preconditions to process the request were not met.
                            if ((int)__response.StatusCode == 412)
                            {
                                string? __content_412 = null;
                                global::System.Exception? __exception_412 = null;
                                global::Topaz.PostRestoreGenResponse5? __value_412 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_412 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_412 = global::Topaz.PostRestoreGenResponse5.FromJson(__content_412, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_412 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_412 = global::Topaz.PostRestoreGenResponse5.FromJson(__content_412, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_412 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse5>(
                                    message: __content_412 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_412,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_412,
                                    ResponseObject = __value_412,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // The request is larger than the server is willing or able to process.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::Topaz.PostRestoreGenResponse6? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::Topaz.PostRestoreGenResponse6.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::Topaz.PostRestoreGenResponse6.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse6>(
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_413,
                                    ResponseObject = __value_413,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // The request entity has a media type which the server or resource does not support.
                            if ((int)__response.StatusCode == 415)
                            {
                                string? __content_415 = null;
                                global::System.Exception? __exception_415 = null;
                                global::Topaz.PostRestoreGenResponse7? __value_415 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_415 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_415 = global::Topaz.PostRestoreGenResponse7.FromJson(__content_415, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_415 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_415 = global::Topaz.PostRestoreGenResponse7.FromJson(__content_415, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_415 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse7>(
                                    message: __content_415 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_415,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_415,
                                    ResponseObject = __value_415,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // The request was well-formed but was unable to be followed due to semantic errors.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Topaz.PostRestoreGenResponse8? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Topaz.PostRestoreGenResponse8.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Topaz.PostRestoreGenResponse8.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse8>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // The request was sent too early to be processed. Please wait before retrying.
                            if ((int)__response.StatusCode == 425)
                            {
                                string? __content_425 = null;
                                global::System.Exception? __exception_425 = null;
                                global::Topaz.PostRestoreGenResponse9? __value_425 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_425 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_425 = global::Topaz.PostRestoreGenResponse9.FromJson(__content_425, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_425 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_425 = global::Topaz.PostRestoreGenResponse9.FromJson(__content_425, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_425 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse9>(
                                    message: __content_425 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_425,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_425,
                                    ResponseObject = __value_425,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Too many requests hit the API too quickly. A backoff (e.g. exponential) is recommended for your requests.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Topaz.PostRestoreGenResponse10? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Topaz.PostRestoreGenResponse10.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Topaz.PostRestoreGenResponse10.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse10>(
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_429,
                                    ResponseObject = __value_429,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Unexpected error on our end.
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Topaz.PostRestoreGenResponse11? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Topaz.PostRestoreGenResponse11.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Topaz.PostRestoreGenResponse11.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.PostRestoreGenResponse11>(
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_500,
                                    ResponseObject = __value_500,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessPostRestoreGenResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Topaz.AsyncResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Topaz.AutoSDKHttpResponse<global::Topaz.AsyncResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Topaz.AutoSDKHttpResponse.CreateHeaders(__response),
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Topaz.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Topaz.AsyncResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Topaz.AutoSDKHttpResponse<global::Topaz.AsyncResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Topaz.AutoSDKHttpResponse.CreateHeaders(__response),
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Topaz.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Restore Generative<br/>
        /// The following are our restoration models designed to enhance photos that are older and of poorer quality.<br/>
        /// Returns `process_id` and `eta` to use as an efficient way to track the progress of the image restoration job:<br/>
        ///   - Use the `Status` endpoints to check the status of this job using the returned `process_id`.<br/>
        ///   - Use the `Download` endpoints to download the input or processed image (once it is ready).<br/>
        ///   - Use the `Cancel` endpoint to cancel the job while it is in progress.<br/>
        /// The same `process_id` and `eta` are also returned in the response headers as `X-Process-ID` and `X-ETA` respectively.<br/>
        /// &gt; The `eta` represents when the job is expected to finish in Unix time. We recommend using this to know when you can expect your (bulk) jobs to finish processing.
        /// </summary>
        /// <param name="image">
        /// The image file to be processed. Supported formats:<br/>
        ///   - jpeg (or jpg)<br/>
        ///   - png<br/>
        ///   - tiff (or tif)
        /// </param>
        /// <param name="sourceId">
        /// Unique identifier of the source image.
        /// </param>
        /// <param name="sourceUrl">
        /// The URL of the source image.
        /// </param>
        /// <param name="model">
        /// The model to use for processing the image.<br/>
        /// Default Value: Dust-Scratch
        /// </param>
        /// <param name="outputFormat">
        /// The desired format of the output image.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to send the webhook to. When provided, a POST request with a JSON payload will be sent to this URL when the job status changes or completes.<br/>
        /// **Request Body:**<br/>
        /// The webhook will be sent as a POST request with `Content-Type: application/json` containing the following fields:<br/>
        ///   - `notification_id` (string, ULID): Unique identifier for this notification. Can be used to order messages in case they are received out of order; see the [ULID specification](https://github.com/ulid/spec)<br/>
        ///   - `process_id` (string, UUID): Unique identifier of the image processing job.<br/>
        ///   - `status` (string): Current status of the job (i.e., "Pending", "Processing", "Completed", "Cancelled", "Failed").<br/>
        ///   - `creation_time` (integer): Unix timestamp in seconds when the job was created.<br/>
        ///   - `modification_time` (integer): Unix timestamp in seconds when the job was last modified.<br/>
        ///   - `progress` (integer): Progress of the job as a percentage (0-100).<br/>
        ///   - `download_url` (string, optional): Presigned GET URL for the processed image. Only present once the job is completed.<br/>
        ///   - `head_url` (string, optional): Presigned HEAD URL for the processed image. Only present once the job is completed.<br/>
        ///   - `input_download_url` (string): Presigned GET URL for the input image.<br/>
        ///   - `input_head_url` (string): Presigned HEAD URL for the input image.<br/>
        /// **Retry Behavior:**<br/>
        /// If the webhook endpoint returns a 5xx server error, the system will retry the webhook with exponential backoff. The backoff starts at 5 seconds and doubles with each retry attempt (5s, 10s, 20s, 40s, etc.), up to a maximum of 15 minutes. Client errors (4xx status codes) are not retried and the notification is discarded.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Topaz.AsyncResponse> PostRestoreGenAsync(
            string? image = default,
            string? sourceId = default,
            string? sourceUrl = default,
            global::Topaz.RestoreGenRequestModel? model = default,
            global::Topaz.RestoreGenRequestOutputFormat? outputFormat = default,
            string? webhookUrl = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Topaz.RestoreGenRequest
            {
                Image = image,
                SourceId = sourceId,
                SourceUrl = sourceUrl,
                Model = model,
                OutputFormat = outputFormat,
                WebhookUrl = webhookUrl,
            };

            return await PostRestoreGenAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}