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
using Azure.ResourceManager.Maintenance.Models;

namespace Azure.ResourceManager.Maintenance
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _applyUpdateClientDiagnostics;
        private ApplyUpdatesRestOperations _applyUpdateRestClient;
        private ClientDiagnostics _applyUpdateForResourceGroupClientDiagnostics;
        private ApplyUpdateForResourceGroupRestOperations _applyUpdateForResourceGroupRestClient;
        private ClientDiagnostics _updatesClientDiagnostics;
        private UpdatesRestOperations _updatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ApplyUpdateClientDiagnostics => _applyUpdateClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Maintenance", ApplyUpdateResource.ResourceType.Namespace, Diagnostics);
        private ApplyUpdatesRestOperations ApplyUpdateRestClient => _applyUpdateRestClient ??= new ApplyUpdatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ApplyUpdateResource.ResourceType));
        private ClientDiagnostics ApplyUpdateForResourceGroupClientDiagnostics => _applyUpdateForResourceGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Maintenance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ApplyUpdateForResourceGroupRestOperations ApplyUpdateForResourceGroupRestClient => _applyUpdateForResourceGroupRestClient ??= new ApplyUpdateForResourceGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics UpdatesClientDiagnostics => _updatesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Maintenance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UpdatesRestOperations UpdatesRestClient => _updatesRestClient ??= new UpdatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MaintenanceConfigurationResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MaintenanceConfigurationResources and their operations over a MaintenanceConfigurationResource. </returns>
        public virtual MaintenanceConfigurationCollection GetMaintenanceConfigurations()
        {
            return GetCachedClient(Client => new MaintenanceConfigurationCollection(Client, Id));
        }

        /// <summary> Gets a collection of ApplyUpdateResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ApplyUpdateResources and their operations over a ApplyUpdateResource. </returns>
        public virtual ApplyUpdateCollection GetApplyUpdates()
        {
            return GetCachedClient(Client => new ApplyUpdateCollection(Client, Id));
        }

        /// <summary> Gets a collection of ConfigurationAssignmentResources in the ResourceGroupResource. </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceParentType"> Resource parent type. </param>
        /// <param name="resourceParentName"> Resource parent identifier. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <returns> An object representing collection of ConfigurationAssignmentResources and their operations over a ConfigurationAssignmentResource. </returns>
        public virtual ConfigurationAssignmentCollection GetConfigurationAssignments(string providerName, string resourceParentType, string resourceParentName, string resourceType, string resourceName)
        {
            return new ConfigurationAssignmentCollection(Client, Id, providerName, resourceParentType, resourceParentName, resourceType, resourceName);
        }

        /// <summary>
        /// Apply maintenance updates to resource with parent
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceParentType}/{resourceParentName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/default
        /// Operation Id: ApplyUpdates_CreateOrUpdateParent
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceParentType"> Resource parent type. </param>
        /// <param name="resourceParentName"> Resource parent identifier. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplyUpdateResource>> CreateOrUpdateParentApplyUpdateAsync(string providerName, string resourceParentType, string resourceParentName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = ApplyUpdateClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CreateOrUpdateParentApplyUpdate");
            scope.Start();
            try
            {
                var response = await ApplyUpdateRestClient.CreateOrUpdateParentAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceParentType, resourceParentName, resourceType, resourceName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Apply maintenance updates to resource with parent
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceParentType}/{resourceParentName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/default
        /// Operation Id: ApplyUpdates_CreateOrUpdateParent
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceParentType"> Resource parent type. </param>
        /// <param name="resourceParentName"> Resource parent identifier. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplyUpdateResource> CreateOrUpdateParentApplyUpdate(string providerName, string resourceParentType, string resourceParentName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = ApplyUpdateClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CreateOrUpdateParentApplyUpdate");
            scope.Start();
            try
            {
                var response = ApplyUpdateRestClient.CreateOrUpdateParent(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceParentType, resourceParentName, resourceType, resourceName, cancellationToken);
                return Response.FromValue(new ApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Apply maintenance updates to resource
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/default
        /// Operation Id: ApplyUpdates_CreateOrUpdate
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplyUpdateResource>> CreateOrUpdateApplyUpdateAsync(string providerName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = ApplyUpdateClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CreateOrUpdateApplyUpdate");
            scope.Start();
            try
            {
                var response = await ApplyUpdateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Apply maintenance updates to resource
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/default
        /// Operation Id: ApplyUpdates_CreateOrUpdate
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplyUpdateResource> CreateOrUpdateApplyUpdate(string providerName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = ApplyUpdateClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CreateOrUpdateApplyUpdate");
            scope.Start();
            try
            {
                var response = ApplyUpdateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, cancellationToken);
                return Response.FromValue(new ApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Configuration records within a subscription and resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maintenance/applyUpdates
        /// Operation Id: ApplyUpdateForResourceGroup_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplyUpdateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplyUpdateResource> GetApplyUpdatesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplyUpdateResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApplyUpdateForResourceGroupClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetApplyUpdates");
                scope.Start();
                try
                {
                    var response = await ApplyUpdateForResourceGroupRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplyUpdateResource(Client, value)), null, response.GetRawResponse());
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
        /// Get Configuration records within a subscription and resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maintenance/applyUpdates
        /// Operation Id: ApplyUpdateForResourceGroup_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplyUpdateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplyUpdateResource> GetApplyUpdates(CancellationToken cancellationToken = default)
        {
            Page<ApplyUpdateResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApplyUpdateForResourceGroupClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetApplyUpdates");
                scope.Start();
                try
                {
                    var response = ApplyUpdateForResourceGroupRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplyUpdateResource(Client, value)), null, response.GetRawResponse());
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
        /// Get updates to resources.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceParentType}/{resourceParentName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/updates
        /// Operation Id: Updates_ListParent
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceParentType"> Resource parent type. </param>
        /// <param name="resourceParentName"> Resource parent identifier. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Update" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Update> GetParentUpdatesAsync(string providerName, string resourceParentType, string resourceParentName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            async Task<Page<Update>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UpdatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetParentUpdates");
                scope.Start();
                try
                {
                    var response = await UpdatesRestClient.ListParentAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceParentType, resourceParentName, resourceType, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Get updates to resources.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceParentType}/{resourceParentName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/updates
        /// Operation Id: Updates_ListParent
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceParentType"> Resource parent type. </param>
        /// <param name="resourceParentName"> Resource parent identifier. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Update" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Update> GetParentUpdates(string providerName, string resourceParentType, string resourceParentName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Page<Update> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UpdatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetParentUpdates");
                scope.Start();
                try
                {
                    var response = UpdatesRestClient.ListParent(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceParentType, resourceParentName, resourceType, resourceName, cancellationToken: cancellationToken);
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
        /// Get updates to resources.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/updates
        /// Operation Id: Updates_List
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Update" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Update> GetUpdatesAsync(string providerName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            async Task<Page<Update>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UpdatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetUpdates");
                scope.Start();
                try
                {
                    var response = await UpdatesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Get updates to resources.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/updates
        /// Operation Id: Updates_List
        /// </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Update" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Update> GetUpdates(string providerName, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Page<Update> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UpdatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetUpdates");
                scope.Start();
                try
                {
                    var response = UpdatesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, providerName, resourceType, resourceName, cancellationToken: cancellationToken);
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
