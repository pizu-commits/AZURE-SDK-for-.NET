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
    /// <summary> The DdosProtectionPlans service client. </summary>
    public partial class DdosProtectionPlansClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DdosProtectionPlansRestClient RestClient { get; }
        /// <summary> Initializes a new instance of DdosProtectionPlansClient for mocking. </summary>
        protected DdosProtectionPlansClient()
        {
        }

        /// <summary> Initializes a new instance of DdosProtectionPlansClient. </summary>
        public DdosProtectionPlansClient(string subscriptionId, TokenCredential tokenCredential, NetworkManagementClientOptions options = null)
        {
            options ??= new NetworkManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new DdosProtectionPlansRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId);
        }

        /// <summary> Gets information about the specified DDoS protection plan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DdosProtectionPlan>> GetAsync(string resourceGroupName, string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, ddosProtectionPlanName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified DDoS protection plan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DdosProtectionPlan> Get(string resourceGroupName, string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, ddosProtectionPlanName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a DDoS protection plan tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the update DDoS protection plan resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DdosProtectionPlan>> UpdateTagsAsync(string resourceGroupName, string ddosProtectionPlanName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, ddosProtectionPlanName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a DDoS protection plan tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the update DDoS protection plan resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DdosProtectionPlan> UpdateTags(string resourceGroupName, string ddosProtectionPlanName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, ddosProtectionPlanName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all DDoS protection plans in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DdosProtectionPlan> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DdosProtectionPlan>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DdosProtectionPlan>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all DDoS protection plans in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DdosProtectionPlan> List(CancellationToken cancellationToken = default)
        {
            Page<DdosProtectionPlan> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DdosProtectionPlan> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
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

        /// <summary> Gets all the DDoS protection plans in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DdosProtectionPlan> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<DdosProtectionPlan>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DdosProtectionPlan>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all the DDoS protection plans in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DdosProtectionPlan> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<DdosProtectionPlan> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DdosProtectionPlan> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Deletes the specified DDoS protection plan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<DdosProtectionPlansDeleteOperation> StartDeleteAsync(string resourceGroupName, string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, ddosProtectionPlanName, cancellationToken).ConfigureAwait(false);
                return new DdosProtectionPlansDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, ddosProtectionPlanName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified DDoS protection plan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DdosProtectionPlansDeleteOperation StartDelete(string resourceGroupName, string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, ddosProtectionPlanName, cancellationToken);
                return new DdosProtectionPlansDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, ddosProtectionPlanName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DDoS protection plan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<DdosProtectionPlansCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string ddosProtectionPlanName, DdosProtectionPlan parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, ddosProtectionPlanName, parameters, cancellationToken).ConfigureAwait(false);
                return new DdosProtectionPlansCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, ddosProtectionPlanName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DDoS protection plan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DdosProtectionPlansCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string ddosProtectionPlanName, DdosProtectionPlan parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosProtectionPlanName == null)
            {
                throw new ArgumentNullException(nameof(ddosProtectionPlanName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosProtectionPlansClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, ddosProtectionPlanName, parameters, cancellationToken);
                return new DdosProtectionPlansCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, ddosProtectionPlanName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
