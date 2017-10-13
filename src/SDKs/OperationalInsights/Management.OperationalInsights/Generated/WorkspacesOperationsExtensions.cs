// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkspacesOperations.
    /// </summary>
    public static partial class WorkspacesOperationsExtensions
    {
            /// <summary>
            /// Disables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be disabled.
            /// </param>
            public static void DisableIntelligencePack(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
            {
                operations.DisableIntelligencePackAsync(resourceGroupName, workspaceName, intelligencePackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be disabled.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableIntelligencePackAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DisableIntelligencePackWithHttpMessagesAsync(resourceGroupName, workspaceName, intelligencePackName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Enables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be enabled.
            /// </param>
            public static void EnableIntelligencePack(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
            {
                operations.EnableIntelligencePackAsync(resourceGroupName, workspaceName, intelligencePackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be enabled.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableIntelligencePackAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EnableIntelligencePackWithHttpMessagesAsync(resourceGroupName, workspaceName, intelligencePackName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the intelligence packs possible and whether they are enabled or
            /// disabled for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            public static IList<IntelligencePack> ListIntelligencePacks(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListIntelligencePacksAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the intelligence packs possible and whether they are enabled or
            /// disabled for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<IntelligencePack>> ListIntelligencePacksAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListIntelligencePacksWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the shared keys for a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            public static SharedKeys GetSharedKeys(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.GetSharedKeysAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the shared keys for a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedKeys> GetSharedKeysAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSharedKeysWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of usage metrics for a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IEnumerable<UsageMetric> ListUsages(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListUsagesAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of usage metrics for a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<UsageMetric>> ListUsagesAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUsagesWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of management groups connected to a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IEnumerable<ManagementGroup> ListManagementGroups(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListManagementGroupsAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of management groups connected to a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ManagementGroup>> ListManagementGroupsAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListManagementGroupsWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets workspaces in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            public static IEnumerable<Workspace> ListByResourceGroup(this IWorkspacesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets workspaces in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Workspace>> ListByResourceGroupAsync(this IWorkspacesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the workspaces in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<Workspace> List(this IWorkspacesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the workspaces in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Workspace>> ListAsync(this IWorkspacesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to create or update a workspace.
            /// </param>
            public static Workspace CreateOrUpdate(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, Workspace parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to create or update a workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workspace> CreateOrUpdateAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, Workspace parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a workspace instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            public static void Delete(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a workspace instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a workspace instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            public static Workspace Get(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workspace instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workspace> GetAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of workspaces which the current user has administrator
            /// privileges and are not associated with an Azure Subscription. The
            /// subscriptionId parameter in the Url is ignored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<LinkTarget> ListLinkTargets(this IWorkspacesOperations operations)
            {
                return operations.ListLinkTargetsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of workspaces which the current user has administrator
            /// privileges and are not associated with an Azure Subscription. The
            /// subscriptionId parameter in the Url is ignored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LinkTarget>> ListLinkTargetsAsync(this IWorkspacesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListLinkTargetsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the schema for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            public static SearchGetSchemaResponse GetSchema(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.GetSchemaAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the schema for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchGetSchemaResponse> GetSchemaAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSchemaWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submit a search for a given workspace. The response will contain an id to
            /// track the search. User can use the id to poll the search status and get the
            /// full search result later if the search takes long time to finish.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute a search query.
            /// </param>
            public static SearchResultsResponse GetSearchResults(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, SearchParameters parameters)
            {
                return operations.GetSearchResultsAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submit a search for a given workspace. The response will contain an id to
            /// track the search. User can use the id to poll the search status and get the
            /// full search result later if the search takes long time to finish.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute a search query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchResultsResponse> GetSearchResultsAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, SearchParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSearchResultsWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets updated search results for a given search query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            /// <param name='id'>
            /// The id of the search that will have results updated. You can get the id
            /// from the response of the GetResults call.
            /// </param>
            public static SearchResultsResponse UpdateSearchResults(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, string id)
            {
                return operations.UpdateSearchResultsAsync(resourceGroupName, workspaceName, id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets updated search results for a given search query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            /// <param name='id'>
            /// The id of the search that will have results updated. You can get the id
            /// from the response of the GetResults call.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchResultsResponse> UpdateSearchResultsAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateSearchResultsWithHttpMessagesAsync(resourceGroupName, workspaceName, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to create or update a workspace.
            /// </param>
            public static Workspace BeginCreateOrUpdate(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, Workspace parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the workspace.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to create or update a workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workspace> BeginCreateOrUpdateAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, Workspace parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submit a search for a given workspace. The response will contain an id to
            /// track the search. User can use the id to poll the search status and get the
            /// full search result later if the search takes long time to finish.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute a search query.
            /// </param>
            public static SearchResultsResponse BeginGetSearchResults(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, SearchParameters parameters)
            {
                return operations.BeginGetSearchResultsAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submit a search for a given workspace. The response will contain an id to
            /// track the search. User can use the id to poll the search status and get the
            /// full search result later if the search takes long time to finish.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Log Analytics workspace name
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute a search query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchResultsResponse> BeginGetSearchResultsAsync(this IWorkspacesOperations operations, string resourceGroupName, string workspaceName, SearchParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetSearchResultsWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
