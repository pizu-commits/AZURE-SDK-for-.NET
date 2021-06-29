// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The ImageProcessing service client. </summary>
    public partial class ImageProcessingClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of ImageProcessingClient for mocking. </summary>
        protected ImageProcessingClient()
        {
        }

        /// <summary> Initializes a new instance of ImageProcessingClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ImageProcessingClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new FarmBeatsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Create a ImageProcessing Rasterize job. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>farmerId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Farmer ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>shapefileAttachmentId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Shapefile attachment ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>shapefileColumnNames</term>
        ///     <term>string[]</term>
        ///     <term>Yes</term>
        ///     <term> List of shapefile column names to create raster attachments. </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique job id. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// Status of the job.
        /// 
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>durationInSeconds</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> Duration of the job in seconds. </term>
        ///   </item>
        ///   <item>
        ///     <term>message</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status message to capture more details of the job. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>lastActionDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>startTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>endTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateRasterizeJobAsync(string jobId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateRasterizeJobRequest(jobId, content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ImageProcessingClient.CreateRasterizeJob");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a ImageProcessing Rasterize job. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>farmerId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Farmer ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>shapefileAttachmentId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Shapefile attachment ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>shapefileColumnNames</term>
        ///     <term>string[]</term>
        ///     <term>Yes</term>
        ///     <term> List of shapefile column names to create raster attachments. </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique job id. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// Status of the job.
        /// 
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>durationInSeconds</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> Duration of the job in seconds. </term>
        ///   </item>
        ///   <item>
        ///     <term>message</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status message to capture more details of the job. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>lastActionDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>startTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>endTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateRasterizeJob(string jobId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateRasterizeJobRequest(jobId, content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ImageProcessingClient.CreateRasterizeJob");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="CreateRasterizeJob"/> and <see cref="CreateRasterizeJobAsync"/> operations. </summary>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateCreateRasterizeJobRequest(string jobId, RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/image-processing/rasterize/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get ImageProcessing Rasterize job&apos;s details. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetRasterizeJobAsync(string jobId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateGetRasterizeJobRequest(jobId, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ImageProcessingClient.GetRasterizeJob");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get ImageProcessing Rasterize job&apos;s details. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetRasterizeJob(string jobId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateGetRasterizeJobRequest(jobId, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ImageProcessingClient.GetRasterizeJob");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetRasterizeJob"/> and <see cref="GetRasterizeJobAsync"/> operations. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetRasterizeJobRequest(string jobId, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/image-processing/rasterize/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
