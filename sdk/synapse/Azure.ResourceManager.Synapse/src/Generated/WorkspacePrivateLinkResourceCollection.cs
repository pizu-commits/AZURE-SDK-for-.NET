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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkspacePrivateLinkResource" /> and their operations.
    /// Each <see cref="WorkspacePrivateLinkResource" /> in the collection will belong to the same instance of <see cref="WorkspaceResource" />.
    /// To get a <see cref="WorkspacePrivateLinkResourceCollection" /> instance call the GetWorkspacePrivateLinkResources method from an instance of <see cref="WorkspaceResource" />.
    /// </summary>
    public partial class WorkspacePrivateLinkResourceCollection : ArmCollection, IEnumerable<WorkspacePrivateLinkResource>, IAsyncEnumerable<WorkspacePrivateLinkResource>
    {
        private readonly ClientDiagnostics _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _workspacePrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkspacePrivateLinkResourceCollection"/> class for mocking. </summary>
        protected WorkspacePrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspacePrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkspacePrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", WorkspacePrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkspacePrivateLinkResource.ResourceType, out string workspacePrivateLinkResourcePrivateLinkResourcesApiVersion);
            _workspacePrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workspacePrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get private link resource in workspace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<WorkspacePrivateLinkResource>> GetAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get private link resource in workspace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<WorkspacePrivateLinkResource> Get(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all private link resources for a workspaces
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkspacePrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkspacePrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkspacePrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkspacePrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkspacePrivateLinkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkspacePrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get all private link resources for a workspaces
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkspacePrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkspacePrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WorkspacePrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkspacePrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkspacePrivateLinkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkspacePrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _workspacePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("WorkspacePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _workspacePrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkspacePrivateLinkResource> IEnumerable<WorkspacePrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkspacePrivateLinkResource> IAsyncEnumerable<WorkspacePrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
