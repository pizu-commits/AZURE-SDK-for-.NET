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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteCircuitPeering and their operations over its parent. </summary>
    public partial class ExpressRouteCircuitPeeringCollection : ArmCollection, IEnumerable<ExpressRouteCircuitPeering>, IAsyncEnumerable<ExpressRouteCircuitPeering>
    {
        private readonly ClientDiagnostics _expressRouteCircuitPeeringClientDiagnostics;
        private readonly ExpressRouteCircuitPeeringsRestOperations _expressRouteCircuitPeeringRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeeringCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeeringCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteCircuitPeeringCollection(ArmResource parent) : base(parent)
        {
            _expressRouteCircuitPeeringClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuitPeering.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ExpressRouteCircuitPeering.ResourceType, out string expressRouteCircuitPeeringApiVersion);
            _expressRouteCircuitPeeringRestClient = new ExpressRouteCircuitPeeringsRestOperations(_expressRouteCircuitPeeringClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteCircuitPeeringApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuit.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuit.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a peering in the specified express route circuits. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update express route circuit peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public virtual ExpressRouteCircuitPeeringCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string peeringName, ExpressRouteCircuitPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken);
                var operation = new ExpressRouteCircuitPeeringCreateOrUpdateOperation(ArmClient, _expressRouteCircuitPeeringClientDiagnostics, Pipeline, _expressRouteCircuitPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response);
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

        /// <summary> Creates or updates a peering in the specified express route circuits. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update express route circuit peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteCircuitPeeringCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string peeringName, ExpressRouteCircuitPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitPeeringCreateOrUpdateOperation(ArmClient, _expressRouteCircuitPeeringClientDiagnostics, Pipeline, _expressRouteCircuitPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response);
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

        /// <summary> Gets the specified peering for the express route circuit. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitPeering> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken);
                if (response.Value == null)
                    throw _expressRouteCircuitPeeringClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeering(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified peering for the express route circuit. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuitPeering>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _expressRouteCircuitPeeringClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuitPeering(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitPeering> GetIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuitPeering>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeering(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuitPeering>> GetIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuitPeering>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeering(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<bool> Exists(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(peeringName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all peerings in a specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCircuitPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitPeeringRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitPeering(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuitPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitPeeringRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitPeering(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all peerings in a specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCircuitPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitPeeringRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitPeering(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuitPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitPeeringClientDiagnostics.CreateScope("ExpressRouteCircuitPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitPeeringRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitPeering(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ExpressRouteCircuitPeering> IEnumerable<ExpressRouteCircuitPeering>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitPeering> IAsyncEnumerable<ExpressRouteCircuitPeering>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
