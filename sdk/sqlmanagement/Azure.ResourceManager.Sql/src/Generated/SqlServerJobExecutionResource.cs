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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerJobExecution along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlServerJobExecutionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlServerJobExecutionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerJobResource" /> using the GetSqlServerJobExecution method.
    /// </summary>
    public partial class SqlServerJobExecutionResource : BaseSqlServerJobExecutionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerJobExecutionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerJobExecutionJobExecutionsClientDiagnostics;
        private readonly JobExecutionsRestOperations _sqlServerJobExecutionJobExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionResource"/> class for mocking. </summary>
        protected SqlServerJobExecutionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlServerJobExecutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerJobExecutionResource(ArmClient client, SqlServerJobExecutionData data) : base(client, data)
        {
            _sqlServerJobExecutionJobExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobExecutionJobExecutionsApiVersion);
            _sqlServerJobExecutionJobExecutionsRestClient = new JobExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionJobExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerJobExecutionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobExecutionJobExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobExecutionJobExecutionsApiVersion);
            _sqlServerJobExecutionJobExecutionsRestClient = new JobExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionJobExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents/jobs/executions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SqlServerJobExecutionStepResources in the SqlServerJobExecution. </summary>
        /// <returns> An object representing collection of SqlServerJobExecutionStepResources and their operations over a SqlServerJobExecutionStepResource. </returns>
        public virtual SqlServerJobExecutionStepCollection GetSqlServerJobExecutionSteps()
        {
            return GetCachedClient(Client => new SqlServerJobExecutionStepCollection(Client, Id));
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlServerJobExecutionStepResource>> GetSqlServerJobExecutionStepAsync(string stepName, CancellationToken cancellationToken = default)
        {
            return await GetSqlServerJobExecutionSteps().GetAsync(stepName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SqlServerJobExecutionStepResource> GetSqlServerJobExecutionStep(string stepName, CancellationToken cancellationToken = default)
        {
            return GetSqlServerJobExecutionSteps().Get(stepName, cancellationToken);
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseSqlServerJobExecutionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionJobExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
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
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SqlServerJobExecutionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SqlServerJobExecutionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseSqlServerJobExecutionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionJobExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
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
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SqlServerJobExecutionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SqlServerJobExecutionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Creates or updates a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<SqlServerJobExecutionResource>> UpdateAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionResource.Update");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionJobExecutionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerJobExecutionResource>(new SqlServerJobExecutionOperationSource(Client), _sqlServerJobExecutionJobExecutionsClientDiagnostics, Pipeline, _sqlServerJobExecutionJobExecutionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name)).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<SqlServerJobExecutionResource> Update(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionResource.Update");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionJobExecutionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                var operation = new SqlArmOperation<SqlServerJobExecutionResource>(new SqlServerJobExecutionOperationSource(Client), _sqlServerJobExecutionJobExecutionsClientDiagnostics, Pipeline, _sqlServerJobExecutionJobExecutionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name)).Request, response, OperationFinalStateVia.Location);
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
        /// Requests cancellation of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/cancel
        /// Operation Id: JobExecutions_Cancel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionResource.Cancel");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionJobExecutionsRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Requests cancellation of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/cancel
        /// Operation Id: JobExecutions_Cancel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionResource.Cancel");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionJobExecutionsRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
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
