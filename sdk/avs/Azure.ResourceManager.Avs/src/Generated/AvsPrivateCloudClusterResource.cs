// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A Class representing an AvsPrivateCloudCluster along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AvsPrivateCloudClusterResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAvsPrivateCloudClusterResource method.
    /// Otherwise you can get one from its parent resource <see cref="AvsPrivateCloudResource" /> using the GetAvsPrivateCloudCluster method.
    /// </summary>
    public partial class AvsPrivateCloudClusterResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AvsPrivateCloudClusterResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _avsPrivateCloudClusterClustersClientDiagnostics;
        private readonly ClustersRestOperations _avsPrivateCloudClusterClustersRestClient;
        private readonly AvsPrivateCloudClusterData _data;

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudClusterResource"/> class for mocking. </summary>
        protected AvsPrivateCloudClusterResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AvsPrivateCloudClusterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AvsPrivateCloudClusterResource(ArmClient client, AvsPrivateCloudClusterData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudClusterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AvsPrivateCloudClusterResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _avsPrivateCloudClusterClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string avsPrivateCloudClusterClustersApiVersion);
            _avsPrivateCloudClusterClustersRestClient = new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, avsPrivateCloudClusterClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AVS/privateClouds/clusters";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AvsPrivateCloudClusterData Data
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

        /// <summary> Gets a collection of AvsPrivateCloudDatastoreResources in the AvsPrivateCloudCluster. </summary>
        /// <returns> An object representing collection of AvsPrivateCloudDatastoreResources and their operations over a AvsPrivateCloudDatastoreResource. </returns>
        public virtual AvsPrivateCloudDatastoreCollection GetAvsPrivateCloudDatastores()
        {
            return GetCachedClient(Client => new AvsPrivateCloudDatastoreCollection(Client, Id));
        }

        /// <summary>
        /// Get a datastore in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AvsPrivateCloudDatastoreResource>> GetAvsPrivateCloudDatastoreAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            return await GetAvsPrivateCloudDatastores().GetAsync(datastoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a datastore in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<AvsPrivateCloudDatastoreResource> GetAvsPrivateCloudDatastore(string datastoreName, CancellationToken cancellationToken = default)
        {
            return GetAvsPrivateCloudDatastores().Get(datastoreName, cancellationToken);
        }

        /// <summary> Gets a collection of AvsPrivateCloudClusterVirtualMachineResources in the AvsPrivateCloudCluster. </summary>
        /// <returns> An object representing collection of AvsPrivateCloudClusterVirtualMachineResources and their operations over a AvsPrivateCloudClusterVirtualMachineResource. </returns>
        public virtual AvsPrivateCloudClusterVirtualMachineCollection GetAvsPrivateCloudClusterVirtualMachines()
        {
            return GetCachedClient(Client => new AvsPrivateCloudClusterVirtualMachineCollection(Client, Id));
        }

        /// <summary>
        /// Get a virtual machine by id in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AvsPrivateCloudClusterVirtualMachineResource>> GetAvsPrivateCloudClusterVirtualMachineAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            return await GetAvsPrivateCloudClusterVirtualMachines().GetAsync(virtualMachineId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a virtual machine by id in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<AvsPrivateCloudClusterVirtualMachineResource> GetAvsPrivateCloudClusterVirtualMachine(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            return GetAvsPrivateCloudClusterVirtualMachines().Get(virtualMachineId, cancellationToken);
        }

        /// <summary> Gets a collection of PlacementPolicyResources in the AvsPrivateCloudCluster. </summary>
        /// <returns> An object representing collection of PlacementPolicyResources and their operations over a PlacementPolicyResource. </returns>
        public virtual PlacementPolicyCollection GetPlacementPolicies()
        {
            return GetCachedClient(Client => new PlacementPolicyCollection(Client, Id));
        }

        /// <summary>
        /// Get a placement policy by name in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PlacementPolicyResource>> GetPlacementPolicyAsync(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            return await GetPlacementPolicies().GetAsync(placementPolicyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a placement policy by name in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<PlacementPolicyResource> GetPlacementPolicy(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            return GetPlacementPolicies().Get(placementPolicyName, cancellationToken);
        }

        /// <summary>
        /// Get a cluster by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AvsPrivateCloudClusterResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _avsPrivateCloudClusterClustersClientDiagnostics.CreateScope("AvsPrivateCloudClusterResource.Get");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a cluster by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AvsPrivateCloudClusterResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _avsPrivateCloudClusterClustersClientDiagnostics.CreateScope("AvsPrivateCloudClusterResource.Get");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a cluster in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _avsPrivateCloudClusterClustersClientDiagnostics.CreateScope("AvsPrivateCloudClusterResource.Delete");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudClusterClustersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation(_avsPrivateCloudClusterClustersClientDiagnostics, Pipeline, _avsPrivateCloudClusterClustersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a cluster in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _avsPrivateCloudClusterClustersClientDiagnostics.CreateScope("AvsPrivateCloudClusterResource.Delete");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudClusterClustersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AvsArmOperation(_avsPrivateCloudClusterClustersClientDiagnostics, Pipeline, _avsPrivateCloudClusterClustersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Update a cluster in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The cluster properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<AvsPrivateCloudClusterResource>> UpdateAsync(WaitUntil waitUntil, AvsPrivateCloudClusterPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _avsPrivateCloudClusterClustersClientDiagnostics.CreateScope("AvsPrivateCloudClusterResource.Update");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudClusterClustersRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<AvsPrivateCloudClusterResource>(new AvsPrivateCloudClusterOperationSource(Client), _avsPrivateCloudClusterClustersClientDiagnostics, Pipeline, _avsPrivateCloudClusterClustersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update a cluster in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The cluster properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<AvsPrivateCloudClusterResource> Update(WaitUntil waitUntil, AvsPrivateCloudClusterPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _avsPrivateCloudClusterClustersClientDiagnostics.CreateScope("AvsPrivateCloudClusterResource.Update");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudClusterClustersRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new AvsArmOperation<AvsPrivateCloudClusterResource>(new AvsPrivateCloudClusterOperationSource(Client), _avsPrivateCloudClusterClustersClientDiagnostics, Pipeline, _avsPrivateCloudClusterClustersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// List hosts by zone in a cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/listZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListZones</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvsClusterZone" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvsClusterZone> GetZonesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudClusterClustersRestClient.CreateListZonesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, AvsClusterZone.DeserializeAvsClusterZone, _avsPrivateCloudClusterClustersClientDiagnostics, Pipeline, "AvsPrivateCloudClusterResource.GetZones", "zones", null, cancellationToken);
        }

        /// <summary>
        /// List hosts by zone in a cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/listZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListZones</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvsClusterZone" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvsClusterZone> GetZones(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudClusterClustersRestClient.CreateListZonesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, AvsClusterZone.DeserializeAvsClusterZone, _avsPrivateCloudClusterClustersClientDiagnostics, Pipeline, "AvsPrivateCloudClusterResource.GetZones", "zones", null, cancellationToken);
        }
    }
}
