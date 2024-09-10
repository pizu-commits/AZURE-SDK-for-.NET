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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningServerlessEndpointResource"/> and their operations.
    /// Each <see cref="MachineLearningServerlessEndpointResource"/> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// To get a <see cref="MachineLearningServerlessEndpointCollection"/> instance call the GetMachineLearningServerlessEndpoints method from an instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// </summary>
    public partial class MachineLearningServerlessEndpointCollection : ArmCollection, IEnumerable<MachineLearningServerlessEndpointResource>, IAsyncEnumerable<MachineLearningServerlessEndpointResource>
    {
        private readonly ClientDiagnostics _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics;
        private readonly ServerlessEndpointsRestOperations _machineLearningServerlessEndpointServerlessEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningServerlessEndpointCollection"/> class for mocking. </summary>
        protected MachineLearningServerlessEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningServerlessEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningServerlessEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningServerlessEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningServerlessEndpointResource.ResourceType, out string machineLearningServerlessEndpointServerlessEndpointsApiVersion);
            _machineLearningServerlessEndpointServerlessEndpointsRestClient = new ServerlessEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningServerlessEndpointServerlessEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update Serverless Endpoint (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="data"> Serverless Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningServerlessEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, MachineLearningServerlessEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningServerlessEndpointResource>(new MachineLearningServerlessEndpointOperationSource(Client), _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics, Pipeline, _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update Serverless Endpoint (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="data"> Serverless Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningServerlessEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string name, MachineLearningServerlessEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningServerlessEndpointResource>(new MachineLearningServerlessEndpointOperationSource(Client), _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics, Pipeline, _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get Serverless Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<MachineLearningServerlessEndpointResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningServerlessEndpointServerlessEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningServerlessEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Serverless Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<MachineLearningServerlessEndpointResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningServerlessEndpointServerlessEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningServerlessEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Serverless Endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningServerlessEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningServerlessEndpointResource> GetAllAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningServerlessEndpointResource(Client, MachineLearningServerlessEndpointData.DeserializeMachineLearningServerlessEndpointData(e)), _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics, Pipeline, "MachineLearningServerlessEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Serverless Endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningServerlessEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningServerlessEndpointResource> GetAll(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningServerlessEndpointServerlessEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningServerlessEndpointResource(Client, MachineLearningServerlessEndpointData.DeserializeMachineLearningServerlessEndpointData(e)), _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics, Pipeline, "MachineLearningServerlessEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningServerlessEndpointServerlessEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningServerlessEndpointServerlessEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningServerlessEndpointResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningServerlessEndpointServerlessEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningServerlessEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningServerlessEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/serverlessEndpoints/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerlessEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningServerlessEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Serverless Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<MachineLearningServerlessEndpointResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningServerlessEndpointServerlessEndpointsClientDiagnostics.CreateScope("MachineLearningServerlessEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningServerlessEndpointServerlessEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningServerlessEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningServerlessEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningServerlessEndpointResource> IEnumerable<MachineLearningServerlessEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningServerlessEndpointResource> IAsyncEnumerable<MachineLearningServerlessEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
