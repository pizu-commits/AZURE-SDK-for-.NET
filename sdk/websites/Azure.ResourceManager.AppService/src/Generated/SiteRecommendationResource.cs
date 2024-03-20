// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteRecommendation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteRecommendationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteRecommendationResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource"/> using the GetSiteRecommendation method.
    /// </summary>
    public partial class SiteRecommendationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteRecommendationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="siteName"> The siteName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteRecommendationRecommendationsClientDiagnostics;
        private readonly RecommendationsRestOperations _siteRecommendationRecommendationsRestClient;
        private readonly RecommendationRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/recommendations";

        /// <summary> Initializes a new instance of the <see cref="SiteRecommendationResource"/> class for mocking. </summary>
        protected SiteRecommendationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecommendationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteRecommendationResource(ArmClient client, RecommendationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecommendationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteRecommendationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecommendationRecommendationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteRecommendationRecommendationsApiVersion);
            _siteRecommendationRecommendationsRestClient = new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecommendationRecommendationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RecommendationRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByWebApp</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteRecommendationResource>> GetAsync(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationResource.Get");
            scope.Start();
            try
            {
                var response = await _siteRecommendationRecommendationsRestClient.GetRuleDetailsByWebAppAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateSeen, recommendationId, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get a recommendation rule for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByWebApp</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteRecommendationResource> Get(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationResource.Get");
            scope.Start();
            try
            {
                var response = _siteRecommendationRecommendationsRestClient.GetRuleDetailsByWebApp(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateSeen, recommendationId, cancellationToken);
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
        /// Description for Disables the specific rule for a web site permanently.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_DisableRecommendationForSite</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DisableAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationResource.Disable");
            scope.Start();
            try
            {
                var response = await _siteRecommendationRecommendationsRestClient.DisableRecommendationForSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Disables the specific rule for a web site permanently.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_DisableRecommendationForSite</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Disable(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecommendationRecommendationsClientDiagnostics.CreateScope("SiteRecommendationResource.Disable");
            scope.Start();
            try
            {
                var response = _siteRecommendationRecommendationsRestClient.DisableRecommendationForSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
