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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningModelVersionResource"/> and their operations.
    /// Each <see cref="MachineLearningModelVersionResource"/> in the collection will belong to the same instance of <see cref="MachineLearningModelContainerResource"/>.
    /// To get a <see cref="MachineLearningModelVersionCollection"/> instance call the GetMachineLearningModelVersions method from an instance of <see cref="MachineLearningModelContainerResource"/>.
    /// </summary>
    public partial class MachineLearningModelVersionCollection : ArmCollection, IEnumerable<MachineLearningModelVersionResource>, IAsyncEnumerable<MachineLearningModelVersionResource>
    {
        private readonly ClientDiagnostics _machineLearningModelVersionModelVersionsClientDiagnostics;
        private readonly ModelVersionsRestOperations _machineLearningModelVersionModelVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningModelVersionCollection"/> class for mocking. </summary>
        protected MachineLearningModelVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningModelVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningModelVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningModelVersionModelVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningModelVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningModelVersionResource.ResourceType, out string machineLearningModelVersionModelVersionsApiVersion);
            _machineLearningModelVersionModelVersionsRestClient = new ModelVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningModelVersionModelVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningModelContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningModelContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningModelVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, MachineLearningModelVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningModelVersionModelVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var uri = _machineLearningModelVersionModelVersionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningModelVersionResource>(Response.FromValue(new MachineLearningModelVersionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningModelVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, MachineLearningModelVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningModelVersionModelVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var uri = _machineLearningModelVersionModelVersionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningModelVersionResource>(Response.FromValue(new MachineLearningModelVersionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<MachineLearningModelVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningModelVersionModelVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningModelVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<MachineLearningModelVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningModelVersionModelVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningModelVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List model versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningModelVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningModelVersionResource> GetAllAsync(MachineLearningModelVersionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningModelVersionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningModelVersionModelVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.OrderBy, options.Top, options.Version, options.Description, options.Offset, options.Tags, options.Properties, options.Feed, options.ListViewType, options.Stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningModelVersionModelVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.OrderBy, options.Top, options.Version, options.Description, options.Offset, options.Tags, options.Properties, options.Feed, options.ListViewType, options.Stage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningModelVersionResource(Client, MachineLearningModelVersionData.DeserializeMachineLearningModelVersionData(e)), _machineLearningModelVersionModelVersionsClientDiagnostics, Pipeline, "MachineLearningModelVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List model versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningModelVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningModelVersionResource> GetAll(MachineLearningModelVersionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningModelVersionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningModelVersionModelVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.OrderBy, options.Top, options.Version, options.Description, options.Offset, options.Tags, options.Properties, options.Feed, options.ListViewType, options.Stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningModelVersionModelVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.OrderBy, options.Top, options.Version, options.Description, options.Offset, options.Tags, options.Properties, options.Feed, options.ListViewType, options.Stage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningModelVersionResource(Client, MachineLearningModelVersionData.DeserializeMachineLearningModelVersionData(e)), _machineLearningModelVersionModelVersionsClientDiagnostics, Pipeline, "MachineLearningModelVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningModelVersionModelVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningModelVersionModelVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningModelVersionResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningModelVersionModelVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningModelVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningModelVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<MachineLearningModelVersionResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningModelVersionModelVersionsClientDiagnostics.CreateScope("MachineLearningModelVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningModelVersionModelVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningModelVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningModelVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningModelVersionResource> IEnumerable<MachineLearningModelVersionResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningModelVersionResource> IAsyncEnumerable<MachineLearningModelVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
