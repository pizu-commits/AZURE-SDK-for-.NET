// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DomainTopicEventSubscriptionsOperations operations.
    /// </summary>
    public partial interface IDomainTopicEventSubscriptionsOperations
    {
        /// <summary>
        /// Get a nested event subscription for domain topic.
        /// </summary>
        /// <remarks>
        /// Get properties of a nested event subscription for a domain topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EventSubscription>> GetWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a nested event subscription to a domain topic.
        /// </summary>
        /// <remarks>
        /// Asynchronously creates a new event subscription or updates an
        /// existing event subscription.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='eventSubscriptionInfo'>
        /// Event subscription properties containing the destination and filter
        /// information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EventSubscription>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a nested event subscription for a domain topic.
        /// </summary>
        /// <remarks>
        /// Delete a nested existing event subscription for a domain topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be deleted. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a nested event subscription for a domain topic.
        /// </summary>
        /// <remarks>
        /// Update an existing event subscription for a domain topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be updated.
        /// </param>
        /// <param name='eventSubscriptionUpdateParameters'>
        /// Updated event subscription information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EventSubscription>> UpdateWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get full URL of a nested event subscription for domain topic.
        /// </summary>
        /// <remarks>
        /// Get the full endpoint URL for a nested event subscription for
        /// domain topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EventSubscriptionFullUrl>> GetFullUrlWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all nested event subscriptions for a specific domain topic.
        /// </summary>
        /// <remarks>
        /// List all event subscriptions that have been created for a specific
        /// domain topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<EventSubscription>>> ListWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get delivery attributes for an event subscription for domain topic.
        /// </summary>
        /// <remarks>
        /// Get all delivery attributes for an event subscription for domain
        /// topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DeliveryAttributeListResult>> GetDeliveryAttributesWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a nested event subscription to a domain topic.
        /// </summary>
        /// <remarks>
        /// Asynchronously creates a new event subscription or updates an
        /// existing event subscription.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='eventSubscriptionInfo'>
        /// Event subscription properties containing the destination and filter
        /// information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EventSubscription>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a nested event subscription for a domain topic.
        /// </summary>
        /// <remarks>
        /// Delete a nested existing event subscription for a domain topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the top level domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the domain topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be deleted. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a nested event subscription for a domain topic.
        /// </summary>
        /// <remarks>
        /// Update an existing event subscription for a domain topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='topicName'>
        /// Name of the topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be updated.
        /// </param>
        /// <param name='eventSubscriptionUpdateParameters'>
        /// Updated event subscription information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EventSubscription>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string domainName, string topicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
