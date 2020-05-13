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
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The Galleries service client. </summary>
    public partial class GalleriesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GalleriesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of GalleriesClient for mocking. </summary>
        protected GalleriesClient()
        {
        }

        /// <summary> Initializes a new instance of GalleriesClient. </summary>
        public GalleriesClient(string subscriptionId, TokenCredential tokenCredential, ComputeManagementClientOptions options = null)
        {
            options ??= new ComputeManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new GalleriesRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId);
        }

        /// <summary> Retrieves information about a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Gallery>> GetAsync(string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, galleryName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Gallery> Get(string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, galleryName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List galleries under a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Gallery> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<Gallery>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.ListByResourceGroup");
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
            async Task<Page<Gallery>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.ListByResourceGroup");
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

        /// <summary> List galleries under a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Gallery> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<Gallery> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.ListByResourceGroup");
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
            Page<Gallery> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.ListByResourceGroup");
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

        /// <summary> List galleries under a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Gallery> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Gallery>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.List");
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
            async Task<Page<Gallery>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.List");
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

        /// <summary> List galleries under a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Gallery> List(CancellationToken cancellationToken = default)
        {
            Page<Gallery> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.List");
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
            Page<Gallery> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleriesClient.List");
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

        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<GalleriesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string galleryName, Gallery gallery, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, galleryName, gallery, cancellationToken).ConfigureAwait(false);
                return new GalleriesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, galleryName, gallery).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual GalleriesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string galleryName, Gallery gallery, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, galleryName, gallery, cancellationToken);
                return new GalleriesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, galleryName, gallery).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<GalleriesUpdateOperation> StartUpdateAsync(string resourceGroupName, string galleryName, GalleryUpdate gallery, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, galleryName, gallery, cancellationToken).ConfigureAwait(false);
                return new GalleriesUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, galleryName, gallery).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual GalleriesUpdateOperation StartUpdate(string resourceGroupName, string galleryName, GalleryUpdate gallery, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, galleryName, gallery, cancellationToken);
                return new GalleriesUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, galleryName, gallery).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<GalleriesDeleteOperation> StartDeleteAsync(string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, galleryName, cancellationToken).ConfigureAwait(false);
                return new GalleriesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, galleryName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a Shared Image Gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual GalleriesDeleteOperation StartDelete(string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleriesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, galleryName, cancellationToken);
                return new GalleriesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, galleryName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
