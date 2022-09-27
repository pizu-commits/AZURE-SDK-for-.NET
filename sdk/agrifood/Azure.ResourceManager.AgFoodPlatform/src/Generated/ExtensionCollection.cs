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

namespace Azure.ResourceManager.AgFoodPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="ExtensionResource" /> and their operations.
    /// Each <see cref="ExtensionResource" /> in the collection will belong to the same instance of <see cref="FarmBeatResource" />.
    /// To get an <see cref="ExtensionCollection" /> instance call the GetExtensions method from an instance of <see cref="FarmBeatResource" />.
    /// </summary>
    public partial class ExtensionCollection : ArmCollection, IEnumerable<ExtensionResource>, IAsyncEnumerable<ExtensionResource>
    {
        private readonly ClientDiagnostics _extensionClientDiagnostics;
        private readonly ExtensionsRestOperations _extensionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExtensionCollection"/> class for mocking. </summary>
        protected ExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _extensionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AgFoodPlatform", ExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExtensionResource.ResourceType, out string extensionApiVersion);
            _extensionRestClient = new ExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, extensionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FarmBeatResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FarmBeatResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Install extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions/{extensionId}
        /// Operation Id: Extensions_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionId"/> is null. </exception>
        public virtual async Task<ArmOperation<ExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _extensionRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionId, cancellationToken).ConfigureAwait(false);
                var operation = new AgFoodPlatformArmOperation<ExtensionResource>(Response.FromValue(new ExtensionResource(Client, response), response.GetRawResponse()));
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
        /// Install extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions/{extensionId}
        /// Operation Id: Extensions_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionId"/> is null. </exception>
        public virtual ArmOperation<ExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _extensionRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionId, cancellationToken);
                var operation = new AgFoodPlatformArmOperation<ExtensionResource>(Response.FromValue(new ExtensionResource(Client, response), response.GetRawResponse()));
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
        /// Get installed extension details by extension id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions/{extensionId}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionId"/> is null. </exception>
        public virtual async Task<Response<ExtensionResource>> GetAsync(string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _extensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get installed extension details by extension id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions/{extensionId}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionId"/> is null. </exception>
        public virtual Response<ExtensionResource> Get(string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _extensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get installed extensions details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions
        /// Operation Id: Extensions_ListByFarmBeats
        /// </summary>
        /// <param name="extensionIds"> Installed extension ids. </param>
        /// <param name="extensionCategories"> Installed extension categories. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExtensionResource> GetAllAsync(IEnumerable<string> extensionIds = null, IEnumerable<string> extensionCategories = null, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ExtensionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _extensionRestClient.ListByFarmBeatsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionIds, extensionCategories, pageSizeHint, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExtensionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _extensionRestClient.ListByFarmBeatsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionIds, extensionCategories, pageSizeHint, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get installed extensions details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions
        /// Operation Id: Extensions_ListByFarmBeats
        /// </summary>
        /// <param name="extensionIds"> Installed extension ids. </param>
        /// <param name="extensionCategories"> Installed extension categories. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExtensionResource> GetAll(IEnumerable<string> extensionIds = null, IEnumerable<string> extensionCategories = null, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ExtensionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _extensionRestClient.ListByFarmBeats(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionIds, extensionCategories, pageSizeHint, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExtensionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _extensionRestClient.ListByFarmBeatsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionIds, extensionCategories, pageSizeHint, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions/{extensionId}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _extensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/extensions/{extensionId}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionId"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var scope = _extensionClientDiagnostics.CreateScope("ExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _extensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExtensionResource> IEnumerable<ExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExtensionResource> IAsyncEnumerable<ExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
