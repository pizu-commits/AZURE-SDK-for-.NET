// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing a SystemTopicEventSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SystemTopicEventSubscriptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSystemTopicEventSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SystemTopicResource" /> using the GetSystemTopicEventSubscription method.
    /// </summary>
    public partial class SystemTopicEventSubscriptionResource : BaseEventSubscriptionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SystemTopicEventSubscriptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string systemTopicName, string eventSubscriptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _systemTopicEventSubscriptionClientDiagnostics;
        private readonly SystemTopicEventSubscriptionsRestOperations _systemTopicEventSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="SystemTopicEventSubscriptionResource"/> class for mocking. </summary>
        protected SystemTopicEventSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SystemTopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SystemTopicEventSubscriptionResource(ArmClient client, EventSubscriptionData data) : base(client, data)
        {
            _systemTopicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string systemTopicEventSubscriptionApiVersion);
            _systemTopicEventSubscriptionRestClient = new SystemTopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, systemTopicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SystemTopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SystemTopicEventSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _systemTopicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string systemTopicEventSubscriptionApiVersion);
            _systemTopicEventSubscriptionRestClient = new SystemTopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, systemTopicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/systemTopics/eventSubscriptions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an event subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseEventSubscriptionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an event subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SystemTopicEventSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SystemTopicEventSubscriptionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Get an event subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseEventSubscriptionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an event subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SystemTopicEventSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SystemTopicEventSubscriptionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Delete an existing event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an existing event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an existing event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        protected override async Task<ArmOperation<BaseEventSubscriptionResource>> UpdateCoreAsync(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<BaseEventSubscriptionResource>(new BaseEventSubscriptionOperationSource(Client), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update an existing event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<SystemTopicEventSubscriptionResource>> UpdateAsync(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            var result = await UpdateCoreAsync(waitUntil, patch, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new EventGridArmOperation<SystemTopicEventSubscriptionResource>(Response.FromValue((SystemTopicEventSubscriptionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new EventGridArmOperation<SystemTopicEventSubscriptionResource>(new SystemTopicEventSubscriptionOperationSource(Client), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// Update an existing event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        protected override ArmOperation<BaseEventSubscriptionResource> UpdateCore(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new EventGridArmOperation<BaseEventSubscriptionResource>(new BaseEventSubscriptionOperationSource(Client), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update an existing event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: SystemTopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<SystemTopicEventSubscriptionResource> Update(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            var result = UpdateCore(waitUntil, patch, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new EventGridArmOperation<SystemTopicEventSubscriptionResource>(Response.FromValue((SystemTopicEventSubscriptionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new EventGridArmOperation<SystemTopicEventSubscriptionResource>(new SystemTopicEventSubscriptionOperationSource(Client), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// Get the full endpoint URL for an event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}/getFullUrl
        /// Operation Id: SystemTopicEventSubscriptions_GetFullUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<EventSubscriptionFullUri>> GetFullUriCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.GetFullUri");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.GetFullUriAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the full endpoint URL for an event subscription of a system topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}/getFullUrl
        /// Operation Id: SystemTopicEventSubscriptions_GetFullUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<EventSubscriptionFullUri> GetFullUriCore(CancellationToken cancellationToken = default)
        {
            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.GetFullUri");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.GetFullUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all delivery attributes for an event subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}/getDeliveryAttributes
        /// Operation Id: SystemTopicEventSubscriptions_GetDeliveryAttributes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeliveryAttributeMapping" /> that may take multiple service requests to iterate over. </returns>
        protected override AsyncPageable<DeliveryAttributeMapping> GetDeliveryAttributesCoreAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeliveryAttributeMapping>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.GetDeliveryAttributes");
                scope.Start();
                try
                {
                    var response = await _systemTopicEventSubscriptionRestClient.GetDeliveryAttributesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all delivery attributes for an event subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}/getDeliveryAttributes
        /// Operation Id: SystemTopicEventSubscriptions_GetDeliveryAttributes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeliveryAttributeMapping" /> that may take multiple service requests to iterate over. </returns>
        protected override Pageable<DeliveryAttributeMapping> GetDeliveryAttributesCore(CancellationToken cancellationToken = default)
        {
            Page<DeliveryAttributeMapping> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionResource.GetDeliveryAttributes");
                scope.Start();
                try
                {
                    var response = _systemTopicEventSubscriptionRestClient.GetDeliveryAttributes(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
