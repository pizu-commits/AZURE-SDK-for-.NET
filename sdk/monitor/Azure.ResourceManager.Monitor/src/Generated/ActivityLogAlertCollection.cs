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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="ActivityLogAlertResource"/> and their operations.
    /// Each <see cref="ActivityLogAlertResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="ActivityLogAlertCollection"/> instance call the GetActivityLogAlerts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ActivityLogAlertCollection : ArmCollection, IEnumerable<ActivityLogAlertResource>, IAsyncEnumerable<ActivityLogAlertResource>
    {
        private readonly ClientDiagnostics _activityLogAlertClientDiagnostics;
        private readonly ActivityLogAlertsRestOperations _activityLogAlertRestClient;

        /// <summary> Initializes a new instance of the <see cref="ActivityLogAlertCollection"/> class for mocking. </summary>
        protected ActivityLogAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ActivityLogAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ActivityLogAlertCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _activityLogAlertClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ActivityLogAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ActivityLogAlertResource.ResourceType, out string activityLogAlertApiVersion);
            _activityLogAlertRestClient = new ActivityLogAlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, activityLogAlertApiVersion);
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
        /// Create a new Activity Log Alert rule or update an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="data"> The Activity Log Alert rule to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ActivityLogAlertResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string activityLogAlertName, ActivityLogAlertData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _activityLogAlertRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, data, cancellationToken).ConfigureAwait(false);
                var uri = _activityLogAlertRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MonitorArmOperation<ActivityLogAlertResource>(Response.FromValue(new ActivityLogAlertResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a new Activity Log Alert rule or update an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="data"> The Activity Log Alert rule to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ActivityLogAlertResource> CreateOrUpdate(WaitUntil waitUntil, string activityLogAlertName, ActivityLogAlertData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _activityLogAlertRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, data, cancellationToken);
                var uri = _activityLogAlertRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MonitorArmOperation<ActivityLogAlertResource>(Response.FromValue(new ActivityLogAlertResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get an Activity Log Alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual async Task<Response<ActivityLogAlertResource>> GetAsync(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _activityLogAlertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ActivityLogAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an Activity Log Alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual Response<ActivityLogAlertResource> Get(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _activityLogAlertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ActivityLogAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all Activity Log Alert rules in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ActivityLogAlertResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ActivityLogAlertResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _activityLogAlertRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _activityLogAlertRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ActivityLogAlertResource(Client, ActivityLogAlertData.DeserializeActivityLogAlertData(e)), _activityLogAlertClientDiagnostics, Pipeline, "ActivityLogAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all Activity Log Alert rules in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ActivityLogAlertResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ActivityLogAlertResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _activityLogAlertRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _activityLogAlertRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ActivityLogAlertResource(Client, ActivityLogAlertData.DeserializeActivityLogAlertData(e)), _activityLogAlertClientDiagnostics, Pipeline, "ActivityLogAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _activityLogAlertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual Response<bool> Exists(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _activityLogAlertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual async Task<NullableResponse<ActivityLogAlertResource>> GetIfExistsAsync(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _activityLogAlertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ActivityLogAlertResource>(response.GetRawResponse());
                return Response.FromValue(new ActivityLogAlertResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/activityLogAlerts/{activityLogAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActivityLogAlerts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActivityLogAlertResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="activityLogAlertName"> The name of the Activity Log Alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="activityLogAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual NullableResponse<ActivityLogAlertResource> GetIfExists(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(activityLogAlertName, nameof(activityLogAlertName));

            using var scope = _activityLogAlertClientDiagnostics.CreateScope("ActivityLogAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _activityLogAlertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ActivityLogAlertResource>(response.GetRawResponse());
                return Response.FromValue(new ActivityLogAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ActivityLogAlertResource> IEnumerable<ActivityLogAlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ActivityLogAlertResource> IAsyncEnumerable<ActivityLogAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
