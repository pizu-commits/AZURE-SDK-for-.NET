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
    /// A Class representing a TopicEventSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TopicEventSubscriptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTopicEventSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventGridTopicResource" /> using the GetTopicEventSubscription method.
    /// </summary>
    public partial class TopicEventSubscriptionResource : BaseEventSubscriptionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TopicEventSubscriptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string topicName, string eventSubscriptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _topicEventSubscriptionClientDiagnostics;
        private readonly TopicEventSubscriptionsRestOperations _topicEventSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="TopicEventSubscriptionResource"/> class for mocking. </summary>
        protected TopicEventSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TopicEventSubscriptionResource(ArmClient client, EventSubscriptionData data) : base(client, data)
        {
            _topicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string topicEventSubscriptionApiVersion);
            _topicEventSubscriptionRestClient = new TopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="TopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TopicEventSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string topicEventSubscriptionApiVersion);
            _topicEventSubscriptionRestClient = new TopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/topics/eventSubscriptions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Get properties of an event subscription of a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseEventSubscriptionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.GetCore");
            scope.Start();
            try
            {
                var response = await _topicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Get properties of an event subscription of a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<TopicEventSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((TopicEventSubscriptionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Get properties of an event subscription of a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseEventSubscriptionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.GetCore");
            scope.Start();
            try
            {
                var response = _topicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Get properties of an event subscription of a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<TopicEventSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((TopicEventSubscriptionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Delete an existing event subscription for a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _topicEventSubscriptionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_topicEventSubscriptionClientDiagnostics, Pipeline, _topicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The core implementation for operation Delete
        /// Delete an existing event subscription for a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _topicEventSubscriptionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_topicEventSubscriptionClientDiagnostics, Pipeline, _topicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The core implementation for operation Update
        /// Update an existing event subscription for a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        protected override async Task<ArmOperation<BaseEventSubscriptionResource>> UpdateCoreAsync(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.UpdateCore");
            scope.Start();
            try
            {
                var response = await _topicEventSubscriptionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<BaseEventSubscriptionResource>(new BaseEventSubscriptionOperationSource(Client), _topicEventSubscriptionClientDiagnostics, Pipeline, _topicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update an existing event subscription for a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<TopicEventSubscriptionResource>> UpdateAsync(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(waitUntil, patch, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new EventGridArmOperation<TopicEventSubscriptionResource>(Response.FromValue((TopicEventSubscriptionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new EventGridArmOperation<TopicEventSubscriptionResource>(new TopicEventSubscriptionOperationSource(Client), _topicEventSubscriptionClientDiagnostics, Pipeline, _topicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Update an existing event subscription for a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        protected override ArmOperation<BaseEventSubscriptionResource> UpdateCore(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.UpdateCore");
            scope.Start();
            try
            {
                var response = _topicEventSubscriptionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new EventGridArmOperation<BaseEventSubscriptionResource>(new BaseEventSubscriptionOperationSource(Client), _topicEventSubscriptionClientDiagnostics, Pipeline, _topicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update an existing event subscription for a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: TopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<TopicEventSubscriptionResource> Update(WaitUntil waitUntil, EventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(waitUntil, patch, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new EventGridArmOperation<TopicEventSubscriptionResource>(Response.FromValue((TopicEventSubscriptionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new EventGridArmOperation<TopicEventSubscriptionResource>(new TopicEventSubscriptionOperationSource(Client), _topicEventSubscriptionClientDiagnostics, Pipeline, _topicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation GetDeliveryAttributes
        /// Get all delivery attributes for an event subscription for topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getDeliveryAttributes
        /// Operation Id: TopicEventSubscriptions_GetDeliveryAttributes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override AsyncPageable<DeliveryAttributeMapping> GetDeliveryAttributesCoreAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeliveryAttributeMapping>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.GetDeliveryAttributesCore");
                scope.Start();
                try
                {
                    var response = await _topicEventSubscriptionRestClient.GetDeliveryAttributesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// The core implementation for operation GetDeliveryAttributes
        /// Get all delivery attributes for an event subscription for topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getDeliveryAttributes
        /// Operation Id: TopicEventSubscriptions_GetDeliveryAttributes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Pageable<DeliveryAttributeMapping> GetDeliveryAttributesCore(CancellationToken cancellationToken = default)
        {
            Page<DeliveryAttributeMapping> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.GetDeliveryAttributesCore");
                scope.Start();
                try
                {
                    var response = _topicEventSubscriptionRestClient.GetDeliveryAttributes(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
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

        /// <summary>
        /// The core implementation for operation GetFullUri
        /// Get the full endpoint URL for an event subscription for topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getFullUrl
        /// Operation Id: TopicEventSubscriptions_GetFullUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<EventSubscriptionFullUri>> GetFullUriCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.GetFullUriCore");
            scope.Start();
            try
            {
                var response = await _topicEventSubscriptionRestClient.GetFullUriAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation GetFullUri
        /// Get the full endpoint URL for an event subscription for topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getFullUrl
        /// Operation Id: TopicEventSubscriptions_GetFullUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<EventSubscriptionFullUri> GetFullUriCore(CancellationToken cancellationToken = default)
        {
            using var scope = _topicEventSubscriptionClientDiagnostics.CreateScope("TopicEventSubscriptionResource.GetFullUriCore");
            scope.Start();
            try
            {
                var response = _topicEventSubscriptionRestClient.GetFullUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
