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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a WorkspaceSqlAdministrator along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WorkspaceSqlAdministratorResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWorkspaceSqlAdministratorResource method.
    /// Otherwise you can get one from its parent resource <see cref="WorkspaceResource" /> using the GetWorkspaceSqlAdministrator method.
    /// </summary>
    public partial class WorkspaceSqlAdministratorResource : WorkspaceAadAdminInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkspaceSqlAdministratorResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics;
        private readonly WorkspaceSqlAadAdminsRestOperations _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkspaceSqlAdministratorResource"/> class for mocking. </summary>
        protected WorkspaceSqlAdministratorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WorkspaceSqlAdministratorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkspaceSqlAdministratorResource(ArmClient client, WorkspaceAadAdminInfoData data) : base(client, data)
        {
            _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workspaceSqlAdministratorWorkspaceSqlAadAdminsApiVersion);
            _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient = new WorkspaceSqlAadAdminsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workspaceSqlAdministratorWorkspaceSqlAadAdminsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspaceSqlAdministratorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkspaceSqlAdministratorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workspaceSqlAdministratorWorkspaceSqlAadAdminsApiVersion);
            _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient = new WorkspaceSqlAadAdminsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workspaceSqlAdministratorWorkspaceSqlAadAdminsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlAdministrators";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<WorkspaceAadAdminInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics.CreateScope("WorkspaceSqlAdministratorResource.Get");
            scope.Start();
            try
            {
                var response = await _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<WorkspaceSqlAdministratorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WorkspaceSqlAdministratorResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<WorkspaceAadAdminInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics.CreateScope("WorkspaceSqlAdministratorResource.Get");
            scope.Start();
            try
            {
                var response = _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
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
        /// Gets a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<WorkspaceSqlAdministratorResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((WorkspaceSqlAdministratorResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Deletes a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics.CreateScope("WorkspaceSqlAdministratorResource.Delete");
            scope.Start();
            try
            {
                var response = await _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(_workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics, Pipeline, _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics.CreateScope("WorkspaceSqlAdministratorResource.Delete");
            scope.Start();
            try
            {
                var response = _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                var operation = new SynapseArmOperation(_workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics, Pipeline, _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Workspace active directory administrator properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        protected override async Task<ArmOperation<WorkspaceAadAdminInfoResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, WorkspaceAadAdminInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics.CreateScope("WorkspaceSqlAdministratorResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, info, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<WorkspaceAadAdminInfoResource>(new WorkspaceAadAdminInfoOperationSource(Client), _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics, Pipeline, _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, info).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Workspace active directory administrator properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<WorkspaceSqlAdministratorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, WorkspaceAadAdminInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            var result = await CreateOrUpdateCoreAsync(waitUntil, info, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new SynapseArmOperation<WorkspaceSqlAdministratorResource>(Response.FromValue((WorkspaceSqlAdministratorResource)result.Value, result.GetRawResponse()));
            }
            var operation = new SynapseArmOperation<WorkspaceSqlAdministratorResource>(new WorkspaceSqlAdministratorOperationSource(Client), _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics, Pipeline, _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, info).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// Creates or updates a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Workspace active directory administrator properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        protected override ArmOperation<WorkspaceAadAdminInfoResource> CreateOrUpdateCore(WaitUntil waitUntil, WorkspaceAadAdminInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics.CreateScope("WorkspaceSqlAdministratorResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, info, cancellationToken);
                var operation = new SynapseArmOperation<WorkspaceAadAdminInfoResource>(new WorkspaceAadAdminInfoOperationSource(Client), _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics, Pipeline, _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, info).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a workspace SQL active directory admin
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlAdministrators/activeDirectory
        /// Operation Id: WorkspaceSqlAadAdmins_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> Workspace active directory administrator properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<WorkspaceSqlAdministratorResource> CreateOrUpdate(WaitUntil waitUntil, WorkspaceAadAdminInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            var result = CreateOrUpdateCore(waitUntil, info, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new SynapseArmOperation<WorkspaceSqlAdministratorResource>(Response.FromValue((WorkspaceSqlAdministratorResource)result.Value, result.GetRawResponse()));
            }
            var operation = new SynapseArmOperation<WorkspaceSqlAdministratorResource>(new WorkspaceSqlAdministratorOperationSource(Client), _workspaceSqlAdministratorWorkspaceSqlAadAdminsClientDiagnostics, Pipeline, _workspaceSqlAdministratorWorkspaceSqlAadAdminsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, info).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
