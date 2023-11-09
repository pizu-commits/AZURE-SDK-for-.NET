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
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchAccountResource" /> and their operations.
    /// Each <see cref="BatchAccountResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="BatchAccountCollection" /> instance call the GetBatchAccounts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class BatchAccountCollection : ArmCollection, IEnumerable<BatchAccountResource>, IAsyncEnumerable<BatchAccountResource>
    {
        private readonly ClientDiagnostics _batchAccountClientDiagnostics;
        private readonly BatchAccountRestOperations _batchAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchAccountCollection"/> class for mocking. </summary>
        protected BatchAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", BatchAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchAccountResource.ResourceType, out string batchAccountApiVersion);
            _batchAccountRestClient = new BatchAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchAccountApiVersion);
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
        /// Creates a new Batch account with the specified parameters. Existing accounts cannot be updated with this API and should instead be updated with the Update Batch Account API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> A name for the Batch account which must be unique within the region. Batch account names must be between 3 and 24 characters in length and must use only numbers and lowercase letters. This name is used as part of the DNS name that is used to access the Batch service in the region in which the account is created. For example: http://accountname.region.batch.azure.com/. </param>
        /// <param name="content"> Additional parameters for account creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<BatchAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, BatchAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _batchAccountRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken).ConfigureAwait(false);
                var operation = new BatchArmOperation<BatchAccountResource>(new BatchAccountOperationSource(Client), _batchAccountClientDiagnostics, Pipeline, _batchAccountRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new Batch account with the specified parameters. Existing accounts cannot be updated with this API and should instead be updated with the Update Batch Account API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> A name for the Batch account which must be unique within the region. Batch account names must be between 3 and 24 characters in length and must use only numbers and lowercase letters. This name is used as part of the DNS name that is used to access the Batch service in the region in which the account is created. For example: http://accountname.region.batch.azure.com/. </param>
        /// <param name="content"> Additional parameters for account creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<BatchAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, BatchAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _batchAccountRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken);
                var operation = new BatchArmOperation<BatchAccountResource>(new BatchAccountOperationSource(Client), _batchAccountClientDiagnostics, Pipeline, _batchAccountRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about the specified Batch account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<BatchAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified Batch account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<BatchAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _batchAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the Batch accounts associated with the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new BatchAccountResource(Client, BatchAccountData.DeserializeBatchAccountData(e)), _batchAccountClientDiagnostics, Pipeline, "BatchAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about the Batch accounts associated with the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new BatchAccountResource(Client, BatchAccountData.DeserializeBatchAccountData(e)), _batchAccountClientDiagnostics, Pipeline, "BatchAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NullableResponse<BatchAccountResource>> GetIfExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _batchAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BatchAccountResource>(response.GetRawResponse());
                return Response.FromValue(new BatchAccountResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual NullableResponse<BatchAccountResource> GetIfExists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _batchAccountClientDiagnostics.CreateScope("BatchAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _batchAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BatchAccountResource>(response.GetRawResponse());
                return Response.FromValue(new BatchAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchAccountResource> IEnumerable<BatchAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchAccountResource> IAsyncEnumerable<BatchAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
