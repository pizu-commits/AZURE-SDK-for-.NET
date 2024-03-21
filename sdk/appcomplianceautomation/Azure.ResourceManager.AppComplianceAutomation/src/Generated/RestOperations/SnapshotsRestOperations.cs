// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    internal partial class SnapshotsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SnapshotsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SnapshotsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-11-16-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string reportName, string skipToken, int? top, string select, string reportCreatorTenantId, string offerGuid)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/reports/", false);
            uri.AppendPath(reportName, true);
            uri.AppendPath("/snapshots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            if (reportCreatorTenantId != null)
            {
                uri.AppendQuery("reportCreatorTenantId", reportCreatorTenantId, true);
            }
            if (offerGuid != null)
            {
                uri.AppendQuery("offerGuid", offerGuid, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the AppComplianceAutomation snapshot list. </summary>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SnapshotResourceList>> ListAsync(string reportName, string skipToken = null, int? top = null, string select = null, string reportCreatorTenantId = null, string offerGuid = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var message = CreateListRequest(reportName, skipToken, top, select, reportCreatorTenantId, offerGuid);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SnapshotResourceList.DeserializeSnapshotResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the AppComplianceAutomation snapshot list. </summary>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SnapshotResourceList> List(string reportName, string skipToken = null, int? top = null, string select = null, string reportCreatorTenantId = null, string offerGuid = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var message = CreateListRequest(reportName, skipToken, top, select, reportCreatorTenantId, offerGuid);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SnapshotResourceList.DeserializeSnapshotResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string reportName, string skipToken, int? top, string select, string reportCreatorTenantId, string offerGuid)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the AppComplianceAutomation snapshot list. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="reportName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SnapshotResourceList>> ListNextPageAsync(string nextLink, string reportName, string skipToken = null, int? top = null, string select = null, string reportCreatorTenantId = null, string offerGuid = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var message = CreateListNextPageRequest(nextLink, reportName, skipToken, top, select, reportCreatorTenantId, offerGuid);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SnapshotResourceList.DeserializeSnapshotResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the AppComplianceAutomation snapshot list. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="reportName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SnapshotResourceList> ListNextPage(string nextLink, string reportName, string skipToken = null, int? top = null, string select = null, string reportCreatorTenantId = null, string offerGuid = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var message = CreateListNextPageRequest(nextLink, reportName, skipToken, top, select, reportCreatorTenantId, offerGuid);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SnapshotResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SnapshotResourceList.DeserializeSnapshotResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
