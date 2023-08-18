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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementTagResource" /> and their operations.
    /// Each <see cref="ApiManagementTagResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementTagCollection" /> instance call the GetApiManagementTags method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementTagCollection : ArmCollection, IEnumerable<ApiManagementTagResource>, IAsyncEnumerable<ApiManagementTagResource>
    {
        private readonly ClientDiagnostics _apiManagementTagTagClientDiagnostics;
        private readonly TagRestOperations _apiManagementTagTagRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementTagCollection"/> class for mocking. </summary>
        protected ApiManagementTagCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementTagCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementTagCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementTagTagClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementTagResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementTagResource.ResourceType, out string apiManagementTagTagApiVersion);
            _apiManagementTagTagRestClient = new TagRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementTagTagApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementTagResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tagId, ApiManagementTagCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementTagTagClientDiagnostics.CreateScope("ApiManagementTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementTagTagRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementTagResource>(Response.FromValue(new ApiManagementTagResource(Client, response), response.GetRawResponse()));
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
        /// Creates a tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementTagResource> CreateOrUpdate(WaitUntil waitUntil, string tagId, ApiManagementTagCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementTagTagClientDiagnostics.CreateScope("ApiManagementTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementTagTagRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementTagResource>(Response.FromValue(new ApiManagementTagResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the tag specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementTagResource>> GetAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementTagTagClientDiagnostics.CreateScope("ApiManagementTagCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementTagTagRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the tag specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<ApiManagementTagResource> Get(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementTagTagClientDiagnostics.CreateScope("ApiManagementTagCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementTagTagRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of tags defined within a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="scope"> Scope like 'apis', 'products' or 'apis/{apiId}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementTagResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, string scope = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementTagTagRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementTagTagRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementTagResource(Client, TagContractData.DeserializeTagContractData(e)), _apiManagementTagTagClientDiagnostics, Pipeline, "ApiManagementTagCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of tags defined within a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="scope"> Scope like 'apis', 'products' or 'apis/{apiId}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementTagResource> GetAll(string filter = null, int? top = null, int? skip = null, string scope = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementTagTagRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementTagTagRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementTagResource(Client, TagContractData.DeserializeTagContractData(e)), _apiManagementTagTagClientDiagnostics, Pipeline, "ApiManagementTagCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_Get</description>
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

            using var scope = _apiManagementTagTagClientDiagnostics.CreateScope("ApiManagementTagCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementTagTagRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_Get</description>
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

            using var scope = _apiManagementTagTagClientDiagnostics.CreateScope("ApiManagementTagCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementTagTagRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementTagResource> IEnumerable<ApiManagementTagResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementTagResource> IAsyncEnumerable<ApiManagementTagResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
