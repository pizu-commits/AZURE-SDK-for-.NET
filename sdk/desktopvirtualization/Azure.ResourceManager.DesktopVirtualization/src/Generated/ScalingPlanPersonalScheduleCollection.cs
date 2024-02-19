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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="ScalingPlanPersonalScheduleResource"/> and their operations.
    /// Each <see cref="ScalingPlanPersonalScheduleResource"/> in the collection will belong to the same instance of <see cref="ScalingPlanResource"/>.
    /// To get a <see cref="ScalingPlanPersonalScheduleCollection"/> instance call the GetScalingPlanPersonalSchedules method from an instance of <see cref="ScalingPlanResource"/>.
    /// </summary>
    public partial class ScalingPlanPersonalScheduleCollection : ArmCollection, IEnumerable<ScalingPlanPersonalScheduleResource>, IAsyncEnumerable<ScalingPlanPersonalScheduleResource>
    {
        private readonly ClientDiagnostics _scalingPlanPersonalScheduleClientDiagnostics;
        private readonly ScalingPlanPersonalSchedulesRestOperations _scalingPlanPersonalScheduleRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScalingPlanPersonalScheduleCollection"/> class for mocking. </summary>
        protected ScalingPlanPersonalScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScalingPlanPersonalScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScalingPlanPersonalScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scalingPlanPersonalScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ScalingPlanPersonalScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScalingPlanPersonalScheduleResource.ResourceType, out string scalingPlanPersonalScheduleApiVersion);
            _scalingPlanPersonalScheduleRestClient = new ScalingPlanPersonalSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scalingPlanPersonalScheduleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ScalingPlanResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ScalingPlanResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a ScalingPlanPersonalSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="data"> Object containing ScalingPlanPersonalSchedule definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScalingPlanPersonalScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scalingPlanScheduleName, ScalingPlanPersonalScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scalingPlanPersonalScheduleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, data, cancellationToken).ConfigureAwait(false);
                var uri = _scalingPlanPersonalScheduleRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<ScalingPlanPersonalScheduleResource>(Response.FromValue(new ScalingPlanPersonalScheduleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update a ScalingPlanPersonalSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="data"> Object containing ScalingPlanPersonalSchedule definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScalingPlanPersonalScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string scalingPlanScheduleName, ScalingPlanPersonalScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scalingPlanPersonalScheduleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, data, cancellationToken);
                var uri = _scalingPlanPersonalScheduleRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<ScalingPlanPersonalScheduleResource>(Response.FromValue(new ScalingPlanPersonalScheduleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get a ScalingPlanPersonalSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual async Task<Response<ScalingPlanPersonalScheduleResource>> GetAsync(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _scalingPlanPersonalScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPersonalScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ScalingPlanPersonalSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual Response<ScalingPlanPersonalScheduleResource> Get(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _scalingPlanPersonalScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPersonalScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List ScalingPlanPersonalSchedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScalingPlanPersonalScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScalingPlanPersonalScheduleResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scalingPlanPersonalScheduleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scalingPlanPersonalScheduleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScalingPlanPersonalScheduleResource(Client, ScalingPlanPersonalScheduleData.DeserializeScalingPlanPersonalScheduleData(e)), _scalingPlanPersonalScheduleClientDiagnostics, Pipeline, "ScalingPlanPersonalScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ScalingPlanPersonalSchedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScalingPlanPersonalScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScalingPlanPersonalScheduleResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scalingPlanPersonalScheduleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scalingPlanPersonalScheduleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScalingPlanPersonalScheduleResource(Client, ScalingPlanPersonalScheduleData.DeserializeScalingPlanPersonalScheduleData(e)), _scalingPlanPersonalScheduleClientDiagnostics, Pipeline, "ScalingPlanPersonalScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scalingPlanPersonalScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _scalingPlanPersonalScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScalingPlanPersonalScheduleResource>> GetIfExistsAsync(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scalingPlanPersonalScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScalingPlanPersonalScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPersonalScheduleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/personalSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPersonalSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanPersonalScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual NullableResponse<ScalingPlanPersonalScheduleResource> GetIfExists(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPersonalScheduleClientDiagnostics.CreateScope("ScalingPlanPersonalScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scalingPlanPersonalScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScalingPlanPersonalScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPersonalScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScalingPlanPersonalScheduleResource> IEnumerable<ScalingPlanPersonalScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScalingPlanPersonalScheduleResource> IAsyncEnumerable<ScalingPlanPersonalScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
