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

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudKubernetesClusterResource"/> and their operations.
    /// Each <see cref="NetworkCloudKubernetesClusterResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkCloudKubernetesClusterCollection"/> instance call the GetNetworkCloudKubernetesClusters method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkCloudKubernetesClusterCollection : ArmCollection, IEnumerable<NetworkCloudKubernetesClusterResource>, IAsyncEnumerable<NetworkCloudKubernetesClusterResource>
    {
        private readonly ClientDiagnostics _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics;
        private readonly KubernetesClustersRestOperations _networkCloudKubernetesClusterKubernetesClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudKubernetesClusterCollection"/> class for mocking. </summary>
        protected NetworkCloudKubernetesClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudKubernetesClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudKubernetesClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudKubernetesClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudKubernetesClusterResource.ResourceType, out string networkCloudKubernetesClusterKubernetesClustersApiVersion);
            _networkCloudKubernetesClusterKubernetesClustersRestClient = new KubernetesClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudKubernetesClusterKubernetesClustersApiVersion);
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
        /// Create a new Kubernetes cluster or update the properties of the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudKubernetesClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string kubernetesClusterName, NetworkCloudKubernetesClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudKubernetesClusterResource>(new NetworkCloudKubernetesClusterOperationSource(Client), _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics, Pipeline, _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new Kubernetes cluster or update the properties of the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudKubernetesClusterResource> CreateOrUpdate(WaitUntil waitUntil, string kubernetesClusterName, NetworkCloudKubernetesClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudKubernetesClusterResource>(new NetworkCloudKubernetesClusterOperationSource(Client), _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics, Pipeline, _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of the provided the Kubernetes cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudKubernetesClusterResource>> GetAsync(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudKubernetesClusterKubernetesClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudKubernetesClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided the Kubernetes cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        public virtual Response<NetworkCloudKubernetesClusterResource> Get(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudKubernetesClusterKubernetesClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudKubernetesClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Kubernetes clusters in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudKubernetesClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudKubernetesClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudKubernetesClusterResource(Client, NetworkCloudKubernetesClusterData.DeserializeNetworkCloudKubernetesClusterData(e)), _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics, Pipeline, "NetworkCloudKubernetesClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Kubernetes clusters in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudKubernetesClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudKubernetesClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudKubernetesClusterKubernetesClustersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudKubernetesClusterResource(Client, NetworkCloudKubernetesClusterData.DeserializeNetworkCloudKubernetesClusterData(e)), _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics, Pipeline, "NetworkCloudKubernetesClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudKubernetesClusterKubernetesClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudKubernetesClusterKubernetesClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudKubernetesClusterResource>> GetIfExistsAsync(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudKubernetesClusterKubernetesClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudKubernetesClusterResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudKubernetesClusterResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/kubernetesClusters/{kubernetesClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KubernetesClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudKubernetesClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kubernetesClusterName"> The name of the Kubernetes cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kubernetesClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesClusterName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudKubernetesClusterResource> GetIfExists(string kubernetesClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kubernetesClusterName, nameof(kubernetesClusterName));

            using var scope = _networkCloudKubernetesClusterKubernetesClustersClientDiagnostics.CreateScope("NetworkCloudKubernetesClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudKubernetesClusterKubernetesClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, kubernetesClusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudKubernetesClusterResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudKubernetesClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudKubernetesClusterResource> IEnumerable<NetworkCloudKubernetesClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudKubernetesClusterResource> IAsyncEnumerable<NetworkCloudKubernetesClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
