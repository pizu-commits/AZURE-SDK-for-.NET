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
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StoragePool. </summary>
    public static partial class StoragePoolExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools
        /// Operation Id: DiskPools_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPool" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DiskPool> GetDiskPoolsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDiskPoolsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools
        /// Operation Id: DiskPools_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPool" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DiskPool> GetDiskPools(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDiskPools(cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones
        /// Operation Id: DiskPoolZones_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="DiskPoolZoneInfo" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DiskPoolZoneInfo> GetDiskPoolZonesAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetDiskPoolZonesAsync(location, cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones
        /// Operation Id: DiskPoolZones_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="DiskPoolZoneInfo" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DiskPoolZoneInfo> GetDiskPoolZones(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetDiskPoolZones(location, cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus
        /// Operation Id: ResourceSkus_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceSkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceSkuInfo> GetResourceSkusAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetResourceSkusAsync(location, cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus
        /// Operation Id: ResourceSkus_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceSkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceSkuInfo> GetResourceSkus(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetResourceSkus(location, cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of DiskPools in the DiskPool. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DiskPools and their operations over a DiskPool. </returns>
        public static DiskPoolCollection GetDiskPools(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDiskPools();
        }

        /// <summary>
        /// Get a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public static async Task<Response<DiskPool>> GetDiskPoolAsync(this ResourceGroup resourceGroup, string diskPoolName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetDiskPools().GetAsync(diskPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public static Response<DiskPool> GetDiskPool(this ResourceGroup resourceGroup, string diskPoolName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetDiskPools().Get(diskPoolName, cancellationToken);
        }

        #region DiskPool
        /// <summary> Gets an object representing a DiskPool along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskPool" /> object. </returns>
        public static DiskPool GetDiskPool(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DiskPool.ValidateResourceId(id);
                return new DiskPool(client, id);
            }
            );
        }
        #endregion

        #region IscsiTarget
        /// <summary> Gets an object representing a IscsiTarget along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IscsiTarget" /> object. </returns>
        public static IscsiTarget GetIscsiTarget(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                IscsiTarget.ValidateResourceId(id);
                return new IscsiTarget(client, id);
            }
            );
        }
        #endregion
    }
}
