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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteBackup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteBackupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteBackupResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetSiteBackup method.
    /// </summary>
    public partial class SiteBackupResource : BackupItemResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteBackupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string backupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteBackupWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteBackupWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteBackupResource"/> class for mocking. </summary>
        protected SiteBackupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteBackupResource(ArmClient client, BackupItemData data) : base(client, data)
        {
            _siteBackupWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteBackupWebAppsApiVersion);
            _siteBackupWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteBackupWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteBackupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteBackupWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteBackupWebAppsApiVersion);
            _siteBackupWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteBackupWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/backups";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BackupItemResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.Get");
            scope.Start();
            try
            {
                var response = await _siteBackupWebAppsRestClient.GetBackupStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SiteBackupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteBackupResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Gets a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BackupItemResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.Get");
            scope.Start();
            try
            {
                var response = _siteBackupWebAppsRestClient.GetBackupStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Gets a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SiteBackupResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SiteBackupResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Deletes a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// Operation Id: WebApps_DeleteBackup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteBackupWebAppsRestClient.DeleteBackupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
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
        /// Description for Deletes a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// Operation Id: WebApps_DeleteBackup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.Delete");
            scope.Start();
            try
            {
                var response = _siteBackupWebAppsRestClient.DeleteBackup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
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
        /// Description for Gets status of a web app backup that may be in progress, including secrets associated with the backup, such as the Azure Storage SAS URL. Also can be used to update the SAS URL for the backup if a new URL is passed in the request body.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}/list
        /// Operation Id: WebApps_ListBackupStatusSecrets
        /// </summary>
        /// <param name="request"> Information on backup request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public virtual async Task<Response<SiteBackupResource>> GetBackupStatusSecretsAsync(BackupRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.GetBackupStatusSecrets");
            scope.Start();
            try
            {
                var response = await _siteBackupWebAppsRestClient.ListBackupStatusSecretsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, request, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets status of a web app backup that may be in progress, including secrets associated with the backup, such as the Azure Storage SAS URL. Also can be used to update the SAS URL for the backup if a new URL is passed in the request body.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}/list
        /// Operation Id: WebApps_ListBackupStatusSecrets
        /// </summary>
        /// <param name="request"> Information on backup request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public virtual Response<SiteBackupResource> GetBackupStatusSecrets(BackupRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.GetBackupStatusSecrets");
            scope.Start();
            try
            {
                var response = _siteBackupWebAppsRestClient.ListBackupStatusSecrets(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, request, cancellationToken);
                return Response.FromValue(new SiteBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Restores a specific backup to another app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}/restore
        /// Operation Id: WebApps_Restore
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Information on restore request . </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation> RestoreAsync(WaitUntil waitUntil, RestoreRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.Restore");
            scope.Start();
            try
            {
                var response = await _siteBackupWebAppsRestClient.RestoreAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_siteBackupWebAppsClientDiagnostics, Pipeline, _siteBackupWebAppsRestClient.CreateRestoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Restores a specific backup to another app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}/restore
        /// Operation Id: WebApps_Restore
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Information on restore request . </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual ArmOperation Restore(WaitUntil waitUntil, RestoreRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupResource.Restore");
            scope.Start();
            try
            {
                var response = _siteBackupWebAppsRestClient.Restore(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken);
                var operation = new AppServiceArmOperation(_siteBackupWebAppsClientDiagnostics, Pipeline, _siteBackupWebAppsRestClient.CreateRestoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
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
    }
}
