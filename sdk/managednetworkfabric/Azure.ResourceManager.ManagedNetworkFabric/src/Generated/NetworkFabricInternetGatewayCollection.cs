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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricInternetGatewayResource" /> and their operations.
    /// Each <see cref="NetworkFabricInternetGatewayResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkFabricInternetGatewayCollection" /> instance call the GetNetworkFabricInternetGateways method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkFabricInternetGatewayCollection : ArmCollection, IEnumerable<NetworkFabricInternetGatewayResource>, IAsyncEnumerable<NetworkFabricInternetGatewayResource>
    {
        private readonly ClientDiagnostics _networkFabricInternetGatewayInternetGatewaysClientDiagnostics;
        private readonly InternetGatewaysRestOperations _networkFabricInternetGatewayInternetGatewaysRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricInternetGatewayCollection"/> class for mocking. </summary>
        protected NetworkFabricInternetGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricInternetGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricInternetGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricInternetGatewayInternetGatewaysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricInternetGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricInternetGatewayResource.ResourceType, out string networkFabricInternetGatewayInternetGatewaysApiVersion);
            _networkFabricInternetGatewayInternetGatewaysRestClient = new InternetGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricInternetGatewayInternetGatewaysApiVersion);
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
        /// Implements Gateway GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/internetGateways/{internetGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternetGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internetGatewayName"> Name of the Internet Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internetGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internetGatewayName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricInternetGatewayResource>> GetAsync(string internetGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internetGatewayName, nameof(internetGatewayName));

            using var scope = _networkFabricInternetGatewayInternetGatewaysClientDiagnostics.CreateScope("NetworkFabricInternetGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricInternetGatewayInternetGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, internetGatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricInternetGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements Gateway GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/internetGateways/{internetGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternetGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internetGatewayName"> Name of the Internet Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internetGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internetGatewayName"/> is null. </exception>
        public virtual Response<NetworkFabricInternetGatewayResource> Get(string internetGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internetGatewayName, nameof(internetGatewayName));

            using var scope = _networkFabricInternetGatewayInternetGatewaysClientDiagnostics.CreateScope("NetworkFabricInternetGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricInternetGatewayInternetGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, internetGatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricInternetGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Displays Internet Gateways list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/internetGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternetGateways_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricInternetGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricInternetGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricInternetGatewayInternetGatewaysRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricInternetGatewayInternetGatewaysRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkFabricInternetGatewayResource(Client, NetworkFabricInternetGatewayData.DeserializeNetworkFabricInternetGatewayData(e)), _networkFabricInternetGatewayInternetGatewaysClientDiagnostics, Pipeline, "NetworkFabricInternetGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Displays Internet Gateways list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/internetGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternetGateways_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricInternetGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricInternetGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricInternetGatewayInternetGatewaysRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricInternetGatewayInternetGatewaysRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkFabricInternetGatewayResource(Client, NetworkFabricInternetGatewayData.DeserializeNetworkFabricInternetGatewayData(e)), _networkFabricInternetGatewayInternetGatewaysClientDiagnostics, Pipeline, "NetworkFabricInternetGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/internetGateways/{internetGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternetGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internetGatewayName"> Name of the Internet Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internetGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internetGatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string internetGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internetGatewayName, nameof(internetGatewayName));

            using var scope = _networkFabricInternetGatewayInternetGatewaysClientDiagnostics.CreateScope("NetworkFabricInternetGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricInternetGatewayInternetGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, internetGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/internetGateways/{internetGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternetGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internetGatewayName"> Name of the Internet Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internetGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internetGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string internetGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internetGatewayName, nameof(internetGatewayName));

            using var scope = _networkFabricInternetGatewayInternetGatewaysClientDiagnostics.CreateScope("NetworkFabricInternetGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricInternetGatewayInternetGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, internetGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricInternetGatewayResource> IEnumerable<NetworkFabricInternetGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricInternetGatewayResource> IAsyncEnumerable<NetworkFabricInternetGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
