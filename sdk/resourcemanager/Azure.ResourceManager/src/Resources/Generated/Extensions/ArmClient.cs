// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager
{
    public partial class ArmClient
    {
        #region PolicyAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="PolicyAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PolicyAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="PolicyAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentResource" /> object. </returns>
        public virtual PolicyAssignmentResource GetPolicyAssignmentResource(ResourceIdentifier id)
        {
            PolicyAssignmentResource.ValidateResourceId(id);
            return new PolicyAssignmentResource(this, id);
        }
        #endregion

        #region ResourceProviderResource
        /// <summary>
        /// Gets an object representing a <see cref="ResourceProviderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceProviderResource.CreateResourceIdentifier" /> to create a <see cref="ResourceProviderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceProviderResource" /> object. </returns>
        public virtual ResourceProviderResource GetResourceProviderResource(ResourceIdentifier id)
        {
            ResourceProviderResource.ValidateResourceId(id);
            return new ResourceProviderResource(this, id);
        }
        #endregion

        #region ResourceGroupResource
        /// <summary>
        /// Gets an object representing a <see cref="ResourceGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceGroupResource.CreateResourceIdentifier" /> to create a <see cref="ResourceGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceGroupResource" /> object. </returns>
        public virtual ResourceGroupResource GetResourceGroupResource(ResourceIdentifier id)
        {
            ResourceGroupResource.ValidateResourceId(id);
            return new ResourceGroupResource(this, id);
        }
        #endregion

        #region TagResource
        /// <summary>
        /// Gets an object representing a <see cref="TagResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TagResource.CreateResourceIdentifier" /> to create a <see cref="TagResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TagResource" /> object. </returns>
        public virtual TagResource GetTagResource(ResourceIdentifier id)
        {
            TagResource.ValidateResourceId(id);
            return new TagResource(this, id);
        }
        #endregion

        #region SubscriptionPolicyDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionPolicyDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubscriptionPolicyDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="SubscriptionPolicyDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicyDefinitionResource" /> object. </returns>
        public virtual SubscriptionPolicyDefinitionResource GetSubscriptionPolicyDefinitionResource(ResourceIdentifier id)
        {
            SubscriptionPolicyDefinitionResource.ValidateResourceId(id);
            return new SubscriptionPolicyDefinitionResource(this, id);
        }
        #endregion

        #region TenantPolicyDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="TenantPolicyDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TenantPolicyDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="TenantPolicyDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantPolicyDefinitionResource" /> object. </returns>
        public virtual TenantPolicyDefinitionResource GetTenantPolicyDefinitionResource(ResourceIdentifier id)
        {
            TenantPolicyDefinitionResource.ValidateResourceId(id);
            return new TenantPolicyDefinitionResource(this, id);
        }
        #endregion

        #region ManagementGroupPolicyDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagementGroupPolicyDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementGroupPolicyDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="ManagementGroupPolicyDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroupPolicyDefinitionResource" /> object. </returns>
        public virtual ManagementGroupPolicyDefinitionResource GetManagementGroupPolicyDefinitionResource(ResourceIdentifier id)
        {
            ManagementGroupPolicyDefinitionResource.ValidateResourceId(id);
            return new ManagementGroupPolicyDefinitionResource(this, id);
        }
        #endregion

        #region SubscriptionPolicySetDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionPolicySetDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubscriptionPolicySetDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="SubscriptionPolicySetDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicySetDefinitionResource" /> object. </returns>
        public virtual SubscriptionPolicySetDefinitionResource GetSubscriptionPolicySetDefinitionResource(ResourceIdentifier id)
        {
            SubscriptionPolicySetDefinitionResource.ValidateResourceId(id);
            return new SubscriptionPolicySetDefinitionResource(this, id);
        }
        #endregion

        #region TenantPolicySetDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="TenantPolicySetDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TenantPolicySetDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="TenantPolicySetDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantPolicySetDefinitionResource" /> object. </returns>
        public virtual TenantPolicySetDefinitionResource GetTenantPolicySetDefinitionResource(ResourceIdentifier id)
        {
            TenantPolicySetDefinitionResource.ValidateResourceId(id);
            return new TenantPolicySetDefinitionResource(this, id);
        }
        #endregion

        #region ManagementGroupPolicySetDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagementGroupPolicySetDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementGroupPolicySetDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="ManagementGroupPolicySetDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroupPolicySetDefinitionResource" /> object. </returns>
        public virtual ManagementGroupPolicySetDefinitionResource GetManagementGroupPolicySetDefinitionResource(ResourceIdentifier id)
        {
            ManagementGroupPolicySetDefinitionResource.ValidateResourceId(id);
            return new ManagementGroupPolicySetDefinitionResource(this, id);
        }
        #endregion

        #region PolicyExemptionResource
        /// <summary>
        /// Gets an object representing a <see cref="PolicyExemptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PolicyExemptionResource.CreateResourceIdentifier" /> to create a <see cref="PolicyExemptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyExemptionResource" /> object. </returns>
        public virtual PolicyExemptionResource GetPolicyExemptionResource(ResourceIdentifier id)
        {
            PolicyExemptionResource.ValidateResourceId(id);
            return new PolicyExemptionResource(this, id);
        }
        #endregion

        #region DataPolicyManifestResource
        /// <summary>
        /// Gets an object representing a <see cref="DataPolicyManifestResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataPolicyManifestResource.CreateResourceIdentifier" /> to create a <see cref="DataPolicyManifestResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataPolicyManifestResource" /> object. </returns>
        public virtual DataPolicyManifestResource GetDataPolicyManifestResource(ResourceIdentifier id)
        {
            DataPolicyManifestResource.ValidateResourceId(id);
            return new DataPolicyManifestResource(this, id);
        }
        #endregion

        #region ManagementLockResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagementLockResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementLockResource.CreateResourceIdentifier" /> to create a <see cref="ManagementLockResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementLockResource" /> object. </returns>
        public virtual ManagementLockResource GetManagementLockResource(ResourceIdentifier id)
        {
            ManagementLockResource.ValidateResourceId(id);
            return new ManagementLockResource(this, id);
        }
        #endregion

        #region ResourceLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="ResourceLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceLinkResource.CreateResourceIdentifier" /> to create a <see cref="ResourceLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceLinkResource" /> object. </returns>
        public virtual ResourceLinkResource GetResourceLinkResource(ResourceIdentifier id)
        {
            ResourceLinkResource.ValidateResourceId(id);
            return new ResourceLinkResource(this, id);
        }
        #endregion

        #region SubscriptionResource
        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="SubscriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionResource" /> object. </returns>
        public virtual SubscriptionResource GetSubscriptionResource(ResourceIdentifier id)
        {
            SubscriptionResource.ValidateResourceId(id);
            return new SubscriptionResource(this, id);
        }
        #endregion

        #region TenantResource
        /// <summary>
        /// Gets an object representing a <see cref="TenantResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TenantResource.CreateResourceIdentifier" /> to create a <see cref="TenantResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantResource" /> object. </returns>
        public virtual TenantResource GetTenantResource(ResourceIdentifier id)
        {
            TenantResource.ValidateResourceId(id);
            return new TenantResource(this, id);
        }
        #endregion

        #region FeatureResource
        /// <summary>
        /// Gets an object representing a <see cref="FeatureResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FeatureResource.CreateResourceIdentifier" /> to create a <see cref="FeatureResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FeatureResource" /> object. </returns>
        public virtual FeatureResource GetFeatureResource(ResourceIdentifier id)
        {
            FeatureResource.ValidateResourceId(id);
            return new FeatureResource(this, id);
        }
        #endregion
    }
}
