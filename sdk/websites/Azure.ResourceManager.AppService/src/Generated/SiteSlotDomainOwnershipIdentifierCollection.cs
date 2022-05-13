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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotDomainOwnershipIdentifierResource" /> and their operations.
    /// Each <see cref="SiteSlotDomainOwnershipIdentifierResource" /> in the collection will belong to the same instance of <see cref="SiteSlotResource" />.
    /// To get a <see cref="SiteSlotDomainOwnershipIdentifierCollection" /> instance call the GetSiteSlotDomainOwnershipIdentifiers method from an instance of <see cref="SiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotDomainOwnershipIdentifierCollection : ArmCollection, IEnumerable<SiteSlotDomainOwnershipIdentifierResource>, IAsyncEnumerable<SiteSlotDomainOwnershipIdentifierResource>
    {
        private readonly ClientDiagnostics _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotDomainOwnershipIdentifierWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDomainOwnershipIdentifierCollection"/> class for mocking. </summary>
        protected SiteSlotDomainOwnershipIdentifierCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDomainOwnershipIdentifierCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDomainOwnershipIdentifierCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDomainOwnershipIdentifierResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotDomainOwnershipIdentifierResource.ResourceType, out string siteSlotDomainOwnershipIdentifierWebAppsApiVersion);
            _siteSlotDomainOwnershipIdentifierWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDomainOwnershipIdentifierWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_CreateOrUpdateDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotDomainOwnershipIdentifierResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainOwnershipIdentifierName, IdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotDomainOwnershipIdentifierResource>(Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_CreateOrUpdateDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteSlotDomainOwnershipIdentifierResource> CreateOrUpdate(WaitUntil waitUntil, string domainOwnershipIdentifierName, IdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotDomainOwnershipIdentifierResource>(Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDomainOwnershipIdentifierResource>> GetAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteSlotDomainOwnershipIdentifierResource> Get(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists ownership identifiers for domain associated with web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers
        /// Operation Id: WebApps_ListDomainOwnershipIdentifiersSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDomainOwnershipIdentifierResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDomainOwnershipIdentifierResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDomainOwnershipIdentifierResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifierResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDomainOwnershipIdentifierResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifierResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists ownership identifiers for domain associated with web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers
        /// Operation Id: WebApps_ListDomainOwnershipIdentifiersSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDomainOwnershipIdentifierResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDomainOwnershipIdentifierResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDomainOwnershipIdentifierResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifierResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDomainOwnershipIdentifierResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifierResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDomainOwnershipIdentifierResource> IEnumerable<SiteSlotDomainOwnershipIdentifierResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDomainOwnershipIdentifierResource> IAsyncEnumerable<SiteSlotDomainOwnershipIdentifierResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
