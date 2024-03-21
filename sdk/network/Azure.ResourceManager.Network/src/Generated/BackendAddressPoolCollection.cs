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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="BackendAddressPoolResource"/> and their operations.
    /// Each <see cref="BackendAddressPoolResource"/> in the collection will belong to the same instance of <see cref="LoadBalancerResource"/>.
    /// To get a <see cref="BackendAddressPoolCollection"/> instance call the GetBackendAddressPools method from an instance of <see cref="LoadBalancerResource"/>.
    /// </summary>
    public partial class BackendAddressPoolCollection : ArmCollection, IEnumerable<BackendAddressPoolResource>, IAsyncEnumerable<BackendAddressPoolResource>
    {
        private readonly ClientDiagnostics _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics;
        private readonly LoadBalancerBackendAddressPoolsRestOperations _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolCollection"/> class for mocking. </summary>
        protected BackendAddressPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackendAddressPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BackendAddressPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackendAddressPoolResource.ResourceType, out string backendAddressPoolLoadBalancerBackendAddressPoolsApiVersion);
            _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient = new LoadBalancerBackendAddressPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backendAddressPoolLoadBalancerBackendAddressPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="data"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BackendAddressPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backendAddressPoolName, BackendAddressPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BackendAddressPoolResource>(new BackendAddressPoolOperationSource(Client), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="data"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BackendAddressPoolResource> CreateOrUpdate(WaitUntil waitUntil, string backendAddressPoolName, BackendAddressPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, data, cancellationToken);
                var operation = new NetworkArmOperation<BackendAddressPoolResource>(new BackendAddressPoolOperationSource(Client), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual async Task<Response<BackendAddressPoolResource>> GetAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<BackendAddressPoolResource> Get(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancer backed address pools.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackendAddressPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BackendAddressPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BackendAddressPoolResource(Client, BackendAddressPoolData.DeserializeBackendAddressPoolData(e)), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, "BackendAddressPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the load balancer backed address pools.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackendAddressPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BackendAddressPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BackendAddressPoolResource(Client, BackendAddressPoolData.DeserializeBackendAddressPoolData(e)), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, "BackendAddressPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<BackendAddressPoolResource>> GetIfExistsAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackendAddressPoolResource>(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual NullableResponse<BackendAddressPoolResource> GetIfExists(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackendAddressPoolResource>(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BackendAddressPoolResource> IEnumerable<BackendAddressPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BackendAddressPoolResource> IAsyncEnumerable<BackendAddressPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
