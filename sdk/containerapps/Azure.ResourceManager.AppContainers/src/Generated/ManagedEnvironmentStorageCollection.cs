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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedEnvironmentStorageResource" /> and their operations.
    /// Each <see cref="ManagedEnvironmentStorageResource" /> in the collection will belong to the same instance of <see cref="ManagedEnvironmentResource" />.
    /// To get a <see cref="ManagedEnvironmentStorageCollection" /> instance call the GetManagedEnvironmentStorages method from an instance of <see cref="ManagedEnvironmentResource" />.
    /// </summary>
    public partial class ManagedEnvironmentStorageCollection : ArmCollection, IEnumerable<ManagedEnvironmentStorageResource>, IAsyncEnumerable<ManagedEnvironmentStorageResource>
    {
        private readonly ClientDiagnostics _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics;
        private readonly ManagedEnvironmentsStoragesRestOperations _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedEnvironmentStorageCollection"/> class for mocking. </summary>
        protected ManagedEnvironmentStorageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedEnvironmentStorageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedEnvironmentStorageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ManagedEnvironmentStorageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedEnvironmentStorageResource.ResourceType, out string managedEnvironmentStorageManagedEnvironmentsStoragesApiVersion);
            _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient = new ManagedEnvironmentsStoragesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedEnvironmentStorageManagedEnvironmentsStoragesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update storage for a managedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}
        /// Operation Id: ManagedEnvironmentsStorages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="data"> Configuration details of storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedEnvironmentStorageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageName, ManagedEnvironmentStorageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ManagedEnvironmentStorageResource>(Response.FromValue(new ManagedEnvironmentStorageResource(Client, response), response.GetRawResponse()));
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
        /// Create or update storage for a managedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}
        /// Operation Id: ManagedEnvironmentsStorages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="data"> Configuration details of storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedEnvironmentStorageResource> CreateOrUpdate(WaitUntil waitUntil, string storageName, ManagedEnvironmentStorageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ManagedEnvironmentStorageResource>(Response.FromValue(new ManagedEnvironmentStorageResource(Client, response), response.GetRawResponse()));
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
        /// Get storage for a managedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}
        /// Operation Id: ManagedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<ManagedEnvironmentStorageResource>> GetAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get storage for a managedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}
        /// Operation Id: ManagedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<ManagedEnvironmentStorageResource> Get(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.Get");
            scope.Start();
            try
            {
                var response = _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all storages for a managedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages
        /// Operation Id: ManagedEnvironmentsStorages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedEnvironmentStorageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedEnvironmentStorageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedEnvironmentStorageResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedEnvironmentStorageResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all storages for a managedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages
        /// Operation Id: ManagedEnvironmentsStorages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedEnvironmentStorageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedEnvironmentStorageResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedEnvironmentStorageResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedEnvironmentStorageResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}
        /// Operation Id: ManagedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}
        /// Operation Id: ManagedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _managedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ManagedEnvironmentStorageCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedEnvironmentStorageManagedEnvironmentsStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedEnvironmentStorageResource> IEnumerable<ManagedEnvironmentStorageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedEnvironmentStorageResource> IAsyncEnumerable<ManagedEnvironmentStorageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
