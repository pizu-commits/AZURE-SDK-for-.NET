// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupProtectedItemResource"/> and their operations.
    /// Each <see cref="BackupProtectedItemResource"/> in the collection will belong to the same instance of <see cref="BackupProtectionContainerResource"/>.
    /// To get a <see cref="BackupProtectedItemCollection"/> instance call the GetBackupProtectedItems method from an instance of <see cref="BackupProtectionContainerResource"/>.
    /// </summary>
    public partial class BackupProtectedItemCollection : ArmCollection
    {
        private readonly ClientDiagnostics _backupProtectedItemProtectedItemsClientDiagnostics;
        private readonly ProtectedItemsRestOperations _backupProtectedItemProtectedItemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackupProtectedItemCollection"/> class for mocking. </summary>
        protected BackupProtectedItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupProtectedItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackupProtectedItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupProtectedItemProtectedItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupProtectedItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupProtectedItemResource.ResourceType, out string backupProtectedItemProtectedItemsApiVersion);
            _backupProtectedItemProtectedItemsRestClient = new ProtectedItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupProtectedItemProtectedItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BackupProtectionContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BackupProtectionContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Enables backup of an item or to modifies the backup policy information of an already backed up item. This is an
        /// asynchronous operation. To know the status of the operation, call the GetItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="protectedItemName"> Item name to be backed up. </param>
        /// <param name="data"> resource backed up item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BackupProtectedItemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string protectedItemName, BackupProtectedItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backupProtectedItemProtectedItemsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectedItemResource>(new BackupProtectedItemOperationSource(Client), _backupProtectedItemProtectedItemsClientDiagnostics, Pipeline, _backupProtectedItemProtectedItemsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Enables backup of an item or to modifies the backup policy information of an already backed up item. This is an
        /// asynchronous operation. To know the status of the operation, call the GetItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="protectedItemName"> Item name to be backed up. </param>
        /// <param name="data"> resource backed up item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BackupProtectedItemResource> CreateOrUpdate(WaitUntil waitUntil, string protectedItemName, BackupProtectedItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backupProtectedItemProtectedItemsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, data, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectedItemResource>(new BackupProtectedItemOperationSource(Client), _backupProtectedItemProtectedItemsClientDiagnostics, Pipeline, _backupProtectedItemProtectedItemsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Provides the details of the backed up item. This is an asynchronous operation. To know the status of the operation,
        /// call the GetItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual async Task<Response<BackupProtectedItemResource>> GetAsync(string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupProtectedItemProtectedItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, filter, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the details of the backed up item. This is an asynchronous operation. To know the status of the operation,
        /// call the GetItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual Response<BackupProtectedItemResource> Get(string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.Get");
            scope.Start();
            try
            {
                var response = _backupProtectedItemProtectedItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, filter, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupProtectedItemProtectedItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupProtectedItemProtectedItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, filter, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual async Task<NullableResponse<BackupProtectedItemResource>> GetIfExistsAsync(string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backupProtectedItemProtectedItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectedItemResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectedItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectedItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectedItemName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectedItemName"/> is null. </exception>
        public virtual NullableResponse<BackupProtectedItemResource> GetIfExists(string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var scope = _backupProtectedItemProtectedItemsClientDiagnostics.CreateScope("BackupProtectedItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backupProtectedItemProtectedItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectedItemName, filter, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectedItemResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectedItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
