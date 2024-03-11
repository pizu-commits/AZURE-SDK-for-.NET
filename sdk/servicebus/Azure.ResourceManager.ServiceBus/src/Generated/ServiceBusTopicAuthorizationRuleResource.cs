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
    /// A Class representing a ServiceBusTopicAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServiceBusTopicAuthorizationRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServiceBusTopicAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusTopicResource"/> using the GetServiceBusTopicAuthorizationRule method.
    /// </summary>
    public partial class ServiceBusTopicAuthorizationRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceBusTopicAuthorizationRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="namespaceName"> The namespaceName. </param>
        /// <param name="topicName"> The topicName. </param>
        /// <param name="authorizationRuleName"> The authorizationRuleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics;
        private readonly TopicAuthorizationRulesRestOperations _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient;
        private readonly ServiceBusAuthorizationRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/topics/authorizationRules";

        /// <summary> Initializes a new instance of the <see cref="ServiceBusTopicAuthorizationRuleResource"/> class for mocking. </summary>
        protected ServiceBusTopicAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusTopicAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceBusTopicAuthorizationRuleResource(ArmClient client, ServiceBusAuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusTopicAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusTopicAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceBusTopicAuthorizationRuleTopicAuthorizationRulesApiVersion);
            _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient = new TopicAuthorizationRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusTopicAuthorizationRuleTopicAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusAuthorizationRuleData Data
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
        /// Returns the specified authorization rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceBusTopicAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the specified authorization rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusTopicAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a topic authorization rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Deletes a topic authorization rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Creates an authorization rule for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusTopicAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusTopicAuthorizationRuleResource>(Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates an authorization rule for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusTopicAuthorizationRuleResource> Update(WaitUntil waitUntil, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusTopicAuthorizationRuleResource>(Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets the primary and secondary connection strings for the topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}/ListKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_ListKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceBusAccessKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the primary and secondary connection strings for the topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}/ListKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_ListKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusAccessKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates primary or secondary connection strings for the topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}/regenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_RegenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ServiceBusAccessKeys>> RegenerateKeysAsync(ServiceBusRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates primary or secondary connection strings for the topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}/regenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_RegenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ServiceBusAccessKeys> RegenerateKeys(ServiceBusRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
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
