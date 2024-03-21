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

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFunctionDefinitionVersionResource"/> and their operations.
    /// Each <see cref="NetworkFunctionDefinitionVersionResource"/> in the collection will belong to the same instance of <see cref="NetworkFunctionDefinitionGroupResource"/>.
    /// To get a <see cref="NetworkFunctionDefinitionVersionCollection"/> instance call the GetNetworkFunctionDefinitionVersions method from an instance of <see cref="NetworkFunctionDefinitionGroupResource"/>.
    /// </summary>
    public partial class NetworkFunctionDefinitionVersionCollection : ArmCollection, IEnumerable<NetworkFunctionDefinitionVersionResource>, IAsyncEnumerable<NetworkFunctionDefinitionVersionResource>
    {
        private readonly ClientDiagnostics _networkFunctionDefinitionVersionClientDiagnostics;
        private readonly NetworkFunctionDefinitionVersionsRestOperations _networkFunctionDefinitionVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionDefinitionVersionCollection"/> class for mocking. </summary>
        protected NetworkFunctionDefinitionVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionDefinitionVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFunctionDefinitionVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFunctionDefinitionVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", NetworkFunctionDefinitionVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFunctionDefinitionVersionResource.ResourceType, out string networkFunctionDefinitionVersionApiVersion);
            _networkFunctionDefinitionVersionRestClient = new NetworkFunctionDefinitionVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFunctionDefinitionVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkFunctionDefinitionGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkFunctionDefinitionGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network function definition version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="data"> Parameters supplied to the create or update network function definition version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFunctionDefinitionVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkFunctionDefinitionVersionName, NetworkFunctionDefinitionVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionVersionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridNetworkArmOperation<NetworkFunctionDefinitionVersionResource>(new NetworkFunctionDefinitionVersionOperationSource(Client), _networkFunctionDefinitionVersionClientDiagnostics, Pipeline, _networkFunctionDefinitionVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a network function definition version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="data"> Parameters supplied to the create or update network function definition version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFunctionDefinitionVersionResource> CreateOrUpdate(WaitUntil waitUntil, string networkFunctionDefinitionVersionName, NetworkFunctionDefinitionVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionVersionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, data, cancellationToken);
                var operation = new HybridNetworkArmOperation<NetworkFunctionDefinitionVersionResource>(new NetworkFunctionDefinitionVersionOperationSource(Client), _networkFunctionDefinitionVersionClientDiagnostics, Pipeline, _networkFunctionDefinitionVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about a network function definition version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> is null. </exception>
        public virtual async Task<Response<NetworkFunctionDefinitionVersionResource>> GetAsync(string networkFunctionDefinitionVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a network function definition version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> is null. </exception>
        public virtual Response<NetworkFunctionDefinitionVersionResource> Get(string networkFunctionDefinitionVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a list of network function definition versions under a network function definition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_ListByNetworkFunctionDefinitionGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFunctionDefinitionVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFunctionDefinitionVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionDefinitionVersionRestClient.CreateListByNetworkFunctionDefinitionGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionDefinitionVersionRestClient.CreateListByNetworkFunctionDefinitionGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionDefinitionVersionResource(Client, NetworkFunctionDefinitionVersionData.DeserializeNetworkFunctionDefinitionVersionData(e)), _networkFunctionDefinitionVersionClientDiagnostics, Pipeline, "NetworkFunctionDefinitionVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about a list of network function definition versions under a network function definition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_ListByNetworkFunctionDefinitionGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFunctionDefinitionVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFunctionDefinitionVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionDefinitionVersionRestClient.CreateListByNetworkFunctionDefinitionGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionDefinitionVersionRestClient.CreateListByNetworkFunctionDefinitionGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionDefinitionVersionResource(Client, NetworkFunctionDefinitionVersionData.DeserializeNetworkFunctionDefinitionVersionData(e)), _networkFunctionDefinitionVersionClientDiagnostics, Pipeline, "NetworkFunctionDefinitionVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkFunctionDefinitionVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkFunctionDefinitionVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFunctionDefinitionVersionResource>> GetIfExistsAsync(string networkFunctionDefinitionVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFunctionDefinitionVersionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFunctionDefinitionVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/> is null. </exception>
        public virtual NullableResponse<NetworkFunctionDefinitionVersionResource> GetIfExists(string networkFunctionDefinitionVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));

            using var scope = _networkFunctionDefinitionVersionClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFunctionDefinitionVersionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFunctionDefinitionVersionResource> IEnumerable<NetworkFunctionDefinitionVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFunctionDefinitionVersionResource> IAsyncEnumerable<NetworkFunctionDefinitionVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
