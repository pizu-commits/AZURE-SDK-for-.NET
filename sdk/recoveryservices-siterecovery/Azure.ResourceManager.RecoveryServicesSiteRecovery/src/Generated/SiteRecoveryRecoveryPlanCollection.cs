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
    /// A class representing a collection of <see cref="SiteRecoveryRecoveryPlanResource"/> and their operations.
    /// Each <see cref="SiteRecoveryRecoveryPlanResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SiteRecoveryRecoveryPlanCollection"/> instance call the GetSiteRecoveryRecoveryPlans method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SiteRecoveryRecoveryPlanCollection : ArmCollection, IEnumerable<SiteRecoveryRecoveryPlanResource>, IAsyncEnumerable<SiteRecoveryRecoveryPlanResource>
    {
        private readonly ClientDiagnostics _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics;
        private readonly ReplicationRecoveryPlansRestOperations _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryRecoveryPlanCollection"/> class for mocking. </summary>
        protected SiteRecoveryRecoveryPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryRecoveryPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SiteRecoveryRecoveryPlanCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryRecoveryPlanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryRecoveryPlanResource.ResourceType, out string siteRecoveryRecoveryPlanReplicationRecoveryPlansApiVersion);
            _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient = new ReplicationRecoveryPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryRecoveryPlanReplicationRecoveryPlansApiVersion);
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
        /// The operation to create a recovery plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="recoveryPlanName"> Recovery plan name. </param>
        /// <param name="content"> Recovery Plan creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryRecoveryPlanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string recoveryPlanName, SiteRecoveryRecoveryPlanCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryRecoveryPlanResource>(new SiteRecoveryRecoveryPlanOperationSource(Client), _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create a recovery plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="recoveryPlanName"> Recovery plan name. </param>
        /// <param name="content"> Recovery Plan creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryRecoveryPlanResource> CreateOrUpdate(WaitUntil waitUntil, string recoveryPlanName, SiteRecoveryRecoveryPlanCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryRecoveryPlanResource>(new SiteRecoveryRecoveryPlanOperationSource(Client), _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the recovery plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryRecoveryPlanResource>> GetAsync(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryRecoveryPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the recovery plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual Response<SiteRecoveryRecoveryPlanResource> Get(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryRecoveryPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the recovery plans in the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryRecoveryPlanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryRecoveryPlanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryRecoveryPlanResource(Client, SiteRecoveryRecoveryPlanData.DeserializeSiteRecoveryRecoveryPlanData(e)), _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, "SiteRecoveryRecoveryPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the recovery plans in the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryRecoveryPlanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryRecoveryPlanResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryRecoveryPlanResource(Client, SiteRecoveryRecoveryPlanData.DeserializeSiteRecoveryRecoveryPlanData(e)), _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, "SiteRecoveryRecoveryPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryRecoveryPlanResource>> GetIfExistsAsync(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryRecoveryPlanResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryRecoveryPlanResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationRecoveryPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryRecoveryPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryRecoveryPlanResource> GetIfExists(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _siteRecoveryRecoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("SiteRecoveryRecoveryPlanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryRecoveryPlanReplicationRecoveryPlansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryRecoveryPlanResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryRecoveryPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryRecoveryPlanResource> IEnumerable<SiteRecoveryRecoveryPlanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryRecoveryPlanResource> IAsyncEnumerable<SiteRecoveryRecoveryPlanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
