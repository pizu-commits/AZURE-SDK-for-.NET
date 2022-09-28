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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiIssue along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiIssueResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiIssueResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiResource" /> using the GetApiIssue method.
    /// </summary>
    public partial class ApiIssueResource : IssueContractResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiIssueResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string issueId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiIssueClientDiagnostics;
        private readonly ApiIssueRestOperations _apiIssueRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiIssueResource"/> class for mocking. </summary>
        protected ApiIssueResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiIssueResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiIssueResource(ArmClient client, IssueContractData data) : base(client, data)
        {
            _apiIssueClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiIssueApiVersion);
            _apiIssueRestClient = new ApiIssueRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiIssueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ApiIssueResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiIssueResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiIssueClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiIssueApiVersion);
            _apiIssueRestClient = new ApiIssueRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiIssueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/apis/issues";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ApiIssueCommentResources in the ApiIssue. </summary>
        /// <returns> An object representing collection of ApiIssueCommentResources and their operations over a ApiIssueCommentResource. </returns>
        public virtual ApiIssueCommentCollection GetApiIssueComments()
        {
            return GetCachedClient(Client => new ApiIssueCommentCollection(Client, Id));
        }

        /// <summary>
        /// Gets the details of the issue Comment for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}
        /// Operation Id: ApiIssueComment_Get
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ApiIssueCommentResource>> GetApiIssueCommentAsync(string commentId, CancellationToken cancellationToken = default)
        {
            return await GetApiIssueComments().GetAsync(commentId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the issue Comment for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}
        /// Operation Id: ApiIssueComment_Get
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ApiIssueCommentResource> GetApiIssueComment(string commentId, CancellationToken cancellationToken = default)
        {
            return GetApiIssueComments().Get(commentId, cancellationToken);
        }

        /// <summary> Gets a collection of ApiIssueAttachmentResources in the ApiIssue. </summary>
        /// <returns> An object representing collection of ApiIssueAttachmentResources and their operations over a ApiIssueAttachmentResource. </returns>
        public virtual ApiIssueAttachmentCollection GetApiIssueAttachments()
        {
            return GetCachedClient(Client => new ApiIssueAttachmentCollection(Client, Id));
        }

        /// <summary>
        /// Gets the details of the issue Attachment for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}
        /// Operation Id: ApiIssueAttachment_Get
        /// </summary>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ApiIssueAttachmentResource>> GetApiIssueAttachmentAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            return await GetApiIssueAttachments().GetAsync(attachmentId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the issue Attachment for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}
        /// Operation Id: ApiIssueAttachment_Get
        /// </summary>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ApiIssueAttachmentResource> GetApiIssueAttachment(string attachmentId, CancellationToken cancellationToken = default)
        {
            return GetApiIssueAttachments().Get(attachmentId, cancellationToken);
        }

        /// <summary>
        /// Gets the details of the Issue for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Get
        /// </summary>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<IssueContractResource>> GetCoreAsync(bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.Get");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expandCommentsAttachments, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Issue for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Get
        /// </summary>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ApiIssueResource>> GetAsync(bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(expandCommentsAttachments, cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ApiIssueResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets the details of the Issue for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Get
        /// </summary>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<IssueContractResource> GetCore(bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.Get");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expandCommentsAttachments, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Issue for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Get
        /// </summary>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ApiIssueResource> Get(bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            var result = GetCore(expandCommentsAttachments, cancellationToken);
            return Response.FromValue((ApiIssueResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Deletes the specified Issue from an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
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
        /// Deletes the specified Issue from an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.Delete");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
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
        /// Updates an existing issue for an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<ApiIssueResource>> UpdateAsync(ETag ifMatch, ApiIssuePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.Update");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApiIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing issue for an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<ApiIssueResource> Update(ETag ifMatch, ApiIssuePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.Update");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken);
                return Response.FromValue(new ApiIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the Issue for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the Issue for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}
        /// Operation Id: ApiIssue_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
