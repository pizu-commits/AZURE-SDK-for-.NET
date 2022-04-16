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
    /// A class representing a collection of <see cref="SiteSiteextensionResource" /> and their operations.
    /// Each <see cref="SiteSiteextensionResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteSiteextensionCollection" /> instance call the GetSiteSiteextensions method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteSiteextensionCollection : ArmCollection, IEnumerable<SiteSiteextensionResource>, IAsyncEnumerable<SiteSiteextensionResource>
    {
        private readonly ClientDiagnostics _siteSiteextensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSiteextensionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSiteextensionCollection"/> class for mocking. </summary>
        protected SiteSiteextensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSiteextensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSiteextensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSiteextensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSiteextensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSiteextensionResource.ResourceType, out string siteSiteextensionWebAppsApiVersion);
            _siteSiteextensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSiteextensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Install site extension on a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_InstallSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSiteextensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSiteextensionWebAppsRestClient.InstallSiteExtensionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSiteextensionResource>(new SiteSiteextensionOperationSource(Client), _siteSiteextensionWebAppsClientDiagnostics, Pipeline, _siteSiteextensionWebAppsRestClient.CreateInstallSiteExtensionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Install site extension on a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_InstallSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual ArmOperation<SiteSiteextensionResource> CreateOrUpdate(WaitUntil waitUntil, string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSiteextensionWebAppsRestClient.InstallSiteExtension(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSiteextensionResource>(new SiteSiteextensionOperationSource(Client), _siteSiteextensionWebAppsClientDiagnostics, Pipeline, _siteSiteextensionWebAppsRestClient.CreateInstallSiteExtensionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual async Task<Response<SiteSiteextensionResource>> GetAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSiteextensionWebAppsRestClient.GetSiteExtensionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSiteextensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual Response<SiteSiteextensionResource> Get(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSiteextensionWebAppsRestClient.GetSiteExtension(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSiteextensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get list of siteextensions for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions
        /// Operation Id: WebApps_ListSiteExtensions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSiteextensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSiteextensionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSiteextensionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSiteextensionWebAppsRestClient.ListSiteExtensionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSiteextensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSiteextensionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSiteextensionWebAppsRestClient.ListSiteExtensionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSiteextensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get list of siteextensions for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions
        /// Operation Id: WebApps_ListSiteExtensions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSiteextensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSiteextensionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSiteextensionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSiteextensionWebAppsRestClient.ListSiteExtensions(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSiteextensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSiteextensionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSiteextensionWebAppsRestClient.ListSiteExtensionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSiteextensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSiteextensionWebAppsRestClient.GetSiteExtensionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual Response<bool> Exists(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _siteSiteextensionWebAppsClientDiagnostics.CreateScope("SiteSiteextensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSiteextensionWebAppsRestClient.GetSiteExtension(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteExtensionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSiteextensionResource> IEnumerable<SiteSiteextensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSiteextensionResource> IAsyncEnumerable<SiteSiteextensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
