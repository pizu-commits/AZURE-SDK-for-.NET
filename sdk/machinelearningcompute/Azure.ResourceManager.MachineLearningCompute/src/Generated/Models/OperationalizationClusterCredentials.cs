// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Credentials to resources in the cluster. </summary>
    public partial class OperationalizationClusterCredentials
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OperationalizationClusterCredentials"/>. </summary>
        internal OperationalizationClusterCredentials()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalizationClusterCredentials"/>. </summary>
        /// <param name="storageAccount"> Credentials for the Storage Account. </param>
        /// <param name="containerRegistry"> Credentials for Azure Container Registry. </param>
        /// <param name="containerService"> Credentials for Azure Container Service. </param>
        /// <param name="appInsights"> Credentials for Azure AppInsights. </param>
        /// <param name="serviceAuthConfiguration"> Global authorization keys for all user services deployed in cluster. These are used if the service does not have auth keys. </param>
        /// <param name="sslConfiguration"> The SSL configuration for the services. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalizationClusterCredentials(StorageAccountCredentials storageAccount, ContainerRegistryCredentials containerRegistry, ContainerServiceCredentials containerService, AppInsightsCredentials appInsights, ServiceAuthConfiguration serviceAuthConfiguration, SslConfiguration sslConfiguration, Dictionary<string, BinaryData> rawData)
        {
            StorageAccount = storageAccount;
            ContainerRegistry = containerRegistry;
            ContainerService = containerService;
            AppInsights = appInsights;
            ServiceAuthConfiguration = serviceAuthConfiguration;
            SslConfiguration = sslConfiguration;
            _rawData = rawData;
        }

        /// <summary> Credentials for the Storage Account. </summary>
        public StorageAccountCredentials StorageAccount { get; }
        /// <summary> Credentials for Azure Container Registry. </summary>
        public ContainerRegistryCredentials ContainerRegistry { get; }
        /// <summary> Credentials for Azure Container Service. </summary>
        public ContainerServiceCredentials ContainerService { get; }
        /// <summary> Credentials for Azure AppInsights. </summary>
        public AppInsightsCredentials AppInsights { get; }
        /// <summary> Global authorization keys for all user services deployed in cluster. These are used if the service does not have auth keys. </summary>
        public ServiceAuthConfiguration ServiceAuthConfiguration { get; }
        /// <summary> The SSL configuration for the services. </summary>
        public SslConfiguration SslConfiguration { get; }
    }
}
