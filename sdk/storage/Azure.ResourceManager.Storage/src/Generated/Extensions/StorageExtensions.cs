// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Storage. </summary>
    public static partial class StorageExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeletedAccountResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedAccountResources and their operations over a DeletedAccountResource. </returns>
        public static DeletedAccountCollection GetDeletedAccounts(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedAccounts();
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeletedAccountResource>> GetDeletedAccountAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetDeletedAccounts().GetAsync(location, deletedAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DeletedAccountResource> GetDeletedAccount(this SubscriptionResource subscriptionResource, AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetDeletedAccounts().Get(location, deletedAccountName, cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageSkuInformation> GetSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageSkuInformation> GetSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkus(cancellationToken);
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// Operation Id: StorageAccounts_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<StorageAccountNameAvailabilityResult>> CheckStorageAccountNameAvailabilityAsync(this SubscriptionResource subscriptionResource, StorageAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckStorageAccountNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// Operation Id: StorageAccounts_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<StorageAccountNameAvailabilityResult> CheckStorageAccountNameAvailability(this SubscriptionResource subscriptionResource, StorageAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckStorageAccountNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageAccountResource> GetStorageAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetStorageAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageAccountResource> GetStorageAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetStorageAccounts(cancellationToken);
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts
        /// Operation Id: DeletedAccounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedAccountResource> GetDeletedAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts
        /// Operation Id: DeletedAccounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedAccountResource> GetDeletedAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedAccounts(cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageUsage> GetUsagesByLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetUsagesByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageUsage> GetUsagesByLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetUsagesByLocation(location, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of StorageAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageAccountResources and their operations over a StorageAccountResource. </returns>
        public static StorageAccountCollection GetStorageAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetStorageAccounts();
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageAccountResource>> GetStorageAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetStorageAccounts().GetAsync(accountName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageAccountResource> GetStorageAccount(this ResourceGroupResource resourceGroupResource, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetStorageAccounts().Get(accountName, expand, cancellationToken);
        }

        #region StorageAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountResource" /> object. </returns>
        public static StorageAccountResource GetStorageAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageAccountResource.ValidateResourceId(id);
                return new StorageAccountResource(client, id);
            }
            );
        }
        #endregion

        #region DeletedAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="DeletedAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedAccountResource.CreateResourceIdentifier" /> to create a <see cref="DeletedAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAccountResource" /> object. </returns>
        public static DeletedAccountResource GetDeletedAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeletedAccountResource.ValidateResourceId(id);
                return new DeletedAccountResource(client, id);
            }
            );
        }
        #endregion

        #region StorageAccountManagementPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountManagementPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountManagementPolicyResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountManagementPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountManagementPolicyResource" /> object. </returns>
        public static StorageAccountManagementPolicyResource GetStorageAccountManagementPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageAccountManagementPolicyResource.ValidateResourceId(id);
                return new StorageAccountManagementPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region BlobInventoryPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobInventoryPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobInventoryPolicyResource.CreateResourceIdentifier" /> to create a <see cref="BlobInventoryPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobInventoryPolicyResource" /> object. </returns>
        public static BlobInventoryPolicyResource GetBlobInventoryPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobInventoryPolicyResource.ValidateResourceId(id);
                return new BlobInventoryPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region StoragePrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="StoragePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StoragePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="StoragePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StoragePrivateEndpointConnectionResource" /> object. </returns>
        public static StoragePrivateEndpointConnectionResource GetStoragePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StoragePrivateEndpointConnectionResource.ValidateResourceId(id);
                return new StoragePrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region ObjectReplicationPolicyResource
        /// <summary>
        /// Gets an object representing an <see cref="ObjectReplicationPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ObjectReplicationPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ObjectReplicationPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ObjectReplicationPolicyResource" /> object. </returns>
        public static ObjectReplicationPolicyResource GetObjectReplicationPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ObjectReplicationPolicyResource.ValidateResourceId(id);
                return new ObjectReplicationPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region StorageAccountLocalUserResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountLocalUserResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountLocalUserResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountLocalUserResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountLocalUserResource" /> object. </returns>
        public static StorageAccountLocalUserResource GetStorageAccountLocalUserResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageAccountLocalUserResource.ValidateResourceId(id);
                return new StorageAccountLocalUserResource(client, id);
            }
            );
        }
        #endregion

        #region EncryptionScopeResource
        /// <summary>
        /// Gets an object representing an <see cref="EncryptionScopeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EncryptionScopeResource.CreateResourceIdentifier" /> to create an <see cref="EncryptionScopeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EncryptionScopeResource" /> object. </returns>
        public static EncryptionScopeResource GetEncryptionScopeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EncryptionScopeResource.ValidateResourceId(id);
                return new EncryptionScopeResource(client, id);
            }
            );
        }
        #endregion

        #region BlobServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobServiceResource.CreateResourceIdentifier" /> to create a <see cref="BlobServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobServiceResource" /> object. </returns>
        public static BlobServiceResource GetBlobServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobServiceResource.ValidateResourceId(id);
                return new BlobServiceResource(client, id);
            }
            );
        }
        #endregion

        #region BlobContainerResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobContainerResource.CreateResourceIdentifier" /> to create a <see cref="BlobContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobContainerResource" /> object. </returns>
        public static BlobContainerResource GetBlobContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobContainerResource.ValidateResourceId(id);
                return new BlobContainerResource(client, id);
            }
            );
        }
        #endregion

        #region ImmutabilityPolicyResource
        /// <summary>
        /// Gets an object representing an <see cref="ImmutabilityPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ImmutabilityPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ImmutabilityPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImmutabilityPolicyResource" /> object. </returns>
        public static ImmutabilityPolicyResource GetImmutabilityPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ImmutabilityPolicyResource.ValidateResourceId(id);
                return new ImmutabilityPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region FileServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="FileServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileServiceResource.CreateResourceIdentifier" /> to create a <see cref="FileServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileServiceResource" /> object. </returns>
        public static FileServiceResource GetFileServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FileServiceResource.ValidateResourceId(id);
                return new FileServiceResource(client, id);
            }
            );
        }
        #endregion

        #region FileShareResource
        /// <summary>
        /// Gets an object representing a <see cref="FileShareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileShareResource.CreateResourceIdentifier" /> to create a <see cref="FileShareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileShareResource" /> object. </returns>
        public static FileShareResource GetFileShareResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FileShareResource.ValidateResourceId(id);
                return new FileShareResource(client, id);
            }
            );
        }
        #endregion

        #region QueueServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="QueueServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QueueServiceResource.CreateResourceIdentifier" /> to create a <see cref="QueueServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QueueServiceResource" /> object. </returns>
        public static QueueServiceResource GetQueueServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                QueueServiceResource.ValidateResourceId(id);
                return new QueueServiceResource(client, id);
            }
            );
        }
        #endregion

        #region StorageQueueResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageQueueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageQueueResource.CreateResourceIdentifier" /> to create a <see cref="StorageQueueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageQueueResource" /> object. </returns>
        public static StorageQueueResource GetStorageQueueResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageQueueResource.ValidateResourceId(id);
                return new StorageQueueResource(client, id);
            }
            );
        }
        #endregion

        #region TableServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="TableServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TableServiceResource.CreateResourceIdentifier" /> to create a <see cref="TableServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableServiceResource" /> object. </returns>
        public static TableServiceResource GetTableServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TableServiceResource.ValidateResourceId(id);
                return new TableServiceResource(client, id);
            }
            );
        }
        #endregion

        #region TableResource
        /// <summary>
        /// Gets an object representing a <see cref="TableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TableResource.CreateResourceIdentifier" /> to create a <see cref="TableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableResource" /> object. </returns>
        public static TableResource GetTableResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TableResource.ValidateResourceId(id);
                return new TableResource(client, id);
            }
            );
        }
        #endregion
    }
}
