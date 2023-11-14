// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteSlotWebJobResource" /> and their operations.
    /// Each <see cref="WebSiteSlotWebJobResource" /> in the collection will belong to the same instance of <see cref="WebSiteSlotResource" />.
    /// To get a <see cref="WebSiteSlotWebJobCollection" /> instance call the GetWebSiteSlotWebJobs method from an instance of <see cref="WebSiteSlotResource" />.
    /// </summary>
    public partial class WebSiteSlotWebJobCollection : ArmCollection, IEnumerable<WebSiteSlotWebJobResource>, IAsyncEnumerable<WebSiteSlotWebJobResource>
    {
        private readonly ClientDiagnostics _webSiteSlotWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotWebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotWebJobCollection"/> class for mocking. </summary>
        protected WebSiteSlotWebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotWebJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotWebJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotWebJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotWebJobResource.ResourceType, out string webSiteSlotWebJobWebAppsApiVersion);
            _webSiteSlotWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get webjob information for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotWebJobResource>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get webjob information for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<WebSiteSlotWebJobResource> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List webjobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListWebJobsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotWebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotWebJobResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotWebJobWebAppsRestClient.CreateListWebJobsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotWebJobWebAppsRestClient.CreateListWebJobsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteSlotWebJobResource(Client, WebJobData.DeserializeWebJobData(e)), _webSiteSlotWebJobWebAppsClientDiagnostics, Pipeline, "WebSiteSlotWebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List webjobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListWebJobsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotWebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotWebJobResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotWebJobWebAppsRestClient.CreateListWebJobsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotWebJobWebAppsRestClient.CreateListWebJobsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteSlotWebJobResource(Client, WebJobData.DeserializeWebJobData(e)), _webSiteSlotWebJobWebAppsClientDiagnostics, Pipeline, "WebSiteSlotWebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<NullableResponse<WebSiteSlotWebJobResource>> GetIfExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotWebJobResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual NullableResponse<WebSiteSlotWebJobResource> GetIfExists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotWebJobResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotWebJobResource> IEnumerable<WebSiteSlotWebJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotWebJobResource> IAsyncEnumerable<WebSiteSlotWebJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
