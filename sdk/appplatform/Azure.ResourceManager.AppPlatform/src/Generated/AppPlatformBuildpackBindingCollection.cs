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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformBuildpackBindingResource" /> and their operations.
    /// Each <see cref="AppPlatformBuildpackBindingResource" /> in the collection will belong to the same instance of <see cref="AppPlatformBuilderResource" />.
    /// To get an <see cref="AppPlatformBuildpackBindingCollection" /> instance call the GetAppPlatformBuildpackBindings method from an instance of <see cref="AppPlatformBuilderResource" />.
    /// </summary>
    public partial class AppPlatformBuildpackBindingCollection : ArmCollection, IEnumerable<AppPlatformBuildpackBindingResource>, IAsyncEnumerable<AppPlatformBuildpackBindingResource>
    {
        private readonly ClientDiagnostics _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics;
        private readonly BuildpackBindingRestOperations _appPlatformBuildpackBindingBuildpackBindingRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildpackBindingCollection"/> class for mocking. </summary>
        protected AppPlatformBuildpackBindingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildpackBindingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformBuildpackBindingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformBuildpackBindingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformBuildpackBindingResource.ResourceType, out string appPlatformBuildpackBindingBuildpackBindingApiVersion);
            _appPlatformBuildpackBindingBuildpackBindingRestClient = new BuildpackBindingRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBuildpackBindingBuildpackBindingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformBuilderResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformBuilderResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a buildpack binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings/{buildpackBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="data"> The target buildpack binding for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackBindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformBuildpackBindingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string buildpackBindingName, AppPlatformBuildpackBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics.CreateScope("AppPlatformBuildpackBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformBuildpackBindingResource>(new AppPlatformBuildpackBindingOperationSource(Client), _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics, Pipeline, _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create or update a buildpack binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings/{buildpackBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="data"> The target buildpack binding for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackBindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformBuildpackBindingResource> CreateOrUpdate(WaitUntil waitUntil, string buildpackBindingName, AppPlatformBuildpackBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics.CreateScope("AppPlatformBuildpackBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformBuildpackBindingResource>(new AppPlatformBuildpackBindingOperationSource(Client), _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics, Pipeline, _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Get a buildpack binding by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings/{buildpackBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackBindingName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformBuildpackBindingResource>> GetAsync(string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var scope = _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics.CreateScope("AppPlatformBuildpackBindingCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildpackBindingBuildpackBindingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildpackBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a buildpack binding by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings/{buildpackBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackBindingName"/> is null. </exception>
        public virtual Response<AppPlatformBuildpackBindingResource> Get(string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var scope = _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics.CreateScope("AppPlatformBuildpackBindingCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBuildpackBindingBuildpackBindingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildpackBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all buildpack bindings in a builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformBuildpackBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformBuildpackBindingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppPlatformBuildpackBindingResource(Client, AppPlatformBuildpackBindingData.DeserializeAppPlatformBuildpackBindingData(e)), _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics, Pipeline, "AppPlatformBuildpackBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all buildpack bindings in a builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformBuildpackBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformBuildpackBindingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuildpackBindingBuildpackBindingRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppPlatformBuildpackBindingResource(Client, AppPlatformBuildpackBindingData.DeserializeAppPlatformBuildpackBindingData(e)), _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics, Pipeline, "AppPlatformBuildpackBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings/{buildpackBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackBindingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var scope = _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics.CreateScope("AppPlatformBuildpackBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildpackBindingBuildpackBindingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}/buildpackBindings/{buildpackBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildpackBinding_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackBindingName"/> is null. </exception>
        public virtual Response<bool> Exists(string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var scope = _appPlatformBuildpackBindingBuildpackBindingClientDiagnostics.CreateScope("AppPlatformBuildpackBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformBuildpackBindingBuildpackBindingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, buildpackBindingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformBuildpackBindingResource> IEnumerable<AppPlatformBuildpackBindingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformBuildpackBindingResource> IAsyncEnumerable<AppPlatformBuildpackBindingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
