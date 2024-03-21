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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class IntegrationAccountBatchConfigurationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IntegrationAccountBatchConfigurationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IntegrationAccountBatchConfigurationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string integrationAccountName)
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
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/batchConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List the batch configurations for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BatchConfigurationCollection>> ListAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, integrationAccountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BatchConfigurationCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BatchConfigurationCollection.DeserializeBatchConfigurationCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List the batch configurations for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BatchConfigurationCollection> List(string subscriptionId, string resourceGroupName, string integrationAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, integrationAccountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BatchConfigurationCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BatchConfigurationCollection.DeserializeBatchConfigurationCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName)
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
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/batchConfigurations/", false);
            uri.AppendPath(batchConfigurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a batch configuration for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountBatchConfigurationData>> GetAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, integrationAccountName, batchConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountBatchConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountBatchConfigurationData.DeserializeIntegrationAccountBatchConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationAccountBatchConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a batch configuration for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountBatchConfigurationData> Get(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, integrationAccountName, batchConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountBatchConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountBatchConfigurationData.DeserializeIntegrationAccountBatchConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationAccountBatchConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName, IntegrationAccountBatchConfigurationData data)
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
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/batchConfigurations/", false);
            uri.AppendPath(batchConfigurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a batch configuration for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="data"> The batch configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="batchConfigurationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountBatchConfigurationData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName, IntegrationAccountBatchConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, integrationAccountName, batchConfigurationName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        IntegrationAccountBatchConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountBatchConfigurationData.DeserializeIntegrationAccountBatchConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a batch configuration for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="data"> The batch configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="batchConfigurationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountBatchConfigurationData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName, IntegrationAccountBatchConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, integrationAccountName, batchConfigurationName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        IntegrationAccountBatchConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountBatchConfigurationData.DeserializeIntegrationAccountBatchConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName)
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
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/batchConfigurations/", false);
            uri.AppendPath(batchConfigurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a batch configuration for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, integrationAccountName, batchConfigurationName);
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

        /// <summary> Delete a batch configuration for an integration account. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string integrationAccountName, string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, integrationAccountName, batchConfigurationName);
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
    }
}
