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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementServiceResource" /> and their operations.
    /// Each <see cref="ApiManagementServiceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ApiManagementServiceCollection" /> instance call the GetApiManagementServices method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ApiManagementServiceCollection : ArmCollection, IEnumerable<ApiManagementServiceResource>, IAsyncEnumerable<ApiManagementServiceResource>
    {
        private readonly ClientDiagnostics _apiManagementServiceClientDiagnostics;
        private readonly ApiManagementServiceRestOperations _apiManagementServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementServiceCollection"/> class for mocking. </summary>
        protected ApiManagementServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementServiceResource.ResourceType, out string apiManagementServiceApiVersion);
            _apiManagementServiceRestClient = new ApiManagementServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an API Management service. This is long running operation and could take several minutes to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate API Management service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceName, ApiManagementServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementServiceClientDiagnostics.CreateScope("ApiManagementServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementServiceResource>(new ApiManagementServiceOperationSource(Client), _apiManagementServiceClientDiagnostics, Pipeline, _apiManagementServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an API Management service. This is long running operation and could take several minutes to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate API Management service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementServiceResource> CreateOrUpdate(WaitUntil waitUntil, string serviceName, ApiManagementServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementServiceClientDiagnostics.CreateScope("ApiManagementServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementServiceResource>(new ApiManagementServiceOperationSource(Client), _apiManagementServiceClientDiagnostics, Pipeline, _apiManagementServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an API Management service resource description.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<ApiManagementServiceResource>> GetAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementServiceClientDiagnostics.CreateScope("ApiManagementServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an API Management service resource description.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<ApiManagementServiceResource> Get(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementServiceClientDiagnostics.CreateScope("ApiManagementServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all API Management services within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementServiceResource(Client, ApiManagementServiceData.DeserializeApiManagementServiceData(e)), _apiManagementServiceClientDiagnostics, Pipeline, "ApiManagementServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all API Management services within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementServiceResource(Client, ApiManagementServiceData.DeserializeApiManagementServiceData(e)), _apiManagementServiceClientDiagnostics, Pipeline, "ApiManagementServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementServiceClientDiagnostics.CreateScope("ApiManagementServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _apiManagementServiceClientDiagnostics.CreateScope("ApiManagementServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementServiceResource> IEnumerable<ApiManagementServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementServiceResource> IAsyncEnumerable<ApiManagementServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
