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

namespace Azure.ResourceManager.Maintenance
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _applyUpdateClientDiagnostics;
        private ApplyUpdatesRestOperations _applyUpdateRestClient;
        private ClientDiagnostics _maintenanceConfigurationClientDiagnostics;
        private MaintenanceConfigurationsRestOperations _maintenanceConfigurationRestClient;
        private ClientDiagnostics _configurationAssignmentsWithinSubscriptionClientDiagnostics;
        private ConfigurationAssignmentsWithinSubscriptionRestOperations _configurationAssignmentsWithinSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ApplyUpdateClientDiagnostics => _applyUpdateClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Maintenance", ApplyUpdateResource.ResourceType.Namespace, Diagnostics);
        private ApplyUpdatesRestOperations ApplyUpdateRestClient => _applyUpdateRestClient ??= new ApplyUpdatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ApplyUpdateResource.ResourceType));
        private ClientDiagnostics MaintenanceConfigurationClientDiagnostics => _maintenanceConfigurationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Maintenance", MaintenanceConfigurationResource.ResourceType.Namespace, Diagnostics);
        private MaintenanceConfigurationsRestOperations MaintenanceConfigurationRestClient => _maintenanceConfigurationRestClient ??= new MaintenanceConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MaintenanceConfigurationResource.ResourceType));
        private ClientDiagnostics ConfigurationAssignmentsWithinSubscriptionClientDiagnostics => _configurationAssignmentsWithinSubscriptionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Maintenance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ConfigurationAssignmentsWithinSubscriptionRestOperations ConfigurationAssignmentsWithinSubscriptionRestClient => _configurationAssignmentsWithinSubscriptionRestClient ??= new ConfigurationAssignmentsWithinSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PublicMaintenanceConfigurationResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of PublicMaintenanceConfigurationResources and their operations over a PublicMaintenanceConfigurationResource. </returns>
        public virtual PublicMaintenanceConfigurationCollection GetPublicMaintenanceConfigurations()
        {
            return GetCachedClient(Client => new PublicMaintenanceConfigurationCollection(Client, Id));
        }

        /// <summary>
        /// Get Configuration records within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/applyUpdates
        /// Operation Id: ApplyUpdates_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplyUpdateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplyUpdateResource> GetApplyUpdatesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplyUpdateResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApplyUpdateClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApplyUpdates");
                scope.Start();
                try
                {
                    var response = await ApplyUpdateRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Get Configuration records within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/applyUpdates
        /// Operation Id: ApplyUpdates_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplyUpdateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplyUpdateResource> GetApplyUpdates(CancellationToken cancellationToken = default)
        {
            Page<ApplyUpdateResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApplyUpdateClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApplyUpdates");
                scope.Start();
                try
                {
                    var response = ApplyUpdateRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
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
        /// Get Configuration records within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/maintenanceConfigurations
        /// Operation Id: MaintenanceConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BaseMaintenanceConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BaseMaintenanceConfigurationResource> GetMaintenanceConfigurationsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BaseMaintenanceConfigurationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MaintenanceConfigurationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMaintenanceConfigurations");
                scope.Start();
                try
                {
                    var response = await MaintenanceConfigurationRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => BaseMaintenanceConfigurationResource.GetResource(Client, value)), null, response.GetRawResponse());
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
        /// Get Configuration records within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/maintenanceConfigurations
        /// Operation Id: MaintenanceConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BaseMaintenanceConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BaseMaintenanceConfigurationResource> GetMaintenanceConfigurations(CancellationToken cancellationToken = default)
        {
            Page<BaseMaintenanceConfigurationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MaintenanceConfigurationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMaintenanceConfigurations");
                scope.Start();
                try
                {
                    var response = MaintenanceConfigurationRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => BaseMaintenanceConfigurationResource.GetResource(Client, value)), null, response.GetRawResponse());
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
        /// Get configuration assignment within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/configurationAssignments
        /// Operation Id: ConfigurationAssignmentsWithinSubscription_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationAssignmentResource> GetConfigurationAssignmentsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ConfigurationAssignmentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ConfigurationAssignmentsWithinSubscriptionClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetConfigurationAssignments");
                scope.Start();
                try
                {
                    var response = await ConfigurationAssignmentsWithinSubscriptionRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationAssignmentResource(Client, value)), null, response.GetRawResponse());
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
        /// Get configuration assignment within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/configurationAssignments
        /// Operation Id: ConfigurationAssignmentsWithinSubscription_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationAssignmentResource> GetConfigurationAssignments(CancellationToken cancellationToken = default)
        {
            Page<ConfigurationAssignmentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ConfigurationAssignmentsWithinSubscriptionClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetConfigurationAssignments");
                scope.Start();
                try
                {
                    var response = ConfigurationAssignmentsWithinSubscriptionRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationAssignmentResource(Client, value)), null, response.GetRawResponse());
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
