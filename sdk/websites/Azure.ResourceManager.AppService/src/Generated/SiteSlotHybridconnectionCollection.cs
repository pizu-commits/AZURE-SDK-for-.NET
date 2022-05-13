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
    /// A class representing a collection of <see cref="SiteSlotHybridconnectionResource" /> and their operations.
    /// Each <see cref="SiteSlotHybridconnectionResource" /> in the collection will belong to the same instance of <see cref="SiteSlotResource" />.
    /// To get a <see cref="SiteSlotHybridconnectionCollection" /> instance call the GetSiteSlotHybridconnections method from an instance of <see cref="SiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotHybridconnectionCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteSlotHybridconnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotHybridconnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridconnectionCollection"/> class for mocking. </summary>
        protected SiteSlotHybridconnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridconnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotHybridconnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotHybridconnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotHybridconnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotHybridconnectionResource.ResourceType, out string siteSlotHybridconnectionWebAppsApiVersion);
            _siteSlotHybridconnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotHybridconnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// Operation Id: WebApps_CreateOrUpdateRelayServiceConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="data"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotHybridconnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string entityName, RelayServiceConnectionEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotHybridconnectionWebAppsClientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridconnectionWebAppsRestClient.CreateOrUpdateRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotHybridconnectionResource>(Response.FromValue(new SiteSlotHybridconnectionResource(Client, response), response.GetRawResponse()));
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// Operation Id: WebApps_CreateOrUpdateRelayServiceConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="data"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteSlotHybridconnectionResource> CreateOrUpdate(WaitUntil waitUntil, string entityName, RelayServiceConnectionEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotHybridconnectionWebAppsClientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotHybridconnectionWebAppsRestClient.CreateOrUpdateRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotHybridconnectionResource>(Response.FromValue(new SiteSlotHybridconnectionResource(Client, response), response.GetRawResponse()));
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnectionSlot
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotHybridconnectionResource>> GetAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteSlotHybridconnectionWebAppsClientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridconnectionWebAppsRestClient.GetRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridconnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a hybrid connection configuration by its name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnectionSlot
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<SiteSlotHybridconnectionResource> Get(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteSlotHybridconnectionWebAppsClientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotHybridconnectionWebAppsRestClient.GetRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridconnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnectionSlot
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteSlotHybridconnectionWebAppsClientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridconnectionWebAppsRestClient.GetRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnectionSlot
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<bool> Exists(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _siteSlotHybridconnectionWebAppsClientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotHybridconnectionWebAppsRestClient.GetRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken: cancellationToken);
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
