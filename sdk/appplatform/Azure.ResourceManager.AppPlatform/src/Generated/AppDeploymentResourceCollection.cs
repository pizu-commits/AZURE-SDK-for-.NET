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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppDeploymentResource" /> and their operations.
    /// Each <see cref="AppDeploymentResource" /> in the collection will belong to the same instance of <see cref="AppPlatformAppResource" />.
    /// To get an <see cref="AppDeploymentResourceCollection" /> instance call the GetAppDeploymentResources method from an instance of <see cref="AppPlatformAppResource" />.
    /// </summary>
    public partial class AppDeploymentResourceCollection : ArmCollection, IEnumerable<AppDeploymentResource>, IAsyncEnumerable<AppDeploymentResource>
    {
        private readonly ClientDiagnostics _appDeploymentResourceDeploymentsClientDiagnostics;
        private readonly DeploymentsRestOperations _appDeploymentResourceDeploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppDeploymentResourceCollection"/> class for mocking. </summary>
        protected AppDeploymentResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppDeploymentResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppDeploymentResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appDeploymentResourceDeploymentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppDeploymentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppDeploymentResource.ResourceType, out string appDeploymentResourceDeploymentsApiVersion);
            _appDeploymentResourceDeploymentsRestClient = new DeploymentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appDeploymentResourceDeploymentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new Deployment or update an exiting Deployment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppDeploymentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deploymentName, AppDeploymentResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appDeploymentResourceDeploymentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppDeploymentResource>(new AppDeploymentResourceOperationSource(Client), _appDeploymentResourceDeploymentsClientDiagnostics, Pipeline, _appDeploymentResourceDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new Deployment or update an exiting Deployment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppDeploymentResource> CreateOrUpdate(WaitUntil waitUntil, string deploymentName, AppDeploymentResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appDeploymentResourceDeploymentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppDeploymentResource>(new AppDeploymentResourceOperationSource(Client), _appDeploymentResourceDeploymentsClientDiagnostics, Pipeline, _appDeploymentResourceDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Deployment and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_Get
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<AppDeploymentResource>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _appDeploymentResourceDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Deployment and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_Get
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<AppDeploymentResource> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _appDeploymentResourceDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in an App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments
        /// Operation Id: Deployments_List
        /// </summary>
        /// <param name="version"> Version of the deployments to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppDeploymentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppDeploymentResource> GetAllAsync(IEnumerable<string> version = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AppDeploymentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appDeploymentResourceDeploymentsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppDeploymentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appDeploymentResourceDeploymentsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Handles requests to list all resources in an App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments
        /// Operation Id: Deployments_List
        /// </summary>
        /// <param name="version"> Version of the deployments to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppDeploymentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppDeploymentResource> GetAll(IEnumerable<string> version = null, CancellationToken cancellationToken = default)
        {
            Page<AppDeploymentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appDeploymentResourceDeploymentsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppDeploymentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appDeploymentResourceDeploymentsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_Get
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appDeploymentResourceDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_Get
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<bool> Exists(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appDeploymentResourceDeploymentsClientDiagnostics.CreateScope("AppDeploymentResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _appDeploymentResourceDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppDeploymentResource> IEnumerable<AppDeploymentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppDeploymentResource> IAsyncEnumerable<AppDeploymentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
