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
    /// <summary> The ApplicationSecurityGroups service client. </summary>
    public partial class ApplicationSecurityGroupsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ApplicationSecurityGroupsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ApplicationSecurityGroupsClient for mocking. </summary>
        protected ApplicationSecurityGroupsClient()
        {
        }

        /// <summary> Initializes a new instance of ApplicationSecurityGroupsClient. </summary>
        public ApplicationSecurityGroupsClient(string subscriptionId, TokenCredential tokenCredential, NetworkManagementClientOptions options = null)
        {
            options ??= new NetworkManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new ApplicationSecurityGroupsRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId);
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationSecurityGroup>> GetAsync(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, applicationSecurityGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationSecurityGroup> Get(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, applicationSecurityGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an application security group&apos;s tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to update application security group tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationSecurityGroup>> UpdateTagsAsync(string resourceGroupName, string applicationSecurityGroupName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, applicationSecurityGroupName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an application security group&apos;s tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to update application security group tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationSecurityGroup> UpdateTags(string resourceGroupName, string applicationSecurityGroupName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, applicationSecurityGroupName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ApplicationSecurityGroup> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ApplicationSecurityGroup> ListAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAll(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
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

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ApplicationSecurityGroup> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ApplicationSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ApplicationSecurityGroup> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ApplicationSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Deletes the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<ApplicationSecurityGroupsDeleteOperation> StartDeleteAsync(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, applicationSecurityGroupName, cancellationToken).ConfigureAwait(false);
                return new ApplicationSecurityGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, applicationSecurityGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationSecurityGroupsDeleteOperation StartDelete(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, applicationSecurityGroupName, cancellationToken);
                return new ApplicationSecurityGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, applicationSecurityGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<ApplicationSecurityGroupsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, applicationSecurityGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return new ApplicationSecurityGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationSecurityGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationSecurityGroupsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, applicationSecurityGroupName, parameters, cancellationToken);
                return new ApplicationSecurityGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationSecurityGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
