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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadGroupResource"/> and their operations.
    /// Each <see cref="WorkloadGroupResource"/> in the collection will belong to the same instance of <see cref="SqlDatabaseResource"/>.
    /// To get a <see cref="WorkloadGroupCollection"/> instance call the GetWorkloadGroups method from an instance of <see cref="SqlDatabaseResource"/>.
    /// </summary>
    public partial class WorkloadGroupCollection : ArmCollection, IEnumerable<WorkloadGroupResource>, IAsyncEnumerable<WorkloadGroupResource>
    {
        private readonly ClientDiagnostics _workloadGroupClientDiagnostics;
        private readonly WorkloadGroupsRestOperations _workloadGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadGroupCollection"/> class for mocking. </summary>
        protected WorkloadGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", WorkloadGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadGroupResource.ResourceType, out string workloadGroupApiVersion);
            _workloadGroupRestClient = new WorkloadGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workloadGroupName, WorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<WorkloadGroupResource>(new WorkloadGroupOperationSource(Client), _workloadGroupClientDiagnostics, Pipeline, _workloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadGroupResource> CreateOrUpdate(WaitUntil waitUntil, string workloadGroupName, WorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<WorkloadGroupResource>(new WorkloadGroupOperationSource(Client), _workloadGroupClientDiagnostics, Pipeline, _workloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a workload group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual async Task<Response<WorkloadGroupResource>> GetAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workload group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<WorkloadGroupResource> Get(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of workload groups
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadGroupRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadGroupRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkloadGroupResource(Client, WorkloadGroupData.DeserializeWorkloadGroupData(e)), _workloadGroupClientDiagnostics, Pipeline, "WorkloadGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of workload groups
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadGroupRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadGroupRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkloadGroupResource(Client, WorkloadGroupData.DeserializeWorkloadGroupData(e)), _workloadGroupClientDiagnostics, Pipeline, "WorkloadGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkloadGroupResource>> GetIfExistsAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadGroupResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkloadGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual NullableResponse<WorkloadGroupResource> GetIfExists(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadGroupResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadGroupResource> IEnumerable<WorkloadGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadGroupResource> IAsyncEnumerable<WorkloadGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
