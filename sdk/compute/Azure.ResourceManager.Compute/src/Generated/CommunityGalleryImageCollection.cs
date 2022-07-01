// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="CommunityGalleryImageResource" /> and their operations.
    /// Each <see cref="CommunityGalleryImageResource" /> in the collection will belong to the same instance of <see cref="CommunityGalleryResource" />.
    /// To get a <see cref="CommunityGalleryImageCollection" /> instance call the GetCommunityGalleryImages method from an instance of <see cref="CommunityGalleryResource" />.
    /// </summary>
    public partial class CommunityGalleryImageCollection : ArmCollection, IEnumerable<CommunityGalleryImageResource>, IAsyncEnumerable<CommunityGalleryImageResource>
    {
        private readonly ClientDiagnostics _communityGalleryImageClientDiagnostics;
        private readonly CommunityGalleryImagesRestOperations _communityGalleryImageRestClient;

        /// <summary> Initializes a new instance of the <see cref="CommunityGalleryImageCollection"/> class for mocking. </summary>
        protected CommunityGalleryImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CommunityGalleryImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CommunityGalleryImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _communityGalleryImageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CommunityGalleryImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CommunityGalleryImageResource.ResourceType, out string communityGalleryImageApiVersion);
            _communityGalleryImageRestClient = new CommunityGalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, communityGalleryImageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CommunityGalleryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CommunityGalleryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a community gallery image.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}
        /// Operation Id: CommunityGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<CommunityGalleryImageResource>> GetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _communityGalleryImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CommunityGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName);
                return Response.FromValue(new CommunityGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a community gallery image.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}
        /// Operation Id: CommunityGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<CommunityGalleryImageResource> Get(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = _communityGalleryImageRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CommunityGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName);
                return Response.FromValue(new CommunityGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List community gallery images inside a gallery.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images
        /// Operation Id: CommunityGalleryImages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommunityGalleryImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommunityGalleryImageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CommunityGalleryImageResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _communityGalleryImageRestClient.ListAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = CommunityGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, value.Name);
                        return new CommunityGalleryImageResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CommunityGalleryImageResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _communityGalleryImageRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = CommunityGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, value.Name);
                        return new CommunityGalleryImageResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
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
        /// List community gallery images inside a gallery.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images
        /// Operation Id: CommunityGalleryImages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommunityGalleryImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommunityGalleryImageResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CommunityGalleryImageResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _communityGalleryImageRestClient.List(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = CommunityGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, value.Name);
                        return new CommunityGalleryImageResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CommunityGalleryImageResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _communityGalleryImageRestClient.ListNextPage(nextLink, Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = CommunityGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, value.Name);
                        return new CommunityGalleryImageResource(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}
        /// Operation Id: CommunityGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _communityGalleryImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}
        /// Operation Id: CommunityGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _communityGalleryImageClientDiagnostics.CreateScope("CommunityGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _communityGalleryImageRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CommunityGalleryImageResource> IEnumerable<CommunityGalleryImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CommunityGalleryImageResource> IAsyncEnumerable<CommunityGalleryImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
