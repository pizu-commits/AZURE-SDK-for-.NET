// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableServiceBusArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableServiceBusArmClient"/> class for mocking. </summary>
        protected MockableServiceBusArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceBusArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceBusArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableServiceBusArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusNamespaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusNamespaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusNamespaceResource"/> object. </returns>
        public virtual ServiceBusNamespaceResource GetServiceBusNamespaceResource(ResourceIdentifier id)
        {
            ServiceBusNamespaceResource.ValidateResourceId(id);
            return new ServiceBusNamespaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusNetworkRuleSetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusNetworkRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusNetworkRuleSetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusNetworkRuleSetResource"/> object. </returns>
        public virtual ServiceBusNetworkRuleSetResource GetServiceBusNetworkRuleSetResource(ResourceIdentifier id)
        {
            ServiceBusNetworkRuleSetResource.ValidateResourceId(id);
            return new ServiceBusNetworkRuleSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusPrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusPrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusPrivateEndpointConnectionResource"/> object. </returns>
        public virtual ServiceBusPrivateEndpointConnectionResource GetServiceBusPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            ServiceBusPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new ServiceBusPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusDisasterRecoveryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusDisasterRecoveryResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusDisasterRecoveryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusDisasterRecoveryResource"/> object. </returns>
        public virtual ServiceBusDisasterRecoveryResource GetServiceBusDisasterRecoveryResource(ResourceIdentifier id)
        {
            ServiceBusDisasterRecoveryResource.ValidateResourceId(id);
            return new ServiceBusDisasterRecoveryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MigrationConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MigrationConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MigrationConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MigrationConfigurationResource"/> object. </returns>
        public virtual MigrationConfigurationResource GetMigrationConfigurationResource(ResourceIdentifier id)
        {
            MigrationConfigurationResource.ValidateResourceId(id);
            return new MigrationConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusNamespaceAuthorizationRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusNamespaceAuthorizationRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusNamespaceAuthorizationRuleResource"/> object. </returns>
        public virtual ServiceBusNamespaceAuthorizationRuleResource GetServiceBusNamespaceAuthorizationRuleResource(ResourceIdentifier id)
        {
            ServiceBusNamespaceAuthorizationRuleResource.ValidateResourceId(id);
            return new ServiceBusNamespaceAuthorizationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusQueueAuthorizationRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusQueueAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusQueueAuthorizationRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusQueueAuthorizationRuleResource"/> object. </returns>
        public virtual ServiceBusQueueAuthorizationRuleResource GetServiceBusQueueAuthorizationRuleResource(ResourceIdentifier id)
        {
            ServiceBusQueueAuthorizationRuleResource.ValidateResourceId(id);
            return new ServiceBusQueueAuthorizationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusTopicAuthorizationRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusTopicAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusTopicAuthorizationRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusTopicAuthorizationRuleResource"/> object. </returns>
        public virtual ServiceBusTopicAuthorizationRuleResource GetServiceBusTopicAuthorizationRuleResource(ResourceIdentifier id)
        {
            ServiceBusTopicAuthorizationRuleResource.ValidateResourceId(id);
            return new ServiceBusTopicAuthorizationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource"/> object. </returns>
        public virtual ServiceBusDisasterRecoveryAuthorizationRuleResource GetServiceBusDisasterRecoveryAuthorizationRuleResource(ResourceIdentifier id)
        {
            ServiceBusDisasterRecoveryAuthorizationRuleResource.ValidateResourceId(id);
            return new ServiceBusDisasterRecoveryAuthorizationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusQueueResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusQueueResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusQueueResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusQueueResource"/> object. </returns>
        public virtual ServiceBusQueueResource GetServiceBusQueueResource(ResourceIdentifier id)
        {
            ServiceBusQueueResource.ValidateResourceId(id);
            return new ServiceBusQueueResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusTopicResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusTopicResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusTopicResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusTopicResource"/> object. </returns>
        public virtual ServiceBusTopicResource GetServiceBusTopicResource(ResourceIdentifier id)
        {
            ServiceBusTopicResource.ValidateResourceId(id);
            return new ServiceBusTopicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusRuleResource"/> object. </returns>
        public virtual ServiceBusRuleResource GetServiceBusRuleResource(ResourceIdentifier id)
        {
            ServiceBusRuleResource.ValidateResourceId(id);
            return new ServiceBusRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusSubscriptionResource"/> object. </returns>
        public virtual ServiceBusSubscriptionResource GetServiceBusSubscriptionResource(ResourceIdentifier id)
        {
            ServiceBusSubscriptionResource.ValidateResourceId(id);
            return new ServiceBusSubscriptionResource(Client, id);
        }
    }
}
