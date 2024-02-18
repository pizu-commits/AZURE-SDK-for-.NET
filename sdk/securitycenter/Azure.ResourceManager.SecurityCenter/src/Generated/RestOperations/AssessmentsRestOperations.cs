// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class AssessmentsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AssessmentsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AssessmentsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string scope)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get security assessments on all your scanned resources inside a scope. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<SecurityAssessmentList>> ListAsync(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentList.DeserializeSecurityAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get security assessments on all your scanned resources inside a scope. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<SecurityAssessmentList> List(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentList.DeserializeSecurityAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string resourceId, string assessmentName, SecurityAssessmentODataExpand? expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand.Value.ToString(), true);
            }
            return uri;
        }

        internal HttpMessage CreateGetRequest(string resourceId, string assessmentName, SecurityAssessmentODataExpand? expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand.Value.ToString(), true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a security assessment on your scanned resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAssessmentData>> GetAsync(string resourceId, string assessmentName, SecurityAssessmentODataExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateGetRequest(resourceId, assessmentName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentData.DeserializeSecurityAssessmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAssessmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a security assessment on your scanned resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAssessmentData> Get(string resourceId, string assessmentName, SecurityAssessmentODataExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateGetRequest(resourceId, assessmentName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentData.DeserializeSecurityAssessmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAssessmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string resourceId, string assessmentName, SecurityAssessmentCreateOrUpdateContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceId, string assessmentName, SecurityAssessmentCreateOrUpdateContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
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

        /// <summary> Create a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="content"> Calculated assessment on a pre-defined assessment metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/>, <paramref name="assessmentName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAssessmentData>> CreateOrUpdateAsync(string resourceId, string assessmentName, SecurityAssessmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateOrUpdateRequest(resourceId, assessmentName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityAssessmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentData.DeserializeSecurityAssessmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="content"> Calculated assessment on a pre-defined assessment metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/>, <paramref name="assessmentName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAssessmentData> CreateOrUpdate(string resourceId, string assessmentName, SecurityAssessmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateOrUpdateRequest(resourceId, assessmentName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityAssessmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentData.DeserializeSecurityAssessmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string resourceId, string assessmentName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string resourceId, string assessmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string resourceId, string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateDeleteRequest(resourceId, assessmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string resourceId, string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateDeleteRequest(resourceId, assessmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string scope)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string scope)
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

        /// <summary> Get security assessments on all your scanned resources inside a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<SecurityAssessmentList>> ListNextPageAsync(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentList.DeserializeSecurityAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get security assessments on all your scanned resources inside a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<SecurityAssessmentList> ListNextPage(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentList.DeserializeSecurityAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
