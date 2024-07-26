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
    /// A class representing a collection of <see cref="DocumentationContractResource"/> and their operations.
    /// Each <see cref="DocumentationContractResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get a <see cref="DocumentationContractCollection"/> instance call the GetDocumentationContracts method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class DocumentationContractCollection : ArmCollection, IEnumerable<DocumentationContractResource>, IAsyncEnumerable<DocumentationContractResource>
    {
        private readonly ClientDiagnostics _documentationContractDocumentationClientDiagnostics;
        private readonly DocumentationRestOperations _documentationContractDocumentationRestClient;

        /// <summary> Initializes a new instance of the <see cref="DocumentationContractCollection"/> class for mocking. </summary>
        protected DocumentationContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DocumentationContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DocumentationContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _documentationContractDocumentationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", DocumentationContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DocumentationContractResource.ResourceType, out string documentationContractDocumentationApiVersion);
            _documentationContractDocumentationRestClient = new DocumentationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, documentationContractDocumentationApiVersion);
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
        /// Creates a new Documentation or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DocumentationContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string documentationId, DocumentationContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _documentationContractDocumentationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _documentationContractDocumentationRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<DocumentationContractResource>(Response.FromValue(new DocumentationContractResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates a new Documentation or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DocumentationContractResource> CreateOrUpdate(WaitUntil waitUntil, string documentationId, DocumentationContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _documentationContractDocumentationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, data, ifMatch, cancellationToken);
                var uri = _documentationContractDocumentationRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<DocumentationContractResource>(Response.FromValue(new DocumentationContractResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the details of the Documentation specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> is null. </exception>
        public virtual async Task<Response<DocumentationContractResource>> GetAsync(string documentationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _documentationContractDocumentationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DocumentationContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Documentation specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> is null. </exception>
        public virtual Response<DocumentationContractResource> Get(string documentationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.Get");
            scope.Start();
            try
            {
                var response = _documentationContractDocumentationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DocumentationContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Documentations of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | eq |  contains |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DocumentationContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DocumentationContractResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _documentationContractDocumentationRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _documentationContractDocumentationRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DocumentationContractResource(Client, DocumentationContractData.DeserializeDocumentationContractData(e)), _documentationContractDocumentationClientDiagnostics, Pipeline, "DocumentationContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Documentations of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | eq |  contains |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DocumentationContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DocumentationContractResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _documentationContractDocumentationRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _documentationContractDocumentationRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DocumentationContractResource(Client, DocumentationContractData.DeserializeDocumentationContractData(e)), _documentationContractDocumentationClientDiagnostics, Pipeline, "DocumentationContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string documentationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _documentationContractDocumentationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> is null. </exception>
        public virtual Response<bool> Exists(string documentationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _documentationContractDocumentationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> is null. </exception>
        public virtual async Task<NullableResponse<DocumentationContractResource>> GetIfExistsAsync(string documentationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _documentationContractDocumentationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DocumentationContractResource>(response.GetRawResponse());
                return Response.FromValue(new DocumentationContractResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/documentations/{documentationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Documentation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DocumentationContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="documentationId"> Documentation identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="documentationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="documentationId"/> is null. </exception>
        public virtual NullableResponse<DocumentationContractResource> GetIfExists(string documentationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(documentationId, nameof(documentationId));

            using var scope = _documentationContractDocumentationClientDiagnostics.CreateScope("DocumentationContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _documentationContractDocumentationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, documentationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DocumentationContractResource>(response.GetRawResponse());
                return Response.FromValue(new DocumentationContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DocumentationContractResource> IEnumerable<DocumentationContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DocumentationContractResource> IAsyncEnumerable<DocumentationContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
