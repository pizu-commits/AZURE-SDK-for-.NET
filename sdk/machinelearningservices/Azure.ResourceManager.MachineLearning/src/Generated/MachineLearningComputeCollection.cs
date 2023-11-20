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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningComputeResource"/> and their operations.
    /// Each <see cref="MachineLearningComputeResource"/> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// To get a <see cref="MachineLearningComputeCollection"/> instance call the GetMachineLearningComputes method from an instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// </summary>
    public partial class MachineLearningComputeCollection : ArmCollection, IEnumerable<MachineLearningComputeResource>, IAsyncEnumerable<MachineLearningComputeResource>
    {
        private readonly ClientDiagnostics _machineLearningComputeComputeClientDiagnostics;
        private readonly ComputeRestOperations _machineLearningComputeComputeRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningComputeCollection"/> class for mocking. </summary>
        protected MachineLearningComputeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningComputeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningComputeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningComputeComputeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningComputeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningComputeResource.ResourceType, out string machineLearningComputeComputeApiVersion);
            _machineLearningComputeComputeRestClient = new ComputeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningComputeComputeApiVersion);
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
        /// Creates or updates compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. If your intent is to create a new compute, do a GET first to verify that it does not exist yet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="data"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningComputeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string computeName, MachineLearningComputeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningComputeComputeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningComputeResource>(new MachineLearningComputeOperationSource(Client), _machineLearningComputeComputeClientDiagnostics, Pipeline, _machineLearningComputeComputeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. If your intent is to create a new compute, do a GET first to verify that it does not exist yet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="data"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningComputeResource> CreateOrUpdate(WaitUntil waitUntil, string computeName, MachineLearningComputeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningComputeComputeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningComputeResource>(new MachineLearningComputeOperationSource(Client), _machineLearningComputeComputeClientDiagnostics, Pipeline, _machineLearningComputeComputeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets compute definition by its name. Any secrets (storage keys, service credentials, etc) are not returned - use 'keys' nested resource to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningComputeResource>> GetAsync(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningComputeComputeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComputeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets compute definition by its name. Any secrets (storage keys, service credentials, etc) are not returned - use 'keys' nested resource to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual Response<MachineLearningComputeResource> Get(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningComputeComputeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComputeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets computes in specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningComputeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningComputeResource> GetAllAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningComputeComputeRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningComputeComputeRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningComputeResource(Client, MachineLearningComputeData.DeserializeMachineLearningComputeData(e)), _machineLearningComputeComputeClientDiagnostics, Pipeline, "MachineLearningComputeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets computes in specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningComputeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningComputeResource> GetAll(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningComputeComputeRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningComputeComputeRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningComputeResource(Client, MachineLearningComputeData.DeserializeMachineLearningComputeData(e)), _machineLearningComputeComputeClientDiagnostics, Pipeline, "MachineLearningComputeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningComputeComputeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual Response<bool> Exists(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningComputeComputeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningComputeResource>> GetIfExistsAsync(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningComputeComputeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningComputeResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComputeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Compute_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual NullableResponse<MachineLearningComputeResource> GetIfExists(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _machineLearningComputeComputeClientDiagnostics.CreateScope("MachineLearningComputeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningComputeComputeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningComputeResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComputeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningComputeResource> IEnumerable<MachineLearningComputeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningComputeResource> IAsyncEnumerable<MachineLearningComputeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
