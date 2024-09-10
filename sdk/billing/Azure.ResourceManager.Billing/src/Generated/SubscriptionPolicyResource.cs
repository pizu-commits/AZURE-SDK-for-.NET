// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a SubscriptionPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SubscriptionPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSubscriptionPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSubscriptionPolicy method.
    /// </summary>
    public partial class SubscriptionPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionPolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Billing/policies/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionPolicyPoliciesClientDiagnostics;
        private readonly PoliciesRestOperations _subscriptionPolicyPoliciesRestClient;
        private readonly SubscriptionPolicyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/policies";

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicyResource"/> class for mocking. </summary>
        protected SubscriptionPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionPolicyResource(ArmClient client, SubscriptionPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionPolicyPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionPolicyPoliciesApiVersion);
            _subscriptionPolicyPoliciesRestClient = new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionPolicyPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubscriptionPolicyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Lists the policies that are managed by the Billing Admin for the defined subscriptions. This is supported for Microsoft Online Services Program, Microsoft Customer Agreement and Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Billing/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_GetBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicyPoliciesClientDiagnostics.CreateScope("SubscriptionPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicyPoliciesRestClient.GetBySubscriptionAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the policies that are managed by the Billing Admin for the defined subscriptions. This is supported for Microsoft Online Services Program, Microsoft Customer Agreement and Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Billing/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_GetBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicyPoliciesClientDiagnostics.CreateScope("SubscriptionPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionPolicyPoliciesRestClient.GetBySubscription(Id.SubscriptionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
