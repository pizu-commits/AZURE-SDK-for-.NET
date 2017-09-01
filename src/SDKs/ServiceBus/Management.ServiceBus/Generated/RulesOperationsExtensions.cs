// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RulesOperations.
    /// </summary>
    public static partial class RulesOperationsExtensions
    {
            /// <summary>
            /// List all the rules within given topic-subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            public static IPage<Rule> ListBySubscriptions(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
            {
                return operations.ListBySubscriptionsAsync(resourceGroupName, namespaceName, topicName, subscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the rules within given topic-subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Rule>> ListBySubscriptionsAsync(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionsWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new rule and updates an existing rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='ruleName'>
            /// The rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a rule.
            /// </param>
            public static Rule CreateOrUpdate(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName, Rule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, topicName, subscriptionName, ruleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new rule and updates an existing rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='ruleName'>
            /// The rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Rule> CreateOrUpdateAsync(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName, Rule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, ruleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='ruleName'>
            /// The rule name.
            /// </param>
            public static void Delete(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, topicName, subscriptionName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='ruleName'>
            /// The rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, ruleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves the description for the specified rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='ruleName'>
            /// The rule name.
            /// </param>
            public static Rule Get(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, topicName, subscriptionName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the description for the specified rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='ruleName'>
            /// The rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Rule> GetAsync(this IRulesOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, ruleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the rules within given topic-subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Rule> ListBySubscriptionsNext(this IRulesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the rules within given topic-subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Rule>> ListBySubscriptionsNextAsync(this IRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
