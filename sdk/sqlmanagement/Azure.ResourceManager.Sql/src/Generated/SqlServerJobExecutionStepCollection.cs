// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerJobExecutionStepResource" /> and their operations.
    /// Each <see cref="SqlServerJobExecutionStepResource" /> in the collection will belong to the same instance of <see cref="SqlServerJobExecutionResource" />.
    /// To get a <see cref="SqlServerJobExecutionStepCollection" /> instance call the GetSqlServerJobExecutionSteps method from an instance of <see cref="SqlServerJobExecutionResource" />.
    /// </summary>
    public partial class SqlServerJobExecutionStepCollection : ArmCollection, IEnumerable<SqlServerJobExecutionStepResource>, IAsyncEnumerable<SqlServerJobExecutionStepResource>
    {
        private readonly ClientDiagnostics _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics;
        private readonly JobStepExecutionsRestOperations _sqlServerJobExecutionStepJobStepExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepCollection"/> class for mocking. </summary>
        protected SqlServerJobExecutionStepCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobExecutionStepCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobExecutionStepResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobExecutionStepResource.ResourceType, out string sqlServerJobExecutionStepJobStepExecutionsApiVersion);
            _sqlServerJobExecutionStepJobStepExecutionsRestClient = new JobStepExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionStepJobStepExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerJobExecutionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerJobExecutionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<Response<SqlServerJobExecutionStepResource>> GetAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionStepJobStepExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<SqlServerJobExecutionStepResource> Get(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionStepJobStepExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the step executions of a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_ListByJobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobExecutionStepResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobExecutionStepResource> GetAllAsync(SqlServerJobExecutionStepCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SqlServerJobExecutionStepCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionStepJobStepExecutionsRestClient.CreateListByJobExecutionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionStepJobStepExecutionsRestClient.CreateListByJobExecutionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerJobExecutionStepResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionStepCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the step executions of a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_ListByJobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobExecutionStepResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobExecutionStepResource> GetAll(SqlServerJobExecutionStepCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SqlServerJobExecutionStepCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionStepJobStepExecutionsRestClient.CreateListByJobExecutionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionStepJobStepExecutionsRestClient.CreateListByJobExecutionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerJobExecutionStepResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionStepCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionStepJobStepExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<bool> Exists(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionStepJobStepExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerJobExecutionStepResource>> GetIfExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionStepJobStepExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobExecutionStepResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionStepResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStepExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual NullableResponse<SqlServerJobExecutionStepResource> GetIfExists(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionStepJobStepExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobExecutionStepResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobExecutionStepResource> IEnumerable<SqlServerJobExecutionStepResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobExecutionStepResource> IAsyncEnumerable<SqlServerJobExecutionStepResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
