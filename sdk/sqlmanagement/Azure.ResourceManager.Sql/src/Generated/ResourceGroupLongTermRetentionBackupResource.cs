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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ResourceGroupLongTermRetentionBackup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ResourceGroupLongTermRetentionBackupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetResourceGroupLongTermRetentionBackupResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetResourceGroupLongTermRetentionBackup method.
    /// </summary>
    public partial class ResourceGroupLongTermRetentionBackupResource : LongTermRetentionBackupResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroupLongTermRetentionBackupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, AzureLocation locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics;
        private readonly LongTermRetentionBackupsRestOperations _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionBackupResource"/> class for mocking. </summary>
        protected ResourceGroupLongTermRetentionBackupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceGroupLongTermRetentionBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGroupLongTermRetentionBackupResource(ArmClient client, LongTermRetentionBackupData data) : base(client, data)
        {
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupLongTermRetentionBackupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/longTermRetentionServers/longTermRetentionDatabases/longTermRetentionBackups";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<LongTermRetentionBackupResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.GetCore");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ResourceGroupLongTermRetentionBackupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ResourceGroupLongTermRetentionBackupResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<LongTermRetentionBackupResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.GetCore");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ResourceGroupLongTermRetentionBackupResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ResourceGroupLongTermRetentionBackupResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_DeleteByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.DeleteByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateDeleteByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The core implementation for operation Delete
        /// Deletes a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_DeleteByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.DeleteByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateDeleteByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Copy an existing long term retention backup to a different server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/copy
        /// Operation Id: LongTermRetentionBackups_CopyByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters needed for long term retention copy request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<LongTermRetentionBackupOperationResult>> CopyByResourceGroupAsync(WaitUntil waitUntil, CopyLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.CopyByResourceGroup");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CopyByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateCopyByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Copy an existing long term retention backup to a different server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/copy
        /// Operation Id: LongTermRetentionBackups_CopyByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters needed for long term retention copy request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<LongTermRetentionBackupOperationResult> CopyByResourceGroup(WaitUntil waitUntil, CopyLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.CopyByResourceGroup");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CopyByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateCopyByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/update
        /// Operation Id: LongTermRetentionBackups_UpdateByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The requested backup resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<LongTermRetentionBackupOperationResult>> UpdateByResourceGroupAsync(WaitUntil waitUntil, UpdateLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.UpdateByResourceGroup");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.UpdateByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateUpdateByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/update
        /// Operation Id: LongTermRetentionBackups_UpdateByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The requested backup resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<LongTermRetentionBackupOperationResult> UpdateByResourceGroup(WaitUntil waitUntil, UpdateLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.UpdateByResourceGroup");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.UpdateByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateUpdateByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
