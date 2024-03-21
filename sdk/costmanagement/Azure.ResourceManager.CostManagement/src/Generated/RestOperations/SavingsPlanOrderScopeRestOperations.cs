// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CostManagement.Models;

namespace Azure.ResourceManager.CostManagement
{
    internal partial class SavingsPlanOrderScopeRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SavingsPlanOrderScopeRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SavingsPlanOrderScopeRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGenerateBenefitUtilizationSummariesReportRequest(string savingsPlanOrderId, BenefitUtilizationSummariesContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.BillingBenefits/savingsPlanOrders/", false);
            uri.AppendPath(savingsPlanOrderId, true);
            uri.AppendPath("/providers/Microsoft.CostManagement/generateBenefitUtilizationSummariesReport", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Triggers generation of a benefit utilization summaries report for the provided savings plan order. </summary>
        /// <param name="savingsPlanOrderId"> Savings plan order ID. </param>
        /// <param name="content"> Async Benefit Utilization Summary report to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> GenerateBenefitUtilizationSummariesReportAsync(string savingsPlanOrderId, BenefitUtilizationSummariesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGenerateBenefitUtilizationSummariesReportRequest(savingsPlanOrderId, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Triggers generation of a benefit utilization summaries report for the provided savings plan order. </summary>
        /// <param name="savingsPlanOrderId"> Savings plan order ID. </param>
        /// <param name="content"> Async Benefit Utilization Summary report to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response GenerateBenefitUtilizationSummariesReport(string savingsPlanOrderId, BenefitUtilizationSummariesContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGenerateBenefitUtilizationSummariesReportRequest(savingsPlanOrderId, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
