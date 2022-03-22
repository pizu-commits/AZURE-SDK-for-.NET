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
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing collection of HostPool and their operations over its parent. </summary>
    public partial class HostPoolCollection : ArmCollection, IEnumerable<HostPoolResource>, IAsyncEnumerable<HostPoolResource>
    {
        private readonly ClientDiagnostics _hostPoolClientDiagnostics;
        private readonly HostPoolsRestOperations _hostPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostPoolCollection"/> class for mocking. </summary>
        protected HostPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HostPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", HostPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HostPoolResource.ResourceType, out string hostPoolApiVersion);
            _hostPoolRestClient = new HostPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostPoolApiVersion);
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
        /// Create or update a host pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="hostPool"> Object containing HostPool definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> or <paramref name="hostPool"/> is null. </exception>
        public virtual async Task<ArmOperation<HostPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hostPoolName, HostPoolData hostPool, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(hostPool, nameof(hostPool));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hostPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, hostPool, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<HostPoolResource>(Response.FromValue(new HostPoolResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a host pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="hostPool"> Object containing HostPool definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> or <paramref name="hostPool"/> is null. </exception>
        public virtual ArmOperation<HostPoolResource> CreateOrUpdate(WaitUntil waitUntil, string hostPoolName, HostPoolData hostPool, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(hostPool, nameof(hostPool));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hostPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, hostPool, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<HostPoolResource>(Response.FromValue(new HostPoolResource(Client, response), response.GetRawResponse()));
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
        /// Get a host pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_Get
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual async Task<Response<HostPoolResource>> GetAsync(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _hostPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a host pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_Get
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual Response<HostPoolResource> Get(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _hostPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List hostPools.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools
        /// Operation Id: HostPools_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HostPoolResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hostPoolRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HostPoolResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hostPoolRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List hostPools.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools
        /// Operation Id: HostPools_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HostPoolResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hostPoolRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HostPoolResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hostPoolRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_Get
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_Get
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostPoolName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_Get
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual async Task<Response<HostPoolResource>> GetIfExistsAsync(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hostPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<HostPoolResource>(null, response.GetRawResponse());
                return Response.FromValue(new HostPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}
        /// Operation Id: HostPools_Get
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual Response<HostPoolResource> GetIfExists(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hostPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<HostPoolResource>(null, response.GetRawResponse());
                return Response.FromValue(new HostPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HostPoolResource> IEnumerable<HostPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostPoolResource> IAsyncEnumerable<HostPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
