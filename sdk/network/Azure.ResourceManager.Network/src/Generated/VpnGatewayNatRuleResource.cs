// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a VpnGatewayNatRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="VpnGatewayNatRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetVpnGatewayNatRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="VpnGatewayResource" /> using the GetVpnGatewayNatRule method.
    /// </summary>
    public partial class VpnGatewayNatRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VpnGatewayNatRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string gatewayName, string natRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _vpnGatewayNatRuleNatRulesClientDiagnostics;
        private readonly NatRulesRestOperations _vpnGatewayNatRuleNatRulesRestClient;
        private readonly VpnGatewayNatRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleResource"/> class for mocking. </summary>
        protected VpnGatewayNatRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VpnGatewayNatRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VpnGatewayNatRuleResource(ArmClient client, VpnGatewayNatRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnGatewayNatRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnGatewayNatRuleNatRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string vpnGatewayNatRuleNatRulesApiVersion);
            _vpnGatewayNatRuleNatRulesRestClient = new NatRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnGatewayNatRuleNatRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/vpnGateways/natRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VpnGatewayNatRuleData Data
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
        /// Retrieves the details of a nat ruleGet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnGatewayNatRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a nat ruleGet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnGatewayNatRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleResource.Get");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a nat rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a nat rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VpnGatewayNatRuleResource>> UpdateAsync(WaitUntil waitUntil, VpnGatewayNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnGatewayNatRuleResource>(new VpnGatewayNatRuleOperationSource(Client), _vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VpnGatewayNatRuleResource> Update(WaitUntil waitUntil, VpnGatewayNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleResource.Update");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NetworkArmOperation<VpnGatewayNatRuleResource>(new VpnGatewayNatRuleOperationSource(Client), _vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
