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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualApplicationResource"/> and their operations.
    /// Each <see cref="VirtualApplicationResource"/> in the collection will belong to the same instance of <see cref="VirtualApplicationGroupResource"/>.
    /// To get a <see cref="VirtualApplicationCollection"/> instance call the GetVirtualApplications method from an instance of <see cref="VirtualApplicationGroupResource"/>.
    /// </summary>
    public partial class VirtualApplicationCollection : ArmCollection, IEnumerable<VirtualApplicationResource>, IAsyncEnumerable<VirtualApplicationResource>
    {
        private readonly ClientDiagnostics _virtualApplicationApplicationsClientDiagnostics;
        private readonly ApplicationsRestOperations _virtualApplicationApplicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualApplicationCollection"/> class for mocking. </summary>
        protected VirtualApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualApplicationApplicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", VirtualApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualApplicationResource.ResourceType, out string virtualApplicationApplicationsApiVersion);
            _virtualApplicationApplicationsRestClient = new ApplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualApplicationApplicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualApplicationGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualApplicationGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="data"> Object containing Application definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualApplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationName, VirtualApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualApplicationApplicationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken).ConfigureAwait(false);
                var uri = _virtualApplicationApplicationsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<VirtualApplicationResource>(Response.FromValue(new VirtualApplicationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update an application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="data"> Object containing Application definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualApplicationResource> CreateOrUpdate(WaitUntil waitUntil, string applicationName, VirtualApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualApplicationApplicationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken);
                var uri = _virtualApplicationApplicationsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<VirtualApplicationResource>(Response.FromValue(new VirtualApplicationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get an application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<VirtualApplicationResource>> GetAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<VirtualApplicationResource> Get(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List applications.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualApplicationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualApplicationResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualApplicationApplicationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualApplicationApplicationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualApplicationResource(Client, VirtualApplicationData.DeserializeVirtualApplicationData(e)), _virtualApplicationApplicationsClientDiagnostics, Pipeline, "VirtualApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List applications.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualApplicationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualApplicationResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualApplicationApplicationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualApplicationApplicationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualApplicationResource(Client, VirtualApplicationData.DeserializeVirtualApplicationData(e)), _virtualApplicationApplicationsClientDiagnostics, Pipeline, "VirtualApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualApplicationResource>> GetIfExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualApplicationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application within the specified application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual NullableResponse<VirtualApplicationResource> GetIfExists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualApplicationResource> IEnumerable<VirtualApplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualApplicationResource> IAsyncEnumerable<VirtualApplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
