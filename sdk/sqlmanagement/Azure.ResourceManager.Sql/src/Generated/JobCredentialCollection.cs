// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="JobCredentialResource" /> and their operations.
    /// Each <see cref="JobCredentialResource" /> in the collection will belong to the same instance of <see cref="JobAgentResource" />.
    /// To get a <see cref="JobCredentialCollection" /> instance call the GetJobCredentials method from an instance of <see cref="JobAgentResource" />.
    /// </summary>
    public partial class JobCredentialCollection : ArmCollection, IEnumerable<JobCredentialResource>, IAsyncEnumerable<JobCredentialResource>
    {
        private readonly ClientDiagnostics _jobCredentialClientDiagnostics;
        private readonly JobCredentialsRestOperations _jobCredentialRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobCredentialCollection"/> class for mocking. </summary>
        protected JobCredentialCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobCredentialCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JobCredentialCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobCredentialClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", JobCredentialResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(JobCredentialResource.ResourceType, out string jobCredentialApiVersion);
            _jobCredentialRestClient = new JobCredentialsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jobCredentialApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobAgentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobAgentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a job credential.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="data"> The requested job credential state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<JobCredentialResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string credentialName, JobCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobCredentialRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<JobCredentialResource>(Response.FromValue(new JobCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a job credential.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="data"> The requested job credential state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<JobCredentialResource> CreateOrUpdate(WaitUntil waitUntil, string credentialName, JobCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobCredentialRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, data, cancellationToken);
                var operation = new SqlArmOperation<JobCredentialResource>(Response.FromValue(new JobCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Gets a jobs credential.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_Get
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<JobCredentialResource>> GetAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a jobs credential.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_Get
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<JobCredentialResource> Get(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = _jobCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of jobs credentials.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials
        /// Operation Id: JobCredentials_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobCredentialResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobCredentialResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JobCredentialResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobCredentialRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredentialResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobCredentialResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobCredentialRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredentialResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of jobs credentials.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials
        /// Operation Id: JobCredentials_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobCredentialResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobCredentialResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JobCredentialResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobCredentialRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredentialResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobCredentialResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobCredentialRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredentialResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_Get
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_Get
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<bool> Exists(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(credentialName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_Get
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<JobCredentialResource>> GetIfExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<JobCredentialResource>(null, response.GetRawResponse());
                return Response.FromValue(new JobCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// Operation Id: JobCredentials_Get
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<JobCredentialResource> GetIfExists(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<JobCredentialResource>(null, response.GetRawResponse());
                return Response.FromValue(new JobCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JobCredentialResource> IEnumerable<JobCredentialResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobCredentialResource> IAsyncEnumerable<JobCredentialResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
