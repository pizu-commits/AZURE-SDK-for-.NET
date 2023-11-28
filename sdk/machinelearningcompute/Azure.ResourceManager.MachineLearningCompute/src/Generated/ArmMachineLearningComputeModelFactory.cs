// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.MachineLearningCompute;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMachineLearningComputeModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningCompute.OperationalizationClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of the cluster. </param>
        /// <param name="createdOn"> The date and time when the cluster was created. </param>
        /// <param name="modifiedOn"> The date and time when the cluster was last modified. </param>
        /// <param name="provisioningState"> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </param>
        /// <param name="provisioningErrors"> List of provisioning errors reported by the resource provider. </param>
        /// <param name="clusterType"> The cluster type. </param>
        /// <param name="storageAccountResourceId"> Storage Account properties. </param>
        /// <param name="containerRegistryResourceId"> Container Registry properties. </param>
        /// <param name="containerService"> Parameters for the Azure Container Service cluster. </param>
        /// <param name="appInsightsResourceId"> AppInsights configuration. </param>
        /// <param name="globalServiceConfiguration"> Contains global configuration for the web services in the cluster. </param>
        /// <returns> A new <see cref="MachineLearningCompute.OperationalizationClusterData"/> instance for mocking. </returns>
        public static OperationalizationClusterData OperationalizationClusterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string description = null, DateTimeOffset? createdOn = null, DateTimeOffset? modifiedOn = null, OperationStatus? provisioningState = null, IEnumerable<ErrorResponseWrapper> provisioningErrors = null, ClusterType? clusterType = null, string storageAccountResourceId = null, string containerRegistryResourceId = null, AcsClusterProperties containerService = null, string appInsightsResourceId = null, GlobalServiceConfiguration globalServiceConfiguration = null)
        {
            tags ??= new Dictionary<string, string>();
            provisioningErrors ??= new List<ErrorResponseWrapper>();

            return new OperationalizationClusterData(id, name, resourceType, systemData, tags, location, description, createdOn, modifiedOn, provisioningState, provisioningErrors?.ToList(), clusterType, storageAccountResourceId != null ? new StorageAccountProperties(storageAccountResourceId) : null, containerRegistryResourceId != null ? new ContainerRegistryProperties(containerRegistryResourceId) : null, containerService, appInsightsResourceId != null ? new AppInsightsProperties(appInsightsResourceId) : null, globalServiceConfiguration);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ErrorResponseWrapper"/>. </summary>
        /// <param name="error"> The error response. </param>
        /// <returns> A new <see cref="Models.ErrorResponseWrapper"/> instance for mocking. </returns>
        public static ErrorResponseWrapper ErrorResponseWrapper(ErrorResponse error = null)
        {
            return new ErrorResponseWrapper(error);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ErrorResponse"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="details"> An array of error detail objects. </param>
        /// <returns> A new <see cref="Models.ErrorResponse"/> instance for mocking. </returns>
        public static ErrorResponse ErrorResponse(string code = null, string message = null, IEnumerable<ErrorDetail> details = null)
        {
            details ??= new List<ErrorDetail>();

            return new ErrorResponse(code, message, details?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.ErrorDetail"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        /// <returns> A new <see cref="Models.ErrorDetail"/> instance for mocking. </returns>
        public static ErrorDetail ErrorDetail(string code = null, string message = null)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            return new ErrorDetail(code, message);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AcsClusterProperties"/>. </summary>
        /// <param name="clusterFqdn"> The FQDN of the cluster. </param>
        /// <param name="orchestratorType"> Type of orchestrator. It cannot be changed once the cluster is created. </param>
        /// <param name="orchestratorServicePrincipal"> Orchestrator specific properties. </param>
        /// <param name="systemServices"> The system services deployed to the cluster. </param>
        /// <param name="masterCount"> The number of master nodes in the container service. </param>
        /// <param name="agentCount"> The number of agent nodes in the Container Service. This can be changed to scale the cluster. </param>
        /// <param name="agentVmSize"> The Azure VM size of the agent VM nodes. This cannot be changed once the cluster is created. This list is non exhaustive; refer to https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes for the possible VM sizes. </param>
        /// <returns> A new <see cref="Models.AcsClusterProperties"/> instance for mocking. </returns>
        public static AcsClusterProperties AcsClusterProperties(string clusterFqdn = null, OrchestratorType orchestratorType = default, ServicePrincipalProperties orchestratorServicePrincipal = null, IEnumerable<SystemService> systemServices = null, int? masterCount = null, int? agentCount = null, AgentVmSizeType? agentVmSize = null)
        {
            systemServices ??= new List<SystemService>();

            return new AcsClusterProperties(clusterFqdn, orchestratorType, orchestratorServicePrincipal != null ? new KubernetesClusterProperties(orchestratorServicePrincipal) : null, systemServices?.ToList(), masterCount, agentCount, agentVmSize);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SystemService"/>. </summary>
        /// <param name="systemServiceType"> The system service type. </param>
        /// <param name="publicIPAddress"> The public IP address of the system service. </param>
        /// <param name="version"> The state of the system service. </param>
        /// <returns> A new <see cref="Models.SystemService"/> instance for mocking. </returns>
        public static SystemService SystemService(SystemServiceType systemServiceType = default, string publicIPAddress = null, string version = null)
        {
            return new SystemService(systemServiceType, publicIPAddress, version);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OperationalizationClusterCredentials"/>. </summary>
        /// <param name="storageAccount"> Credentials for the Storage Account. </param>
        /// <param name="containerRegistry"> Credentials for Azure Container Registry. </param>
        /// <param name="containerService"> Credentials for Azure Container Service. </param>
        /// <param name="appInsights"> Credentials for Azure AppInsights. </param>
        /// <param name="serviceAuthConfiguration"> Global authorization keys for all user services deployed in cluster. These are used if the service does not have auth keys. </param>
        /// <param name="sslConfiguration"> The SSL configuration for the services. </param>
        /// <returns> A new <see cref="Models.OperationalizationClusterCredentials"/> instance for mocking. </returns>
        public static OperationalizationClusterCredentials OperationalizationClusterCredentials(StorageAccountCredentials storageAccount = null, ContainerRegistryCredentials containerRegistry = null, ContainerServiceCredentials containerService = null, AppInsightsCredentials appInsights = null, ServiceAuthConfiguration serviceAuthConfiguration = null, SslConfiguration sslConfiguration = null)
        {
            return new OperationalizationClusterCredentials(storageAccount, containerRegistry, containerService, appInsights, serviceAuthConfiguration, sslConfiguration);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StorageAccountCredentials"/>. </summary>
        /// <param name="resourceId"> The ARM resource ID of the storage account. </param>
        /// <param name="primaryKey"> The primary key of the storage account. </param>
        /// <param name="secondaryKey"> The secondary key of the storage account. </param>
        /// <returns> A new <see cref="Models.StorageAccountCredentials"/> instance for mocking. </returns>
        public static StorageAccountCredentials StorageAccountCredentials(string resourceId = null, string primaryKey = null, string secondaryKey = null)
        {
            return new StorageAccountCredentials(resourceId, primaryKey, secondaryKey);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerRegistryCredentials"/>. </summary>
        /// <param name="loginServer"> The ACR login server name. User name is the first part of the FQDN. </param>
        /// <param name="password"> The ACR primary password. </param>
        /// <param name="password2"> The ACR secondary password. </param>
        /// <param name="username"> The ACR login username. </param>
        /// <returns> A new <see cref="Models.ContainerRegistryCredentials"/> instance for mocking. </returns>
        public static ContainerRegistryCredentials ContainerRegistryCredentials(string loginServer = null, string password = null, string password2 = null, string username = null)
        {
            return new ContainerRegistryCredentials(loginServer, password, password2, username);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerServiceCredentials"/>. </summary>
        /// <param name="acsKubeConfig"> The ACS kube config file. </param>
        /// <param name="servicePrincipalConfiguration"> Service principal configuration used by Kubernetes. </param>
        /// <param name="imagePullSecretName"> The ACR image pull secret name which was created in Kubernetes. </param>
        /// <returns> A new <see cref="Models.ContainerServiceCredentials"/> instance for mocking. </returns>
        public static ContainerServiceCredentials ContainerServiceCredentials(string acsKubeConfig = null, ServicePrincipalProperties servicePrincipalConfiguration = null, string imagePullSecretName = null)
        {
            return new ContainerServiceCredentials(acsKubeConfig, servicePrincipalConfiguration, imagePullSecretName);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AppInsightsCredentials"/>. </summary>
        /// <param name="appId"> The AppInsights application ID. </param>
        /// <param name="instrumentationKey"> The AppInsights instrumentation key. This is not returned in response of GET/PUT on the resource. To see this please call listKeys API. </param>
        /// <returns> A new <see cref="Models.AppInsightsCredentials"/> instance for mocking. </returns>
        public static AppInsightsCredentials AppInsightsCredentials(string appId = null, string instrumentationKey = null)
        {
            return new AppInsightsCredentials(appId, instrumentationKey);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CheckSystemServicesUpdatesAvailableResponse"/>. </summary>
        /// <param name="updatesAvailable"> Yes if updates are available for the system services, No if not. </param>
        /// <returns> A new <see cref="Models.CheckSystemServicesUpdatesAvailableResponse"/> instance for mocking. </returns>
        public static CheckSystemServicesUpdatesAvailableResponse CheckSystemServicesUpdatesAvailableResponse(UpdatesAvailable? updatesAvailable = null)
        {
            return new CheckSystemServicesUpdatesAvailableResponse(updatesAvailable);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UpdateSystemServicesResponse"/>. </summary>
        /// <param name="updateStatus"> Update status. </param>
        /// <param name="updateStartedOn"> The date and time when the last system services update was started. </param>
        /// <param name="updateCompletedOn"> The date and time when the last system services update completed. </param>
        /// <returns> A new <see cref="Models.UpdateSystemServicesResponse"/> instance for mocking. </returns>
        public static UpdateSystemServicesResponse UpdateSystemServicesResponse(OperationStatus? updateStatus = null, DateTimeOffset? updateStartedOn = null, DateTimeOffset? updateCompletedOn = null)
        {
            return new UpdateSystemServicesResponse(updateStatus, updateStartedOn, updateCompletedOn);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResourceOperation"/>. </summary>
        /// <param name="name"> Name of this operation. </param>
        /// <param name="display"> Display of the operation. </param>
        /// <param name="origin"> The operation origin. </param>
        /// <returns> A new <see cref="Models.ResourceOperation"/> instance for mocking. </returns>
        public static ResourceOperation ResourceOperation(string name = null, ResourceOperationDisplay display = null, string origin = null)
        {
            return new ResourceOperation(name, display, origin);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResourceOperationDisplay"/>. </summary>
        /// <param name="provider"> The resource provider name. </param>
        /// <param name="resource"> The resource name. </param>
        /// <param name="operation"> The operation. </param>
        /// <param name="description"> The description of the operation. </param>
        /// <returns> A new <see cref="Models.ResourceOperationDisplay"/> instance for mocking. </returns>
        public static ResourceOperationDisplay ResourceOperationDisplay(string provider = null, string resource = null, string operation = null, string description = null)
        {
            return new ResourceOperationDisplay(provider, resource, operation, description);
        }
    }
}
