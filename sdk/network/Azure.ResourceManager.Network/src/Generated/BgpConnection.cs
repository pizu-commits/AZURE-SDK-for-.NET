// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a BgpConnection along with the instance operations that can be performed on it. </summary>
    public partial class BgpConnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BgpConnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualHubName, string connectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _bgpConnectionVirtualHubBgpConnectionClientDiagnostics;
        private readonly VirtualHubBgpConnectionRestOperations _bgpConnectionVirtualHubBgpConnectionRestClient;
        private readonly ClientDiagnostics _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics;
        private readonly VirtualHubBgpConnectionsRestOperations _bgpConnectionVirtualHubBgpConnectionsRestClient;
        private readonly BgpConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="BgpConnection"/> class for mocking. </summary>
        protected BgpConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BgpConnection"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BgpConnection(ArmClient armClient, BgpConnectionData data) : this(armClient, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BgpConnection"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BgpConnection(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _bgpConnectionVirtualHubBgpConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string bgpConnectionVirtualHubBgpConnectionApiVersion);
            _bgpConnectionVirtualHubBgpConnectionRestClient = new VirtualHubBgpConnectionRestOperations(_bgpConnectionVirtualHubBgpConnectionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, bgpConnectionVirtualHubBgpConnectionApiVersion);
            _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string bgpConnectionVirtualHubBgpConnectionsApiVersion);
            _bgpConnectionVirtualHubBgpConnectionsRestClient = new VirtualHubBgpConnectionsRestOperations(_bgpConnectionVirtualHubBgpConnectionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, bgpConnectionVirtualHubBgpConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualHubs/bgpConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BgpConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Retrieves the details of a Virtual Hub Bgp Connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BgpConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnection.Get");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BgpConnection(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a Virtual Hub Bgp Connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BgpConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnection.Get");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BgpConnection(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnection.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnection.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHubBgpConnection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BgpConnectionDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnection.Delete");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BgpConnectionDeleteOperation(_bgpConnectionVirtualHubBgpConnectionClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHubBgpConnection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BgpConnectionDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnection.Delete");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new BgpConnectionDeleteOperation(_bgpConnectionVirtualHubBgpConnectionClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a list of routes the virtual hub bgp connection has learned. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BgpConnectionGetLearnedRoutesVirtualHubBgpConnectionOperation> GetLearnedRoutesVirtualHubBgpConnectionAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnection.GetLearnedRoutesVirtualHubBgpConnection");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionsRestClient.ListLearnedRoutesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BgpConnectionGetLearnedRoutesVirtualHubBgpConnectionOperation(_bgpConnectionVirtualHubBgpConnectionsClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListLearnedRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a list of routes the virtual hub bgp connection has learned. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BgpConnectionGetLearnedRoutesVirtualHubBgpConnectionOperation GetLearnedRoutesVirtualHubBgpConnection(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnection.GetLearnedRoutesVirtualHubBgpConnection");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionsRestClient.ListLearnedRoutes(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new BgpConnectionGetLearnedRoutesVirtualHubBgpConnectionOperation(_bgpConnectionVirtualHubBgpConnectionsClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListLearnedRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a list of routes the virtual hub bgp connection is advertising to the specified peer. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BgpConnectionGetAdvertisedRoutesVirtualHubBgpConnectionOperation> GetAdvertisedRoutesVirtualHubBgpConnectionAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnection.GetAdvertisedRoutesVirtualHubBgpConnection");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionsRestClient.ListAdvertisedRoutesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BgpConnectionGetAdvertisedRoutesVirtualHubBgpConnectionOperation(_bgpConnectionVirtualHubBgpConnectionsClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListAdvertisedRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a list of routes the virtual hub bgp connection is advertising to the specified peer. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BgpConnectionGetAdvertisedRoutesVirtualHubBgpConnectionOperation GetAdvertisedRoutesVirtualHubBgpConnection(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics.CreateScope("BgpConnection.GetAdvertisedRoutesVirtualHubBgpConnection");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionsRestClient.ListAdvertisedRoutes(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new BgpConnectionGetAdvertisedRoutesVirtualHubBgpConnectionOperation(_bgpConnectionVirtualHubBgpConnectionsClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListAdvertisedRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
