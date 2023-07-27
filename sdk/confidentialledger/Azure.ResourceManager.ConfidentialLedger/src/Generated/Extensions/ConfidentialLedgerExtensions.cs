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
using Azure.ResourceManager.ConfidentialLedger.Mocking;
using Azure.ResourceManager.ConfidentialLedger.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConfidentialLedger
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ConfidentialLedger. </summary>
    public static partial class ConfidentialLedgerExtensions
    {
        private static ConfidentialLedgerArmClientMockingExtension GetConfidentialLedgerArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new ConfidentialLedgerArmClientMockingExtension(client);
            });
        }

        private static ConfidentialLedgerResourceGroupMockingExtension GetConfidentialLedgerResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ConfidentialLedgerResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static ConfidentialLedgerSubscriptionMockingExtension GetConfidentialLedgerSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ConfidentialLedgerSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region ConfidentialLedgerResource
        /// <summary>
        /// Gets an object representing a <see cref="ConfidentialLedgerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConfidentialLedgerResource.CreateResourceIdentifier" /> to create a <see cref="ConfidentialLedgerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConfidentialLedgerResource" /> object. </returns>
        public static ConfidentialLedgerResource GetConfidentialLedgerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetConfidentialLedgerArmClientMockingExtension(client).GetConfidentialLedgerResource(id);
        }
        #endregion

        #region ManagedCcfResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedCcfResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedCcfResource.CreateResourceIdentifier" /> to create a <see cref="ManagedCcfResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedCcfResource" /> object. </returns>
        public static ManagedCcfResource GetManagedCcfResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetConfidentialLedgerArmClientMockingExtension(client).GetManagedCcfResource(id);
        }
        #endregion

        /// <summary> Gets a collection of ConfidentialLedgerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ConfidentialLedgerResources and their operations over a ConfidentialLedgerResource. </returns>
        public static ConfidentialLedgerCollection GetConfidentialLedgers(this ResourceGroupResource resourceGroupResource)
        {
            return GetConfidentialLedgerResourceGroupMockingExtension(resourceGroupResource).GetConfidentialLedgers();
        }

        /// <summary>
        /// Retrieves the properties of a Confidential Ledger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ConfidentialLedgerResource>> GetConfidentialLedgerAsync(this ResourceGroupResource resourceGroupResource, string ledgerName, CancellationToken cancellationToken = default)
        {
            return await GetConfidentialLedgerResourceGroupMockingExtension(resourceGroupResource).GetConfidentialLedgerAsync(ledgerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the properties of a Confidential Ledger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ConfidentialLedgerResource> GetConfidentialLedger(this ResourceGroupResource resourceGroupResource, string ledgerName, CancellationToken cancellationToken = default)
        {
            return GetConfidentialLedgerResourceGroupMockingExtension(resourceGroupResource).GetConfidentialLedger(ledgerName, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedCcfResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagedCcfResources and their operations over a ManagedCcfResource. </returns>
        public static ManagedCcfCollection GetManagedCcfs(this ResourceGroupResource resourceGroupResource)
        {
            return GetConfidentialLedgerResourceGroupMockingExtension(resourceGroupResource).GetManagedCcfs();
        }

        /// <summary>
        /// Retrieves the properties of a Managed CCF app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedCcfResource>> GetManagedCcfAsync(this ResourceGroupResource resourceGroupResource, string appName, CancellationToken cancellationToken = default)
        {
            return await GetConfidentialLedgerResourceGroupMockingExtension(resourceGroupResource).GetManagedCcfAsync(appName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the properties of a Managed CCF app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedCcfResource> GetManagedCcf(this ResourceGroupResource resourceGroupResource, string appName, CancellationToken cancellationToken = default)
        {
            return GetConfidentialLedgerResourceGroupMockingExtension(resourceGroupResource).GetManagedCcf(appName, cancellationToken);
        }

        /// <summary>
        /// To check whether a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Name availability request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<ConfidentialLedgerNameAvailabilityResult>> CheckConfidentialLedgerNameAvailabilityAsync(this SubscriptionResource subscriptionResource, ConfidentialLedgerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetConfidentialLedgerSubscriptionMockingExtension(subscriptionResource).CheckConfidentialLedgerNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// To check whether a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Name availability request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<ConfidentialLedgerNameAvailabilityResult> CheckConfidentialLedgerNameAvailability(this SubscriptionResource subscriptionResource, ConfidentialLedgerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetConfidentialLedgerSubscriptionMockingExtension(subscriptionResource).CheckConfidentialLedgerNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Confidential Ledgers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/ledgers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfidentialLedgerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfidentialLedgerResource> GetConfidentialLedgersAsync(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetConfidentialLedgerSubscriptionMockingExtension(subscriptionResource).GetConfidentialLedgersAsync(filter, cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Confidential Ledgers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/ledgers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfidentialLedgerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfidentialLedgerResource> GetConfidentialLedgers(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetConfidentialLedgerSubscriptionMockingExtension(subscriptionResource).GetConfidentialLedgers(filter, cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Managed CCF.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/managedCCFs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedCcfResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedCcfResource> GetManagedCcfsAsync(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetConfidentialLedgerSubscriptionMockingExtension(subscriptionResource).GetManagedCcfsAsync(filter, cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Managed CCF.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/managedCCFs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedCcfResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedCcfResource> GetManagedCcfs(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetConfidentialLedgerSubscriptionMockingExtension(subscriptionResource).GetManagedCcfs(filter, cancellationToken);
        }
    }
}
