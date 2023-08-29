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
using Azure.ResourceManager.Maintenance.Models;

namespace Azure.ResourceManager.Maintenance
{
    internal partial class ConfigurationAssignmentsForSubscriptionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConfigurationAssignmentsForSubscriptionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConfigurationAssignmentsForSubscriptionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string configurationAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Maintenance/configurationAssignments/", false);
            uri.AppendPath(configurationAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get configuration assignment for resource.. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MaintenanceConfigurationAssignmentData>> GetAsync(string subscriptionId, string configurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));

            using var message = CreateGetRequest(subscriptionId, configurationAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get configuration assignment for resource.. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MaintenanceConfigurationAssignmentData> Get(string subscriptionId, string configurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));

            using var message = CreateGetRequest(subscriptionId, configurationAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string configurationAssignmentName, MaintenanceConfigurationAssignmentData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Maintenance/configurationAssignments/", false);
            uri.AppendPath(configurationAssignmentName, true);
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

        /// <summary> Register configuration for resource. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Configuration assignment name. </param>
        /// <param name="data"> The configurationAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="configurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MaintenanceConfigurationAssignmentData>> CreateOrUpdateAsync(string subscriptionId, string configurationAssignmentName, MaintenanceConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, configurationAssignmentName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Register configuration for resource. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Configuration assignment name. </param>
        /// <param name="data"> The configurationAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="configurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MaintenanceConfigurationAssignmentData> CreateOrUpdate(string subscriptionId, string configurationAssignmentName, MaintenanceConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, configurationAssignmentName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string configurationAssignmentName, MaintenanceConfigurationAssignmentData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Maintenance/configurationAssignments/", false);
            uri.AppendPath(configurationAssignmentName, true);
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

        /// <summary> Register configuration for resource. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Configuration assignment name. </param>
        /// <param name="data"> The configurationAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="configurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MaintenanceConfigurationAssignmentData>> UpdateAsync(string subscriptionId, string configurationAssignmentName, MaintenanceConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, configurationAssignmentName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Register configuration for resource. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Configuration assignment name. </param>
        /// <param name="data"> The configurationAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="configurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MaintenanceConfigurationAssignmentData> Update(string subscriptionId, string configurationAssignmentName, MaintenanceConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, configurationAssignmentName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string configurationAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Maintenance/configurationAssignments/", false);
            uri.AppendPath(configurationAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Unregister configuration for resource. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Unique configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MaintenanceConfigurationAssignmentData>> DeleteAsync(string subscriptionId, string configurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));

            using var message = CreateDeleteRequest(subscriptionId, configurationAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((MaintenanceConfigurationAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Unregister configuration for resource. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="configurationAssignmentName"> Unique configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="configurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MaintenanceConfigurationAssignmentData> Delete(string subscriptionId, string configurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(configurationAssignmentName, nameof(configurationAssignmentName));

            using var message = CreateDeleteRequest(subscriptionId, configurationAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MaintenanceConfigurationAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MaintenanceConfigurationAssignmentData.DeserializeMaintenanceConfigurationAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((MaintenanceConfigurationAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
