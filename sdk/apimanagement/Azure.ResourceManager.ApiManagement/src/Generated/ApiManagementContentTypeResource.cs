// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementContentType along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiManagementContentTypeResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiManagementContentTypeResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource" /> using the GetApiManagementContentType method.
    /// </summary>
    public partial class ApiManagementContentTypeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementContentTypeResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string contentTypeId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementContentTypeContentTypeClientDiagnostics;
        private readonly ContentTypeRestOperations _apiManagementContentTypeContentTypeRestClient;
        private readonly ApiManagementContentTypeData _data;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementContentTypeResource"/> class for mocking. </summary>
        protected ApiManagementContentTypeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiManagementContentTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementContentTypeResource(ArmClient client, ApiManagementContentTypeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementContentTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementContentTypeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementContentTypeContentTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementContentTypeContentTypeApiVersion);
            _apiManagementContentTypeContentTypeRestClient = new ContentTypeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementContentTypeContentTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/contentTypes";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiManagementContentTypeData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ApiManagementContentItemResources in the ApiManagementContentType. </summary>
        /// <returns> An object representing collection of ApiManagementContentItemResources and their operations over a ApiManagementContentItemResource. </returns>
        public virtual ApiManagementContentItemCollection GetApiManagementContentItems()
        {
            return GetCachedClient(Client => new ApiManagementContentItemCollection(Client, Id));
        }

        /// <summary>
        /// Returns the developer portal&apos;s content item specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}/contentItems/{contentItemId}
        /// Operation Id: ContentItem_Get
        /// </summary>
        /// <param name="contentItemId"> Content item identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentItemId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ApiManagementContentItemResource>> GetApiManagementContentItemAsync(string contentItemId, CancellationToken cancellationToken = default)
        {
            return await GetApiManagementContentItems().GetAsync(contentItemId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the developer portal&apos;s content item specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}/contentItems/{contentItemId}
        /// Operation Id: ContentItem_Get
        /// </summary>
        /// <param name="contentItemId"> Content item identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentItemId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ApiManagementContentItemResource> GetApiManagementContentItem(string contentItemId, CancellationToken cancellationToken = default)
        {
            return GetApiManagementContentItems().Get(contentItemId, cancellationToken);
        }

        /// <summary>
        /// Gets the details of the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementContentTypeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementContentTypeContentTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementContentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementContentTypeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementContentTypeContentTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementContentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes the specified developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints. Built-in content types (with identifiers starting with the `c-` prefix) can&apos;t be removed.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiManagementContentTypeContentTypeRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes the specified developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints. Built-in content types (with identifiers starting with the `c-` prefix) can&apos;t be removed.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeResource.Delete");
            scope.Start();
            try
            {
                var response = _apiManagementContentTypeContentTypeRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints. Custom content types&apos; identifiers need to start with the `c-` prefix. Built-in content types can&apos;t be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<ApiManagementContentTypeResource>> UpdateAsync(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeResource.Update");
            scope.Start();
            try
            {
                var response = await _apiManagementContentTypeContentTypeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementContentTypeResource>(Response.FromValue(new ApiManagementContentTypeResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints. Custom content types&apos; identifiers need to start with the `c-` prefix. Built-in content types can&apos;t be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ApiManagementContentTypeResource> Update(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeResource.Update");
            scope.Start();
            try
            {
                var response = _apiManagementContentTypeContentTypeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementContentTypeResource>(Response.FromValue(new ApiManagementContentTypeResource(Client, response), response.GetRawResponse()));
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
    }
}
