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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A class representing a collection of <see cref="CognitiveServicesCommitmentPlanResource" /> and their operations.
    /// Each <see cref="CognitiveServicesCommitmentPlanResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CognitiveServicesCommitmentPlanCollection" /> instance call the GetCognitiveServicesCommitmentPlans method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CognitiveServicesCommitmentPlanCollection : ArmCollection, IEnumerable<CognitiveServicesCommitmentPlanResource>, IAsyncEnumerable<CognitiveServicesCommitmentPlanResource>
    {
        private readonly ClientDiagnostics _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics;
        private readonly CommitmentPlansRestOperations _cognitiveServicesCommitmentPlanCommitmentPlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesCommitmentPlanCollection"/> class for mocking. </summary>
        protected CognitiveServicesCommitmentPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesCommitmentPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CognitiveServicesCommitmentPlanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesCommitmentPlanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CognitiveServicesCommitmentPlanResource.ResourceType, out string cognitiveServicesCommitmentPlanCommitmentPlansApiVersion);
            _cognitiveServicesCommitmentPlanCommitmentPlansRestClient = new CommitmentPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cognitiveServicesCommitmentPlanCommitmentPlansApiVersion);
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
        /// Create Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_CreateOrUpdatePlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="data"> The parameters to provide for the created commitment plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CognitiveServicesCommitmentPlanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string commitmentPlanName, CommitmentPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanName, nameof(commitmentPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateOrUpdatePlanAsync(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesCommitmentPlanResource>(new CognitiveServicesCommitmentPlanOperationSource(Client), _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateCreateOrUpdatePlanRequest(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_CreateOrUpdatePlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="data"> The parameters to provide for the created commitment plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CognitiveServicesCommitmentPlanResource> CreateOrUpdate(WaitUntil waitUntil, string commitmentPlanName, CommitmentPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanName, nameof(commitmentPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateOrUpdatePlan(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, data, cancellationToken);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesCommitmentPlanResource>(new CognitiveServicesCommitmentPlanOperationSource(Client), _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateCreateOrUpdatePlanRequest(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns a Cognitive Services commitment plan specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> is null. </exception>
        public virtual async Task<Response<CognitiveServicesCommitmentPlanResource>> GetAsync(string commitmentPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanName, nameof(commitmentPlanName));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlanAsync(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Cognitive Services commitment plan specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> is null. </exception>
        public virtual Response<CognitiveServicesCommitmentPlanResource> Get(string commitmentPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanName, nameof(commitmentPlanName));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlan(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_ListPlansByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesCommitmentPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesCommitmentPlanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesCommitmentPlanResource(Client, CommitmentPlanData.DeserializeCommitmentPlanData(e)), _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, "CognitiveServicesCommitmentPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_ListPlansByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesCommitmentPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesCommitmentPlanResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesCommitmentPlanResource(Client, CommitmentPlanData.DeserializeCommitmentPlanData(e)), _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, "CognitiveServicesCommitmentPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string commitmentPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanName, nameof(commitmentPlanName));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlanAsync(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string commitmentPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanName, nameof(commitmentPlanName));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlan(Id.SubscriptionId, Id.ResourceGroupName, commitmentPlanName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CognitiveServicesCommitmentPlanResource> IEnumerable<CognitiveServicesCommitmentPlanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CognitiveServicesCommitmentPlanResource> IAsyncEnumerable<CognitiveServicesCommitmentPlanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
