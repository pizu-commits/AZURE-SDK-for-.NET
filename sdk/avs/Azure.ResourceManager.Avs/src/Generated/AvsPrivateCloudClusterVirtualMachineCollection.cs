// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="AvsPrivateCloudClusterVirtualMachineResource" /> and their operations.
    /// Each <see cref="AvsPrivateCloudClusterVirtualMachineResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudClusterResource" />.
    /// To get an <see cref="AvsPrivateCloudClusterVirtualMachineCollection" /> instance call the GetAvsPrivateCloudClusterVirtualMachines method from an instance of <see cref="AvsPrivateCloudClusterResource" />.
    /// </summary>
    public partial class AvsPrivateCloudClusterVirtualMachineCollection : ArmCollection, IEnumerable<AvsPrivateCloudClusterVirtualMachineResource>, IAsyncEnumerable<AvsPrivateCloudClusterVirtualMachineResource>
    {
        private readonly ClientDiagnostics _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics;
        private readonly VirtualMachinesRestOperations _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudClusterVirtualMachineCollection"/> class for mocking. </summary>
        protected AvsPrivateCloudClusterVirtualMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudClusterVirtualMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AvsPrivateCloudClusterVirtualMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", AvsPrivateCloudClusterVirtualMachineResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AvsPrivateCloudClusterVirtualMachineResource.ResourceType, out string avsPrivateCloudClusterVirtualMachineVirtualMachinesApiVersion);
            _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient = new VirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, avsPrivateCloudClusterVirtualMachineVirtualMachinesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudClusterResource.ResourceType), nameof(id));
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
        public virtual async Task<Response<AvsPrivateCloudClusterVirtualMachineResource>> GetAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, virtualMachineId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudClusterVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        public virtual Response<AvsPrivateCloudClusterVirtualMachineResource> Get(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, virtualMachineId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudClusterVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of virtual machines in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvsPrivateCloudClusterVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvsPrivateCloudClusterVirtualMachineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudClusterVirtualMachineResource(Client, AvsPrivateCloudClusterVirtualMachineData.DeserializeAvsPrivateCloudClusterVirtualMachineData(e)), _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, "AvsPrivateCloudClusterVirtualMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtual machines in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvsPrivateCloudClusterVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvsPrivateCloudClusterVirtualMachineResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudClusterVirtualMachineResource(Client, AvsPrivateCloudClusterVirtualMachineData.DeserializeAvsPrivateCloudClusterVirtualMachineData(e)), _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, "AvsPrivateCloudClusterVirtualMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        public virtual async Task<Response<bool>> ExistsAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, virtualMachineId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        public virtual Response<bool> Exists(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, virtualMachineId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AvsPrivateCloudClusterVirtualMachineResource> IEnumerable<AvsPrivateCloudClusterVirtualMachineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AvsPrivateCloudClusterVirtualMachineResource> IAsyncEnumerable<AvsPrivateCloudClusterVirtualMachineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
