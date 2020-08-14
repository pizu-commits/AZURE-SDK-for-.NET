// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppConfiguration;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> AppConfiguration service management client. </summary>
    public class AppConfigurationManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly string _subscriptionId;
        private readonly Uri _endpoint;

        /// <summary> Initializes a new instance of AppConfigurationManagementClient for mocking. </summary>
        protected AppConfigurationManagementClient()
        {
        }

        /// <summary> Initializes a new instance of AppConfigurationManagementClient. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public AppConfigurationManagementClient(string subscriptionId, TokenCredential tokenCredential, AppConfigurationManagementClientOptions options = null) : this(subscriptionId, null, tokenCredential, options)
        {
        }
        /// <summary> Initializes a new instance of AppConfigurationManagementClient. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public AppConfigurationManagementClient(string subscriptionId, Uri endpoint, TokenCredential tokenCredential, AppConfigurationManagementClientOptions options = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            options ??= new AppConfigurationManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, endpoint, options);
            _subscriptionId = subscriptionId;
            _endpoint = endpoint;
        }

        /// <summary> Returns an instance of ConfigurationStoresOperations. </summary>
        public virtual ConfigurationStoresOperations ConfigurationStores => new ConfigurationStoresOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of Operations. </summary>
        public virtual Operations Operations => new Operations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of PrivateEndpointConnectionsOperations. </summary>
        public virtual PrivateEndpointConnectionsOperations PrivateEndpointConnections => new PrivateEndpointConnectionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of PrivateLinkResourcesOperations. </summary>
        public virtual PrivateLinkResourcesOperations PrivateLinkResources => new PrivateLinkResourcesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
    }
}
