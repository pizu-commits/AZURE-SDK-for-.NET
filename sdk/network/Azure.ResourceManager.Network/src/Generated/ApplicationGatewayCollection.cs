// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ApplicationGateway and their operations over its parent. </summary>
    public partial class ApplicationGatewayCollection : ArmCollection, IEnumerable<ApplicationGatewayResource>, IAsyncEnumerable<ApplicationGatewayResource>
    {
        private readonly ClientDiagnostics _applicationGatewayClientDiagnostics;
        private readonly ApplicationGatewaysRestOperations _applicationGatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayCollection"/> class for mocking. </summary>
        protected ApplicationGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApplicationGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationGatewayClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ApplicationGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApplicationGatewayResource.ResourceType, out string applicationGatewayApiVersion);
            _applicationGatewayRestClient = new ApplicationGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, applicationGatewayApiVersion);
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
        /// Creates or updates the specified application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update application gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ApplicationGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationGatewayName, ApplicationGatewayData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _applicationGatewayRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ApplicationGatewayResource>(new ApplicationGatewayOperationSource(Client), _applicationGatewayClientDiagnostics, Pipeline, _applicationGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the specified application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update application gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ApplicationGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string applicationGatewayName, ApplicationGatewayData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _applicationGatewayRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<ApplicationGatewayResource>(new ApplicationGatewayOperationSource(Client), _applicationGatewayClientDiagnostics, Pipeline, _applicationGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_Get
        /// </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> is null. </exception>
        public virtual async Task<Response<ApplicationGatewayResource>> GetAsync(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_Get
        /// </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> is null. </exception>
        public virtual Response<ApplicationGatewayResource> Get(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all application gateways in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways
        /// Operation Id: ApplicationGateways_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationGatewayResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationGatewayResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all application gateways in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways
        /// Operation Id: ApplicationGateways_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationGatewayResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationGatewayRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationGatewayResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationGatewayRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_Get
        /// </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(applicationGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_Get
        /// </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(applicationGatewayName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_Get
        /// </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> is null. </exception>
        public virtual async Task<Response<ApplicationGatewayResource>> GetIfExistsAsync(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _applicationGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ApplicationGatewayResource>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
        /// Operation Id: ApplicationGateways_Get
        /// </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> is null. </exception>
        public virtual Response<ApplicationGatewayResource> GetIfExists(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGatewayName, nameof(applicationGatewayName));

            using var scope = _applicationGatewayClientDiagnostics.CreateScope("ApplicationGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _applicationGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationGatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ApplicationGatewayResource>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApplicationGatewayResource> IEnumerable<ApplicationGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApplicationGatewayResource> IAsyncEnumerable<ApplicationGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
