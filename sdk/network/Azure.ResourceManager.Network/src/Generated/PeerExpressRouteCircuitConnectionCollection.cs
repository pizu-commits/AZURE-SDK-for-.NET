// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="PeerExpressRouteCircuitConnectionResource" /> and their operations.
    /// Each <see cref="PeerExpressRouteCircuitConnectionResource" /> in the collection will belong to the same instance of <see cref="ExpressRouteCircuitPeeringResource" />.
    /// To get a <see cref="PeerExpressRouteCircuitConnectionCollection" /> instance call the GetPeerExpressRouteCircuitConnections method from an instance of <see cref="ExpressRouteCircuitPeeringResource" />.
    /// </summary>
    public partial class PeerExpressRouteCircuitConnectionCollection : ArmCollection, IEnumerable<PeerExpressRouteCircuitConnectionResource>, IAsyncEnumerable<PeerExpressRouteCircuitConnectionResource>
    {
        private readonly ClientDiagnostics _peerExpressRouteCircuitConnectionClientDiagnostics;
        private readonly PeerExpressRouteCircuitConnectionsRestOperations _peerExpressRouteCircuitConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="PeerExpressRouteCircuitConnectionCollection"/> class for mocking. </summary>
        protected PeerExpressRouteCircuitConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeerExpressRouteCircuitConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PeerExpressRouteCircuitConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peerExpressRouteCircuitConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PeerExpressRouteCircuitConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PeerExpressRouteCircuitConnectionResource.ResourceType, out string peerExpressRouteCircuitConnectionApiVersion);
            _peerExpressRouteCircuitConnectionRestClient = new PeerExpressRouteCircuitConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peerExpressRouteCircuitConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuitPeeringResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuitPeeringResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified Peer Express Route Circuit Connection from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}
        /// Operation Id: PeerExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<PeerExpressRouteCircuitConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _peerExpressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Peer Express Route Circuit Connection from the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}
        /// Operation Id: PeerExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<PeerExpressRouteCircuitConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _peerExpressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all global reach peer connections associated with a private peering in an express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections
        /// Operation Id: PeerExpressRouteCircuitConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeerExpressRouteCircuitConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PeerExpressRouteCircuitConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PeerExpressRouteCircuitConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _peerExpressRouteCircuitConnectionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PeerExpressRouteCircuitConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PeerExpressRouteCircuitConnectionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _peerExpressRouteCircuitConnectionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PeerExpressRouteCircuitConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all global reach peer connections associated with a private peering in an express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections
        /// Operation Id: PeerExpressRouteCircuitConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeerExpressRouteCircuitConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PeerExpressRouteCircuitConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PeerExpressRouteCircuitConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _peerExpressRouteCircuitConnectionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PeerExpressRouteCircuitConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PeerExpressRouteCircuitConnectionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _peerExpressRouteCircuitConnectionRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PeerExpressRouteCircuitConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}
        /// Operation Id: PeerExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}
        /// Operation Id: PeerExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}
        /// Operation Id: PeerExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<PeerExpressRouteCircuitConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _peerExpressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PeerExpressRouteCircuitConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}
        /// Operation Id: PeerExpressRouteCircuitConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<PeerExpressRouteCircuitConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _peerExpressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PeerExpressRouteCircuitConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PeerExpressRouteCircuitConnectionResource> IEnumerable<PeerExpressRouteCircuitConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PeerExpressRouteCircuitConnectionResource> IAsyncEnumerable<PeerExpressRouteCircuitConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
