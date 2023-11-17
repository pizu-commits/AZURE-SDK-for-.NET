// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PostgreSql.FlexibleServers;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockablePostgreSqlFlexibleServersSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _locationBasedCapabilitiesClientDiagnostics;
        private LocationBasedCapabilitiesRestOperations _locationBasedCapabilitiesRestClient;
        private ClientDiagnostics _checkNameAvailabilityClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityRestClient;
        private ClientDiagnostics _checkNameAvailabilityWithLocationClientDiagnostics;
        private CheckNameAvailabilityWithLocationRestOperations _checkNameAvailabilityWithLocationRestClient;
        private ClientDiagnostics _postgreSqlFlexibleServerServersClientDiagnostics;
        private ServersRestOperations _postgreSqlFlexibleServerServersRestClient;
        private ClientDiagnostics _virtualNetworkSubnetUsageClientDiagnostics;
        private VirtualNetworkSubnetUsageRestOperations _virtualNetworkSubnetUsageRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockablePostgreSqlFlexibleServersSubscriptionResource"/> class for mocking. </summary>
        protected MockablePostgreSqlFlexibleServersSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePostgreSqlFlexibleServersSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePostgreSqlFlexibleServersSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LocationBasedCapabilitiesClientDiagnostics => _locationBasedCapabilitiesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationBasedCapabilitiesRestOperations LocationBasedCapabilitiesRestClient => _locationBasedCapabilitiesRestClient ??= new LocationBasedCapabilitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityClientDiagnostics => _checkNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityRestClient => _checkNameAvailabilityRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityWithLocationClientDiagnostics => _checkNameAvailabilityWithLocationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityWithLocationRestOperations CheckNameAvailabilityWithLocationRestClient => _checkNameAvailabilityWithLocationRestClient ??= new CheckNameAvailabilityWithLocationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PostgreSqlFlexibleServerServersClientDiagnostics => _postgreSqlFlexibleServerServersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlFlexibleServerResource.ResourceType.Namespace, Diagnostics);
        private ServersRestOperations PostgreSqlFlexibleServerServersRestClient => _postgreSqlFlexibleServerServersRestClient ??= new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(PostgreSqlFlexibleServerResource.ResourceType));
        private ClientDiagnostics VirtualNetworkSubnetUsageClientDiagnostics => _virtualNetworkSubnetUsageClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private VirtualNetworkSubnetUsageRestOperations VirtualNetworkSubnetUsageRestClient => _virtualNetworkSubnetUsageRestClient ??= new VirtualNetworkSubnetUsageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilities_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerCapabilityProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerCapabilityProperties> ExecuteLocationBasedCapabilitiesAsync(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationBasedCapabilitiesRestClient.CreateExecuteRequest(Id.SubscriptionId, locationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationBasedCapabilitiesRestClient.CreateExecuteNextPageRequest(nextLink, Id.SubscriptionId, locationName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PostgreSqlFlexibleServerCapabilityProperties.DeserializePostgreSqlFlexibleServerCapabilityProperties, LocationBasedCapabilitiesClientDiagnostics, Pipeline, "MockablePostgreSqlFlexibleServersSubscriptionResource.ExecuteLocationBasedCapabilities", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilities_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerCapabilityProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerCapabilityProperties> ExecuteLocationBasedCapabilities(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationBasedCapabilitiesRestClient.CreateExecuteRequest(Id.SubscriptionId, locationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationBasedCapabilitiesRestClient.CreateExecuteNextPageRequest(nextLink, Id.SubscriptionId, locationName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PostgreSqlFlexibleServerCapabilityProperties.DeserializePostgreSqlFlexibleServerCapabilityProperties, LocationBasedCapabilitiesClientDiagnostics, Pipeline, "MockablePostgreSqlFlexibleServersSubscriptionResource.ExecuteLocationBasedCapabilities", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerNameAvailabilityResult>> CheckPostgreSqlFlexibleServerNameAvailabilityAsync(PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersSubscriptionResource.CheckPostgreSqlFlexibleServerNameAvailability");
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerNameAvailabilityResult> CheckPostgreSqlFlexibleServerNameAvailability(PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersSubscriptionResource.CheckPostgreSqlFlexibleServerNameAvailability");
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
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityWithLocation_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerNameAvailabilityResult>> CheckPostgreSqlFlexibleServerNameAvailabilityWithLocationAsync(AzureLocation locationName, PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityWithLocationClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersSubscriptionResource.CheckPostgreSqlFlexibleServerNameAvailabilityWithLocation");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityWithLocationRestClient.ExecuteAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityWithLocation_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerNameAvailabilityResult> CheckPostgreSqlFlexibleServerNameAvailabilityWithLocation(AzureLocation locationName, PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityWithLocationClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersSubscriptionResource.CheckPostgreSqlFlexibleServerNameAvailabilityWithLocation");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityWithLocationRestClient.Execute(Id.SubscriptionId, locationName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerResource> GetPostgreSqlFlexibleServersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PostgreSqlFlexibleServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PostgreSqlFlexibleServerServersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerResource(Client, PostgreSqlFlexibleServerData.DeserializePostgreSqlFlexibleServerData(e)), PostgreSqlFlexibleServerServersClientDiagnostics, Pipeline, "MockablePostgreSqlFlexibleServersSubscriptionResource.GetPostgreSqlFlexibleServers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerResource> GetPostgreSqlFlexibleServers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PostgreSqlFlexibleServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PostgreSqlFlexibleServerServersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerResource(Client, PostgreSqlFlexibleServerData.DeserializePostgreSqlFlexibleServerData(e)), PostgreSqlFlexibleServerServersClientDiagnostics, Pipeline, "MockablePostgreSqlFlexibleServersSubscriptionResource.GetPostgreSqlFlexibleServers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkVirtualNetworkSubnetUsage</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkSubnetUsage_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>> ExecuteVirtualNetworkSubnetUsageAsync(AzureLocation locationName, PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, nameof(postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter));

            using var scope = VirtualNetworkSubnetUsageClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersSubscriptionResource.ExecuteVirtualNetworkSubnetUsage");
            scope.Start();
            try
            {
                var response = await VirtualNetworkSubnetUsageRestClient.ExecuteAsync(Id.SubscriptionId, locationName, postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkVirtualNetworkSubnetUsage</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkSubnetUsage_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult> ExecuteVirtualNetworkSubnetUsage(AzureLocation locationName, PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, nameof(postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter));

            using var scope = VirtualNetworkSubnetUsageClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersSubscriptionResource.ExecuteVirtualNetworkSubnetUsage");
            scope.Start();
            try
            {
                var response = VirtualNetworkSubnetUsageRestClient.Execute(Id.SubscriptionId, locationName, postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
