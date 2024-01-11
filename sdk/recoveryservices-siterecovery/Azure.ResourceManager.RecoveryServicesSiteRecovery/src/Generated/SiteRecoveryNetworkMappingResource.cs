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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a SiteRecoveryNetworkMapping along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteRecoveryNetworkMappingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteRecoveryNetworkMappingResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteRecoveryNetworkResource"/> using the GetSiteRecoveryNetworkMapping method.
    /// </summary>
    public partial class SiteRecoveryNetworkMappingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteRecoveryNetworkMappingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="fabricName"> The fabricName. </param>
        /// <param name="networkName"> The networkName. </param>
        /// <param name="networkMappingName"> The networkMappingName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string networkName, string networkMappingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics;
        private readonly ReplicationNetworkMappingsRestOperations _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient;
        private readonly SiteRecoveryNetworkMappingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationFabrics/replicationNetworks/replicationNetworkMappings";

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkMappingResource"/> class for mocking. </summary>
        protected SiteRecoveryNetworkMappingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkMappingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteRecoveryNetworkMappingResource(ArmClient client, SiteRecoveryNetworkMappingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkMappingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteRecoveryNetworkMappingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteRecoveryNetworkMappingReplicationNetworkMappingsApiVersion);
            _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient = new ReplicationNetworkMappingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryNetworkMappingReplicationNetworkMappingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteRecoveryNetworkMappingData Data
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
        /// Gets the details of an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteRecoveryNetworkMappingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingResource.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteRecoveryNetworkMappingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingResource.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete a network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation(_siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to delete a network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingResource.Delete");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation(_siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to update an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Update network mapping input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryNetworkMappingResource>> UpdateAsync(WaitUntil waitUntil, SiteRecoveryNetworkMappingPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingResource.Update");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryNetworkMappingResource>(new SiteRecoveryNetworkMappingOperationSource(Client), _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to update an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Update network mapping input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryNetworkMappingResource> Update(WaitUntil waitUntil, SiteRecoveryNetworkMappingPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingResource.Update");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryNetworkMappingResource>(new SiteRecoveryNetworkMappingOperationSource(Client), _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
