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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A Class representing a LogicWorkflowRun along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LogicWorkflowRunResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLogicWorkflowRunResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogicWorkflowResource" /> using the GetLogicWorkflowRun method.
    /// </summary>
    public partial class LogicWorkflowRunResource : BaseLogicWorkflowRunResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicWorkflowRunResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workflowName, string runName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicWorkflowRunWorkflowRunsClientDiagnostics;
        private readonly WorkflowRunsRestOperations _logicWorkflowRunWorkflowRunsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunResource"/> class for mocking. </summary>
        protected LogicWorkflowRunResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRunResource(ArmClient client, LogicWorkflowRunData data) : base(client, data)
        {
            _logicWorkflowRunWorkflowRunsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunWorkflowRunsApiVersion);
            _logicWorkflowRunWorkflowRunsRestClient = new WorkflowRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunWorkflowRunsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRunResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunWorkflowRunsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunWorkflowRunsApiVersion);
            _logicWorkflowRunWorkflowRunsRestClient = new WorkflowRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunWorkflowRunsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Logic/workflows/runs";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of LogicWorkflowRunOperationResources in the LogicWorkflowRun. </summary>
        /// <returns> An object representing collection of LogicWorkflowRunOperationResources and their operations over a LogicWorkflowRunOperationResource. </returns>
        public virtual LogicWorkflowRunOperationCollection GetLogicWorkflowRunOperations()
        {
            return GetCachedClient(Client => new LogicWorkflowRunOperationCollection(Client, Id));
        }

        /// <summary>
        /// Gets an operation for a run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}
        /// Operation Id: WorkflowRunOperations_Get
        /// </summary>
        /// <param name="operationId"> The workflow operation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowRunOperationResource>> GetLogicWorkflowRunOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflowRunOperations().GetAsync(operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an operation for a run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}
        /// Operation Id: WorkflowRunOperations_Get
        /// </summary>
        /// <param name="operationId"> The workflow operation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowRunOperationResource> GetLogicWorkflowRunOperation(string operationId, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflowRunOperations().Get(operationId, cancellationToken);
        }

        /// <summary> Gets a collection of LogicWorkflowRunActionResources in the LogicWorkflowRun. </summary>
        /// <returns> An object representing collection of LogicWorkflowRunActionResources and their operations over a LogicWorkflowRunActionResource. </returns>
        public virtual LogicWorkflowRunActionCollection GetLogicWorkflowRunActions()
        {
            return GetCachedClient(Client => new LogicWorkflowRunActionCollection(Client, Id));
        }

        /// <summary>
        /// Gets a workflow run action.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}
        /// Operation Id: WorkflowRunActions_Get
        /// </summary>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowRunActionResource>> GetLogicWorkflowRunActionAsync(string actionName, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflowRunActions().GetAsync(actionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow run action.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}
        /// Operation Id: WorkflowRunActions_Get
        /// </summary>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowRunActionResource> GetLogicWorkflowRunAction(string actionName, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflowRunActions().Get(actionName, cancellationToken);
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a workflow run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}
        /// Operation Id: WorkflowRuns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseLogicWorkflowRunResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunResource.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunWorkflowRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets a workflow run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}
        /// Operation Id: WorkflowRuns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<LogicWorkflowRunResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((LogicWorkflowRunResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a workflow run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}
        /// Operation Id: WorkflowRuns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseLogicWorkflowRunResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunResource.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunWorkflowRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets a workflow run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}
        /// Operation Id: WorkflowRuns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<LogicWorkflowRunResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((LogicWorkflowRunResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Cancels a workflow run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/cancel
        /// Operation Id: WorkflowRuns_Cancel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunResource.Cancel");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunWorkflowRunsRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a workflow run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/cancel
        /// Operation Id: WorkflowRuns_Cancel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunWorkflowRunsClientDiagnostics.CreateScope("LogicWorkflowRunResource.Cancel");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunWorkflowRunsRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
