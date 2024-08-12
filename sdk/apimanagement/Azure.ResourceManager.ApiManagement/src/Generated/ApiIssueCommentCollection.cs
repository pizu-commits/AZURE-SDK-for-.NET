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
    /// A class representing a collection of <see cref="ApiIssueCommentResource"/> and their operations.
    /// Each <see cref="ApiIssueCommentResource"/> in the collection will belong to the same instance of <see cref="ApiIssueResource"/>.
    /// To get an <see cref="ApiIssueCommentCollection"/> instance call the GetApiIssueComments method from an instance of <see cref="ApiIssueResource"/>.
    /// </summary>
    public partial class ApiIssueCommentCollection : ArmCollection, IEnumerable<ApiIssueCommentResource>, IAsyncEnumerable<ApiIssueCommentResource>
    {
        private readonly ClientDiagnostics _apiIssueCommentClientDiagnostics;
        private readonly ApiIssueCommentRestOperations _apiIssueCommentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiIssueCommentCollection"/> class for mocking. </summary>
        protected ApiIssueCommentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiIssueCommentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiIssueCommentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiIssueCommentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiIssueCommentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiIssueCommentResource.ResourceType, out string apiIssueCommentApiVersion);
            _apiIssueCommentRestClient = new ApiIssueCommentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiIssueCommentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiIssueResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiIssueResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Comment for the Issue in an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiIssueCommentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string commentId, ApiIssueCommentData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiIssueCommentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _apiIssueCommentRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiIssueCommentResource>(Response.FromValue(new ApiIssueCommentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates a new Comment for the Issue in an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiIssueCommentResource> CreateOrUpdate(WaitUntil waitUntil, string commentId, ApiIssueCommentData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiIssueCommentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, data, ifMatch, cancellationToken);
                var uri = _apiIssueCommentRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiIssueCommentResource>(Response.FromValue(new ApiIssueCommentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the details of the issue Comment for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        public virtual async Task<Response<ApiIssueCommentResource>> GetAsync(string commentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiIssueCommentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiIssueCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the issue Comment for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        public virtual Response<ApiIssueCommentResource> Get(string commentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.Get");
            scope.Start();
            try
            {
                var response = _apiIssueCommentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiIssueCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all comments for the Issue associated with the specified API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiIssueCommentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiIssueCommentResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiIssueCommentRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiIssueCommentRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiIssueCommentResource(Client, ApiIssueCommentData.DeserializeApiIssueCommentData(e)), _apiIssueCommentClientDiagnostics, Pipeline, "ApiIssueCommentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all comments for the Issue associated with the specified API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiIssueCommentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiIssueCommentResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiIssueCommentRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiIssueCommentRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiIssueCommentResource(Client, ApiIssueCommentData.DeserializeApiIssueCommentData(e)), _apiIssueCommentClientDiagnostics, Pipeline, "ApiIssueCommentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string commentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiIssueCommentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        public virtual Response<bool> Exists(string commentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiIssueCommentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiIssueCommentResource>> GetIfExistsAsync(string commentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiIssueCommentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiIssueCommentResource>(response.GetRawResponse());
                return Response.FromValue(new ApiIssueCommentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/comments/{commentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueComment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiIssueCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commentId"> Comment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commentId"/> is null. </exception>
        public virtual NullableResponse<ApiIssueCommentResource> GetIfExists(string commentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commentId, nameof(commentId));

            using var scope = _apiIssueCommentClientDiagnostics.CreateScope("ApiIssueCommentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiIssueCommentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, commentId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiIssueCommentResource>(response.GetRawResponse());
                return Response.FromValue(new ApiIssueCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiIssueCommentResource> IEnumerable<ApiIssueCommentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiIssueCommentResource> IAsyncEnumerable<ApiIssueCommentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
