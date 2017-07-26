// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventHub;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ConsumerGroupsOperations operations.
    /// </summary>
    public partial interface IConsumerGroupsOperations
    {
        /// <summary>
        /// Creates or updates an Event Hubs consumer group as a nested
        /// resource within a Namespace.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639498.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create or update a consumer group resource.
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
        Task<AzureOperationResponse<ConsumerGroupResourceInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, ConsumerGroupCreateOrUpdateParametersInner parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a consumer group from the specified Event Hub and resource
        /// group.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639491.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a description for the specified consumer group.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639488.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
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
        Task<AzureOperationResponse<ConsumerGroupResourceInner>> GetWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is
        /// returned if no consumer group exists in the Namespace.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639503.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
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
        Task<AzureOperationResponse<IPage<ConsumerGroupResourceInner>>> ListAllWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is
        /// returned if no consumer group exists in the Namespace.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639503.aspx" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<ConsumerGroupResourceInner>>> ListAllNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
