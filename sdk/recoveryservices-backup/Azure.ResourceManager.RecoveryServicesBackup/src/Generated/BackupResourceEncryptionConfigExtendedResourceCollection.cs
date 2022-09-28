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
using Azure.ResourceManager.RecoveryServicesBackup.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupResourceEncryptionConfigExtendedResource" /> and their operations.
    /// Each <see cref="BackupResourceEncryptionConfigExtendedResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="BackupResourceEncryptionConfigExtendedResourceCollection" /> instance call the GetBackupResourceEncryptionConfigExtendedResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class BackupResourceEncryptionConfigExtendedResourceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics;
        private readonly BackupResourceEncryptionConfigsRestOperations _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackupResourceEncryptionConfigExtendedResourceCollection"/> class for mocking. </summary>
        protected BackupResourceEncryptionConfigExtendedResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupResourceEncryptionConfigExtendedResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackupResourceEncryptionConfigExtendedResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupResourceEncryptionConfigExtendedResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupResourceEncryptionConfigExtendedResource.ResourceType, out string backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsApiVersion);
            _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient = new BackupResourceEncryptionConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsApiVersion);
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
        /// Updates Vault encryption config.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig
        /// Operation Id: BackupResourceEncryptionConfigs_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="content"> Vault encryption input config request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, BackupResourceEncryptionConfigExtendedResourceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation(response);
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
        /// Updates Vault encryption config.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig
        /// Operation Id: BackupResourceEncryptionConfigs_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="content"> Vault encryption input config request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string vaultName, BackupResourceEncryptionConfigExtendedResourceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, vaultName, content, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation(response);
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
        /// Fetches Vault Encryption config.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig
        /// Operation Id: BackupResourceEncryptionConfigs_Get
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<BackupResourceEncryptionConfigExtendedResource>> GetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupResourceEncryptionConfigExtendedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Fetches Vault Encryption config.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig
        /// Operation Id: BackupResourceEncryptionConfigs_Get
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<BackupResourceEncryptionConfigExtendedResource> Get(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupResourceEncryptionConfigExtendedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig
        /// Operation Id: BackupResourceEncryptionConfigs_Get
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig
        /// Operation Id: BackupResourceEncryptionConfigs_Get
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupResourceEncryptionConfigExtendedResourceBackupResourceEncryptionConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
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
