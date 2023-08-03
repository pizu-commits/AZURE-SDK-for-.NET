// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearningCompute;

namespace Azure.ResourceManager.MachineLearningCompute.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MachineLearningComputeArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MachineLearningComputeArmClientMockingExtension"/> class for mocking. </summary>
        protected MachineLearningComputeArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningComputeArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningComputeArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MachineLearningComputeArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalizationClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalizationClusterResource.CreateResourceIdentifier" /> to create an <see cref="OperationalizationClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalizationClusterResource" /> object. </returns>
        public virtual OperationalizationClusterResource GetOperationalizationClusterResource(ResourceIdentifier id)
        {
            OperationalizationClusterResource.ValidateResourceId(id);
            return new OperationalizationClusterResource(Client, id);
        }
    }
}
