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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SyncAgentResource"/> and their operations.
    /// Each <see cref="SyncAgentResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SyncAgentCollection"/> instance call the GetSyncAgents method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SyncAgentCollection : ArmCollection, IEnumerable<SyncAgentResource>, IAsyncEnumerable<SyncAgentResource>
    {
        private readonly ClientDiagnostics _syncAgentClientDiagnostics;
        private readonly SyncAgentsRestOperations _syncAgentRestClient;

        /// <summary> Initializes a new instance of the <see cref="SyncAgentCollection"/> class for mocking. </summary>
        protected SyncAgentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SyncAgentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SyncAgentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SyncAgentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SyncAgentResource.ResourceType, out string syncAgentApiVersion);
            _syncAgentRestClient = new SyncAgentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, syncAgentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a sync agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="data"> The requested sync agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SyncAgentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string syncAgentName, SyncAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _syncAgentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SyncAgentResource>(new SyncAgentOperationSource(Client), _syncAgentClientDiagnostics, Pipeline, _syncAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a sync agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="data"> The requested sync agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SyncAgentResource> CreateOrUpdate(WaitUntil waitUntil, string syncAgentName, SyncAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _syncAgentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, data, cancellationToken);
                var operation = new SqlArmOperation<SyncAgentResource>(new SyncAgentOperationSource(Client), _syncAgentClientDiagnostics, Pipeline, _syncAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a sync agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual async Task<Response<SyncAgentResource>> GetAsync(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Get");
            scope.Start();
            try
            {
                var response = await _syncAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a sync agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual Response<SyncAgentResource> Get(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Get");
            scope.Start();
            try
            {
                var response = _syncAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists sync agents in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncAgentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncAgentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncAgentRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncAgentRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SyncAgentResource(Client, SyncAgentData.DeserializeSyncAgentData(e)), _syncAgentClientDiagnostics, Pipeline, "SyncAgentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists sync agents in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncAgentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncAgentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncAgentRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncAgentRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SyncAgentResource(Client, SyncAgentData.DeserializeSyncAgentData(e)), _syncAgentClientDiagnostics, Pipeline, "SyncAgentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _syncAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual Response<bool> Exists(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = _syncAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual async Task<NullableResponse<SyncAgentResource>> GetIfExistsAsync(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _syncAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SyncAgentResource>(response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual NullableResponse<SyncAgentResource> GetIfExists(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _syncAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SyncAgentResource>(response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SyncAgentResource> IEnumerable<SyncAgentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SyncAgentResource> IAsyncEnumerable<SyncAgentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
