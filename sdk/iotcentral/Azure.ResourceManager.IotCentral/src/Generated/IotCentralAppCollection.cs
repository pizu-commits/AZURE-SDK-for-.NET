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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotCentral
{
    /// <summary>
    /// A class representing a collection of <see cref="IotCentralAppResource" /> and their operations.
    /// Each <see cref="IotCentralAppResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="IotCentralAppCollection" /> instance call the GetIotCentralApps method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class IotCentralAppCollection : ArmCollection, IEnumerable<IotCentralAppResource>, IAsyncEnumerable<IotCentralAppResource>
    {
        private readonly ClientDiagnostics _iotCentralAppAppsClientDiagnostics;
        private readonly AppsRestOperations _iotCentralAppAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotCentralAppCollection"/> class for mocking. </summary>
        protected IotCentralAppCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotCentralAppCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotCentralAppCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotCentralAppAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotCentral", IotCentralAppResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotCentralAppResource.ResourceType, out string iotCentralAppAppsApiVersion);
            _iotCentralAppAppsRestClient = new AppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotCentralAppAppsApiVersion);
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
        /// Create or update the metadata of an IoT Central application. The usual pattern to modify a property is to retrieve the IoT Central application metadata and security metadata, and then combine them with the modified values in a new body to update the IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="data"> The IoT Central application metadata and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotCentralAppResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, IotCentralAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotCentralAppAppsClientDiagnostics.CreateScope("IotCentralAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iotCentralAppAppsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IotCentralArmOperation<IotCentralAppResource>(new IotCentralAppOperationSource(Client), _iotCentralAppAppsClientDiagnostics, Pipeline, _iotCentralAppAppsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create or update the metadata of an IoT Central application. The usual pattern to modify a property is to retrieve the IoT Central application metadata and security metadata, and then combine them with the modified values in a new body to update the IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="data"> The IoT Central application metadata and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotCentralAppResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, IotCentralAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotCentralAppAppsClientDiagnostics.CreateScope("IotCentralAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iotCentralAppAppsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken);
                var operation = new IotCentralArmOperation<IotCentralAppResource>(new IotCentralAppOperationSource(Client), _iotCentralAppAppsClientDiagnostics, Pipeline, _iotCentralAppAppsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<IotCentralAppResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _iotCentralAppAppsClientDiagnostics.CreateScope("IotCentralAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotCentralAppAppsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotCentralAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<IotCentralAppResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _iotCentralAppAppsClientDiagnostics.CreateScope("IotCentralAppCollection.Get");
            scope.Start();
            try
            {
                var response = _iotCentralAppAppsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotCentralAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the IoT Central Applications in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotCentralAppResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotCentralAppAppsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotCentralAppAppsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IotCentralAppResource(Client, IotCentralAppData.DeserializeIotCentralAppData(e)), _iotCentralAppAppsClientDiagnostics, Pipeline, "IotCentralAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the IoT Central Applications in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotCentralAppResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotCentralAppAppsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotCentralAppAppsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IotCentralAppResource(Client, IotCentralAppData.DeserializeIotCentralAppData(e)), _iotCentralAppAppsClientDiagnostics, Pipeline, "IotCentralAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _iotCentralAppAppsClientDiagnostics.CreateScope("IotCentralAppCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotCentralAppAppsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _iotCentralAppAppsClientDiagnostics.CreateScope("IotCentralAppCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotCentralAppAppsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotCentralAppResource> IEnumerable<IotCentralAppResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotCentralAppResource> IAsyncEnumerable<IotCentralAppResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
