// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    internal partial class ScriptExecutionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ScriptExecutionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ScriptExecutionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string privateCloudName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/scriptExecutions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List script executions in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScriptExecutionsList>> ListAsync(string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptExecutionsList.DeserializeScriptExecutionsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List script executions in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScriptExecutionsList> List(string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptExecutionsList.DeserializeScriptExecutionsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/scriptExecutions/", false);
            uri.AppendPath(scriptExecutionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get an script execution by name in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScriptExecutionData>> GetAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptExecutionData.DeserializeScriptExecutionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScriptExecutionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get an script execution by name in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScriptExecutionData> Get(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptExecutionData.DeserializeScriptExecutionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScriptExecutionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, ScriptExecutionData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/scriptExecutions/", false);
            uri.AppendPath(scriptExecutionName, true);
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

        /// <summary> Create or update a script execution in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> The name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="data"> A script running in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="scriptExecutionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, ScriptExecutionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a script execution in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> The name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="data"> A script running in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="scriptExecutionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, ScriptExecutionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/scriptExecutions/", false);
            uri.AppendPath(scriptExecutionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Cancel a ScriptExecution in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancel a ScriptExecution in a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetExecutionLogsRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, IEnumerable<ScriptOutputStreamType> scriptOutputStreamType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/scriptExecutions/", false);
            uri.AppendPath(scriptExecutionName, true);
            uri.AppendPath("/getExecutionLogs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (scriptOutputStreamType != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Core.Utf8JsonRequestContent();
                content.JsonWriter.WriteStartArray();
                foreach (var item in scriptOutputStreamType)
                {
                    content.JsonWriter.WriteStringValue(item.ToString());
                }
                content.JsonWriter.WriteEndArray();
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Return the logs for a script execution resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="scriptOutputStreamType"> Name of the desired output stream to return. If not provided, will return all. An empty array will return nothing. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScriptExecutionData>> GetExecutionLogsAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, IEnumerable<ScriptOutputStreamType> scriptOutputStreamType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var message = CreateGetExecutionLogsRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName, scriptOutputStreamType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptExecutionData.DeserializeScriptExecutionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Return the logs for a script execution resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="scriptOutputStreamType"> Name of the desired output stream to return. If not provided, will return all. An empty array will return nothing. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScriptExecutionData> GetExecutionLogs(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName, IEnumerable<ScriptOutputStreamType> scriptOutputStreamType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var message = CreateGetExecutionLogsRequest(subscriptionId, resourceGroupName, privateCloudName, scriptExecutionName, scriptOutputStreamType);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptExecutionData.DeserializeScriptExecutionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName)
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

        /// <summary> List script executions in a private cloud. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScriptExecutionsList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptExecutionsList.DeserializeScriptExecutionsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List script executions in a private cloud. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScriptExecutionsList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptExecutionsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptExecutionsList.DeserializeScriptExecutionsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
