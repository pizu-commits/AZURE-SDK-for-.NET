// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DevCenter.Models;

namespace Azure.ResourceManager.DevCenter.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableDevCenterSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _devCenterClientDiagnostics;
        private DevCentersRestOperations _devCenterRestClient;
        private ClientDiagnostics _devCenterProjectProjectsClientDiagnostics;
        private ProjectsRestOperations _devCenterProjectProjectsRestClient;
        private ClientDiagnostics _operationStatusesClientDiagnostics;
        private OperationStatusesRestOperations _operationStatusesRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;
        private ClientDiagnostics _checkNameAvailabilityClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityRestClient;
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _devCenterNetworkConnectionNetworkConnectionsClientDiagnostics;
        private NetworkConnectionsRestOperations _devCenterNetworkConnectionNetworkConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDevCenterSubscriptionResource"/> class for mocking. </summary>
        protected MockableDevCenterSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDevCenterSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDevCenterSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DevCenterClientDiagnostics => _devCenterClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterResource.ResourceType.Namespace, Diagnostics);
        private DevCentersRestOperations DevCenterRestClient => _devCenterRestClient ??= new DevCentersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DevCenterResource.ResourceType));
        private ClientDiagnostics DevCenterProjectProjectsClientDiagnostics => _devCenterProjectProjectsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterProjectResource.ResourceType.Namespace, Diagnostics);
        private ProjectsRestOperations DevCenterProjectProjectsRestClient => _devCenterProjectProjectsRestClient ??= new ProjectsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DevCenterProjectResource.ResourceType));
        private ClientDiagnostics OperationStatusesClientDiagnostics => _operationStatusesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OperationStatusesRestOperations OperationStatusesRestClient => _operationStatusesRestClient ??= new OperationStatusesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityClientDiagnostics => _checkNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityRestClient => _checkNameAvailabilityRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DevCenterNetworkConnectionNetworkConnectionsClientDiagnostics => _devCenterNetworkConnectionNetworkConnectionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterNetworkConnectionResource.ResourceType.Namespace, Diagnostics);
        private NetworkConnectionsRestOperations DevCenterNetworkConnectionNetworkConnectionsRestClient => _devCenterNetworkConnectionNetworkConnectionsRestClient ??= new NetworkConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DevCenterNetworkConnectionResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all devcenters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/devcenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterResource> GetDevCentersAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevCenterRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevCenterRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevCenterResource(Client, DevCenterData.DeserializeDevCenterData(e)), DevCenterClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all devcenters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/devcenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterResource> GetDevCenters(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevCenterRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevCenterRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevCenterResource(Client, DevCenterData.DeserializeDevCenterData(e)), DevCenterClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all projects in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/projects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterProjectResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterProjectResource> GetDevCenterProjectsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevCenterProjectProjectsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevCenterProjectProjectsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevCenterProjectResource(Client, DevCenterProjectData.DeserializeDevCenterProjectData(e)), DevCenterProjectProjectsClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterProjects", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all projects in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/projects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterProjectResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterProjectResource> GetDevCenterProjects(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevCenterProjectProjectsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevCenterProjectProjectsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevCenterProjectResource(Client, DevCenterProjectData.DeserializeDevCenterProjectData(e)), DevCenterProjectProjectsClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterProjects", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the current status of an async operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/locations/{location}/operationStatuses/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationStatuses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<Response<DevCenterOperationStatus>> GetDevCenterOperationStatusAsync(AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = OperationStatusesClientDiagnostics.CreateScope("MockableDevCenterSubscriptionResource.GetDevCenterOperationStatus");
            scope.Start();
            try
            {
                var response = await OperationStatusesRestClient.GetAsync(Id.SubscriptionId, location, operationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current status of an async operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/locations/{location}/operationStatuses/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationStatuses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual Response<DevCenterOperationStatus> GetDevCenterOperationStatus(AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = OperationStatusesClientDiagnostics.CreateScope("MockableDevCenterSubscriptionResource.GetDevCenterOperationStatus");
            scope.Start();
            try
            {
                var response = OperationStatusesRestClient.Get(Id.SubscriptionId, location, operationId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the current usages and limits in this location for the provided subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterUsage> GetDevCenterUsagesByLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => DevCenterUsage.DeserializeDevCenterUsage(e), UsagesClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterUsagesByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the current usages and limits in this location for the provided subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterUsage> GetDevCenterUsagesByLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => DevCenterUsage.DeserializeDevCenterUsage(e), UsagesClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterUsagesByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<DevCenterNameAvailabilityResult>> CheckDevCenterNameAvailabilityAsync(DevCenterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("MockableDevCenterSubscriptionResource.CheckDevCenterNameAvailability");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityRestClient.ExecuteAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<DevCenterNameAvailabilityResult> CheckDevCenterNameAvailability(DevCenterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("MockableDevCenterSubscriptionResource.CheckDevCenterNameAvailability");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityRestClient.Execute(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Microsoft.DevCenter SKUs available in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterSkuDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterSkuDetails> GetDevCenterSkusBySubscriptionAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => DevCenterSkuDetails.DeserializeDevCenterSkuDetails(e), SkusClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterSkusBySubscription", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Microsoft.DevCenter SKUs available in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterSkuDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterSkuDetails> GetDevCenterSkusBySubscription(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => DevCenterSkuDetails.DeserializeDevCenterSkuDetails(e), SkusClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterSkusBySubscription", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists network connections in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/networkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkConnections_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterNetworkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterNetworkConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterNetworkConnectionResource> GetDevCenterNetworkConnectionsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevCenterNetworkConnectionNetworkConnectionsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevCenterNetworkConnectionNetworkConnectionsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevCenterNetworkConnectionResource(Client, DevCenterNetworkConnectionData.DeserializeDevCenterNetworkConnectionData(e)), DevCenterNetworkConnectionNetworkConnectionsClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterNetworkConnections", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists network connections in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevCenter/networkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkConnections_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevCenterNetworkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterNetworkConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterNetworkConnectionResource> GetDevCenterNetworkConnections(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevCenterNetworkConnectionNetworkConnectionsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevCenterNetworkConnectionNetworkConnectionsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevCenterNetworkConnectionResource(Client, DevCenterNetworkConnectionData.DeserializeDevCenterNetworkConnectionData(e)), DevCenterNetworkConnectionNetworkConnectionsClientDiagnostics, Pipeline, "MockableDevCenterSubscriptionResource.GetDevCenterNetworkConnections", "value", "nextLink", cancellationToken);
        }
    }
}
