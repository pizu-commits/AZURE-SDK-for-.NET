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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A Class representing an AttachedNetworkConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AttachedNetworkConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAttachedNetworkConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevCenterResource" /> using the GetAttachedNetworkConnection method.
    /// </summary>
    public partial class AttachedNetworkConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AttachedNetworkConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string devCenterName, string attachedNetworkConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _attachedNetworkConnectionAttachedNetworksClientDiagnostics;
        private readonly AttachedNetworksRestOperations _attachedNetworkConnectionAttachedNetworksRestClient;
        private readonly AttachedNetworkConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="AttachedNetworkConnectionResource"/> class for mocking. </summary>
        protected AttachedNetworkConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AttachedNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AttachedNetworkConnectionResource(ArmClient client, AttachedNetworkConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AttachedNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AttachedNetworkConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _attachedNetworkConnectionAttachedNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string attachedNetworkConnectionAttachedNetworksApiVersion);
            _attachedNetworkConnectionAttachedNetworksRestClient = new AttachedNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, attachedNetworkConnectionAttachedNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevCenter/devcenters/attachednetworks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AttachedNetworkConnectionData Data
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
        /// Gets an attached NetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}
        /// Operation Id: AttachedNetworks_GetByDevCenter
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AttachedNetworkConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _attachedNetworkConnectionAttachedNetworksRestClient.GetByDevCenterAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttachedNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an attached NetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}
        /// Operation Id: AttachedNetworks_GetByDevCenter
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AttachedNetworkConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _attachedNetworkConnectionAttachedNetworksRestClient.GetByDevCenter(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttachedNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Un-attach a NetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}
        /// Operation Id: AttachedNetworks_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _attachedNetworkConnectionAttachedNetworksRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation(_attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, _attachedNetworkConnectionAttachedNetworksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Un-attach a NetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}
        /// Operation Id: AttachedNetworks_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _attachedNetworkConnectionAttachedNetworksRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DevCenterArmOperation(_attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, _attachedNetworkConnectionAttachedNetworksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an attached NetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}
        /// Operation Id: AttachedNetworks_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Represents an attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AttachedNetworkConnectionResource>> UpdateAsync(WaitUntil waitUntil, AttachedNetworkConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _attachedNetworkConnectionAttachedNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<AttachedNetworkConnectionResource>(new AttachedNetworkConnectionOperationSource(Client), _attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, _attachedNetworkConnectionAttachedNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an attached NetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/attachednetworks/{attachedNetworkConnectionName}
        /// Operation Id: AttachedNetworks_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Represents an attached NetworkConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AttachedNetworkConnectionResource> Update(WaitUntil waitUntil, AttachedNetworkConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _attachedNetworkConnectionAttachedNetworksClientDiagnostics.CreateScope("AttachedNetworkConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _attachedNetworkConnectionAttachedNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DevCenterArmOperation<AttachedNetworkConnectionResource>(new AttachedNetworkConnectionOperationSource(Client), _attachedNetworkConnectionAttachedNetworksClientDiagnostics, Pipeline, _attachedNetworkConnectionAttachedNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
