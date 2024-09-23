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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NatGatewayResource"/> and their operations.
    /// Each <see cref="NatGatewayResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NatGatewayCollection"/> instance call the GetNatGateways method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NatGatewayCollection : ArmCollection, IEnumerable<NatGatewayResource>, IAsyncEnumerable<NatGatewayResource>
    {
        private readonly ClientDiagnostics _natGatewayClientDiagnostics;
        private readonly NatGatewaysRestOperations _natGatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="NatGatewayCollection"/> class for mocking. </summary>
        protected NatGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NatGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NatGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _natGatewayClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NatGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NatGatewayResource.ResourceType, out string natGatewayApiVersion);
            _natGatewayRestClient = new NatGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, natGatewayApiVersion);
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
        /// Creates or updates a nat gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="data"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NatGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string natGatewayName, NatGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _natGatewayRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NatGatewayResource>(new NatGatewayOperationSource(Client), _natGatewayClientDiagnostics, Pipeline, _natGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a nat gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="data"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NatGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string natGatewayName, NatGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _natGatewayRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, data, cancellationToken);
                var operation = new NetworkArmOperation<NatGatewayResource>(new NatGatewayOperationSource(Client), _natGatewayClientDiagnostics, Pipeline, _natGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified nat gateway in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> is null. </exception>
        public virtual async Task<Response<NatGatewayResource>> GetAsync(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _natGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NatGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified nat gateway in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> is null. </exception>
        public virtual Response<NatGatewayResource> Get(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _natGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NatGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all nat gateways in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NatGatewayResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NatGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _natGatewayRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _natGatewayRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NatGatewayResource(Client, NatGatewayData.DeserializeNatGatewayData(e)), _natGatewayClientDiagnostics, Pipeline, "NatGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all nat gateways in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NatGatewayResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NatGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _natGatewayRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _natGatewayRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NatGatewayResource(Client, NatGatewayData.DeserializeNatGatewayData(e)), _natGatewayClientDiagnostics, Pipeline, "NatGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _natGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _natGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> is null. </exception>
        public virtual async Task<NullableResponse<NatGatewayResource>> GetIfExistsAsync(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _natGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NatGatewayResource>(response.GetRawResponse());
                return Response.FromValue(new NatGatewayResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/natGateways/{natGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NatGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NatGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> is null. </exception>
        public virtual NullableResponse<NatGatewayResource> GetIfExists(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natGatewayName, nameof(natGatewayName));

            using var scope = _natGatewayClientDiagnostics.CreateScope("NatGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _natGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NatGatewayResource>(response.GetRawResponse());
                return Response.FromValue(new NatGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NatGatewayResource> IEnumerable<NatGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NatGatewayResource> IAsyncEnumerable<NatGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
