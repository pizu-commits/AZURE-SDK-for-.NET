// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal partial class PipelinesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PipelinesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PipelinesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2018-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByFactoryRequest(string subscriptionId, string resourceGroupName, string factoryName)
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
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/pipelines", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists pipelines. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataFactoryPipelineListResult>> ListByFactoryAsync(string subscriptionId, string resourceGroupName, string factoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var message = CreateListByFactoryRequest(subscriptionId, resourceGroupName, factoryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFactoryPipelineListResult.DeserializeDataFactoryPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists pipelines. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataFactoryPipelineListResult> ListByFactory(string subscriptionId, string resourceGroupName, string factoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var message = CreateListByFactoryRequest(subscriptionId, resourceGroupName, factoryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFactoryPipelineListResult.DeserializeDataFactoryPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, DataFactoryPipelineData data, string ifMatch)
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
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/pipelines/", false);
            uri.AppendPath(pipelineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="data"> Pipeline resource definition. </param>
        /// <param name="ifMatch"> ETag of the pipeline entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/>, <paramref name="pipelineName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataFactoryPipelineData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, DataFactoryPipelineData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, factoryName, pipelineName, data, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFactoryPipelineData.DeserializeDataFactoryPipelineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="data"> Pipeline resource definition. </param>
        /// <param name="ifMatch"> ETag of the pipeline entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/>, <paramref name="pipelineName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataFactoryPipelineData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, DataFactoryPipelineData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, factoryName, pipelineName, data, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFactoryPipelineData.DeserializeDataFactoryPipelineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, string ifNoneMatch)
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
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/pipelines/", false);
            uri.AppendPath(pipelineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="ifNoneMatch"> ETag of the pipeline entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataFactoryPipelineData>> GetAsync(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, factoryName, pipelineName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFactoryPipelineData.DeserializeDataFactoryPipelineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                case 404:
                    return Response.FromValue((DataFactoryPipelineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="ifNoneMatch"> ETag of the pipeline entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataFactoryPipelineData> Get(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, factoryName, pipelineName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFactoryPipelineData.DeserializeDataFactoryPipelineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                case 404:
                    return Response.FromValue((DataFactoryPipelineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName)
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
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/pipelines/", false);
            uri.AppendPath(pipelineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, factoryName, pipelineName);
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

        /// <summary> Deletes a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, factoryName, pipelineName);
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

        internal HttpMessage CreateCreateRunRequest(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, IDictionary<string, BinaryData> parameterValueSpecification, string referencePipelineRunId, bool? isRecovery, string startActivityName, bool? startFromFailure)
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
            uri.AppendPath("/providers/Microsoft.DataFactory/factories/", false);
            uri.AppendPath(factoryName, true);
            uri.AppendPath("/pipelines/", false);
            uri.AppendPath(pipelineName, true);
            uri.AppendPath("/createRun", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (referencePipelineRunId != null)
            {
                uri.AppendQuery("referencePipelineRunId", referencePipelineRunId, true);
            }
            if (isRecovery != null)
            {
                uri.AppendQuery("isRecovery", isRecovery.Value, true);
            }
            if (startActivityName != null)
            {
                uri.AppendQuery("startActivityName", startActivityName, true);
            }
            if (startFromFailure != null)
            {
                uri.AppendQuery("startFromFailure", startFromFailure.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (parameterValueSpecification != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartObject();
                foreach (var item in parameterValueSpecification)
                {
                    content.JsonWriter.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        content.JsonWriter.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				content.JsonWriter.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(content.JsonWriter, document.RootElement);
                    }
#endif
                }
                content.JsonWriter.WriteEndObject();
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a run of a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="parameterValueSpecification"> Parameters of the pipeline run. These parameters will be used only if the runId is not specified. </param>
        /// <param name="referencePipelineRunId"> The pipeline run identifier. If run ID is specified the parameters of the specified run will be used to create a new run. </param>
        /// <param name="isRecovery"> Recovery mode flag. If recovery mode is set to true, the specified referenced pipeline run and the new run will be grouped under the same groupId. </param>
        /// <param name="startActivityName"> In recovery mode, the rerun will start from this activity. If not specified, all activities will run. </param>
        /// <param name="startFromFailure"> In recovery mode, if set to true, the rerun will start from failed activities. The property will be used only if startActivityName is not specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PipelineCreateRunResult>> CreateRunAsync(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, IDictionary<string, BinaryData> parameterValueSpecification = null, string referencePipelineRunId = null, bool? isRecovery = null, string startActivityName = null, bool? startFromFailure = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));

            using var message = CreateCreateRunRequest(subscriptionId, resourceGroupName, factoryName, pipelineName, parameterValueSpecification, referencePipelineRunId, isRecovery, startActivityName, startFromFailure);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PipelineCreateRunResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PipelineCreateRunResult.DeserializePipelineCreateRunResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a run of a pipeline. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="parameterValueSpecification"> Parameters of the pipeline run. These parameters will be used only if the runId is not specified. </param>
        /// <param name="referencePipelineRunId"> The pipeline run identifier. If run ID is specified the parameters of the specified run will be used to create a new run. </param>
        /// <param name="isRecovery"> Recovery mode flag. If recovery mode is set to true, the specified referenced pipeline run and the new run will be grouped under the same groupId. </param>
        /// <param name="startActivityName"> In recovery mode, the rerun will start from this activity. If not specified, all activities will run. </param>
        /// <param name="startFromFailure"> In recovery mode, if set to true, the rerun will start from failed activities. The property will be used only if startActivityName is not specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="factoryName"/> or <paramref name="pipelineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PipelineCreateRunResult> CreateRun(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName, IDictionary<string, BinaryData> parameterValueSpecification = null, string referencePipelineRunId = null, bool? isRecovery = null, string startActivityName = null, bool? startFromFailure = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNullOrEmpty(pipelineName, nameof(pipelineName));

            using var message = CreateCreateRunRequest(subscriptionId, resourceGroupName, factoryName, pipelineName, parameterValueSpecification, referencePipelineRunId, isRecovery, startActivityName, startFromFailure);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PipelineCreateRunResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PipelineCreateRunResult.DeserializePipelineCreateRunResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByFactoryNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string factoryName)
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

        /// <summary> Lists pipelines. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataFactoryPipelineListResult>> ListByFactoryNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string factoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var message = CreateListByFactoryNextPageRequest(nextLink, subscriptionId, resourceGroupName, factoryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFactoryPipelineListResult.DeserializeDataFactoryPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists pipelines. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataFactoryPipelineListResult> ListByFactoryNextPage(string nextLink, string subscriptionId, string resourceGroupName, string factoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var message = CreateListByFactoryNextPageRequest(nextLink, subscriptionId, resourceGroupName, factoryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFactoryPipelineListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFactoryPipelineListResult.DeserializeDataFactoryPipelineListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
