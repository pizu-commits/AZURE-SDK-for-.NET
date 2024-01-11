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
    /// A class representing a collection of <see cref="SiteConfigAppsettingResource"/> and their operations.
    /// Each <see cref="SiteConfigAppsettingResource"/> in the collection will belong to the same instance of <see cref="WebSiteResource"/>.
    /// To get a <see cref="SiteConfigAppsettingCollection"/> instance call the GetSiteConfigAppsettings method from an instance of <see cref="WebSiteResource"/>.
    /// </summary>
    public partial class SiteConfigAppsettingCollection : ArmCollection, IEnumerable<SiteConfigAppsettingResource>, IAsyncEnumerable<SiteConfigAppsettingResource>
    {
        private readonly ClientDiagnostics _siteConfigAppsettingWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigAppsettingWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigAppsettingCollection"/> class for mocking. </summary>
        protected SiteConfigAppsettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigAppsettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteConfigAppsettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteConfigAppsettingWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteConfigAppsettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteConfigAppsettingResource.ResourceType, out string siteConfigAppsettingWebAppsApiVersion);
            _siteConfigAppsettingWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteConfigAppsettingWebAppsApiVersion);
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
        /// Description for Gets the config reference and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingKeyVaultReference</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual async Task<Response<SiteConfigAppsettingResource>> GetAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingKeyVaultReference</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual Response<SiteConfigAppsettingResource> Get(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Get");
            scope.Start();
            try
            {
                var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingsKeyVaultReferences</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteConfigAppsettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteConfigAppsettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteConfigAppsettingWebAppsRestClient.CreateGetAppSettingsKeyVaultReferencesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteConfigAppsettingWebAppsRestClient.CreateGetAppSettingsKeyVaultReferencesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteConfigAppsettingResource(Client, ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(e)), _siteConfigAppsettingWebAppsClientDiagnostics, Pipeline, "SiteConfigAppsettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingsKeyVaultReferences</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteConfigAppsettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteConfigAppsettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteConfigAppsettingWebAppsRestClient.CreateGetAppSettingsKeyVaultReferencesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteConfigAppsettingWebAppsRestClient.CreateGetAppSettingsKeyVaultReferencesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteConfigAppsettingResource(Client, ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(e)), _siteConfigAppsettingWebAppsClientDiagnostics, Pipeline, "SiteConfigAppsettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingKeyVaultReference</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingKeyVaultReference</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual Response<bool> Exists(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingKeyVaultReference</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteConfigAppsettingResource>> GetIfExistsAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteConfigAppsettingResource>(response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsettingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetAppSettingKeyVaultReference</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteConfigAppsettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual NullableResponse<SiteConfigAppsettingResource> GetIfExists(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteConfigAppsettingResource>(response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteConfigAppsettingResource> IEnumerable<SiteConfigAppsettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteConfigAppsettingResource> IAsyncEnumerable<SiteConfigAppsettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
