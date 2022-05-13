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
    /// A class representing a collection of <see cref="SiteHybridConnectionResource" /> and their operations.
    /// Each <see cref="SiteHybridConnectionResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteHybridConnectionCollection" /> instance call the GetSiteHybridConnections method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteHybridConnectionCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteHybridConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteHybridConnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteHybridConnectionCollection"/> class for mocking. </summary>
        protected SiteHybridConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteHybridConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteHybridConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteHybridConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteHybridConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteHybridConnectionResource.ResourceType, out string siteHybridConnectionWebAppsApiVersion);
            _siteHybridConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteHybridConnectionWebAppsApiVersion);
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
        /// Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_CreateOrUpdateRelayServiceConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="data"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteHybridConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string entityName, RelayServiceConnectionEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteHybridConnectionWebAppsClientDiagnostics.CreateScope("SiteHybridConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteHybridConnectionWebAppsRestClient.CreateOrUpdateRelayServiceConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteHybridConnectionResource>(Response.FromValue(new SiteHybridConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_CreateOrUpdateRelayServiceConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="data"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteHybridConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string entityName, RelayServiceConnectionEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteHybridConnectionWebAppsClientDiagnostics.CreateScope("SiteHybridConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteHybridConnectionWebAppsRestClient.CreateOrUpdateRelayServiceConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteHybridConnectionResource>(Response.FromValue(new SiteHybridConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Gets a hybrid connection configuration by its name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual async Task<Response<SiteHybridConnectionResource>> GetAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteHybridConnectionWebAppsClientDiagnostics.CreateScope("SiteHybridConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteHybridConnectionWebAppsRestClient.GetRelayServiceConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteHybridConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a hybrid connection configuration by its name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<SiteHybridConnectionResource> Get(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteHybridConnectionWebAppsClientDiagnostics.CreateScope("SiteHybridConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteHybridConnectionWebAppsRestClient.GetRelayServiceConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteHybridConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteHybridConnectionWebAppsClientDiagnostics.CreateScope("SiteHybridConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteHybridConnectionWebAppsRestClient.GetRelayServiceConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<bool> Exists(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteHybridConnectionWebAppsClientDiagnostics.CreateScope("SiteHybridConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteHybridConnectionWebAppsRestClient.GetRelayServiceConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken: cancellationToken);
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
