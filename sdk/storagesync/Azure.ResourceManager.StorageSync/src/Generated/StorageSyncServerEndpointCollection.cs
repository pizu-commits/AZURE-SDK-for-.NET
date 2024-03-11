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
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageSyncServerEndpointResource"/> and their operations.
    /// Each <see cref="StorageSyncServerEndpointResource"/> in the collection will belong to the same instance of <see cref="StorageSyncGroupResource"/>.
    /// To get a <see cref="StorageSyncServerEndpointCollection"/> instance call the GetStorageSyncServerEndpoints method from an instance of <see cref="StorageSyncGroupResource"/>.
    /// </summary>
    public partial class StorageSyncServerEndpointCollection : ArmCollection, IEnumerable<StorageSyncServerEndpointResource>, IAsyncEnumerable<StorageSyncServerEndpointResource>
    {
        private readonly ClientDiagnostics _storageSyncServerEndpointServerEndpointsClientDiagnostics;
        private readonly ServerEndpointsRestOperations _storageSyncServerEndpointServerEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncServerEndpointCollection"/> class for mocking. </summary>
        protected StorageSyncServerEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncServerEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageSyncServerEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncServerEndpointServerEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", StorageSyncServerEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageSyncServerEndpointResource.ResourceType, out string storageSyncServerEndpointServerEndpointsApiVersion);
            _storageSyncServerEndpointServerEndpointsRestClient = new ServerEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncServerEndpointServerEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageSyncGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageSyncGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="content"> Body of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSyncServerEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverEndpointName, StorageSyncServerEndpointCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<StorageSyncServerEndpointResource>(new StorageSyncServerEndpointOperationSource(Client), _storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create a new ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="content"> Body of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<StorageSyncServerEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string serverEndpointName, StorageSyncServerEndpointCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, content, cancellationToken);
                var operation = new StorageSyncArmOperation<StorageSyncServerEndpointResource>(new StorageSyncServerEndpointOperationSource(Client), _storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Get a ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        public virtual async Task<Response<StorageSyncServerEndpointResource>> GetAsync(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        public virtual Response<StorageSyncServerEndpointResource> Get(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ServerEndpoint list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_ListBySyncGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSyncServerEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSyncServerEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncServerEndpointServerEndpointsRestClient.CreateListBySyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new StorageSyncServerEndpointResource(Client, StorageSyncServerEndpointData.DeserializeStorageSyncServerEndpointData(e)), _storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, "StorageSyncServerEndpointCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a ServerEndpoint list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_ListBySyncGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSyncServerEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSyncServerEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncServerEndpointServerEndpointsRestClient.CreateListBySyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new StorageSyncServerEndpointResource(Client, StorageSyncServerEndpointData.DeserializeStorageSyncServerEndpointData(e)), _storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, "StorageSyncServerEndpointCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageSyncServerEndpointResource>> GetIfExistsAsync(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageSyncServerEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServerEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        public virtual NullableResponse<StorageSyncServerEndpointResource> GetIfExists(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverEndpointName, nameof(serverEndpointName));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageSyncServerEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageSyncServerEndpointResource> IEnumerable<StorageSyncServerEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageSyncServerEndpointResource> IAsyncEnumerable<StorageSyncServerEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
