// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
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
    /// Extension methods for TopicsOperations.
    /// </summary>
    public static partial class TopicsOperationsExtensions
    {
            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
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
            public static IPage<SBTopic> ListByNamespace(this ITopicsOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListByNamespaceAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SBTopic>> ListByNamespaceAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a topic in the specified namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639409.aspx" />
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
            /// <param name='parameters'>
            /// Parameters supplied to create a topic resource.
            /// </param>
            public static SBTopic CreateOrUpdate(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, SBTopic parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, topicName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a topic in the specified namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639409.aspx" />
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
            /// <param name='parameters'>
            /// Parameters supplied to create a topic resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBTopic> CreateOrUpdateAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, SBTopic parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a topic from the specified namespace and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639404.aspx" />
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
            public static void Delete(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, topicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a topic from the specified namespace and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639404.aspx" />
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a description for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639399.aspx" />
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
            public static SBTopic Get(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, topicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a description for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639399.aspx" />
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBTopic> GetAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
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
            public static IPage<SBAuthorizationRule> ListAuthorizationRules(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, topicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SBAuthorizationRule>> ListAuthorizationRulesAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an authorizatio rule for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720678.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SBAuthorizationRule CreateOrUpdateAuthorizationRule(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, SBAuthorizationRule parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an authorizatio rule for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720678.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBAuthorizationRule> CreateOrUpdateAuthorizationRuleAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, SBAuthorizationRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720676.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static SBAuthorizationRule GetAuthorizationRule(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720676.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBAuthorizationRule> GetAuthorizationRuleAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a topic authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static void DeleteAuthorizationRule(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a topic authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720677.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static AccessKeys ListKeys(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720677.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates primary or secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720679.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            public static AccessKeys RegenerateKeys(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, RegenerateAccessKeyParameters parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates primary or secondary connection strings for the topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720679.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> RegenerateKeysAsync(this ITopicsOperations operations, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName, RegenerateAccessKeyParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SBTopic> ListByNamespaceNext(this ITopicsOperations operations, string nextPageLink)
            {
                return operations.ListByNamespaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the topics in a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639388.aspx" />
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
            public static async Task<IPage<SBTopic>> ListByNamespaceNextAsync(this ITopicsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SBAuthorizationRule> ListAuthorizationRulesNext(this ITopicsOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets authorization rules for a topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt720681.aspx" />
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
            public static async Task<IPage<SBAuthorizationRule>> ListAuthorizationRulesNextAsync(this ITopicsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
