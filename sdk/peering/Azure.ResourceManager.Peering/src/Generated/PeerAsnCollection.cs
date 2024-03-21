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

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing a collection of <see cref="PeerAsnResource"/> and their operations.
    /// Each <see cref="PeerAsnResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="PeerAsnCollection"/> instance call the GetPeerAsns method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class PeerAsnCollection : ArmCollection, IEnumerable<PeerAsnResource>, IAsyncEnumerable<PeerAsnResource>
    {
        private readonly ClientDiagnostics _peerAsnClientDiagnostics;
        private readonly PeerAsnsRestOperations _peerAsnRestClient;

        /// <summary> Initializes a new instance of the <see cref="PeerAsnCollection"/> class for mocking. </summary>
        protected PeerAsnCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeerAsnCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PeerAsnCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peerAsnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Peering", PeerAsnResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PeerAsnResource.ResourceType, out string peerAsnApiVersion);
            _peerAsnRestClient = new PeerAsnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peerAsnApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new peer ASN or updates an existing peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="data"> The peer ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PeerAsnResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string peerAsnName, PeerAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _peerAsnRestClient.CreateOrUpdateAsync(Id.SubscriptionId, peerAsnName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation<PeerAsnResource>(Response.FromValue(new PeerAsnResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new peer ASN or updates an existing peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="data"> The peer ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PeerAsnResource> CreateOrUpdate(WaitUntil waitUntil, string peerAsnName, PeerAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _peerAsnRestClient.CreateOrUpdate(Id.SubscriptionId, peerAsnName, data, cancellationToken);
                var operation = new PeeringArmOperation<PeerAsnResource>(Response.FromValue(new PeerAsnResource(Client, response), response.GetRawResponse()));
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
        /// Gets the peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> is null. </exception>
        public virtual async Task<Response<PeerAsnResource>> GetAsync(string peerAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.Get");
            scope.Start();
            try
            {
                var response = await _peerAsnRestClient.GetAsync(Id.SubscriptionId, peerAsnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> is null. </exception>
        public virtual Response<PeerAsnResource> Get(string peerAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.Get");
            scope.Start();
            try
            {
                var response = _peerAsnRestClient.Get(Id.SubscriptionId, peerAsnName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the peer ASNs under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeerAsnResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PeerAsnResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peerAsnRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peerAsnRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PeerAsnResource(Client, PeerAsnData.DeserializePeerAsnData(e)), _peerAsnClientDiagnostics, Pipeline, "PeerAsnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the peer ASNs under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeerAsnResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PeerAsnResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peerAsnRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peerAsnRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PeerAsnResource(Client, PeerAsnData.DeserializePeerAsnData(e)), _peerAsnClientDiagnostics, Pipeline, "PeerAsnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string peerAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.Exists");
            scope.Start();
            try
            {
                var response = await _peerAsnRestClient.GetAsync(Id.SubscriptionId, peerAsnName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> is null. </exception>
        public virtual Response<bool> Exists(string peerAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.Exists");
            scope.Start();
            try
            {
                var response = _peerAsnRestClient.Get(Id.SubscriptionId, peerAsnName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> is null. </exception>
        public virtual async Task<NullableResponse<PeerAsnResource>> GetIfExistsAsync(string peerAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _peerAsnRestClient.GetAsync(Id.SubscriptionId, peerAsnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PeerAsnResource>(response.GetRawResponse());
                return Response.FromValue(new PeerAsnResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PeerAsnResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peerAsnName"> The peer ASN name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peerAsnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peerAsnName"/> is null. </exception>
        public virtual NullableResponse<PeerAsnResource> GetIfExists(string peerAsnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peerAsnName, nameof(peerAsnName));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _peerAsnRestClient.Get(Id.SubscriptionId, peerAsnName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PeerAsnResource>(response.GetRawResponse());
                return Response.FromValue(new PeerAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PeerAsnResource> IEnumerable<PeerAsnResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PeerAsnResource> IAsyncEnumerable<PeerAsnResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
