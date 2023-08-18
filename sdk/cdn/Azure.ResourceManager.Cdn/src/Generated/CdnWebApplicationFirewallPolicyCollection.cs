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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="CdnWebApplicationFirewallPolicyResource" /> and their operations.
    /// Each <see cref="CdnWebApplicationFirewallPolicyResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CdnWebApplicationFirewallPolicyCollection" /> instance call the GetCdnWebApplicationFirewallPolicies method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CdnWebApplicationFirewallPolicyCollection : ArmCollection, IEnumerable<CdnWebApplicationFirewallPolicyResource>, IAsyncEnumerable<CdnWebApplicationFirewallPolicyResource>
    {
        private readonly ClientDiagnostics _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics;
        private readonly PoliciesRestOperations _cdnWebApplicationFirewallPolicyPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnWebApplicationFirewallPolicyCollection"/> class for mocking. </summary>
        protected CdnWebApplicationFirewallPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CdnWebApplicationFirewallPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CdnWebApplicationFirewallPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", CdnWebApplicationFirewallPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CdnWebApplicationFirewallPolicyResource.ResourceType, out string cdnWebApplicationFirewallPolicyPoliciesApiVersion);
            _cdnWebApplicationFirewallPolicyPoliciesRestClient = new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cdnWebApplicationFirewallPolicyPoliciesApiVersion);
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
        /// Create or update policy with specified rule set name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="data"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CdnWebApplicationFirewallPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyName, CdnWebApplicationFirewallPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<CdnWebApplicationFirewallPolicyResource>(new CdnWebApplicationFirewallPolicyOperationSource(Client), _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, policyName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create or update policy with specified rule set name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="data"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CdnWebApplicationFirewallPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string policyName, CdnWebApplicationFirewallPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, policyName, data, cancellationToken);
                var operation = new CdnArmOperation<CdnWebApplicationFirewallPolicyResource>(new CdnWebApplicationFirewallPolicyOperationSource(Client), _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, policyName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<CdnWebApplicationFirewallPolicyResource>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<CdnWebApplicationFirewallPolicyResource> Get(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the protection policies within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnWebApplicationFirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnWebApplicationFirewallPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CdnWebApplicationFirewallPolicyResource(Client, CdnWebApplicationFirewallPolicyData.DeserializeCdnWebApplicationFirewallPolicyData(e)), _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, "CdnWebApplicationFirewallPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the protection policies within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnWebApplicationFirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnWebApplicationFirewallPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CdnWebApplicationFirewallPolicyResource(Client, CdnWebApplicationFirewallPolicyData.DeserializeCdnWebApplicationFirewallPolicyData(e)), _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, "CdnWebApplicationFirewallPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CdnWebApplicationFirewallPolicyResource> IEnumerable<CdnWebApplicationFirewallPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnWebApplicationFirewallPolicyResource> IAsyncEnumerable<CdnWebApplicationFirewallPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
