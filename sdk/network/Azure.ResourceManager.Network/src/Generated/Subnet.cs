// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a Subnet along with the instance operations that can be performed on it. </summary>
    public partial class Subnet : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubnetsRestOperations _restClient;
        private readonly SubnetData _data;
        private ResourceNavigationLinksRestOperations _resourceNavigationLinksRestClient { get; }
        private ServiceAssociationLinksRestOperations _serviceAssociationLinksRestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="Subnet"/> class for mocking. </summary>
        protected Subnet()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Subnet"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal Subnet(ArmResource options, SubnetData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SubnetsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _resourceNavigationLinksRestClient = new ResourceNavigationLinksRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _serviceAssociationLinksRestClient = new ServiceAssociationLinksRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="Subnet"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Subnet(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SubnetsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _resourceNavigationLinksRestClient = new ResourceNavigationLinksRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _serviceAssociationLinksRestClient = new ServiceAssociationLinksRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualNetworks/subnets";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubnetData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the specified subnet by virtual network and resource group. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Subnet>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Subnet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified subnet by virtual network and resource group. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Subnet> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Subnet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified subnet. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SubnetDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.Delete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SubnetDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified subnet. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.Delete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SubnetDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Gets a list of resource navigation links for a subnet. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<ResourceNavigationLink>>> GetResourceNavigationLinksAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.GetResourceNavigationLinks");
            scope.Start();
            try
            {
                var response = await _resourceNavigationLinksRestClient.GetAllAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of resource navigation links for a subnet. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ResourceNavigationLink>> GetResourceNavigationLinks(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.GetResourceNavigationLinks");
            scope.Start();
            try
            {
                var response = _resourceNavigationLinksRestClient.GetAll(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of service association links for a subnet. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<ServiceAssociationLink>>> GetServiceAssociationLinksAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.GetServiceAssociationLinks");
            scope.Start();
            try
            {
                var response = await _serviceAssociationLinksRestClient.GetAllAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of service association links for a subnet. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ServiceAssociationLink>> GetServiceAssociationLinks(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Subnet.GetServiceAssociationLinks");
            scope.Start();
            try
            {
                var response = _serviceAssociationLinksRestClient.GetAll(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Prepares a subnet by applying network intent policies. </summary>
        /// <param name="prepareNetworkPoliciesRequestParameters"> Parameters supplied to prepare subnet by applying network intent policies. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prepareNetworkPoliciesRequestParameters"/> is null. </exception>
        public async virtual Task<SubnetPrepareNetworkPoliciesOperation> PrepareNetworkPoliciesAsync(PrepareNetworkPoliciesRequest prepareNetworkPoliciesRequestParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (prepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(prepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("Subnet.PrepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = await _restClient.PrepareNetworkPoliciesAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, prepareNetworkPoliciesRequestParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SubnetPrepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreatePrepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, prepareNetworkPoliciesRequestParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Prepares a subnet by applying network intent policies. </summary>
        /// <param name="prepareNetworkPoliciesRequestParameters"> Parameters supplied to prepare subnet by applying network intent policies. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prepareNetworkPoliciesRequestParameters"/> is null. </exception>
        public virtual SubnetPrepareNetworkPoliciesOperation PrepareNetworkPolicies(PrepareNetworkPoliciesRequest prepareNetworkPoliciesRequestParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (prepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(prepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("Subnet.PrepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = _restClient.PrepareNetworkPolicies(Id.ResourceGroupName, Id.Parent.Name, Id.Name, prepareNetworkPoliciesRequestParameters, cancellationToken);
                var operation = new SubnetPrepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreatePrepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, prepareNetworkPoliciesRequestParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="unprepareNetworkPoliciesRequestParameters"> Parameters supplied to unprepare subnet to remove network intent policies. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="unprepareNetworkPoliciesRequestParameters"/> is null. </exception>
        public async virtual Task<SubnetUnprepareNetworkPoliciesOperation> UnprepareNetworkPoliciesAsync(UnprepareNetworkPoliciesRequest unprepareNetworkPoliciesRequestParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (unprepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(unprepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("Subnet.UnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = await _restClient.UnprepareNetworkPoliciesAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, unprepareNetworkPoliciesRequestParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SubnetUnprepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreateUnprepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, unprepareNetworkPoliciesRequestParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="unprepareNetworkPoliciesRequestParameters"> Parameters supplied to unprepare subnet to remove network intent policies. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="unprepareNetworkPoliciesRequestParameters"/> is null. </exception>
        public virtual SubnetUnprepareNetworkPoliciesOperation UnprepareNetworkPolicies(UnprepareNetworkPoliciesRequest unprepareNetworkPoliciesRequestParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (unprepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(unprepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("Subnet.UnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = _restClient.UnprepareNetworkPolicies(Id.ResourceGroupName, Id.Parent.Name, Id.Name, unprepareNetworkPoliciesRequestParameters, cancellationToken);
                var operation = new SubnetUnprepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreateUnprepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, unprepareNetworkPoliciesRequestParameters).Request, response);
                if (waitForCompletion)
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
