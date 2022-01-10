// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing collection of PrivateLink and their operations over its parent. </summary>
    public partial class PrivateLinkCollection : ArmCollection, IEnumerable<PrivateLink>, IAsyncEnumerable<PrivateLink>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _privateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkCollection"/> class for mocking. </summary>
        protected PrivateLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PrivateLinkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => DeviceUpdateAccount.ResourceType;

        // Collection level operations.

        /// <summary> Get the specified private link resource associated with the device update account. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<PrivateLink> Get(string groupId, CancellationToken cancellationToken = default)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _privateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified private link resource associated with the device update account. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public async virtual Task<Response<PrivateLink>> GetAsync(string groupId, CancellationToken cancellationToken = default)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PrivateLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<PrivateLink> GetIfExists(string groupId, CancellationToken cancellationToken = default)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PrivateLink>(null, response.GetRawResponse())
                    : Response.FromValue(new PrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public async virtual Task<Response<PrivateLink>> GetIfExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _privateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PrivateLink>(null, response.GetRawResponse())
                    : Response.FromValue(new PrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<bool> Exists(string groupId, CancellationToken cancellationToken = default)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(groupId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all private link resources in a device update account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkResourcesRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLink(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> List all private link resources in a device update account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkResourcesRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLink(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<PrivateLink> IEnumerable<PrivateLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateLink> IAsyncEnumerable<PrivateLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, PrivateLink, PrivateLinkData> Construct() { }
    }
}
