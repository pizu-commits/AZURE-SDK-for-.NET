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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerCommunicationLink and their operations over its parent. </summary>
    public partial class ServerCommunicationLinkCollection : ArmCollection, IEnumerable<ServerCommunicationLink>, IAsyncEnumerable<ServerCommunicationLink>
    {
        private readonly ClientDiagnostics _serverCommunicationLinkClientDiagnostics;
        private readonly ServerCommunicationLinksRestOperations _serverCommunicationLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerCommunicationLinkCollection"/> class for mocking. </summary>
        protected ServerCommunicationLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerCommunicationLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerCommunicationLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverCommunicationLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerCommunicationLink.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerCommunicationLink.ResourceType, out string serverCommunicationLinkApiVersion);
            _serverCommunicationLinkRestClient = new ServerCommunicationLinksRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverCommunicationLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a server communication link.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerCommunicationLink>> CreateOrUpdateAsync(WaitUntil waitUntil, string communicationLinkName, ServerCommunicationLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerCommunicationLink>(new ServerCommunicationLinkOperationSource(Client), _serverCommunicationLinkClientDiagnostics, Pipeline, _serverCommunicationLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a server communication link.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServerCommunicationLink> CreateOrUpdate(WaitUntil waitUntil, string communicationLinkName, ServerCommunicationLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ServerCommunicationLink>(new ServerCommunicationLinkOperationSource(Client), _serverCommunicationLinkClientDiagnostics, Pipeline, _serverCommunicationLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Returns a server communication link.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_Get
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual async Task<Response<ServerCommunicationLink>> GetAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a server communication link.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_Get
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<ServerCommunicationLink> Get(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server communication links.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks
        /// Operation Id: ServerCommunicationLinks_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerCommunicationLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerCommunicationLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerCommunicationLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverCommunicationLinkRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerCommunicationLink(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets a list of server communication links.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks
        /// Operation Id: ServerCommunicationLinks_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerCommunicationLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerCommunicationLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerCommunicationLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverCommunicationLinkRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerCommunicationLink(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_Get
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_Get
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(communicationLinkName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_Get
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual async Task<Response<ServerCommunicationLink>> GetIfExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerCommunicationLink>(null, response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// Operation Id: ServerCommunicationLinks_Get
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<ServerCommunicationLink> GetIfExists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerCommunicationLink>(null, response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerCommunicationLink> IEnumerable<ServerCommunicationLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerCommunicationLink> IAsyncEnumerable<ServerCommunicationLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
