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

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingSubscriptionAliasResource" /> and their operations.
    /// Each <see cref="BillingSubscriptionAliasResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="BillingSubscriptionAliasCollection" /> instance call the GetBillingSubscriptionAliases method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class BillingSubscriptionAliasCollection : ArmCollection, IEnumerable<BillingSubscriptionAliasResource>, IAsyncEnumerable<BillingSubscriptionAliasResource>
    {
        private readonly ClientDiagnostics _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics;
        private readonly BillingSubscriptionsAliasesRestOperations _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient;
        private readonly string _billingAccountName;

        /// <summary> Initializes a new instance of the <see cref="BillingSubscriptionAliasCollection"/> class for mocking. </summary>
        protected BillingSubscriptionAliasCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingSubscriptionAliasCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        internal BillingSubscriptionAliasCollection(ArmClient client, ResourceIdentifier id, string billingAccountName) : base(client, id)
        {
            _billingAccountName = billingAccountName;
            _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingSubscriptionAliasResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingSubscriptionAliasResource.ResourceType, out string billingSubscriptionAliasBillingSubscriptionsAliasesApiVersion);
            _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient = new BillingSubscriptionsAliasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingSubscriptionAliasBillingSubscriptionsAliasesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a billing subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="data"> New or updated billing subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BillingSubscriptionAliasResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string aliasName, BillingSubscriptionAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateOrUpdateAsync(_billingAccountName, aliasName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation<BillingSubscriptionAliasResource>(new BillingSubscriptionAliasOperationSource(Client), _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics, Pipeline, _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateCreateOrUpdateRequest(_billingAccountName, aliasName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates or updates a billing subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="data"> New or updated billing subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BillingSubscriptionAliasResource> CreateOrUpdate(WaitUntil waitUntil, string aliasName, BillingSubscriptionAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateOrUpdate(_billingAccountName, aliasName, data, cancellationToken);
                var operation = new BillingArmOperation<BillingSubscriptionAliasResource>(new BillingSubscriptionAliasOperationSource(Client), _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics, Pipeline, _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateCreateOrUpdateRequest(_billingAccountName, aliasName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual async Task<Response<BillingSubscriptionAliasResource>> GetAsync(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.GetAsync(_billingAccountName, aliasName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual Response<BillingSubscriptionAliasResource> Get(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasCollection.Get");
            scope.Start();
            try
            {
                var response = _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.Get(_billingAccountName, aliasName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the subscription aliases for a billing account. The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_ListByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingSubscriptionAliasResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingSubscriptionAliasResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateListByBillingAccountRequest(_billingAccountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateListByBillingAccountNextPageRequest(nextLink, _billingAccountName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingSubscriptionAliasResource(Client, BillingSubscriptionAliasData.DeserializeBillingSubscriptionAliasData(e)), _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics, Pipeline, "BillingSubscriptionAliasCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the subscription aliases for a billing account. The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_ListByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingSubscriptionAliasResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingSubscriptionAliasResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateListByBillingAccountRequest(_billingAccountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.CreateListByBillingAccountNextPageRequest(nextLink, _billingAccountName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingSubscriptionAliasResource(Client, BillingSubscriptionAliasData.DeserializeBillingSubscriptionAliasData(e)), _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics, Pipeline, "BillingSubscriptionAliasCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.GetAsync(_billingAccountName, aliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> is null. </exception>
        public virtual Response<bool> Exists(string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aliasName, nameof(aliasName));

            using var scope = _billingSubscriptionAliasBillingSubscriptionsAliasesClientDiagnostics.CreateScope("BillingSubscriptionAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingSubscriptionAliasBillingSubscriptionsAliasesRestClient.Get(_billingAccountName, aliasName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingSubscriptionAliasResource> IEnumerable<BillingSubscriptionAliasResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingSubscriptionAliasResource> IAsyncEnumerable<BillingSubscriptionAliasResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
