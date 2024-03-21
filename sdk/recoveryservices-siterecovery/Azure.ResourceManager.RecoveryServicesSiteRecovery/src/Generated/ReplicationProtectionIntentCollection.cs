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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="ReplicationProtectionIntentResource"/> and their operations.
    /// Each <see cref="ReplicationProtectionIntentResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ReplicationProtectionIntentCollection"/> instance call the GetReplicationProtectionIntents method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ReplicationProtectionIntentCollection : ArmCollection, IEnumerable<ReplicationProtectionIntentResource>, IAsyncEnumerable<ReplicationProtectionIntentResource>
    {
        private readonly ClientDiagnostics _replicationProtectionIntentClientDiagnostics;
        private readonly ReplicationProtectionIntentsRestOperations _replicationProtectionIntentRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="ReplicationProtectionIntentCollection"/> class for mocking. </summary>
        protected ReplicationProtectionIntentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReplicationProtectionIntentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ReplicationProtectionIntentCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _replicationProtectionIntentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ReplicationProtectionIntentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReplicationProtectionIntentResource.ResourceType, out string replicationProtectionIntentApiVersion);
            _replicationProtectionIntentRestClient = new ReplicationProtectionIntentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, replicationProtectionIntentApiVersion);
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
        /// The operation to create an ASR replication protection intent item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="intentObjectName"> A name for the replication protection item. </param>
        /// <param name="content"> Create Protection Intent Input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ReplicationProtectionIntentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string intentObjectName, ReplicationProtectionIntentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _replicationProtectionIntentRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<ReplicationProtectionIntentResource>(Response.FromValue(new ReplicationProtectionIntentResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create an ASR replication protection intent item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="intentObjectName"> A name for the replication protection item. </param>
        /// <param name="content"> Create Protection Intent Input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ReplicationProtectionIntentResource> CreateOrUpdate(WaitUntil waitUntil, string intentObjectName, ReplicationProtectionIntentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _replicationProtectionIntentRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<ReplicationProtectionIntentResource>(Response.FromValue(new ReplicationProtectionIntentResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of an ASR replication protection intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="intentObjectName"> Replication protection intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> is null. </exception>
        public virtual async Task<Response<ReplicationProtectionIntentResource>> GetAsync(string intentObjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.Get");
            scope.Start();
            try
            {
                var response = await _replicationProtectionIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReplicationProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of an ASR replication protection intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="intentObjectName"> Replication protection intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> is null. </exception>
        public virtual Response<ReplicationProtectionIntentResource> Get(string intentObjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.Get");
            scope.Start();
            try
            {
                var response = _replicationProtectionIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReplicationProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of ASR replication protection intent objects in the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The pagination token. </param>
        /// <param name="takeToken"> The page size. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReplicationProtectionIntentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReplicationProtectionIntentResource> GetAllAsync(string skipToken = null, string takeToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicationProtectionIntentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, skipToken, takeToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _replicationProtectionIntentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, skipToken, takeToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReplicationProtectionIntentResource(Client, ReplicationProtectionIntentData.DeserializeReplicationProtectionIntentData(e)), _replicationProtectionIntentClientDiagnostics, Pipeline, "ReplicationProtectionIntentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of ASR replication protection intent objects in the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The pagination token. </param>
        /// <param name="takeToken"> The page size. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReplicationProtectionIntentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReplicationProtectionIntentResource> GetAll(string skipToken = null, string takeToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicationProtectionIntentRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, skipToken, takeToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _replicationProtectionIntentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, skipToken, takeToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReplicationProtectionIntentResource(Client, ReplicationProtectionIntentData.DeserializeReplicationProtectionIntentData(e)), _replicationProtectionIntentClientDiagnostics, Pipeline, "ReplicationProtectionIntentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="intentObjectName"> Replication protection intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string intentObjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _replicationProtectionIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="intentObjectName"> Replication protection intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> is null. </exception>
        public virtual Response<bool> Exists(string intentObjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = _replicationProtectionIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="intentObjectName"> Replication protection intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> is null. </exception>
        public virtual async Task<NullableResponse<ReplicationProtectionIntentResource>> GetIfExistsAsync(string intentObjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _replicationProtectionIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ReplicationProtectionIntentResource>(response.GetRawResponse());
                return Response.FromValue(new ReplicationProtectionIntentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="intentObjectName"> Replication protection intent name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="intentObjectName"/> is null. </exception>
        public virtual NullableResponse<ReplicationProtectionIntentResource> GetIfExists(string intentObjectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(intentObjectName, nameof(intentObjectName));

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _replicationProtectionIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, intentObjectName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ReplicationProtectionIntentResource>(response.GetRawResponse());
                return Response.FromValue(new ReplicationProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ReplicationProtectionIntentResource> IEnumerable<ReplicationProtectionIntentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ReplicationProtectionIntentResource> IAsyncEnumerable<ReplicationProtectionIntentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
