// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a NetworkSecurityGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NetworkSecurityGroupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNetworkSecurityGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetNetworkSecurityGroup method.
    /// </summary>
    public partial class NetworkSecurityGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkSecurityGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="networkSecurityGroupName"> The networkSecurityGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkSecurityGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkSecurityGroupClientDiagnostics;
        private readonly NetworkSecurityGroupsRestOperations _networkSecurityGroupRestClient;
        private readonly NetworkSecurityGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroupResource"/> class for mocking. </summary>
        protected NetworkSecurityGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkSecurityGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkSecurityGroupResource(ArmClient client, NetworkSecurityGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkSecurityGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string networkSecurityGroupApiVersion);
            _networkSecurityGroupRestClient = new NetworkSecurityGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkSecurityGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkSecurityGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkSecurityGroupData Data
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

        /// <summary> Gets a collection of SecurityRuleResources in the NetworkSecurityGroup. </summary>
        /// <returns> An object representing collection of SecurityRuleResources and their operations over a SecurityRuleResource. </returns>
        public virtual SecurityRuleCollection GetSecurityRules()
        {
            return GetCachedClient(Client => new SecurityRuleCollection(Client, Id));
        }

        /// <summary>
        /// Get the specified network security rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SecurityRuleResource>> GetSecurityRuleAsync(string securityRuleName, CancellationToken cancellationToken = default)
        {
            return await GetSecurityRules().GetAsync(securityRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified network security rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SecurityRuleResource> GetSecurityRule(string securityRuleName, CancellationToken cancellationToken = default)
        {
            return GetSecurityRules().Get(securityRuleName, cancellationToken);
        }

        /// <summary> Gets a collection of DefaultSecurityRuleResources in the NetworkSecurityGroup. </summary>
        /// <returns> An object representing collection of DefaultSecurityRuleResources and their operations over a DefaultSecurityRuleResource. </returns>
        public virtual DefaultSecurityRuleCollection GetDefaultSecurityRules()
        {
            return GetCachedClient(Client => new DefaultSecurityRuleCollection(Client, Id));
        }

        /// <summary>
        /// Get the specified default network security rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules/{defaultSecurityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultSecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultSecurityRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DefaultSecurityRuleResource>> GetDefaultSecurityRuleAsync(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            return await GetDefaultSecurityRules().GetAsync(defaultSecurityRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified default network security rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules/{defaultSecurityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultSecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultSecurityRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<DefaultSecurityRuleResource> GetDefaultSecurityRule(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            return GetDefaultSecurityRules().Get(defaultSecurityRuleName, cancellationToken);
        }

        /// <summary>
        /// Gets the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkSecurityGroupResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkSecurityGroupResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a network security group tags.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_UpdateTags</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTagsObject"> Parameters supplied to update network security group tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTagsObject"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityGroupResource>> UpdateAsync(NetworkTagsObject networkTagsObject, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(networkTagsObject, nameof(networkTagsObject));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkTagsObject, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a network security group tags.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_UpdateTags</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTagsObject"> Parameters supplied to update network security group tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTagsObject"/> is null. </exception>
        public virtual Response<NetworkSecurityGroupResource> Update(NetworkTagsObject networkTagsObject, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(networkTagsObject, nameof(networkTagsObject));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.Update");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkTagsObject, cancellationToken);
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityGroupResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new NetworkSecurityGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new NetworkTagsObject();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<NetworkSecurityGroupResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                    return Response.FromValue(new NetworkSecurityGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new NetworkTagsObject();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityGroupResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new NetworkSecurityGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new NetworkTagsObject();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<NetworkSecurityGroupResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                    return Response.FromValue(new NetworkSecurityGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new NetworkTagsObject();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityGroupResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new NetworkSecurityGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new NetworkTagsObject();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<NetworkSecurityGroupResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                    return Response.FromValue(new NetworkSecurityGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new NetworkTagsObject();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
