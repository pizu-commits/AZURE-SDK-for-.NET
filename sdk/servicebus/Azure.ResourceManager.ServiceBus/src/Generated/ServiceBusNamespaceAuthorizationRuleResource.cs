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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A Class representing a ServiceBusNamespaceAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServiceBusNamespaceAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServiceBusNamespaceAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusNamespaceResource" /> using the GetServiceBusNamespaceAuthorizationRule method.
    /// </summary>
    public partial class ServiceBusNamespaceAuthorizationRuleResource : ServiceBusAuthorizationRuleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceBusNamespaceAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics;
        private readonly NamespaceAuthorizationRulesRestOperations _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespaceAuthorizationRuleResource"/> class for mocking. </summary>
        protected ServiceBusNamespaceAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceBusNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceBusNamespaceAuthorizationRuleResource(ArmClient client, ServiceBusAuthorizationRuleData data) : base(client, data)
        {
            _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesApiVersion);
            _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient = new NamespaceAuthorizationRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusNamespaceAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesApiVersion);
            _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient = new NamespaceAuthorizationRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/AuthorizationRules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ServiceBusAuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ServiceBusNamespaceAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ServiceBusNamespaceAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ServiceBusAuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ServiceBusNamespaceAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ServiceBusNamespaceAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Deletes a namespace authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(response);
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
        /// Deletes a namespace authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(response);
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
        /// Creates or updates an authorization rule for a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusNamespaceAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusNamespaceAuthorizationRuleResource>(Response.FromValue(new ServiceBusNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an authorization rule for a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NamespaceAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusNamespaceAuthorizationRuleResource> Update(WaitUntil waitUntil, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusNamespaceAuthorizationRuleResource>(Response.FromValue(new ServiceBusNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets the primary and secondary connection strings for the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: NamespaceAuthorizationRules_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ServiceBusAccessKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the primary and secondary connection strings for the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: NamespaceAuthorizationRules_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ServiceBusAccessKeys> GetKeysCore(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings for the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: NamespaceAuthorizationRules_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ServiceBusAccessKeys>> RegenerateKeysAsync(ServiceBusRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings for the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: NamespaceAuthorizationRules_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ServiceBusAccessKeys> RegenerateKeys(ServiceBusRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusNamespaceAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceAuthorizationRuleNamespaceAuthorizationRulesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
