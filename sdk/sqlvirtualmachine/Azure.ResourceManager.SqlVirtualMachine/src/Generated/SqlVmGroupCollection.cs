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

namespace Azure.ResourceManager.SqlVirtualMachine
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlVmGroupResource" /> and their operations.
    /// Each <see cref="SqlVmGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SqlVmGroupCollection" /> instance call the GetSqlVmGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SqlVmGroupCollection : ArmCollection, IEnumerable<SqlVmGroupResource>, IAsyncEnumerable<SqlVmGroupResource>
    {
        private readonly ClientDiagnostics _sqlVmGroupSqlVmGroupsClientDiagnostics;
        private readonly SqlVirtualMachineGroupsRestOperations _sqlVmGroupSqlVmGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlVmGroupCollection"/> class for mocking. </summary>
        protected SqlVmGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlVmGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlVmGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlVmGroupSqlVmGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SqlVirtualMachine", SqlVmGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlVmGroupResource.ResourceType, out string sqlVmGroupSqlVmGroupsApiVersion);
            _sqlVmGroupSqlVmGroupsRestClient = new SqlVirtualMachineGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlVmGroupSqlVmGroupsApiVersion);
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
        /// Creates or updates a SQL virtual machine group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}
        /// Operation Id: SqlVirtualMachineGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="data"> The SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlVmGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sqlVmGroupName, SqlVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlVmGroupSqlVmGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlVirtualMachineArmOperation<SqlVmGroupResource>(new SqlVmGroupOperationSource(Client), _sqlVmGroupSqlVmGroupsClientDiagnostics, Pipeline, _sqlVmGroupSqlVmGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a SQL virtual machine group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}
        /// Operation Id: SqlVirtualMachineGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="data"> The SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlVmGroupResource> CreateOrUpdate(WaitUntil waitUntil, string sqlVmGroupName, SqlVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlVmGroupSqlVmGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data, cancellationToken);
                var operation = new SqlVirtualMachineArmOperation<SqlVmGroupResource>(new SqlVmGroupOperationSource(Client), _sqlVmGroupSqlVmGroupsClientDiagnostics, Pipeline, _sqlVmGroupSqlVmGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a SQL virtual machine group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}
        /// Operation Id: SqlVirtualMachineGroups_Get
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual async Task<Response<SqlVmGroupResource>> GetAsync(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlVmGroupSqlVmGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a SQL virtual machine group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}
        /// Operation Id: SqlVirtualMachineGroups_Get
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual Response<SqlVmGroupResource> Get(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlVmGroupSqlVmGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all SQL virtual machine groups in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups
        /// Operation Id: SqlVirtualMachineGroups_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlVmGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlVmGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlVmGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlVmGroupSqlVmGroupsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVmGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlVmGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlVmGroupSqlVmGroupsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVmGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all SQL virtual machine groups in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups
        /// Operation Id: SqlVirtualMachineGroups_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlVmGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlVmGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlVmGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlVmGroupSqlVmGroupsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVmGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlVmGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlVmGroupSqlVmGroupsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVmGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}
        /// Operation Id: SqlVirtualMachineGroups_Get
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlVmGroupSqlVmGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}
        /// Operation Id: SqlVirtualMachineGroups_Get
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));

            using var scope = _sqlVmGroupSqlVmGroupsClientDiagnostics.CreateScope("SqlVmGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlVmGroupSqlVmGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVmGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlVmGroupResource> IEnumerable<SqlVmGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlVmGroupResource> IAsyncEnumerable<SqlVmGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
