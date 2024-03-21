// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableApplicationInsightsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableApplicationInsightsResourceGroupResource"/> class for mocking. </summary>
        protected MockableApplicationInsightsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableApplicationInsightsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableApplicationInsightsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ApplicationInsightsComponentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ApplicationInsightsComponentResources and their operations over a ApplicationInsightsComponentResource. </returns>
        public virtual ApplicationInsightsComponentCollection GetApplicationInsightsComponents()
        {
            return GetCachedClient(client => new ApplicationInsightsComponentCollection(client, Id));
        }

        /// <summary>
        /// Returns an Application Insights component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/components/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Components_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-02-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationInsightsComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ApplicationInsightsComponentResource>> GetApplicationInsightsComponentAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetApplicationInsightsComponents().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns an Application Insights component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/components/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Components_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-02-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationInsightsComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ApplicationInsightsComponentResource> GetApplicationInsightsComponent(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetApplicationInsightsComponents().Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of WebTestResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of WebTestResources and their operations over a WebTestResource. </returns>
        public virtual WebTestCollection GetWebTests()
        {
            return GetCachedClient(client => new WebTestCollection(client, Id));
        }

        /// <summary>
        /// Get a specific Application Insights web test definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WebTestResource>> GetWebTestAsync(string webTestName, CancellationToken cancellationToken = default)
        {
            return await GetWebTests().GetAsync(webTestName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific Application Insights web test definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WebTestResource> GetWebTest(string webTestName, CancellationToken cancellationToken = default)
        {
            return GetWebTests().Get(webTestName, cancellationToken);
        }

        /// <summary> Gets a collection of WorkbookTemplateResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of WorkbookTemplateResources and their operations over a WorkbookTemplateResource. </returns>
        public virtual WorkbookTemplateCollection GetWorkbookTemplates()
        {
            return GetCachedClient(client => new WorkbookTemplateCollection(client, Id));
        }

        /// <summary>
        /// Get a single workbook template by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooktemplates/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkbookTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkbookTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WorkbookTemplateResource>> GetWorkbookTemplateAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetWorkbookTemplates().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a single workbook template by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooktemplates/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkbookTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkbookTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WorkbookTemplateResource> GetWorkbookTemplate(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetWorkbookTemplates().Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of MyWorkbookResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MyWorkbookResources and their operations over a MyWorkbookResource. </returns>
        public virtual MyWorkbookCollection GetMyWorkbooks()
        {
            return GetCachedClient(client => new MyWorkbookCollection(client, Id));
        }

        /// <summary>
        /// Get a single private workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MyWorkbookResource>> GetMyWorkbookAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetMyWorkbooks().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a single private workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MyWorkbookResource> GetMyWorkbook(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetMyWorkbooks().Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of WorkbookResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of WorkbookResources and their operations over a WorkbookResource. </returns>
        public virtual WorkbookCollection GetWorkbooks()
        {
            return GetCachedClient(client => new WorkbookCollection(client, Id));
        }

        /// <summary>
        /// Get a single workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WorkbookResource>> GetWorkbookAsync(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            return await GetWorkbooks().GetAsync(resourceName, canFetchContent, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a single workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WorkbookResource> GetWorkbook(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            return GetWorkbooks().Get(resourceName, canFetchContent, cancellationToken);
        }
    }
}
