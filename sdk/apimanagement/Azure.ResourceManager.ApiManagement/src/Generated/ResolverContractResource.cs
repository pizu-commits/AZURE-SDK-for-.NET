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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing a ResolverContract along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ResolverContractResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetResolverContractResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiResource"/> using the GetResolverContract method.
    /// </summary>
    public partial class ResolverContractResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResolverContractResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="apiId"> The apiId. </param>
        /// <param name="resolverId"> The resolverId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string resolverId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resolverContractGraphQLApiResolverClientDiagnostics;
        private readonly GraphQLApiResolverRestOperations _resolverContractGraphQLApiResolverRestClient;
        private readonly ResolverContractData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/apis/resolvers";

        /// <summary> Initializes a new instance of the <see cref="ResolverContractResource"/> class for mocking. </summary>
        protected ResolverContractResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResolverContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResolverContractResource(ArmClient client, ResolverContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResolverContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResolverContractResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resolverContractGraphQLApiResolverClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resolverContractGraphQLApiResolverApiVersion);
            _resolverContractGraphQLApiResolverRestClient = new GraphQLApiResolverRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resolverContractGraphQLApiResolverApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResolverContractData Data
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

        /// <summary> Gets a collection of ServiceApiResolverPolicyResources in the ResolverContract. </summary>
        /// <returns> An object representing collection of ServiceApiResolverPolicyResources and their operations over a ServiceApiResolverPolicyResource. </returns>
        public virtual ServiceApiResolverPolicyCollection GetServiceApiResolverPolicies()
        {
            return GetCachedClient(client => new ServiceApiResolverPolicyCollection(client, Id));
        }

        /// <summary>
        /// Get the policy configuration at the GraphQL API Resolver level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolverPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceApiResolverPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceApiResolverPolicyResource>> GetServiceApiResolverPolicyAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            return await GetServiceApiResolverPolicies().GetAsync(policyId, format, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the policy configuration at the GraphQL API Resolver level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolverPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceApiResolverPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ServiceApiResolverPolicyResource> GetServiceApiResolverPolicy(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            return GetServiceApiResolverPolicies().Get(policyId, format, cancellationToken);
        }

        /// <summary>
        /// Gets the details of the GraphQL API Resolver specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResolverContractResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.Get");
            scope.Start();
            try
            {
                var response = await _resolverContractGraphQLApiResolverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResolverContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the GraphQL API Resolver specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResolverContractResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.Get");
            scope.Start();
            try
            {
                var response = _resolverContractGraphQLApiResolverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResolverContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified resolver in the GraphQL API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.Delete");
            scope.Start();
            try
            {
                var response = await _resolverContractGraphQLApiResolverRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _resolverContractGraphQLApiResolverRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation(response, rehydrationToken);
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
        /// Deletes the specified resolver in the GraphQL API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.Delete");
            scope.Start();
            try
            {
                var response = _resolverContractGraphQLApiResolverRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var uri = _resolverContractGraphQLApiResolverRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation(response, rehydrationToken);
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
        /// Updates the details of the resolver in the GraphQL API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> GraphQL API Resolver Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<ResolverContractResource>> UpdateAsync(ETag ifMatch, ResolverContractPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.Update");
            scope.Start();
            try
            {
                var response = await _resolverContractGraphQLApiResolverRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResolverContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the details of the resolver in the GraphQL API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> GraphQL API Resolver Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<ResolverContractResource> Update(ETag ifMatch, ResolverContractPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.Update");
            scope.Start();
            try
            {
                var response = _resolverContractGraphQLApiResolverRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken);
                return Response.FromValue(new ResolverContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the GraphQL API resolver specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_GetEntityTag</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _resolverContractGraphQLApiResolverRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the GraphQL API resolver specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/resolvers/{resolverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GraphQLApiResolver_GetEntityTag</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResolverContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _resolverContractGraphQLApiResolverClientDiagnostics.CreateScope("ResolverContractResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _resolverContractGraphQLApiResolverRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
