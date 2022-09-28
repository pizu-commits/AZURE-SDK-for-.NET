// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGuardProxyBaseResource" /> and their operations.
    /// Each <see cref="ResourceGuardProxyBaseResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ResourceGuardProxyBaseResourceCollection" /> instance call the GetResourceGuardProxyBaseResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ResourceGuardProxyBaseResourceCollection : ArmCollection, IEnumerable<ResourceGuardProxyBaseResource>, IAsyncEnumerable<ResourceGuardProxyBaseResource>
    {
        private readonly ClientDiagnostics _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics;
        private readonly ResourceGuardProxyRestOperations _resourceGuardProxyBaseResourceResourceGuardProxyRestClient;
        private readonly ClientDiagnostics _resourceGuardProxyBaseResourceResourceGuardProxiesClientDiagnostics;
        private readonly ResourceGuardProxiesRestOperations _resourceGuardProxyBaseResourceResourceGuardProxiesRestClient;
        private readonly string _vaultName;

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardProxyBaseResourceCollection"/> class for mocking. </summary>
        protected ResourceGuardProxyBaseResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardProxyBaseResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ResourceGuardProxyBaseResourceCollection(ArmClient client, ResourceIdentifier id, string vaultName) : base(client, id)
        {
            _vaultName = vaultName;
            _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ResourceGuardProxyBaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGuardProxyBaseResource.ResourceType, out string resourceGuardProxyBaseResourceResourceGuardProxyApiVersion);
            _resourceGuardProxyBaseResourceResourceGuardProxyRestClient = new ResourceGuardProxyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGuardProxyBaseResourceResourceGuardProxyApiVersion);
            _resourceGuardProxyBaseResourceResourceGuardProxiesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ResourceGuardProxyBaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGuardProxyBaseResource.ResourceType, out string resourceGuardProxyBaseResourceResourceGuardProxiesApiVersion);
            _resourceGuardProxyBaseResourceResourceGuardProxiesRestClient = new ResourceGuardProxiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGuardProxyBaseResourceResourceGuardProxiesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add or Update ResourceGuardProxy under vault
        /// Secures vault critical operations
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}
        /// Operation Id: ResourceGuardProxy_Put
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceGuardProxyName"> The String to use. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceGuardProxyBaseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceGuardProxyName, ResourceGuardProxyBaseResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceGuardProxyBaseResourceResourceGuardProxyRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation<ResourceGuardProxyBaseResource>(Response.FromValue(new ResourceGuardProxyBaseResource(Client, response), response.GetRawResponse()));
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
        /// Add or Update ResourceGuardProxy under vault
        /// Secures vault critical operations
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}
        /// Operation Id: ResourceGuardProxy_Put
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceGuardProxyName"> The String to use. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourceGuardProxyBaseResource> CreateOrUpdate(WaitUntil waitUntil, string resourceGuardProxyName, ResourceGuardProxyBaseResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceGuardProxyBaseResourceResourceGuardProxyRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, data, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation<ResourceGuardProxyBaseResource>(Response.FromValue(new ResourceGuardProxyBaseResource(Client, response), response.GetRawResponse()));
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
        /// Returns ResourceGuardProxy under vault and with the name referenced in request
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}
        /// Operation Id: ResourceGuardProxy_Get
        /// </summary>
        /// <param name="resourceGuardProxyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual async Task<Response<ResourceGuardProxyBaseResource>> GetAsync(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGuardProxyBaseResourceResourceGuardProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardProxyBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns ResourceGuardProxy under vault and with the name referenced in request
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}
        /// Operation Id: ResourceGuardProxy_Get
        /// </summary>
        /// <param name="resourceGuardProxyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual Response<ResourceGuardProxyBaseResource> Get(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGuardProxyBaseResourceResourceGuardProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardProxyBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the ResourceGuardProxies under vault
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies
        /// Operation Id: ResourceGuardProxies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGuardProxyBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGuardProxyBaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGuardProxyBaseResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGuardProxyBaseResourceResourceGuardProxiesClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGuardProxyBaseResourceResourceGuardProxiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardProxyBaseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGuardProxyBaseResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGuardProxyBaseResourceResourceGuardProxiesClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGuardProxyBaseResourceResourceGuardProxiesRestClient.GetNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardProxyBaseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List the ResourceGuardProxies under vault
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies
        /// Operation Id: ResourceGuardProxies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGuardProxyBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGuardProxyBaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ResourceGuardProxyBaseResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGuardProxyBaseResourceResourceGuardProxiesClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGuardProxyBaseResourceResourceGuardProxiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardProxyBaseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGuardProxyBaseResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGuardProxyBaseResourceResourceGuardProxiesClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGuardProxyBaseResourceResourceGuardProxiesRestClient.GetNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardProxyBaseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}
        /// Operation Id: ResourceGuardProxy_Get
        /// </summary>
        /// <param name="resourceGuardProxyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGuardProxyBaseResourceResourceGuardProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}
        /// Operation Id: ResourceGuardProxy_Get
        /// </summary>
        /// <param name="resourceGuardProxyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyBaseResourceResourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyBaseResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGuardProxyBaseResourceResourceGuardProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGuardProxyBaseResource> IEnumerable<ResourceGuardProxyBaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGuardProxyBaseResource> IAsyncEnumerable<ResourceGuardProxyBaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
