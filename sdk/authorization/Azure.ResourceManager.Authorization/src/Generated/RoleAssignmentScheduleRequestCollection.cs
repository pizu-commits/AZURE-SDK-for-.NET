// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleAssignmentScheduleRequestResource" /> and their operations.
    /// Each <see cref="RoleAssignmentScheduleRequestResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleAssignmentScheduleRequestCollection" /> instance call the GetRoleAssignmentScheduleRequests method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleAssignmentScheduleRequestCollection : ArmCollection, IEnumerable<RoleAssignmentScheduleRequestResource>, IAsyncEnumerable<RoleAssignmentScheduleRequestResource>
    {
        private readonly ClientDiagnostics _roleAssignmentScheduleRequestClientDiagnostics;
        private readonly RoleAssignmentScheduleRequestsRestOperations _roleAssignmentScheduleRequestRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleRequestCollection"/> class for mocking. </summary>
        protected RoleAssignmentScheduleRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleRequestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleAssignmentScheduleRequestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentScheduleRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleAssignmentScheduleRequestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleAssignmentScheduleRequestResource.ResourceType, out string roleAssignmentScheduleRequestApiVersion);
            _roleAssignmentScheduleRequestRestClient = new RoleAssignmentScheduleRequestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentScheduleRequestApiVersion);
        }

        /// <summary>
        /// Creates a role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentScheduleRequestName"> A GUID for the role assignment to create. The name must be unique and different for each role assignment. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleAssignmentScheduleRequestResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.CreateAsync(Id, roleAssignmentScheduleRequestName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<RoleAssignmentScheduleRequestResource>(Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response), response.GetRawResponse()));
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
        /// Creates a role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentScheduleRequestName"> A GUID for the role assignment to create. The name must be unique and different for each role assignment. </param>
        /// <param name="data"> Parameters for the role assignment schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoleAssignmentScheduleRequestResource> CreateOrUpdate(WaitUntil waitUntil, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Create(Id, roleAssignmentScheduleRequestName, data, cancellationToken);
                var operation = new AuthorizationArmOperation<RoleAssignmentScheduleRequestResource>(Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response), response.GetRawResponse()));
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
        /// Get the specified role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual async Task<Response<RoleAssignmentScheduleRequestResource>> GetAsync(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.GetAsync(Id, roleAssignmentScheduleRequestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual Response<RoleAssignmentScheduleRequestResource> Get(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Get(Id, roleAssignmentScheduleRequestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role assignment schedule requests for a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleAssignmentScheduleRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleAssignmentScheduleRequestResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleAssignmentScheduleRequestRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleAssignmentScheduleRequestRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RoleAssignmentScheduleRequestResource(Client, RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(e)), _roleAssignmentScheduleRequestClientDiagnostics, Pipeline, "RoleAssignmentScheduleRequestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets role assignment schedule requests for a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleAssignmentScheduleRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleAssignmentScheduleRequestResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleAssignmentScheduleRequestRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleAssignmentScheduleRequestRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RoleAssignmentScheduleRequestResource(Client, RoleAssignmentScheduleRequestData.DeserializeRoleAssignmentScheduleRequestData(e)), _roleAssignmentScheduleRequestClientDiagnostics, Pipeline, "RoleAssignmentScheduleRequestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.GetAsync(Id, roleAssignmentScheduleRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Get(Id, roleAssignmentScheduleRequestName, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual async Task<NullableResponse<RoleAssignmentScheduleRequestResource>> GetIfExistsAsync(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestRestClient.GetAsync(Id, roleAssignmentScheduleRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RoleAssignmentScheduleRequestResource>(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual NullableResponse<RoleAssignmentScheduleRequestResource> GetIfExists(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleRequestName, nameof(roleAssignmentScheduleRequestName));

            using var scope = _roleAssignmentScheduleRequestClientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestRestClient.Get(Id, roleAssignmentScheduleRequestName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RoleAssignmentScheduleRequestResource>(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleAssignmentScheduleRequestResource> IEnumerable<RoleAssignmentScheduleRequestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleAssignmentScheduleRequestResource> IAsyncEnumerable<RoleAssignmentScheduleRequestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
