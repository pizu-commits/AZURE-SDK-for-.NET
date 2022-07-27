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
    internal partial class RoleEligibilityScheduleInstancesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RoleEligibilityScheduleInstancesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoleEligibilityScheduleInstancesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
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
            uri.AppendPath("/providers/Microsoft.Authorization/roleEligibilityScheduleInstances", false);
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

        /// <summary> Gets role eligibility schedule instances of a role eligibility schedule. </summary>
        /// <param name="scope"> The scope of the role eligibility schedule. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo(&apos;{userId}&apos;) to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleEligibilityScheduleInstanceListResult>> ListForScopeAsync(string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeRequest(scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleEligibilityScheduleInstanceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleEligibilityScheduleInstanceListResult.DeserializeRoleEligibilityScheduleInstanceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets role eligibility schedule instances of a role eligibility schedule. </summary>
        /// <param name="scope"> The scope of the role eligibility schedule. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo(&apos;{userId}&apos;) to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<RoleEligibilityScheduleInstanceListResult> ListForScope(string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeRequest(scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleEligibilityScheduleInstanceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleEligibilityScheduleInstanceListResult.DeserializeRoleEligibilityScheduleInstanceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string scope, string roleEligibilityScheduleInstanceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/", false);
            uri.AppendPath(roleEligibilityScheduleInstanceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the specified role eligibility schedule instance. </summary>
        /// <param name="scope"> The scope of the role eligibility schedules. </param>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RoleEligibilityScheduleInstanceData>> GetAsync(string scope, string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var message = CreateGetRequest(scope, roleEligibilityScheduleInstanceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleEligibilityScheduleInstanceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleEligibilityScheduleInstanceData.DeserializeRoleEligibilityScheduleInstanceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleEligibilityScheduleInstanceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the specified role eligibility schedule instance. </summary>
        /// <param name="scope"> The scope of the role eligibility schedules. </param>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RoleEligibilityScheduleInstanceData> Get(string scope, string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleInstanceName, nameof(roleEligibilityScheduleInstanceName));

            using var message = CreateGetRequest(scope, roleEligibilityScheduleInstanceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleEligibilityScheduleInstanceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleEligibilityScheduleInstanceData.DeserializeRoleEligibilityScheduleInstanceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleEligibilityScheduleInstanceData)null, message.Response);
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
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets role eligibility schedule instances of a role eligibility schedule. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role eligibility schedule. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo(&apos;{userId}&apos;) to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleEligibilityScheduleInstanceListResult>> ListForScopeNextPageAsync(string nextLink, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeNextPageRequest(nextLink, scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleEligibilityScheduleInstanceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleEligibilityScheduleInstanceListResult.DeserializeRoleEligibilityScheduleInstanceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets role eligibility schedule instances of a role eligibility schedule. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role eligibility schedule. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo(&apos;{userId}&apos;) to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleEligibilityScheduleInstanceListResult> ListForScopeNextPage(string nextLink, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeNextPageRequest(nextLink, scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleEligibilityScheduleInstanceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleEligibilityScheduleInstanceListResult.DeserializeRoleEligibilityScheduleInstanceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
