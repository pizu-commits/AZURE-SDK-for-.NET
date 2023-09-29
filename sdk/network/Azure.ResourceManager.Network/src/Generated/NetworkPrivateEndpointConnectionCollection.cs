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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="NetworkPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="PrivateLinkServiceResource" />.
    /// To get a <see cref="NetworkPrivateEndpointConnectionCollection" /> instance call the GetNetworkPrivateEndpointConnections method from an instance of <see cref="PrivateLinkServiceResource" />.
    /// </summary>
    public partial class NetworkPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<NetworkPrivateEndpointConnectionResource>, IAsyncEnumerable<NetworkPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics;
        private readonly PrivateLinkServicesRestOperations _networkPrivateEndpointConnectionPrivateLinkServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected NetworkPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkPrivateEndpointConnectionResource.ResourceType, out string networkPrivateEndpointConnectionPrivateLinkServicesApiVersion);
            _networkPrivateEndpointConnectionPrivateLinkServicesRestClient = new PrivateLinkServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkPrivateEndpointConnectionPrivateLinkServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateLinkServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateLinkServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approve or reject private end point connection for a private link service in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_UpdatePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="data"> Parameters supplied to approve or reject the private end point connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string peConnectionName, NetworkPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.UpdatePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkPrivateEndpointConnectionResource>(Response.FromValue(new NetworkPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Approve or reject private end point connection for a private link service in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_UpdatePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="data"> Parameters supplied to approve or reject the private end point connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string peConnectionName, NetworkPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.UpdatePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkPrivateEndpointConnectionResource>(Response.FromValue(new NetworkPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Get the specific private end point connection by specific private link service in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual async Task<Response<NetworkPrivateEndpointConnectionResource>> GetAsync(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specific private end point connection by specific private link service in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual Response<NetworkPrivateEndpointConnectionResource> Get(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all private end point connections for a specific private link service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_ListPrivateEndpointConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.CreateListPrivateEndpointConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.CreateListPrivateEndpointConnectionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkPrivateEndpointConnectionResource(Client, NetworkPrivateEndpointConnectionData.DeserializeNetworkPrivateEndpointConnectionData(e)), _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics, Pipeline, "NetworkPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all private end point connections for a specific private link service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_ListPrivateEndpointConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.CreateListPrivateEndpointConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.CreateListPrivateEndpointConnectionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkPrivateEndpointConnectionResource(Client, NetworkPrivateEndpointConnectionData.DeserializeNetworkPrivateEndpointConnectionData(e)), _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics, Pipeline, "NetworkPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkPrivateEndpointConnectionResource>> GetIfExistsAsync(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkPrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> The name of the private end point connection. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual NullableResponse<NetworkPrivateEndpointConnectionResource> GetIfExists(string peConnectionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _networkPrivateEndpointConnectionPrivateLinkServicesClientDiagnostics.CreateScope("NetworkPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkPrivateEndpointConnectionPrivateLinkServicesRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkPrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkPrivateEndpointConnectionResource> IEnumerable<NetworkPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkPrivateEndpointConnectionResource> IAsyncEnumerable<NetworkPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
