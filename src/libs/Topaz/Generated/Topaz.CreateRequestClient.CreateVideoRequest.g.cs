
#nullable enable

namespace Topaz
{
    public partial class CreateRequestClient
    {


        private static readonly global::Topaz.EndPointSecurityRequirement s_CreateVideoRequestSecurityRequirement0 =
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
        private static readonly global::Topaz.EndPointSecurityRequirement[] s_CreateVideoRequestSecurityRequirements =
            new global::Topaz.EndPointSecurityRequirement[]
            {                s_CreateVideoRequestSecurityRequirement0,
            };
        partial void PrepareCreateVideoRequestArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Topaz.CreateVideoRequestRequest request);
        partial void PrepareCreateVideoRequestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Topaz.CreateVideoRequestRequest request);
        partial void ProcessCreateVideoRequestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVideoRequestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Video Request<br/>
        /// Create a new video enhancement request.<br/>
        /// Send information about the video and desired enhancements then receive cost and time estimates.<br/>
        /// Calling this endpoint does NOT consume credits.<br/>
        /// Calling this endpoint does NOT start processing.<br/>
        /// Estimations are based on values provided, and the calculation is rerun once the system receives the source video. If the second estimate is significantly different than the initial values, the request is failed and the credits are fully refunded.<br/>
        /// The lower bound value of the cost estimate is billed.<br/>
        /// Time estimates are in development and may not be accurate.<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type** | **Description**                     |<br/>
        /// |---------------|----------|-------------------------------------|<br/>
        /// | **requestId** | UUID     | Unique request identifier           |<br/>
        /// | **estimates** | Object   | Refer to **RequestEstimates** below |<br/>
        /// #### RequestEstimates<br/>
        /// `cost` and `time` are arrays with two integers each, representing lower and upper bounds of the estimate.<br/>
        /// | **Property** | **Type** | **Description**         |<br/>
        /// |--------------|----------|-------------------------|<br/>
        /// | **cost**     | Array    | Cost range (in credits) |<br/>
        /// | **time**     | Array    | Time range (in seconds) |
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Topaz.CreateResponse> CreateVideoRequestAsync(

            global::Topaz.CreateVideoRequestRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVideoRequestArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Topaz.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateVideoRequestSecurityRequirements,
                operationName: "CreateVideoRequestAsync");

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
                                path: "/video/",
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Topaz.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateVideoRequestRequest(
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
                                operationId: "CreateVideoRequest",
                                methodName: "CreateVideoRequestAsync",
                                pathTemplate: "\"/video/\"",
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
                                operationId: "CreateVideoRequest",
                                methodName: "CreateVideoRequestAsync",
                                pathTemplate: "\"/video/\"",
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
                                operationId: "CreateVideoRequest",
                                methodName: "CreateVideoRequestAsync",
                                pathTemplate: "\"/video/\"",
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
                ProcessCreateVideoRequestResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Topaz.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Topaz.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVideoRequest",
                                methodName: "CreateVideoRequestAsync",
                                pathTemplate: "\"/video/\"",
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
                                operationId: "CreateVideoRequest",
                                methodName: "CreateVideoRequestAsync",
                                pathTemplate: "\"/video/\"",
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
                            // Bad request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Topaz.CreateVideoRequestResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Topaz.CreateVideoRequestResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Topaz.CreateVideoRequestResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.CreateVideoRequestResponse>(
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
                            // Unauthorized
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Topaz.CreateVideoRequestResponse2? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Topaz.CreateVideoRequestResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Topaz.CreateVideoRequestResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.CreateVideoRequestResponse2>(
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
                            // Internal server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Topaz.CreateVideoRequestResponse3? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Topaz.CreateVideoRequestResponse3.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Topaz.CreateVideoRequestResponse3.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.CreateVideoRequestResponse3>(
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
                            // Service unavailable
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::Topaz.CreateVideoRequestResponse4? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::Topaz.CreateVideoRequestResponse4.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::Topaz.CreateVideoRequestResponse4.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }

                                throw new global::Topaz.ApiException<global::Topaz.CreateVideoRequestResponse4>(
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_503,
                                    ResponseObject = __value_503,
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
                                ProcessCreateVideoRequestResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Topaz.CreateResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        await global::Topaz.CreateResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Create Video Request<br/>
        /// Create a new video enhancement request.<br/>
        /// Send information about the video and desired enhancements then receive cost and time estimates.<br/>
        /// Calling this endpoint does NOT consume credits.<br/>
        /// Calling this endpoint does NOT start processing.<br/>
        /// Estimations are based on values provided, and the calculation is rerun once the system receives the source video. If the second estimate is significantly different than the initial values, the request is failed and the credits are fully refunded.<br/>
        /// The lower bound value of the cost estimate is billed.<br/>
        /// Time estimates are in development and may not be accurate.<br/>
        /// ## Response body<br/>
        /// | **Property**  | **Type** | **Description**                     |<br/>
        /// |---------------|----------|-------------------------------------|<br/>
        /// | **requestId** | UUID     | Unique request identifier           |<br/>
        /// | **estimates** | Object   | Refer to **RequestEstimates** below |<br/>
        /// #### RequestEstimates<br/>
        /// `cost` and `time` are arrays with two integers each, representing lower and upper bounds of the estimate.<br/>
        /// | **Property** | **Type** | **Description**         |<br/>
        /// |--------------|----------|-------------------------|<br/>
        /// | **cost**     | Array    | Cost range (in credits) |<br/>
        /// | **time**     | Array    | Time range (in seconds) |
        /// </summary>
        /// <param name="source">
        /// Source details for the video
        /// </param>
        /// <param name="filters">
        /// Array of UpscaleFilter or FrameInterpolationFilter objects<br/>
        /// Example: [{"model":"prob-4","videoType":"Progressive","auto":"Auto","fieldOrder":"Auto","focusFixLevel":"Normal","compression":0.1,"details":0.2,"prenoise":0.01,"noise":0.3,"halo":0.4,"preblur":0.5,"blur":0.6,"grain":0.02,"grainSize":1,"recoverOriginalDetailValue":0.7}, {"model":"apo-8","slowmo":2,"fps":60,"duplicate":true,"duplicateThreshold":0.01}]
        /// </param>
        /// <param name="output"></param>
        /// <param name="destination"></param>
        /// <param name="notifications"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Topaz.CreateResponse> CreateVideoRequestAsync(
            global::Topaz.CreateVideoRequestRequestSource source,
            global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>> filters,
            global::Topaz.OutputInformationVideo output,
            global::Topaz.CreateVideoRequestRequestDestination? destination = default,
            global::Topaz.CreateVideoRequestRequestNotifications? notifications = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Topaz.CreateVideoRequestRequest
            {
                Source = source,
                Filters = filters,
                Output = output,
                Destination = destination,
                Notifications = notifications,
            };

            return await CreateVideoRequestAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}