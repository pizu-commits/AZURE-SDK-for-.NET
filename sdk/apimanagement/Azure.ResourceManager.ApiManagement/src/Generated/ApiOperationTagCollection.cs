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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiOperationTagResource"/> and their operations.
    /// Each <see cref="ApiOperationTagResource"/> in the collection will belong to the same instance of <see cref="ApiOperationResource"/>.
    /// To get an <see cref="ApiOperationTagCollection"/> instance call the GetApiOperationTags method from an instance of <see cref="ApiOperationResource"/>.
    /// </summary>
    public partial class ApiOperationTagCollection : ArmCollection, IEnumerable<ApiOperationTagResource>, IAsyncEnumerable<ApiOperationTagResource>
    {
        private readonly ClientDiagnostics _apiOperationTagTagClientDiagnostics;
        private readonly TagRestOperations _apiOperationTagTagRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiOperationTagCollection"/> class for mocking. </summary>
        protected ApiOperationTagCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiOperationTagCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiOperationTagCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiOperationTagTagClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiOperationTagResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiOperationTagResource.ResourceType, out string apiOperationTagTagApiVersion);
            _apiOperationTagTagRestClient = new TagRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiOperationTagTagApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiOperationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiOperationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Assign tag to the Operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_AssignToOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiOperationTagResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiOperationTagTagRestClient.AssignToOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                var uri = _apiOperationTagTagRestClient.CreateAssignToOperationRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiOperationTagResource>(Response.FromValue(new ApiOperationTagResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Assign tag to the Operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_AssignToOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual ArmOperation<ApiOperationTagResource> CreateOrUpdate(WaitUntil waitUntil, string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiOperationTagTagRestClient.AssignToOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken);
                var uri = _apiOperationTagTagRestClient.CreateAssignToOperationRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiOperationTagResource>(Response.FromValue(new ApiOperationTagResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get tag associated with the Operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<ApiOperationTagResource>> GetAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiOperationTagTagRestClient.GetByOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiOperationTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get tag associated with the Operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<ApiOperationTagResource> Get(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.Get");
            scope.Start();
            try
            {
                var response = _apiOperationTagTagRestClient.GetByOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiOperationTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Tags associated with the Operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_ListByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiOperationTagResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiOperationTagResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiOperationTagTagRestClient.CreateListByOperationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiOperationTagTagRestClient.CreateListByOperationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiOperationTagResource(Client, TagContractData.DeserializeTagContractData(e)), _apiOperationTagTagClientDiagnostics, Pipeline, "ApiOperationTagCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Tags associated with the Operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_ListByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiOperationTagResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiOperationTagResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiOperationTagTagRestClient.CreateListByOperationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiOperationTagTagRestClient.CreateListByOperationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiOperationTagResource(Client, TagContractData.DeserializeTagContractData(e)), _apiOperationTagTagClientDiagnostics, Pipeline, "ApiOperationTagCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiOperationTagTagRestClient.GetByOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<bool> Exists(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiOperationTagTagRestClient.GetByOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiOperationTagResource>> GetIfExistsAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiOperationTagTagRestClient.GetByOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiOperationTagResource>(response.GetRawResponse());
                return Response.FromValue(new ApiOperationTagResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/operations/{operationId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByOperation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiOperationTagResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual NullableResponse<ApiOperationTagResource> GetIfExists(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiOperationTagTagClientDiagnostics.CreateScope("ApiOperationTagCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiOperationTagTagRestClient.GetByOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiOperationTagResource>(response.GetRawResponse());
                return Response.FromValue(new ApiOperationTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiOperationTagResource> IEnumerable<ApiOperationTagResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiOperationTagResource> IAsyncEnumerable<ApiOperationTagResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
