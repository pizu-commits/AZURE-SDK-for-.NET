// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Search.Models;

namespace Azure.Search
{
    internal partial class AllOperations
    {
        private string endpoint;
        private string ApiVersion;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of AllOperations. </summary>
        public AllOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string ApiVersion = "2019-05-06")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (ApiVersion == null)
            {
                throw new ArgumentNullException(nameof(ApiVersion));
            }

            this.endpoint = endpoint;
            this.ApiVersion = ApiVersion;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreateGetServiceStatisticsRequest(Guid? clientRequestId)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/servicestats", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            return message;
        }
        /// <summary> Gets service level statistics for a search service. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SearchServiceStatistics>> GetServiceStatisticsAsync(Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.GetServiceStatistics");
            scope.Start();
            try
            {
                using var message = CreateGetServiceStatisticsRequest(clientRequestId);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SearchServiceStatistics.DeserializeSearchServiceStatistics(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Gets service level statistics for a search service. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SearchServiceStatistics> GetServiceStatistics(Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.GetServiceStatistics");
            scope.Start();
            try
            {
                using var message = CreateGetServiceStatisticsRequest(clientRequestId);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SearchServiceStatistics.DeserializeSearchServiceStatistics(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
