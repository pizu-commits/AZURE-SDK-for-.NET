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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridIdentityMetadataResource" /> and their operations.
    /// Each <see cref="HybridIdentityMetadataResource" /> in the collection will belong to the same instance of <see cref="VirtualMachineResource" />.
    /// To get a <see cref="HybridIdentityMetadataCollection" /> instance call the GetHybridIdentityMetadata method from an instance of <see cref="VirtualMachineResource" />.
    /// </summary>
    public partial class HybridIdentityMetadataCollection : ArmCollection, IEnumerable<HybridIdentityMetadataResource>, IAsyncEnumerable<HybridIdentityMetadataResource>
    {
        private readonly ClientDiagnostics _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics;
        private readonly HybridIdentityMetadataRestOperations _hybridIdentityMetadataHybridIdentityMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridIdentityMetadataCollection"/> class for mocking. </summary>
        protected HybridIdentityMetadataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridIdentityMetadataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridIdentityMetadataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", HybridIdentityMetadataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridIdentityMetadataResource.ResourceType, out string hybridIdentityMetadataHybridIdentityMetadataApiVersion);
            _hybridIdentityMetadataHybridIdentityMetadataRestClient = new HybridIdentityMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridIdentityMetadataHybridIdentityMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update HybridIdentityMetadata.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridIdentityMetadataResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string metadataName, HybridIdentityMetadataData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<HybridIdentityMetadataResource>(Response.FromValue(new HybridIdentityMetadataResource(Client, response), response.GetRawResponse()));
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
        /// Create Or Update HybridIdentityMetadata.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual ArmOperation<HybridIdentityMetadataResource> CreateOrUpdate(WaitUntil waitUntil, string metadataName, HybridIdentityMetadataData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<HybridIdentityMetadataResource>(Response.FromValue(new HybridIdentityMetadataResource(Client, response), response.GetRawResponse()));
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
        /// Implements HybridIdentityMetadata GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual async Task<Response<HybridIdentityMetadataResource>> GetAsync(string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements HybridIdentityMetadata GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual Response<HybridIdentityMetadataResource> Get(string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of HybridIdentityMetadata of the given vm.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata
        /// Operation Id: HybridIdentityMetadata_ListByVm
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridIdentityMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridIdentityMetadataResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HybridIdentityMetadataResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByVmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HybridIdentityMetadataResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByVmNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns the list of HybridIdentityMetadata of the given vm.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata
        /// Operation Id: HybridIdentityMetadata_ListByVm
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridIdentityMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridIdentityMetadataResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HybridIdentityMetadataResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByVm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HybridIdentityMetadataResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.ListByVmNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(metadataName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual Response<bool> Exists(string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(metadataName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual async Task<Response<HybridIdentityMetadataResource>> GetIfExistsAsync(string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataHybridIdentityMetadataRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<HybridIdentityMetadataResource>(null, response.GetRawResponse());
                return Response.FromValue(new HybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// Operation Id: HybridIdentityMetadata_Get
        /// </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual Response<HybridIdentityMetadataResource> GetIfExists(string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var scope = _hybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataHybridIdentityMetadataRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<HybridIdentityMetadataResource>(null, response.GetRawResponse());
                return Response.FromValue(new HybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridIdentityMetadataResource> IEnumerable<HybridIdentityMetadataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridIdentityMetadataResource> IAsyncEnumerable<HybridIdentityMetadataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
