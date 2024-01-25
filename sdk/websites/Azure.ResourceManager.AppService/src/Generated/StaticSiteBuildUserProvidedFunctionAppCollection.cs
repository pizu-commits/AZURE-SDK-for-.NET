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
    /// A class representing a collection of <see cref="StaticSiteBuildUserProvidedFunctionAppResource"/> and their operations.
    /// Each <see cref="StaticSiteBuildUserProvidedFunctionAppResource"/> in the collection will belong to the same instance of <see cref="StaticSiteBuildResource"/>.
    /// To get a <see cref="StaticSiteBuildUserProvidedFunctionAppCollection"/> instance call the GetStaticSiteBuildUserProvidedFunctionApps method from an instance of <see cref="StaticSiteBuildResource"/>.
    /// </summary>
    public partial class StaticSiteBuildUserProvidedFunctionAppCollection : ArmCollection, IEnumerable<StaticSiteBuildUserProvidedFunctionAppResource>, IAsyncEnumerable<StaticSiteBuildUserProvidedFunctionAppResource>
    {
        private readonly ClientDiagnostics _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionAppCollection"/> class for mocking. </summary>
        protected StaticSiteBuildUserProvidedFunctionAppCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionAppCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteBuildUserProvidedFunctionAppCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteBuildUserProvidedFunctionAppResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteBuildUserProvidedFunctionAppResource.ResourceType, out string staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteBuildResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteBuildResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Register a user provided function app with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_RegisterUserProvidedFunctionAppWithStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionAppName"> Name of the function app to register with the static site build. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteBuildUserProvidedFunctionAppResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string functionAppName, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, data, isForced, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteBuildUserProvidedFunctionAppResource>(new StaticSiteBuildUserProvidedFunctionAppOperationSource(Client), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, data, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Register a user provided function app with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_RegisterUserProvidedFunctionAppWithStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionAppName"> Name of the function app to register with the static site build. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StaticSiteBuildUserProvidedFunctionAppResource> CreateOrUpdate(WaitUntil waitUntil, string functionAppName, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, data, isForced, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteBuildUserProvidedFunctionAppResource>(new StaticSiteBuildUserProvidedFunctionAppOperationSource(Client), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, data, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildUserProvidedFunctionAppResource>> GetAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<StaticSiteBuildUserProvidedFunctionAppResource> Get(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of the user provided function apps registered with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppsForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteBuildUserProvidedFunctionAppResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteBuildUserProvidedFunctionAppResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateGetUserProvidedFunctionAppsForStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateGetUserProvidedFunctionAppsForStaticSiteBuildNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildUserProvidedFunctionAppResource(Client, StaticSiteUserProvidedFunctionAppData.DeserializeStaticSiteUserProvidedFunctionAppData(e)), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildUserProvidedFunctionAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the details of the user provided function apps registered with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppsForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteBuildUserProvidedFunctionAppResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteBuildUserProvidedFunctionAppResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateGetUserProvidedFunctionAppsForStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateGetUserProvidedFunctionAppsForStaticSiteBuildNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildUserProvidedFunctionAppResource(Client, StaticSiteUserProvidedFunctionAppData.DeserializeStaticSiteUserProvidedFunctionAppData(e)), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildUserProvidedFunctionAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<NullableResponse<StaticSiteBuildUserProvidedFunctionAppResource>> GetIfExistsAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteBuildUserProvidedFunctionAppResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteBuildUserProvidedFunctionAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual NullableResponse<StaticSiteBuildUserProvidedFunctionAppResource> GetIfExists(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteBuildUserProvidedFunctionAppResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteBuildUserProvidedFunctionAppResource> IEnumerable<StaticSiteBuildUserProvidedFunctionAppResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteBuildUserProvidedFunctionAppResource> IAsyncEnumerable<StaticSiteBuildUserProvidedFunctionAppResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
