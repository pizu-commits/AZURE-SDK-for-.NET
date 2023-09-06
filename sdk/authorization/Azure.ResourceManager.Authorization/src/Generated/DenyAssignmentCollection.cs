// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="DenyAssignmentResource" /> and their operations.
    /// Each <see cref="DenyAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="DenyAssignmentCollection" /> instance call the GetDenyAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class DenyAssignmentCollection : ArmCollection, IEnumerable<DenyAssignmentResource>, IAsyncEnumerable<DenyAssignmentResource>
    {
        private readonly ClientDiagnostics _denyAssignmentClientDiagnostics;
        private readonly DenyAssignmentsRestOperations _denyAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="DenyAssignmentCollection"/> class for mocking. </summary>
        protected DenyAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DenyAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DenyAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _denyAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", DenyAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DenyAssignmentResource.ResourceType, out string denyAssignmentApiVersion);
            _denyAssignmentRestClient = new DenyAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, denyAssignmentApiVersion);
        }

        /// <summary>
        /// Get the specified deny assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments/{denyAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="denyAssignmentId"> The ID of the deny assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="denyAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="denyAssignmentId"/> is null. </exception>
        public virtual async Task<Response<DenyAssignmentResource>> GetAsync(string denyAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(denyAssignmentId, nameof(denyAssignmentId));

            using var scope = _denyAssignmentClientDiagnostics.CreateScope("DenyAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _denyAssignmentRestClient.GetAsync(Id, denyAssignmentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DenyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified deny assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments/{denyAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="denyAssignmentId"> The ID of the deny assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="denyAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="denyAssignmentId"/> is null. </exception>
        public virtual Response<DenyAssignmentResource> Get(string denyAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(denyAssignmentId, nameof(denyAssignmentId));

            using var scope = _denyAssignmentClientDiagnostics.CreateScope("DenyAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _denyAssignmentRestClient.Get(Id, denyAssignmentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DenyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets deny assignments for a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_ListForResource</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_ListForResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_List</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all deny assignments at or above the scope. Use $filter=denyAssignmentName eq '{name}' to search deny assignments by name at specified scope. Use $filter=principalId eq '{id}' to return all deny assignments at, above and below the scope for the specified principal. Use $filter=gdprExportPrincipalId eq '{id}' to return all deny assignments at, above and below the scope for the specified principal. This filter is different from the principalId filter as it returns not only those deny assignments that contain the specified principal is the Principals list but also those deny assignments that contain the specified principal is the ExcludePrincipals list. Additionally, when gdprExportPrincipalId filter is used, only the deny assignment name and description properties are returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DenyAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DenyAssignmentResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListRequest(Id.SubscriptionId, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == "")
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListForScopeRequest(Id, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListForResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListForResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
        }

        /// <summary>
        /// Gets deny assignments for a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_ListForResource</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_ListForResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_List</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all deny assignments at or above the scope. Use $filter=denyAssignmentName eq '{name}' to search deny assignments by name at specified scope. Use $filter=principalId eq '{id}' to return all deny assignments at, above and below the scope for the specified principal. Use $filter=gdprExportPrincipalId eq '{id}' to return all deny assignments at, above and below the scope for the specified principal. This filter is different from the principalId filter as it returns not only those deny assignments that contain the specified principal is the Principals list but also those deny assignments that contain the specified principal is the ExcludePrincipals list. Additionally, when gdprExportPrincipalId filter is used, only the deny assignment name and description properties are returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DenyAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DenyAssignmentResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListRequest(Id.SubscriptionId, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == "")
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListForScopeRequest(Id, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _denyAssignmentRestClient.CreateListForResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _denyAssignmentRestClient.CreateListForResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DenyAssignmentResource(Client, DenyAssignmentData.DeserializeDenyAssignmentData(e)), _denyAssignmentClientDiagnostics, Pipeline, "DenyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments/{denyAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="denyAssignmentId"> The ID of the deny assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="denyAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="denyAssignmentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string denyAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(denyAssignmentId, nameof(denyAssignmentId));

            using var scope = _denyAssignmentClientDiagnostics.CreateScope("DenyAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _denyAssignmentRestClient.GetAsync(Id, denyAssignmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments/{denyAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="denyAssignmentId"> The ID of the deny assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="denyAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="denyAssignmentId"/> is null. </exception>
        public virtual Response<bool> Exists(string denyAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(denyAssignmentId, nameof(denyAssignmentId));

            using var scope = _denyAssignmentClientDiagnostics.CreateScope("DenyAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _denyAssignmentRestClient.Get(Id, denyAssignmentId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DenyAssignmentResource> IEnumerable<DenyAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DenyAssignmentResource> IAsyncEnumerable<DenyAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
