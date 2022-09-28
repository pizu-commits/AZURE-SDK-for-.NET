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
    /// A Class representing a SqlServerJobExecutionStep along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlServerJobExecutionStepResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlServerJobExecutionStepResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerJobExecutionResource" /> using the GetSqlServerJobExecutionStep method.
    /// </summary>
    public partial class SqlServerJobExecutionStepResource : BaseSqlServerJobExecutionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerJobExecutionStepResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, string stepName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics;
        private readonly JobStepExecutionsRestOperations _sqlServerJobExecutionStepJobStepExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepResource"/> class for mocking. </summary>
        protected SqlServerJobExecutionStepResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlServerJobExecutionStepResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerJobExecutionStepResource(ArmClient client, SqlServerJobExecutionData data) : base(client, data)
        {
            _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobExecutionStepJobStepExecutionsApiVersion);
            _sqlServerJobExecutionStepJobStepExecutionsRestClient = new JobStepExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionStepJobStepExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerJobExecutionStepResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobExecutionStepJobStepExecutionsApiVersion);
            _sqlServerJobExecutionStepJobStepExecutionsRestClient = new JobStepExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionStepJobStepExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents/jobs/executions/steps";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SqlServerJobExecutionStepTargetResources in the SqlServerJobExecutionStep. </summary>
        /// <returns> An object representing collection of SqlServerJobExecutionStepTargetResources and their operations over a SqlServerJobExecutionStepTargetResource. </returns>
        public virtual SqlServerJobExecutionStepTargetCollection GetSqlServerJobExecutionStepTargets()
        {
            return GetCachedClient(Client => new SqlServerJobExecutionStepTargetCollection(Client, Id));
        }

        /// <summary>
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlServerJobExecutionStepTargetResource>> GetSqlServerJobExecutionStepTargetAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            return await GetSqlServerJobExecutionStepTargets().GetAsync(targetId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<SqlServerJobExecutionStepTargetResource> GetSqlServerJobExecutionStepTarget(Guid targetId, CancellationToken cancellationToken = default)
        {
            return GetSqlServerJobExecutionStepTargets().Get(targetId, cancellationToken);
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseSqlServerJobExecutionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionStepJobStepExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SqlServerJobExecutionStepResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SqlServerJobExecutionStepResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseSqlServerJobExecutionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionStepJobStepExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken);
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
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SqlServerJobExecutionStepResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SqlServerJobExecutionStepResource)result.Value, result.GetRawResponse());
        }
    }
}
