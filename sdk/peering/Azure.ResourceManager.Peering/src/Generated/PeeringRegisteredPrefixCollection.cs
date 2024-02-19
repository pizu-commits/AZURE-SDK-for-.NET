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

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing a collection of <see cref="PeeringRegisteredPrefixResource"/> and their operations.
    /// Each <see cref="PeeringRegisteredPrefixResource"/> in the collection will belong to the same instance of <see cref="PeeringResource"/>.
    /// To get a <see cref="PeeringRegisteredPrefixCollection"/> instance call the GetPeeringRegisteredPrefixes method from an instance of <see cref="PeeringResource"/>.
    /// </summary>
    public partial class PeeringRegisteredPrefixCollection : ArmCollection, IEnumerable<PeeringRegisteredPrefixResource>, IAsyncEnumerable<PeeringRegisteredPrefixResource>
    {
        private readonly ClientDiagnostics _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics;
        private readonly RegisteredPrefixesRestOperations _peeringRegisteredPrefixRegisteredPrefixesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PeeringRegisteredPrefixCollection"/> class for mocking. </summary>
        protected PeeringRegisteredPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeeringRegisteredPrefixCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PeeringRegisteredPrefixCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Peering", PeeringRegisteredPrefixResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PeeringRegisteredPrefixResource.ResourceType, out string peeringRegisteredPrefixRegisteredPrefixesApiVersion);
            _peeringRegisteredPrefixRegisteredPrefixesRestClient = new RegisteredPrefixesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peeringRegisteredPrefixRegisteredPrefixesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PeeringResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PeeringResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new registered prefix with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="data"> The properties needed to create a registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PeeringRegisteredPrefixResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string registeredPrefixName, PeeringRegisteredPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, data, cancellationToken).ConfigureAwait(false);
                var uri = _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new PeeringArmOperation<PeeringRegisteredPrefixResource>(Response.FromValue(new PeeringRegisteredPrefixResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates a new registered prefix with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="data"> The properties needed to create a registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PeeringRegisteredPrefixResource> CreateOrUpdate(WaitUntil waitUntil, string registeredPrefixName, PeeringRegisteredPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, data, cancellationToken);
                var uri = _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new PeeringArmOperation<PeeringRegisteredPrefixResource>(Response.FromValue(new PeeringRegisteredPrefixResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets an existing registered prefix with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> is null. </exception>
        public virtual async Task<Response<PeeringRegisteredPrefixResource>> GetAsync(string registeredPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredPrefixRegisteredPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing registered prefix with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> is null. </exception>
        public virtual Response<PeeringRegisteredPrefixResource> Get(string registeredPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _peeringRegisteredPrefixRegisteredPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all registered prefixes under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_ListByPeering</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeeringRegisteredPrefixResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PeeringRegisteredPrefixResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateListByPeeringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateListByPeeringNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PeeringRegisteredPrefixResource(Client, PeeringRegisteredPrefixData.DeserializePeeringRegisteredPrefixData(e)), _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics, Pipeline, "PeeringRegisteredPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all registered prefixes under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_ListByPeering</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeeringRegisteredPrefixResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PeeringRegisteredPrefixResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateListByPeeringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringRegisteredPrefixRegisteredPrefixesRestClient.CreateListByPeeringNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PeeringRegisteredPrefixResource(Client, PeeringRegisteredPrefixData.DeserializePeeringRegisteredPrefixData(e)), _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics, Pipeline, "PeeringRegisteredPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string registeredPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredPrefixRegisteredPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> is null. </exception>
        public virtual Response<bool> Exists(string registeredPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = _peeringRegisteredPrefixRegisteredPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> is null. </exception>
        public virtual async Task<NullableResponse<PeeringRegisteredPrefixResource>> GetIfExistsAsync(string registeredPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredPrefixRegisteredPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PeeringRegisteredPrefixResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredPrefixResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredPrefixes/{registeredPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredPrefixes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeeringRegisteredPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registeredPrefixName"> The name of the registered prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registeredPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registeredPrefixName"/> is null. </exception>
        public virtual NullableResponse<PeeringRegisteredPrefixResource> GetIfExists(string registeredPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registeredPrefixName, nameof(registeredPrefixName));

            using var scope = _peeringRegisteredPrefixRegisteredPrefixesClientDiagnostics.CreateScope("PeeringRegisteredPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _peeringRegisteredPrefixRegisteredPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, registeredPrefixName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PeeringRegisteredPrefixResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PeeringRegisteredPrefixResource> IEnumerable<PeeringRegisteredPrefixResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PeeringRegisteredPrefixResource> IAsyncEnumerable<PeeringRegisteredPrefixResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
