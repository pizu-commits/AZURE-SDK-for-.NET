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

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlServerKeyResource"/> and their operations.
    /// Each <see cref="MySqlServerKeyResource"/> in the collection will belong to the same instance of <see cref="MySqlServerResource"/>.
    /// To get a <see cref="MySqlServerKeyCollection"/> instance call the GetMySqlServerKeys method from an instance of <see cref="MySqlServerResource"/>.
    /// </summary>
    public partial class MySqlServerKeyCollection : ArmCollection, IEnumerable<MySqlServerKeyResource>, IAsyncEnumerable<MySqlServerKeyResource>
    {
        private readonly ClientDiagnostics _mySqlServerKeyServerKeysClientDiagnostics;
        private readonly ServerKeysRestOperations _mySqlServerKeyServerKeysRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlServerKeyCollection"/> class for mocking. </summary>
        protected MySqlServerKeyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlServerKeyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlServerKeyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlServerKeyServerKeysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", MySqlServerKeyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlServerKeyResource.ResourceType, out string mySqlServerKeyServerKeysApiVersion);
            _mySqlServerKeyServerKeysRestClient = new ServerKeysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlServerKeyServerKeysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a MySQL Server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the MySQL Server key to be operated on (updated or created). </param>
        /// <param name="data"> The requested MySQL Server key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MySqlServerKeyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyName, MySqlServerKeyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mySqlServerKeyServerKeysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MySqlArmOperation<MySqlServerKeyResource>(new MySqlServerKeyOperationSource(Client), _mySqlServerKeyServerKeysClientDiagnostics, Pipeline, _mySqlServerKeyServerKeysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a MySQL Server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the MySQL Server key to be operated on (updated or created). </param>
        /// <param name="data"> The requested MySQL Server key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MySqlServerKeyResource> CreateOrUpdate(WaitUntil waitUntil, string keyName, MySqlServerKeyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mySqlServerKeyServerKeysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data, cancellationToken);
                var operation = new MySqlArmOperation<MySqlServerKeyResource>(new MySqlServerKeyOperationSource(Client), _mySqlServerKeyServerKeysClientDiagnostics, Pipeline, _mySqlServerKeyServerKeysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a MySQL Server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<MySqlServerKeyResource>> GetAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlServerKeyServerKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a MySQL Server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<MySqlServerKeyResource> Get(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlServerKeyServerKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of  Server keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlServerKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlServerKeyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlServerKeyServerKeysRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlServerKeyServerKeysRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MySqlServerKeyResource(Client, MySqlServerKeyData.DeserializeMySqlServerKeyData(e)), _mySqlServerKeyServerKeysClientDiagnostics, Pipeline, "MySqlServerKeyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of  Server keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlServerKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlServerKeyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlServerKeyServerKeysRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlServerKeyServerKeysRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MySqlServerKeyResource(Client, MySqlServerKeyData.DeserializeMySqlServerKeyData(e)), _mySqlServerKeyServerKeysClientDiagnostics, Pipeline, "MySqlServerKeyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlServerKeyServerKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlServerKeyServerKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<NullableResponse<MySqlServerKeyResource>> GetIfExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mySqlServerKeyServerKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MySqlServerKeyResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlServerKeyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual NullableResponse<MySqlServerKeyResource> GetIfExists(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _mySqlServerKeyServerKeysClientDiagnostics.CreateScope("MySqlServerKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mySqlServerKeyServerKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MySqlServerKeyResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlServerKeyResource> IEnumerable<MySqlServerKeyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlServerKeyResource> IAsyncEnumerable<MySqlServerKeyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
