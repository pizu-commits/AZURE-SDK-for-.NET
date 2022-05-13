// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecommendationResource" /> and their operations.
    /// Each <see cref="SiteRecommendationResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteRecommendationCollection" /> instance call the GetSiteRecommendations method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteRecommendationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteRecommendationRecommendationsClientDiagnostics;
        private readonly RecommendationsRestOperations _siteRecommendationRecommendationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteRecommendationCollection"/> class for mocking. </summary>
        protected SiteRecommendationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecommendationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteRecommendationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecommendationRecommendationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteRecommendationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecommendationResource.ResourceType, out string siteRecommendationRecommendationsApiVersion);
            _siteRecommendationRecommendationsRestClient = new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecommendationRecommendationsApiVersion);
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
        /// Get a recommendation rule for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByWebApp
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<SiteRecommendationResource>> GetAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecommendationRecommendationsRestClient.GetRuleDetailsByWebAppAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a recommendation rule for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByWebApp
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<SiteRecommendationResource> Get(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecommendationRecommendationsRestClient.GetRuleDetailsByWebApp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByWebApp
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecommendationRecommendationsRestClient.GetRuleDetailsByWebAppAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByWebApp
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecommendationRecommendationsRestClient.GetRuleDetailsByWebApp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
