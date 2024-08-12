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
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing a collection of <see cref="VMwareVirtualNetworkResource"/> and their operations.
    /// Each <see cref="VMwareVirtualNetworkResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VMwareVirtualNetworkCollection"/> instance call the GetVMwareVirtualNetworks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VMwareVirtualNetworkCollection : ArmCollection, IEnumerable<VMwareVirtualNetworkResource>, IAsyncEnumerable<VMwareVirtualNetworkResource>
    {
        private readonly ClientDiagnostics _vMwareVirtualNetworkVirtualNetworksClientDiagnostics;
        private readonly VirtualNetworksRestOperations _vMwareVirtualNetworkVirtualNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareVirtualNetworkCollection"/> class for mocking. </summary>
        protected VMwareVirtualNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareVirtualNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VMwareVirtualNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareVirtualNetworkVirtualNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareVirtualNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VMwareVirtualNetworkResource.ResourceType, out string vMwareVirtualNetworkVirtualNetworksApiVersion);
            _vMwareVirtualNetworkVirtualNetworksRestClient = new VirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vMwareVirtualNetworkVirtualNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VMwareVirtualNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkName, VMwareVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareVirtualNetworkVirtualNetworksRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareVirtualNetworkResource>(new VMwareVirtualNetworkOperationSource(Client), _vMwareVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, _vMwareVirtualNetworkVirtualNetworksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VMwareVirtualNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkName, VMwareVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareVirtualNetworkVirtualNetworksRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareVirtualNetworkResource>(new VMwareVirtualNetworkOperationSource(Client), _vMwareVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, _vMwareVirtualNetworkVirtualNetworksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements virtual network GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<VMwareVirtualNetworkResource>> GetAsync(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareVirtualNetworkVirtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements virtual network GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<VMwareVirtualNetworkResource> Get(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareVirtualNetworkVirtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of virtualNetworks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareVirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareVirtualNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VMwareVirtualNetworkResource(Client, VMwareVirtualNetworkData.DeserializeVMwareVirtualNetworkData(e)), _vMwareVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, "VMwareVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualNetworks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareVirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareVirtualNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VMwareVirtualNetworkResource(Client, VMwareVirtualNetworkData.DeserializeVMwareVirtualNetworkData(e)), _vMwareVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, "VMwareVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vMwareVirtualNetworkVirtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _vMwareVirtualNetworkVirtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<VMwareVirtualNetworkResource>> GetIfExistsAsync(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vMwareVirtualNetworkVirtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VMwareVirtualNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual NullableResponse<VMwareVirtualNetworkResource> GetIfExists(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _vMwareVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("VMwareVirtualNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vMwareVirtualNetworkVirtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VMwareVirtualNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareVirtualNetworkResource> IEnumerable<VMwareVirtualNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareVirtualNetworkResource> IAsyncEnumerable<VMwareVirtualNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
