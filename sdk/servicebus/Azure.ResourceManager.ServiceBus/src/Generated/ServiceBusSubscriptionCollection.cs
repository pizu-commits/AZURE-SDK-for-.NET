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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceBusSubscriptionResource" /> and their operations.
    /// Each <see cref="ServiceBusSubscriptionResource" /> in the collection will belong to the same instance of <see cref="ServiceBusTopicResource" />.
    /// To get a <see cref="ServiceBusSubscriptionCollection" /> instance call the GetServiceBusSubscriptions method from an instance of <see cref="ServiceBusTopicResource" />.
    /// </summary>
    public partial class ServiceBusSubscriptionCollection : ArmCollection, IEnumerable<ServiceBusSubscriptionResource>, IAsyncEnumerable<ServiceBusSubscriptionResource>
    {
        private readonly ClientDiagnostics _serviceBusSubscriptionSubscriptionsClientDiagnostics;
        private readonly SubscriptionsRestOperations _serviceBusSubscriptionSubscriptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusSubscriptionCollection"/> class for mocking. </summary>
        protected ServiceBusSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusSubscriptionSubscriptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceBusSubscriptionResource.ResourceType, out string serviceBusSubscriptionSubscriptionsApiVersion);
            _serviceBusSubscriptionSubscriptionsRestClient = new SubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusSubscriptionSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusTopicResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusTopicResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a topic subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="data"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string subscriptionName, ServiceBusSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusSubscriptionSubscriptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusSubscriptionResource>(Response.FromValue(new ServiceBusSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Creates a topic subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="data"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string subscriptionName, ServiceBusSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusSubscriptionSubscriptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusSubscriptionResource>(Response.FromValue(new ServiceBusSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusSubscriptionResource>> GetAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusSubscriptionSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<ServiceBusSubscriptionResource> Get(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusSubscriptionSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the subscriptions under a specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions
        /// Operation Id: Subscriptions_ListByTopic
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusSubscriptionResource> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceBusSubscriptionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusSubscriptionSubscriptionsRestClient.ListByTopicAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceBusSubscriptionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusSubscriptionSubscriptionsRestClient.ListByTopicNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all the subscriptions under a specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions
        /// Operation Id: Subscriptions_ListByTopic
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusSubscriptionResource> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServiceBusSubscriptionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusSubscriptionSubscriptionsRestClient.ListByTopic(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceBusSubscriptionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusSubscriptionSubscriptionsRestClient.ListByTopicNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subscriptionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusSubscriptionResource>> GetIfExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceBusSubscriptionSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServiceBusSubscriptionResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceBusSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<ServiceBusSubscriptionResource> GetIfExists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceBusSubscriptionSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, subscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServiceBusSubscriptionResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceBusSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusSubscriptionResource> IEnumerable<ServiceBusSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusSubscriptionResource> IAsyncEnumerable<ServiceBusSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
