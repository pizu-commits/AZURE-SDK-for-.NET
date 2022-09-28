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
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A Class representing a NetAppVolumeBackup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NetAppVolumeBackupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNetAppVolumeBackupResource method.
    /// Otherwise you can get one from its parent resource <see cref="NetAppVolumeResource" /> using the GetNetAppVolumeBackup method.
    /// </summary>
    public partial class NetAppVolumeBackupResource : NetAppBackupResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetAppVolumeBackupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _netAppVolumeBackupBackupsClientDiagnostics;
        private readonly BackupsRestOperations _netAppVolumeBackupBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeBackupResource"/> class for mocking. </summary>
        protected NetAppVolumeBackupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetAppVolumeBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetAppVolumeBackupResource(ArmClient client, NetAppBackupData data) : base(client, data)
        {
            _netAppVolumeBackupBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string netAppVolumeBackupBackupsApiVersion);
            _netAppVolumeBackupBackupsRestClient = new BackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppVolumeBackupBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetAppVolumeBackupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppVolumeBackupBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string netAppVolumeBackupBackupsApiVersion);
            _netAppVolumeBackupBackupsRestClient = new BackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppVolumeBackupBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.NetApp/netAppAccounts/capacityPools/volumes/backups";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<NetAppBackupResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppVolumeBackupResource.Get");
            scope.Start();
            try
            {
                var response = await _netAppVolumeBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets the specified backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<NetAppVolumeBackupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((NetAppVolumeBackupResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets the specified backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<NetAppBackupResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppVolumeBackupResource.Get");
            scope.Start();
            try
            {
                var response = _netAppVolumeBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets the specified backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<NetAppVolumeBackupResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((NetAppVolumeBackupResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Delete a backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppVolumeBackupResource.Delete");
            scope.Start();
            try
            {
                var response = await _netAppVolumeBackupBackupsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation(_netAppVolumeBackupBackupsClientDiagnostics, Pipeline, _netAppVolumeBackupBackupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppVolumeBackupResource.Delete");
            scope.Start();
            try
            {
                var response = _netAppVolumeBackupBackupsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetAppArmOperation(_netAppVolumeBackupBackupsClientDiagnostics, Pipeline, _netAppVolumeBackupBackupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Patch a backup for the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Backup object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppVolumeBackupResource>> UpdateAsync(WaitUntil waitUntil, NetAppVolumeBackupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _netAppVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppVolumeBackupResource.Update");
            scope.Start();
            try
            {
                var response = await _netAppVolumeBackupBackupsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppVolumeBackupResource>(new NetAppVolumeBackupOperationSource(Client), _netAppVolumeBackupBackupsClientDiagnostics, Pipeline, _netAppVolumeBackupBackupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Patch a backup for the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Backup object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<NetAppVolumeBackupResource> Update(WaitUntil waitUntil, NetAppVolumeBackupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _netAppVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppVolumeBackupResource.Update");
            scope.Start();
            try
            {
                var response = _netAppVolumeBackupBackupsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new NetAppArmOperation<NetAppVolumeBackupResource>(new NetAppVolumeBackupOperationSource(Client), _netAppVolumeBackupBackupsClientDiagnostics, Pipeline, _netAppVolumeBackupBackupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
