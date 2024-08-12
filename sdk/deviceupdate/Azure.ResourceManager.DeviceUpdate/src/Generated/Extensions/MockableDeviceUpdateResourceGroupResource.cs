// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDeviceUpdateResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDeviceUpdateResourceGroupResource"/> class for mocking. </summary>
        protected MockableDeviceUpdateResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDeviceUpdateResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDeviceUpdateResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeviceUpdateAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DeviceUpdateAccountResources and their operations over a DeviceUpdateAccountResource. </returns>
        public virtual DeviceUpdateAccountCollection GetDeviceUpdateAccounts()
        {
            return GetCachedClient(client => new DeviceUpdateAccountCollection(client, Id));
        }

        /// <summary>
        /// Returns account details for the given account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdateAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DeviceUpdateAccountResource>> GetDeviceUpdateAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetDeviceUpdateAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns account details for the given account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdateAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DeviceUpdateAccountResource> GetDeviceUpdateAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetDeviceUpdateAccounts().Get(accountName, cancellationToken);
        }
    }
}
