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

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A class representing a collection of <see cref="LabServicesScheduleResource" /> and their operations.
    /// Each <see cref="LabServicesScheduleResource" /> in the collection will belong to the same instance of <see cref="LabResource" />.
    /// To get a <see cref="LabServicesScheduleCollection" /> instance call the GetLabServicesSchedules method from an instance of <see cref="LabResource" />.
    /// </summary>
    public partial class LabServicesScheduleCollection : ArmCollection, IEnumerable<LabServicesScheduleResource>, IAsyncEnumerable<LabServicesScheduleResource>
    {
        private readonly ClientDiagnostics _labServicesScheduleSchedulesClientDiagnostics;
        private readonly SchedulesRestOperations _labServicesScheduleSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LabServicesScheduleCollection"/> class for mocking. </summary>
        protected LabServicesScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabServicesScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LabServicesScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labServicesScheduleSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LabServices", LabServicesScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LabServicesScheduleResource.ResourceType, out string labServicesScheduleSchedulesApiVersion);
            _labServicesScheduleSchedulesRestClient = new SchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labServicesScheduleSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Operation to create or update a lab schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LabServicesScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scheduleName, LabServicesScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _labServicesScheduleSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation<LabServicesScheduleResource>(Response.FromValue(new LabServicesScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Operation to create or update a lab schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LabServicesScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string scheduleName, LabServicesScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _labServicesScheduleSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, data, cancellationToken);
                var operation = new LabServicesArmOperation<LabServicesScheduleResource>(Response.FromValue(new LabServicesScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Returns the properties of a lab Schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_Get
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<Response<LabServicesScheduleResource>> GetAsync(string scheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _labServicesScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabServicesScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the properties of a lab Schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_Get
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual Response<LabServicesScheduleResource> Get(string scheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _labServicesScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabServicesScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of all schedules for a lab.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules
        /// Operation Id: Schedules_ListByLab
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabServicesScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabServicesScheduleResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<LabServicesScheduleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labServicesScheduleSchedulesRestClient.ListByLabAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabServicesScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LabServicesScheduleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labServicesScheduleSchedulesRestClient.ListByLabNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabServicesScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns a list of all schedules for a lab.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules
        /// Operation Id: Schedules_ListByLab
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabServicesScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabServicesScheduleResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<LabServicesScheduleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labServicesScheduleSchedulesRestClient.ListByLab(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabServicesScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LabServicesScheduleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labServicesScheduleSchedulesRestClient.ListByLabNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabServicesScheduleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_Get
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _labServicesScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_Get
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string scheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _labServicesScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scheduleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LabServicesScheduleResource> IEnumerable<LabServicesScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LabServicesScheduleResource> IAsyncEnumerable<LabServicesScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
