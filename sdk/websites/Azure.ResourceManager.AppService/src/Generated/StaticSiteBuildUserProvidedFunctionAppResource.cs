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
    /// A Class representing a StaticSiteBuildUserProvidedFunctionApp along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StaticSiteBuildUserProvidedFunctionAppResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStaticSiteBuildUserProvidedFunctionAppResource method.
    /// Otherwise you can get one from its parent resource <see cref="StaticSiteBuildARMResource" /> using the GetStaticSiteBuildUserProvidedFunctionApp method.
    /// </summary>
    public partial class StaticSiteBuildUserProvidedFunctionAppResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteBuildUserProvidedFunctionAppResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string environmentName, string functionAppName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient;
        private readonly StaticSiteUserProvidedFunctionAppARMResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionAppResource"/> class for mocking. </summary>
        protected StaticSiteBuildUserProvidedFunctionAppResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteBuildUserProvidedFunctionAppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteBuildUserProvidedFunctionAppResource(ArmClient client, StaticSiteUserProvidedFunctionAppARMResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionAppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteBuildUserProvidedFunctionAppResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/builds/userProvidedFunctionApps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteUserProvidedFunctionAppARMResourceData Data
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
        /// Gets the details of the user provided function app registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSiteBuildUserProvidedFunctionAppResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets the details of the user provided function app registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteBuildUserProvidedFunctionAppResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppResource.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Detach the user provided function app from the static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_DetachUserProvidedFunctionAppFromStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Detach the user provided function app from the static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_DetachUserProvidedFunctionAppFromStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Register a user provided function app with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteBuildUserProvidedFunctionAppResource>> UpdateAsync(WaitUntil waitUntil, StaticSiteUserProvidedFunctionAppARMResourceData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppResource.Update");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, isForced, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteBuildUserProvidedFunctionAppResource>(new StaticSiteBuildUserProvidedFunctionAppOperationSource(Client), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Register a user provided function app with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StaticSiteBuildUserProvidedFunctionAppResource> Update(WaitUntil waitUntil, StaticSiteUserProvidedFunctionAppARMResourceData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppResource.Update");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, isForced, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteBuildUserProvidedFunctionAppResource>(new StaticSiteBuildUserProvidedFunctionAppOperationSource(Client), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, isForced).Request, response, OperationFinalStateVia.Location);
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
    }
}
