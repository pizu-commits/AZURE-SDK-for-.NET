// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _workspaceClientDiagnostics;
        private WorkspacesRestOperations _workspaceRestClient;
        private ClientDiagnostics _scalingPlanClientDiagnostics;
        private ScalingPlansRestOperations _scalingPlanRestClient;
        private ClientDiagnostics _applicationGroupClientDiagnostics;
        private ApplicationGroupsRestOperations _applicationGroupRestClient;
        private ClientDiagnostics _hostPoolClientDiagnostics;
        private HostPoolsRestOperations _hostPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics WorkspaceClientDiagnostics => _workspaceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", Workspace.ResourceType.Namespace, DiagnosticOptions);
        private WorkspacesRestOperations WorkspaceRestClient => _workspaceRestClient ??= new WorkspacesRestOperations(WorkspaceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(Workspace.ResourceType));
        private ClientDiagnostics ScalingPlanClientDiagnostics => _scalingPlanClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ScalingPlan.ResourceType.Namespace, DiagnosticOptions);
        private ScalingPlansRestOperations ScalingPlanRestClient => _scalingPlanRestClient ??= new ScalingPlansRestOperations(ScalingPlanClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(ScalingPlan.ResourceType));
        private ClientDiagnostics ApplicationGroupClientDiagnostics => _applicationGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ApplicationGroup.ResourceType.Namespace, DiagnosticOptions);
        private ApplicationGroupsRestOperations ApplicationGroupRestClient => _applicationGroupRestClient ??= new ApplicationGroupsRestOperations(ApplicationGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(ApplicationGroup.ResourceType));
        private ClientDiagnostics HostPoolClientDiagnostics => _hostPoolClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", HostPool.ResourceType.Namespace, DiagnosticOptions);
        private HostPoolsRestOperations HostPoolRestClient => _hostPoolRestClient ??= new HostPoolsRestOperations(HostPoolClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(HostPool.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List workspaces in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Workspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Workspace> GetWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Workspace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = await WorkspaceRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Workspace>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = await WorkspaceRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List workspaces in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Workspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Workspace> GetWorkspaces(CancellationToken cancellationToken = default)
        {
            Page<Workspace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = WorkspaceRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Workspace> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = WorkspaceRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List scaling plans in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/scalingPlans
        /// Operation Id: ScalingPlans_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScalingPlan" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScalingPlan> GetScalingPlansAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ScalingPlan>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = await ScalingPlanRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ScalingPlan>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = await ScalingPlanRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List scaling plans in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/scalingPlans
        /// Operation Id: ScalingPlans_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScalingPlan" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScalingPlan> GetScalingPlans(CancellationToken cancellationToken = default)
        {
            Page<ScalingPlan> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = ScalingPlanRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ScalingPlan> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = ScalingPlanRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List applicationGroups in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/applicationGroups
        /// Operation Id: ApplicationGroups_ListBySubscription
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationGroup> GetApplicationGroupsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApplicationGroupClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetApplicationGroups");
                scope.Start();
                try
                {
                    var response = await ApplicationGroupRestClient.ListBySubscriptionAsync(Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApplicationGroupClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetApplicationGroups");
                scope.Start();
                try
                {
                    var response = await ApplicationGroupRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List applicationGroups in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/applicationGroups
        /// Operation Id: ApplicationGroups_ListBySubscription
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationGroup> GetApplicationGroups(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ApplicationGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApplicationGroupClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetApplicationGroups");
                scope.Start();
                try
                {
                    var response = ApplicationGroupRestClient.ListBySubscription(Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApplicationGroupClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetApplicationGroups");
                scope.Start();
                try
                {
                    var response = ApplicationGroupRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List hostPools in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/hostPools
        /// Operation Id: HostPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostPool> GetHostPoolsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HostPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = await HostPoolRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HostPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = await HostPoolRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List hostPools in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/hostPools
        /// Operation Id: HostPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostPool> GetHostPools(CancellationToken cancellationToken = default)
        {
            Page<HostPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = HostPoolRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HostPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = HostPoolRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
