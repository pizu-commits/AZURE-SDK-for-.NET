// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualApplianceSiteResource" /> and their operations.
    /// Each <see cref="VirtualApplianceSiteResource" /> in the collection will belong to the same instance of <see cref="NetworkVirtualApplianceResource" />.
    /// To get a <see cref="VirtualApplianceSiteCollection" /> instance call the GetVirtualApplianceSites method from an instance of <see cref="NetworkVirtualApplianceResource" />.
    /// </summary>
    public partial class VirtualApplianceSiteCollection : ArmCollection, IEnumerable<VirtualApplianceSiteResource>, IAsyncEnumerable<VirtualApplianceSiteResource>
    {
        private readonly ClientDiagnostics _virtualApplianceSiteClientDiagnostics;
        private readonly VirtualApplianceSitesRestOperations _virtualApplianceSiteRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualApplianceSiteCollection"/> class for mocking. </summary>
        protected VirtualApplianceSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualApplianceSiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualApplianceSiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualApplianceSiteClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualApplianceSiteResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualApplianceSiteResource.ResourceType, out string virtualApplianceSiteApiVersion);
            _virtualApplianceSiteRestClient = new VirtualApplianceSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualApplianceSiteApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkVirtualApplianceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkVirtualApplianceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance Site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="data"> Parameters supplied to the create or update Network Virtual Appliance Site operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualApplianceSiteResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string siteName, VirtualApplianceSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualApplianceSiteRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualApplianceSiteResource>(new VirtualApplianceSiteOperationSource(Client), _virtualApplianceSiteClientDiagnostics, Pipeline, _virtualApplianceSiteRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance Site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="data"> Parameters supplied to the create or update Network Virtual Appliance Site operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualApplianceSiteResource> CreateOrUpdate(WaitUntil waitUntil, string siteName, VirtualApplianceSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualApplianceSiteRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualApplianceSiteResource>(new VirtualApplianceSiteOperationSource(Client), _virtualApplianceSiteClientDiagnostics, Pipeline, _virtualApplianceSiteRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Virtual Appliance Site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<Response<VirtualApplianceSiteResource>> GetAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualApplianceSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplianceSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Virtual Appliance Site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<VirtualApplianceSiteResource> Get(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualApplianceSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplianceSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Network Virtual Appliance Sites in a Network Virtual Appliance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualApplianceSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualApplianceSiteResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualApplianceSiteRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualApplianceSiteRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualApplianceSiteResource(Client, VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(e)), _virtualApplianceSiteClientDiagnostics, Pipeline, "VirtualApplianceSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Network Virtual Appliance Sites in a Network Virtual Appliance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualApplianceSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualApplianceSiteResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualApplianceSiteRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualApplianceSiteRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualApplianceSiteResource(Client, VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(e)), _virtualApplianceSiteClientDiagnostics, Pipeline, "VirtualApplianceSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualApplianceSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<bool> Exists(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualApplianceSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualApplianceSiteResource> IEnumerable<VirtualApplianceSiteResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualApplianceSiteResource> IAsyncEnumerable<VirtualApplianceSiteResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
