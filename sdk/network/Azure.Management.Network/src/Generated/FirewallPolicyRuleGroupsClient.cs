// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The FirewallPolicyRuleGroups service client. </summary>
    public partial class FirewallPolicyRuleGroupsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal FirewallPolicyRuleGroupsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of FirewallPolicyRuleGroupsClient for mocking. </summary>
        protected FirewallPolicyRuleGroupsClient()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleGroupsClient. </summary>
        public FirewallPolicyRuleGroupsClient(string subscriptionId, TokenCredential tokenCredential, NetworkManagementClientOptions options = null)
        {
            options ??= new NetworkManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new FirewallPolicyRuleGroupsRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId);
        }

        /// <summary> Gets the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallPolicyRuleGroup>> GetAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallPolicyRuleGroup> Get(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<FirewallPolicyRuleGroup> ListAsync(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            async Task<Page<FirewallPolicyRuleGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, firewallPolicyName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallPolicyRuleGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, firewallPolicyName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<FirewallPolicyRuleGroup> List(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            Page<FirewallPolicyRuleGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, firewallPolicyName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallPolicyRuleGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, firewallPolicyName, cancellationToken);
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

        /// <summary> Deletes the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<FirewallPolicyRuleGroupsDeleteOperation> StartDeleteAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken).ConfigureAwait(false);
                return new FirewallPolicyRuleGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName, ruleGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual FirewallPolicyRuleGroupsDeleteOperation StartDelete(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken);
                return new FirewallPolicyRuleGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName, ruleGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<FirewallPolicyRuleGroupsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return new FirewallPolicyRuleGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, ruleGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual FirewallPolicyRuleGroupsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, cancellationToken);
                return new FirewallPolicyRuleGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, ruleGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
