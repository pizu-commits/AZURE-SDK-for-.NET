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
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    internal partial class RoleAssignmentScheduleRequestsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RoleAssignmentScheduleRequestsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoleAssignmentScheduleRequestsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/", false);
            uri.AppendPath(roleAssignmentScheduleRequestName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment schedule request to create. The scope can be any REST resource instance. For example, use '/subscriptions/{subscription-id}/' for a subscription, '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for a resource group, and '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}' for a resource. </param>
        /// <param name="roleAssignmentScheduleRequestName"> A GUID for the role assignment to create. The name must be unique and different for each role assignment. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RoleAssignmentScheduleRequestData>> CreateAsync(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(scope, roleAssignmentScheduleRequestName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoleAssignmentScheduleRequestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment schedule request to create. The scope can be any REST resource instance. For example, use '/subscriptions/{subscription-id}/' for a subscription, '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for a resource group, and '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}' for a resource. </param>
        /// <param name="roleAssignmentScheduleRequestName"> A GUID for the role assignment to create. The name must be unique and different for each role assignment. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RoleAssignmentScheduleRequestData> Create(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(scope, roleAssignmentScheduleRequestName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoleAssignmentScheduleRequestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string scope, string roleAssignmentScheduleRequestName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/", false);
            uri.AppendPath(roleAssignmentScheduleRequestName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the specified role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment schedule request. </param>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RoleAssignmentScheduleRequestData>> GetAsync(string scope, string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var message = CreateGetRequest(scope, roleAssignmentScheduleRequestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleAssignmentScheduleRequestData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the specified role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment schedule request. </param>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RoleAssignmentScheduleRequestData> Get(string scope, string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var message = CreateGetRequest(scope, roleAssignmentScheduleRequestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleAssignmentScheduleRequestData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeRequest(string scope, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignmentScheduleRequests", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets role assignment schedule requests for a scope. </summary>
        /// <param name="scope"> The scope of the role assignments schedule requests. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleAssignmentScheduleRequestListResult>> ListForScopeAsync(string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeRequest(scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleAssignmentScheduleRequestListResult.DeserializeRoleAssignmentScheduleRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets role assignment schedule requests for a scope. </summary>
        /// <param name="scope"> The scope of the role assignments schedule requests. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<RoleAssignmentScheduleRequestListResult> ListForScope(string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeRequest(scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleAssignmentScheduleRequestListResult.DeserializeRoleAssignmentScheduleRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelRequest(string scope, string roleAssignmentScheduleRequestName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/", false);
            uri.AppendPath(roleAssignmentScheduleRequestName, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Cancels a pending role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment request to cancel. </param>
        /// <param name="roleAssignmentScheduleRequestName"> The name of the role assignment request to cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CancelAsync(string scope, string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var message = CreateCancelRequest(scope, roleAssignmentScheduleRequestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancels a pending role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment request to cancel. </param>
        /// <param name="roleAssignmentScheduleRequestName"> The name of the role assignment request to cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Cancel(string scope, string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var message = CreateCancelRequest(scope, roleAssignmentScheduleRequestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateValidateRequest(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/", false);
            uri.AppendPath(roleAssignmentScheduleRequestName, true);
            uri.AppendPath("/validate", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Validates a new role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment request to validate. </param>
        /// <param name="roleAssignmentScheduleRequestName"> The name of the role assignment request to validate. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RoleAssignmentScheduleRequestData>> ValidateAsync(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateValidateRequest(scope, roleAssignmentScheduleRequestName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Validates a new role assignment schedule request. </summary>
        /// <param name="scope"> The scope of the role assignment request to validate. </param>
        /// <param name="roleAssignmentScheduleRequestName"> The name of the role assignment request to validate. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RoleAssignmentScheduleRequestData> Validate(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateValidateRequest(scope, roleAssignmentScheduleRequestName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeNextPageRequest(string nextLink, string scope, string filter)
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

        /// <summary> Gets role assignment schedule requests for a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role assignments schedule requests. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleAssignmentScheduleRequestListResult>> ListForScopeNextPageAsync(string nextLink, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeNextPageRequest(nextLink, scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleAssignmentScheduleRequestListResult.DeserializeRoleAssignmentScheduleRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets role assignment schedule requests for a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role assignments schedule requests. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleAssignmentScheduleRequestListResult> ListForScopeNextPage(string nextLink, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeNextPageRequest(nextLink, scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentScheduleRequestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleAssignmentScheduleRequestListResult.DeserializeRoleAssignmentScheduleRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
