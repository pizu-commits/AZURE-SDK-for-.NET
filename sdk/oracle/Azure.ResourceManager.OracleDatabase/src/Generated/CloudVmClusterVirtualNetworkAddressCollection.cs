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

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudVmClusterVirtualNetworkAddressResource"/> and their operations.
    /// Each <see cref="CloudVmClusterVirtualNetworkAddressResource"/> in the collection will belong to the same instance of <see cref="CloudVmClusterResource"/>.
    /// To get a <see cref="CloudVmClusterVirtualNetworkAddressCollection"/> instance call the GetCloudVmClusterVirtualNetworkAddresses method from an instance of <see cref="CloudVmClusterResource"/>.
    /// </summary>
    public partial class CloudVmClusterVirtualNetworkAddressCollection : ArmCollection, IEnumerable<CloudVmClusterVirtualNetworkAddressResource>, IAsyncEnumerable<CloudVmClusterVirtualNetworkAddressResource>
    {
        private readonly ClientDiagnostics _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics;
        private readonly VirtualNetworkAddressesRestOperations _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudVmClusterVirtualNetworkAddressCollection"/> class for mocking. </summary>
        protected CloudVmClusterVirtualNetworkAddressCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudVmClusterVirtualNetworkAddressCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudVmClusterVirtualNetworkAddressCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", CloudVmClusterVirtualNetworkAddressResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudVmClusterVirtualNetworkAddressResource.ResourceType, out string cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesApiVersion);
            _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient = new VirtualNetworkAddressesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CloudVmClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CloudVmClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a VirtualNetworkAddress
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CloudVmClusterVirtualNetworkAddressResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualnetworkaddressname, CloudVmClusterVirtualNetworkAddressData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, data, cancellationToken).ConfigureAwait(false);
                var operation = new OracleDatabaseArmOperation<CloudVmClusterVirtualNetworkAddressResource>(new CloudVmClusterVirtualNetworkAddressOperationSource(Client), _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics, Pipeline, _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a VirtualNetworkAddress
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CloudVmClusterVirtualNetworkAddressResource> CreateOrUpdate(WaitUntil waitUntil, string virtualnetworkaddressname, CloudVmClusterVirtualNetworkAddressData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, data, cancellationToken);
                var operation = new OracleDatabaseArmOperation<CloudVmClusterVirtualNetworkAddressResource>(new CloudVmClusterVirtualNetworkAddressOperationSource(Client), _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics, Pipeline, _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a VirtualNetworkAddress
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> is null. </exception>
        public virtual async Task<Response<CloudVmClusterVirtualNetworkAddressResource>> GetAsync(string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterVirtualNetworkAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a VirtualNetworkAddress
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> is null. </exception>
        public virtual Response<CloudVmClusterVirtualNetworkAddressResource> Get(string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterVirtualNetworkAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List VirtualNetworkAddress resources by CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_ListByCloudVmCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudVmClusterVirtualNetworkAddressResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudVmClusterVirtualNetworkAddressResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateListByCloudVmClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateListByCloudVmClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CloudVmClusterVirtualNetworkAddressResource(Client, CloudVmClusterVirtualNetworkAddressData.DeserializeCloudVmClusterVirtualNetworkAddressData(e)), _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics, Pipeline, "CloudVmClusterVirtualNetworkAddressCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List VirtualNetworkAddress resources by CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_ListByCloudVmCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudVmClusterVirtualNetworkAddressResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudVmClusterVirtualNetworkAddressResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateListByCloudVmClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.CreateListByCloudVmClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CloudVmClusterVirtualNetworkAddressResource(Client, CloudVmClusterVirtualNetworkAddressData.DeserializeCloudVmClusterVirtualNetworkAddressData(e)), _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics, Pipeline, "CloudVmClusterVirtualNetworkAddressCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> is null. </exception>
        public virtual async Task<NullableResponse<CloudVmClusterVirtualNetworkAddressResource>> GetIfExistsAsync(string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudVmClusterVirtualNetworkAddressResource>(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterVirtualNetworkAddressResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/virtualNetworkAddresses/{virtualnetworkaddressname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterVirtualNetworkAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualnetworkaddressname"/> is null. </exception>
        public virtual NullableResponse<CloudVmClusterVirtualNetworkAddressResource> GetIfExists(string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var scope = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesClientDiagnostics.CreateScope("CloudVmClusterVirtualNetworkAddressCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudVmClusterVirtualNetworkAddressVirtualNetworkAddressesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualnetworkaddressname, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudVmClusterVirtualNetworkAddressResource>(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterVirtualNetworkAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudVmClusterVirtualNetworkAddressResource> IEnumerable<CloudVmClusterVirtualNetworkAddressResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudVmClusterVirtualNetworkAddressResource> IAsyncEnumerable<CloudVmClusterVirtualNetworkAddressResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
