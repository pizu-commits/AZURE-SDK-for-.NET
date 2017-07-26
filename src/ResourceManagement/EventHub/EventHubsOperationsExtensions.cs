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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EventHubsOperations.
    /// </summary>
    public static partial class EventHubsOperationsExtensions
    {
            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639493.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            public static IPage<EventHubResourceInner> ListAll(this IEventHubsOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListAllAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639493.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventHubResourceInner>> ListAllAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a new Event Hub as a nested resource within a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639497.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create an Event Hub resource.
            /// </param>
            public static EventHubResourceInner CreateOrUpdate(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, EventHubCreateOrUpdateParametersInner parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, eventHubName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a new Event Hub as a nested resource within a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639497.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create an Event Hub resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventHubResourceInner> CreateOrUpdateAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, EventHubCreateOrUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Event Hub from the specified Namespace and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639496.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            public static void Delete(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, eventHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Event Hub from the specified Namespace and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639496.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets an Event Hubs description for the specified Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639501.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            public static EventHubResourceInner Get(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, eventHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an Event Hubs description for the specified Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639501.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventHubResourceInner> GetAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResourceInner> ListAuthorizationRules(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, eventHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResourceInner>> ListAuthorizationRulesAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an AuthorizationRule for the specified Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706096.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access AuthorizationRule.
            /// </param>
            public static SharedAccessAuthorizationRuleResourceInner CreateOrUpdateAuthorizationRule(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParametersInner parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an AuthorizationRule for the specified Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706096.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access AuthorizationRule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResourceInner> CreateOrUpdateAuthorizationRuleAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an AuthorizationRule for an Event Hub by rule name.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706097.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResourceInner GetAuthorizationRule(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an AuthorizationRule for an Event Hub by rule name.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706097.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResourceInner> GetAuthorizationRuleAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Event Hub AuthorizationRule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706100.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static void DeleteAuthorizationRule(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Event Hub AuthorizationRule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706100.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the ACS and SAS connection strings for the Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706098.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static ResourceListKeysInner ListKeys(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the ACS and SAS connection strings for the Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706098.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeysInner> ListKeysAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the ACS and SAS connection strings for the Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706099.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='policykey'>
            /// Key that needs to be regenerated. Possible values include: 'PrimaryKey',
            /// 'SecondaryKey'
            /// </param>
            public static ResourceListKeysInner RegenerateKeys(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, Policykey? policykey = default(Policykey?))
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, policykey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the ACS and SAS connection strings for the Event Hub.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt706099.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='policykey'>
            /// Key that needs to be regenerated. Possible values include: 'PrimaryKey',
            /// 'SecondaryKey'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeysInner> RegenerateKeysAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, Policykey? policykey = default(Policykey?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, policykey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639493.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventHubResourceInner> ListAllNext(this IEventHubsOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639493.aspx" />
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
            public static async Task<IPage<EventHubResourceInner>> ListAllNextAsync(this IEventHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResourceInner> ListAuthorizationRulesNext(this IEventHubsOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
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
            public static async Task<IPage<SharedAccessAuthorizationRuleResourceInner>> ListAuthorizationRulesNextAsync(this IEventHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
