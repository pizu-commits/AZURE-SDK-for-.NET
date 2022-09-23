// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _labClientDiagnostics;
        private LabsRestOperations _labRestClient;
        private ClientDiagnostics _scheduleGlobalSchedulesClientDiagnostics;
        private GlobalSchedulesRestOperations _scheduleGlobalSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LabClientDiagnostics => _labClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", LabResource.ResourceType.Namespace, Diagnostics);
        private LabsRestOperations LabRestClient => _labRestClient ??= new LabsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LabResource.ResourceType));
        private ClientDiagnostics ScheduleGlobalSchedulesClientDiagnostics => _scheduleGlobalSchedulesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", ScheduleResource.ResourceType.Namespace, Diagnostics);
        private GlobalSchedulesRestOperations ScheduleGlobalSchedulesRestClient => _scheduleGlobalSchedulesRestClient ??= new GlobalSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ScheduleResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List labs in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/labs
        /// Operation Id: Labs_ListBySubscription
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=defaultStorageAccount)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabResource> GetLabsAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<LabResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LabClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLabs");
                scope.Start();
                try
                {
                    var response = await LabRestClient.ListBySubscriptionAsync(Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LabResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = LabClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLabs");
                scope.Start();
                try
                {
                    var response = await LabRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List labs in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/labs
        /// Operation Id: Labs_ListBySubscription
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=defaultStorageAccount)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabResource> GetLabs(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Page<LabResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LabClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLabs");
                scope.Start();
                try
                {
                    var response = LabRestClient.ListBySubscription(Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LabResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = LabClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLabs");
                scope.Start();
                try
                {
                    var response = LabRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List schedules in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/schedules
        /// Operation Id: GlobalSchedules_ListBySubscription
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BaseScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BaseScheduleResource> GetSchedulesAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BaseScheduleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ScheduleGlobalSchedulesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSchedules");
                scope.Start();
                try
                {
                    var response = await ScheduleGlobalSchedulesRestClient.ListBySubscriptionAsync(Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => BaseScheduleResource.GetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BaseScheduleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ScheduleGlobalSchedulesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSchedules");
                scope.Start();
                try
                {
                    var response = await ScheduleGlobalSchedulesRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => BaseScheduleResource.GetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List schedules in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/schedules
        /// Operation Id: GlobalSchedules_ListBySubscription
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BaseScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BaseScheduleResource> GetSchedules(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Page<BaseScheduleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ScheduleGlobalSchedulesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSchedules");
                scope.Start();
                try
                {
                    var response = ScheduleGlobalSchedulesRestClient.ListBySubscription(Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => BaseScheduleResource.GetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BaseScheduleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ScheduleGlobalSchedulesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSchedules");
                scope.Start();
                try
                {
                    var response = ScheduleGlobalSchedulesRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => BaseScheduleResource.GetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
