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

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="ScVmmServerResource" /> and their operations.
    /// Each <see cref="ScVmmServerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ScVmmServerCollection" /> instance call the GetScVmmServers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ScVmmServerCollection : ArmCollection, IEnumerable<ScVmmServerResource>, IAsyncEnumerable<ScVmmServerResource>
    {
        private readonly ClientDiagnostics _scVmmServerVmmServersClientDiagnostics;
        private readonly VmmServersRestOperations _scVmmServerVmmServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScVmmServerCollection"/> class for mocking. </summary>
        protected ScVmmServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScVmmServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScVmmServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scVmmServerVmmServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ArcScVmm", ScVmmServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScVmmServerResource.ResourceType, out string scVmmServerVmmServersApiVersion);
            _scVmmServerVmmServersRestClient = new VmmServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scVmmServerVmmServersApiVersion);
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
        /// Onboards the SCVMM fabric as an Azure VmmServer resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScVmmServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmmServerName, ScVmmServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmmServerName, nameof(vmmServerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scVmmServerVmmServersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ArcScVmmArmOperation<ScVmmServerResource>(new ScVmmServerOperationSource(Client), _scVmmServerVmmServersClientDiagnostics, Pipeline, _scVmmServerVmmServersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Onboards the SCVMM fabric as an Azure VmmServer resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScVmmServerResource> CreateOrUpdate(WaitUntil waitUntil, string vmmServerName, ScVmmServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmmServerName, nameof(vmmServerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scVmmServerVmmServersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, data, cancellationToken);
                var operation = new ArcScVmmArmOperation<ScVmmServerResource>(new ScVmmServerOperationSource(Client), _scVmmServerVmmServersClientDiagnostics, Pipeline, _scVmmServerVmmServersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements VMMServer GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_Get
        /// </summary>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        public virtual async Task<Response<ScVmmServerResource>> GetAsync(string vmmServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmmServerName, nameof(vmmServerName));

            using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _scVmmServerVmmServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements VMMServer GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_Get
        /// </summary>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        public virtual Response<ScVmmServerResource> Get(string vmmServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmmServerName, nameof(vmmServerName));

            using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.Get");
            scope.Start();
            try
            {
                var response = _scVmmServerVmmServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of VmmServers in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers
        /// Operation Id: VmmServers_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScVmmServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ScVmmServerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scVmmServerVmmServersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScVmmServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ScVmmServerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scVmmServerVmmServersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScVmmServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List of VmmServers in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers
        /// Operation Id: VmmServers_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScVmmServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ScVmmServerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scVmmServerVmmServersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScVmmServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ScVmmServerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scVmmServerVmmServersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScVmmServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_Get
        /// </summary>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmmServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmmServerName, nameof(vmmServerName));

            using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scVmmServerVmmServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_Get
        /// </summary>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmmServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmmServerName, nameof(vmmServerName));

            using var scope = _scVmmServerVmmServersClientDiagnostics.CreateScope("ScVmmServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _scVmmServerVmmServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmmServerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScVmmServerResource> IEnumerable<ScVmmServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScVmmServerResource> IAsyncEnumerable<ScVmmServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
