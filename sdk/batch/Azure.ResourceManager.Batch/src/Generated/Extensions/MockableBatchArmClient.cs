// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Batch.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableBatchArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableBatchArmClient"/> class for mocking. </summary>
        protected MockableBatchArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableBatchArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableBatchArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableBatchArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountResource"/> object. </returns>
        public virtual BatchAccountResource GetBatchAccountResource(ResourceIdentifier id)
        {
            BatchAccountResource.ValidateResourceId(id);
            return new BatchAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountDetectorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountDetectorResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountDetectorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountDetectorResource"/> object. </returns>
        public virtual BatchAccountDetectorResource GetBatchAccountDetectorResource(ResourceIdentifier id)
        {
            BatchAccountDetectorResource.ValidateResourceId(id);
            return new BatchAccountDetectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchApplicationPackageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchApplicationPackageResource.CreateResourceIdentifier" /> to create a <see cref="BatchApplicationPackageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchApplicationPackageResource"/> object. </returns>
        public virtual BatchApplicationPackageResource GetBatchApplicationPackageResource(ResourceIdentifier id)
        {
            BatchApplicationPackageResource.ValidateResourceId(id);
            return new BatchApplicationPackageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchApplicationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchApplicationResource.CreateResourceIdentifier" /> to create a <see cref="BatchApplicationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchApplicationResource"/> object. </returns>
        public virtual BatchApplicationResource GetBatchApplicationResource(ResourceIdentifier id)
        {
            BatchApplicationResource.ValidateResourceId(id);
            return new BatchApplicationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountCertificateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountCertificateResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountCertificateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountCertificateResource"/> object. </returns>
        public virtual BatchAccountCertificateResource GetBatchAccountCertificateResource(ResourceIdentifier id)
        {
            BatchAccountCertificateResource.ValidateResourceId(id);
            return new BatchAccountCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchPrivateLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="BatchPrivateLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchPrivateLinkResource"/> object. </returns>
        public virtual BatchPrivateLinkResource GetBatchPrivateLinkResource(ResourceIdentifier id)
        {
            BatchPrivateLinkResource.ValidateResourceId(id);
            return new BatchPrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchPrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="BatchPrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchPrivateEndpointConnectionResource"/> object. </returns>
        public virtual BatchPrivateEndpointConnectionResource GetBatchPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            BatchPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new BatchPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountPoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountPoolResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountPoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountPoolResource"/> object. </returns>
        public virtual BatchAccountPoolResource GetBatchAccountPoolResource(ResourceIdentifier id)
        {
            BatchAccountPoolResource.ValidateResourceId(id);
            return new BatchAccountPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkSecurityPerimeterConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="NetworkSecurityPerimeterConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkSecurityPerimeterConfigurationResource"/> object. </returns>
        public virtual NetworkSecurityPerimeterConfigurationResource GetNetworkSecurityPerimeterConfigurationResource(ResourceIdentifier id)
        {
            NetworkSecurityPerimeterConfigurationResource.ValidateResourceId(id);
            return new NetworkSecurityPerimeterConfigurationResource(Client, id);
        }
    }
}
