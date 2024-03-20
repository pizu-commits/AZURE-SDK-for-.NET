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
using Azure.ResourceManager.DataLakeStore.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeStoreTrustedIdProviderResource"/> and their operations.
    /// Each <see cref="DataLakeStoreTrustedIdProviderResource"/> in the collection will belong to the same instance of <see cref="DataLakeStoreAccountResource"/>.
    /// To get a <see cref="DataLakeStoreTrustedIdProviderCollection"/> instance call the GetDataLakeStoreTrustedIdProviders method from an instance of <see cref="DataLakeStoreAccountResource"/>.
    /// </summary>
    public partial class DataLakeStoreTrustedIdProviderCollection : ArmCollection, IEnumerable<DataLakeStoreTrustedIdProviderResource>, IAsyncEnumerable<DataLakeStoreTrustedIdProviderResource>
    {
        private readonly ClientDiagnostics _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics;
        private readonly TrustedIdProvidersRestOperations _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreTrustedIdProviderCollection"/> class for mocking. </summary>
        protected DataLakeStoreTrustedIdProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreTrustedIdProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeStoreTrustedIdProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeStore", DataLakeStoreTrustedIdProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeStoreTrustedIdProviderResource.ResourceType, out string dataLakeStoreTrustedIdProviderTrustedIdProvidersApiVersion);
            _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient = new TrustedIdProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeStoreTrustedIdProviderTrustedIdProvidersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeStoreAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeStoreAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified trusted identity provider. During update, the trusted identity provider with the specified name will be replaced with this new provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="content"> Parameters supplied to create or replace the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeStoreTrustedIdProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string trustedIdProviderName, DataLakeStoreTrustedIdProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreTrustedIdProviderResource>(Response.FromValue(new DataLakeStoreTrustedIdProviderResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the specified trusted identity provider. During update, the trusted identity provider with the specified name will be replaced with this new provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="content"> Parameters supplied to create or replace the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataLakeStoreTrustedIdProviderResource> CreateOrUpdate(WaitUntil waitUntil, string trustedIdProviderName, DataLakeStoreTrustedIdProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, content, cancellationToken);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreTrustedIdProviderResource>(Response.FromValue(new DataLakeStoreTrustedIdProviderResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified Data Lake Store trusted identity provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual async Task<Response<DataLakeStoreTrustedIdProviderResource>> GetAsync(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreTrustedIdProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store trusted identity provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual Response<DataLakeStoreTrustedIdProviderResource> Get(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreTrustedIdProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeStoreTrustedIdProviderResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeStoreTrustedIdProviderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataLakeStoreTrustedIdProviderResource(Client, DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(e)), _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics, Pipeline, "DataLakeStoreTrustedIdProviderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeStoreTrustedIdProviderResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeStoreTrustedIdProviderResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataLakeStoreTrustedIdProviderResource(Client, DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(e)), _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics, Pipeline, "DataLakeStoreTrustedIdProviderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual Response<bool> Exists(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataLakeStoreTrustedIdProviderResource>> GetIfExistsAsync(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeStoreTrustedIdProviderResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreTrustedIdProviderResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedIdProviders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreTrustedIdProviderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        public virtual NullableResponse<DataLakeStoreTrustedIdProviderResource> GetIfExists(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var scope = _dataLakeStoreTrustedIdProviderTrustedIdProvidersClientDiagnostics.CreateScope("DataLakeStoreTrustedIdProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataLakeStoreTrustedIdProviderTrustedIdProvidersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedIdProviderName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataLakeStoreTrustedIdProviderResource>(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreTrustedIdProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeStoreTrustedIdProviderResource> IEnumerable<DataLakeStoreTrustedIdProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataLakeStoreTrustedIdProviderResource> IAsyncEnumerable<DataLakeStoreTrustedIdProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
