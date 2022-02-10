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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of InboundNatRule and their operations over its parent. </summary>
    public partial class InboundNatRuleCollection : ArmCollection, IEnumerable<InboundNatRule>, IAsyncEnumerable<InboundNatRule>
    {
        private readonly ClientDiagnostics _inboundNatRuleClientDiagnostics;
        private readonly InboundNatRulesRestOperations _inboundNatRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="InboundNatRuleCollection"/> class for mocking. </summary>
        protected InboundNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InboundNatRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal InboundNatRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _inboundNatRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", InboundNatRule.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(InboundNatRule.ResourceType, out string inboundNatRuleApiVersion);
            _inboundNatRuleRestClient = new InboundNatRulesRestOperations(_inboundNatRuleClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, inboundNatRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancer.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a load balancer inbound nat rule. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="inboundNatRuleParameters"> Parameters supplied to the create or update inbound nat rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> or <paramref name="inboundNatRuleParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<InboundNatRule>> CreateOrUpdateAsync(bool waitForCompletion, string inboundNatRuleName, InboundNatRuleData inboundNatRuleParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));
            if (inboundNatRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleParameters));
            }

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _inboundNatRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<InboundNatRule>(new InboundNatRuleOperationSource(Client), _inboundNatRuleClientDiagnostics, Pipeline, _inboundNatRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a load balancer inbound nat rule. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="inboundNatRuleParameters"> Parameters supplied to the create or update inbound nat rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> or <paramref name="inboundNatRuleParameters"/> is null. </exception>
        public virtual ArmOperation<InboundNatRule> CreateOrUpdate(bool waitForCompletion, string inboundNatRuleName, InboundNatRuleData inboundNatRuleParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));
            if (inboundNatRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleParameters));
            }

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _inboundNatRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters, cancellationToken);
                var operation = new NetworkArmOperation<InboundNatRule>(new InboundNatRuleOperationSource(Client), _inboundNatRuleClientDiagnostics, Pipeline, _inboundNatRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer inbound nat rule. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public async virtual Task<Response<InboundNatRule>> GetAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _inboundNatRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _inboundNatRuleClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new InboundNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer inbound nat rule. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<InboundNatRule> Get(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _inboundNatRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken);
                if (response.Value == null)
                    throw _inboundNatRuleClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InboundNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InboundNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InboundNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<InboundNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inboundNatRuleRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InboundNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inboundNatRuleRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InboundNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InboundNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<InboundNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inboundNatRuleRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InboundNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inboundNatRuleRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(inboundNatRuleName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(inboundNatRuleName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public async virtual Task<Response<InboundNatRule>> GetIfExistsAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _inboundNatRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<InboundNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new InboundNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<InboundNatRule> GetIfExists(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _inboundNatRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<InboundNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new InboundNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InboundNatRule> IEnumerable<InboundNatRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InboundNatRule> IAsyncEnumerable<InboundNatRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
