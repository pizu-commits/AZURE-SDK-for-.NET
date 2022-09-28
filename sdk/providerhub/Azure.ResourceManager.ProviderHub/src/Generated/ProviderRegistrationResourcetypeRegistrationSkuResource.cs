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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A Class representing a ProviderRegistrationResourcetypeRegistrationSku along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ProviderRegistrationResourcetypeRegistrationSkuResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetProviderRegistrationResourcetypeRegistrationSkuResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceTypeRegistrationResource" /> using the GetProviderRegistrationResourcetypeRegistrationSku method.
    /// </summary>
    public partial class ProviderRegistrationResourcetypeRegistrationSkuResource : SkuResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProviderRegistrationResourcetypeRegistrationSkuResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string providerNamespace, string resourceType, string sku)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics;
        private readonly SkusRestOperations _providerRegistrationResourcetypeRegistrationSkuSkusRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationResourcetypeRegistrationSkuResource"/> class for mocking. </summary>
        protected ProviderRegistrationResourcetypeRegistrationSkuResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ProviderRegistrationResourcetypeRegistrationSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProviderRegistrationResourcetypeRegistrationSkuResource(ArmClient client, SkuResourceData data) : base(client, data)
        {
            _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string providerRegistrationResourcetypeRegistrationSkuSkusApiVersion);
            _providerRegistrationResourcetypeRegistrationSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, providerRegistrationResourcetypeRegistrationSkuSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationResourcetypeRegistrationSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProviderRegistrationResourcetypeRegistrationSkuResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string providerRegistrationResourcetypeRegistrationSkuSkusApiVersion);
            _providerRegistrationResourcetypeRegistrationSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, providerRegistrationResourcetypeRegistrationSkuSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ProviderHub/providerRegistrations/resourcetypeRegistrations/skus";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<SkuResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationSkuResource.Get");
            scope.Start();
            try
            {
                var response = await _providerRegistrationResourcetypeRegistrationSkuSkusRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets the sku details for the given resource type and sku name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ProviderRegistrationResourcetypeRegistrationSkuResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ProviderRegistrationResourcetypeRegistrationSkuResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<SkuResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationSkuResource.Get");
            scope.Start();
            try
            {
                var response = _providerRegistrationResourcetypeRegistrationSkuSkusRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets the sku details for the given resource type and sku name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ProviderRegistrationResourcetypeRegistrationSkuResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ProviderRegistrationResourcetypeRegistrationSkuResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Deletes a resource type sku.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationSkuResource.Delete");
            scope.Start();
            try
            {
                var response = await _providerRegistrationResourcetypeRegistrationSkuSkusRestClient.DeleteAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation(response);
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
        /// Deletes a resource type sku.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationSkuResource.Delete");
            scope.Start();
            try
            {
                var response = _providerRegistrationResourcetypeRegistrationSkuSkusRestClient.Delete(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ProviderHubArmOperation(response);
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
        /// Creates or updates the resource type skus in the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<SkuResource>> UpdateCoreAsync(WaitUntil waitUntil, SkuResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationSkuResource.Update");
            scope.Start();
            try
            {
                var response = await _providerRegistrationResourcetypeRegistrationSkuSkusRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<SkuResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the resource type skus in the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<ProviderRegistrationResourcetypeRegistrationSkuResource>> UpdateAsync(WaitUntil waitUntil, SkuResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            var result = await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            return new ProviderHubArmOperation<ProviderRegistrationResourcetypeRegistrationSkuResource>(Response.FromValue((ProviderRegistrationResourcetypeRegistrationSkuResource)result.Value, result.GetRawResponse()));
        }

        /// <summary>
        /// Creates or updates the resource type skus in the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<SkuResource> UpdateCore(WaitUntil waitUntil, SkuResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationSkuResource.Update");
            scope.Start();
            try
            {
                var response = _providerRegistrationResourcetypeRegistrationSkuSkusRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ProviderHubArmOperation<SkuResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the resource type skus in the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/skus/{sku}
        /// Operation Id: Skus_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<ProviderRegistrationResourcetypeRegistrationSkuResource> Update(WaitUntil waitUntil, SkuResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            var result = UpdateCore(waitUntil, data, cancellationToken);
            return new ProviderHubArmOperation<ProviderRegistrationResourcetypeRegistrationSkuResource>(Response.FromValue((ProviderRegistrationResourcetypeRegistrationSkuResource)result.Value, result.GetRawResponse()));
        }
    }
}
