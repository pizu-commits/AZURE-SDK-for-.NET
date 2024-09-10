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
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a BillingProfileCustomerPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BillingProfileCustomerPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBillingProfileCustomerPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="BillingProfileCustomerResource"/> using the GetBillingProfileCustomerPolicy method.
    /// </summary>
    public partial class BillingProfileCustomerPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingProfileCustomerPolicyResource"/> instance. </summary>
        /// <param name="billingAccountName"> The billingAccountName. </param>
        /// <param name="billingProfileName"> The billingProfileName. </param>
        /// <param name="customerName"> The customerName. </param>
        /// <param name="policyName"> The policyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string customerName, ServiceDefinedResourceName policyName)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/customers/{customerName}/policies/{policyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingProfileCustomerPolicyPoliciesClientDiagnostics;
        private readonly PoliciesRestOperations _billingProfileCustomerPolicyPoliciesRestClient;
        private readonly BillingCustomerPolicyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/billingProfiles/customers/policies";

        /// <summary> Initializes a new instance of the <see cref="BillingProfileCustomerPolicyResource"/> class for mocking. </summary>
        protected BillingProfileCustomerPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingProfileCustomerPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingProfileCustomerPolicyResource(ArmClient client, BillingCustomerPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingProfileCustomerPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingProfileCustomerPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingProfileCustomerPolicyPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingProfileCustomerPolicyPoliciesApiVersion);
            _billingProfileCustomerPolicyPoliciesRestClient = new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingProfileCustomerPolicyPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingCustomerPolicyData Data
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
        /// Lists the policies for a customer. This operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/customers/{customerName}/policies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_GetByCustomer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileCustomerPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingProfileCustomerPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _billingProfileCustomerPolicyPoliciesClientDiagnostics.CreateScope("BillingProfileCustomerPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _billingProfileCustomerPolicyPoliciesRestClient.GetByCustomerAsync(Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingProfileCustomerPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the policies for a customer. This operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/customers/{customerName}/policies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_GetByCustomer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileCustomerPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingProfileCustomerPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _billingProfileCustomerPolicyPoliciesClientDiagnostics.CreateScope("BillingProfileCustomerPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _billingProfileCustomerPolicyPoliciesRestClient.GetByCustomer(Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingProfileCustomerPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
