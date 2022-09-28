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
    /// A Class representing a HostingEnvironmentRecommendation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HostingEnvironmentRecommendationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHostingEnvironmentRecommendationResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceEnvironmentResource" /> using the GetHostingEnvironmentRecommendation method.
    /// </summary>
    public partial class HostingEnvironmentRecommendationResource : RecommendationRuleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentRecommendationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hostingEnvironmentName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hostingEnvironmentRecommendationRecommendationsClientDiagnostics;
        private readonly RecommendationsRestOperations _hostingEnvironmentRecommendationRecommendationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentRecommendationResource"/> class for mocking. </summary>
        protected HostingEnvironmentRecommendationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HostingEnvironmentRecommendationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HostingEnvironmentRecommendationResource(ArmClient client, RecommendationRuleData data) : base(client, data)
        {
            _hostingEnvironmentRecommendationRecommendationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hostingEnvironmentRecommendationRecommendationsApiVersion);
            _hostingEnvironmentRecommendationRecommendationsRestClient = new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentRecommendationRecommendationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentRecommendationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentRecommendationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentRecommendationRecommendationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hostingEnvironmentRecommendationRecommendationsApiVersion);
            _hostingEnvironmentRecommendationRecommendationsRestClient = new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentRecommendationRecommendationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/recommendations";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByHostingEnvironment
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<RecommendationRuleResource>> GetCoreAsync(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateSeen, recommendationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByHostingEnvironment
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<HostingEnvironmentRecommendationResource>> GetAsync(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(updateSeen, recommendationId, cancellationToken).ConfigureAwait(false);
            return Response.FromValue((HostingEnvironmentRecommendationResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByHostingEnvironment
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<RecommendationRuleResource> GetCore(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironment(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateSeen, recommendationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}
        /// Operation Id: Recommendations_GetRuleDetailsByHostingEnvironment
        /// </summary>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<HostingEnvironmentRecommendationResource> Get(bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            var result = GetCore(updateSeen, recommendationId, cancellationToken);
            return Response.FromValue((HostingEnvironmentRecommendationResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Disables the specific rule for a web site permanently.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}/disable
        /// Operation Id: Recommendations_DisableRecommendationForHostingEnvironment
        /// </summary>
        /// <param name="environmentName"> Site name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual async Task<Response> DisableRecommendationForHostingEnvironmentAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(environmentName, nameof(environmentName));

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.DisableRecommendationForHostingEnvironment");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentRecommendationRecommendationsRestClient.DisableRecommendationForHostingEnvironmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, environmentName, cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}/disable
        /// Operation Id: Recommendations_DisableRecommendationForHostingEnvironment
        /// </summary>
        /// <param name="environmentName"> Site name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response DisableRecommendationForHostingEnvironment(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(environmentName, nameof(environmentName));

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationResource.DisableRecommendationForHostingEnvironment");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentRecommendationRecommendationsRestClient.DisableRecommendationForHostingEnvironment(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, environmentName, cancellationToken);
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
