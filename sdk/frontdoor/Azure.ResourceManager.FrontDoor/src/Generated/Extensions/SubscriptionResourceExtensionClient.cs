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
using Azure.ResourceManager.FrontDoor.Models;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _managedRuleSetsClientDiagnostics;
        private ManagedRuleSetsRestOperations _managedRuleSetsRestClient;
        private ClientDiagnostics _frontDoorNameAvailabilityWithSubscriptionClientDiagnostics;
        private FrontDoorNameAvailabilityWithSubscriptionRestOperations _frontDoorNameAvailabilityWithSubscriptionRestClient;
        private ClientDiagnostics _frontDoorClientDiagnostics;
        private FrontDoorsRestOperations _frontDoorRestClient;
        private ClientDiagnostics _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics;
        private NetworkExperimentProfilesRestOperations _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient;

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

        private ClientDiagnostics ManagedRuleSetsClientDiagnostics => _managedRuleSetsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ManagedRuleSetsRestOperations ManagedRuleSetsRestClient => _managedRuleSetsRestClient ??= new ManagedRuleSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics FrontDoorNameAvailabilityWithSubscriptionClientDiagnostics => _frontDoorNameAvailabilityWithSubscriptionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private FrontDoorNameAvailabilityWithSubscriptionRestOperations FrontDoorNameAvailabilityWithSubscriptionRestClient => _frontDoorNameAvailabilityWithSubscriptionRestClient ??= new FrontDoorNameAvailabilityWithSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics FrontDoorClientDiagnostics => _frontDoorClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontDoorResource.ResourceType.Namespace, Diagnostics);
        private FrontDoorsRestOperations FrontDoorRestClient => _frontDoorRestClient ??= new FrontDoorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FrontDoorResource.ResourceType));
        private ClientDiagnostics FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontDoorNetworkExperimentProfileResource.ResourceType.Namespace, Diagnostics);
        private NetworkExperimentProfilesRestOperations FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient ??= new NetworkExperimentProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FrontDoorNetworkExperimentProfileResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedRuleSetDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = await ManagedRuleSetsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedRuleSetDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = await ManagedRuleSetsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(CancellationToken cancellationToken = default)
        {
            Page<ManagedRuleSetDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = ManagedRuleSetsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedRuleSetDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = ManagedRuleSetsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Check the availability of a Front Door subdomain.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailabilityWithSubscription_Check
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FrontDoorNameAvailabilityResult>> CheckFrontDoorNameAvailabilityAsync(FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = FrontDoorNameAvailabilityWithSubscriptionClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckFrontDoorNameAvailability");
            scope.Start();
            try
            {
                var response = await FrontDoorNameAvailabilityWithSubscriptionRestClient.CheckAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailabilityWithSubscription_Check
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FrontDoorNameAvailabilityResult> CheckFrontDoorNameAvailability(FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = FrontDoorNameAvailabilityWithSubscriptionClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckFrontDoorNameAvailability");
            scope.Start();
            try
            {
                var response = FrontDoorNameAvailabilityWithSubscriptionRestClient.Check(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors
        /// Operation Id: FrontDoors_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorResource> GetFrontDoorsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FrontDoorResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = FrontDoorClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoors");
                scope.Start();
                try
                {
                    var response = await FrontDoorRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FrontDoorResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = FrontDoorClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoors");
                scope.Start();
                try
                {
                    var response = await FrontDoorRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all of the Front Doors within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors
        /// Operation Id: FrontDoors_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorResource> GetFrontDoors(CancellationToken cancellationToken = default)
        {
            Page<FrontDoorResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = FrontDoorClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoors");
                scope.Start();
                try
                {
                    var response = FrontDoorRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FrontDoorResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = FrontDoorClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoors");
                scope.Start();
                try
                {
                    var response = FrontDoorRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of Network Experiment Profiles under a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles
        /// Operation Id: NetworkExperimentProfiles_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfilesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FrontDoorNetworkExperimentProfileResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoorNetworkExperimentProfiles");
                scope.Start();
                try
                {
                    var response = await FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorNetworkExperimentProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FrontDoorNetworkExperimentProfileResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoorNetworkExperimentProfiles");
                scope.Start();
                try
                {
                    var response = await FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorNetworkExperimentProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of Network Experiment Profiles under a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles
        /// Operation Id: NetworkExperimentProfiles_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfiles(CancellationToken cancellationToken = default)
        {
            Page<FrontDoorNetworkExperimentProfileResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoorNetworkExperimentProfiles");
                scope.Start();
                try
                {
                    var response = FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorNetworkExperimentProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FrontDoorNetworkExperimentProfileResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFrontDoorNetworkExperimentProfiles");
                scope.Start();
                try
                {
                    var response = FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontDoorNetworkExperimentProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
