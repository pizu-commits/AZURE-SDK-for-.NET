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
    /// <summary> A class representing the operations that can be performed over a specific Subnet. </summary>
    public partial class SubnetOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private SubnetsRestOperations _restClient { get; }
        private ResourceNavigationLinksRestOperations _resourceNavigationLinksRestClient { get; }
        private ServiceAssociationLinksRestOperations _serviceAssociationLinksRestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="SubnetOperations"/> class for mocking. </summary>
        protected SubnetOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubnetOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal SubnetOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
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

        /// <summary> Gets the specified subnet by virtual network and resource group. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Subnet>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
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
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified subnet. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified subnet. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SubnetsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new SubnetsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified subnet. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new SubnetsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.GetResourceNavigationLinks");
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
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.GetResourceNavigationLinks");
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
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.GetServiceAssociationLinks");
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
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.GetServiceAssociationLinks");
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
        /// <param name="serviceName"> The name of the service for which subnet is being prepared for. </param>
        /// <param name="networkIntentPolicyConfigurations"> A list of NetworkIntentPolicyConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> PrepareNetworkPoliciesAsync(string serviceName = null, IEnumerable<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.PrepareNetworkPolicies");
            scope.Start();
            try
            {
                var operation = await StartPrepareNetworkPoliciesAsync(serviceName, networkIntentPolicyConfigurations, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Prepares a subnet by applying network intent policies. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being prepared for. </param>
        /// <param name="networkIntentPolicyConfigurations"> A list of NetworkIntentPolicyConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PrepareNetworkPolicies(string serviceName = null, IEnumerable<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.PrepareNetworkPolicies");
            scope.Start();
            try
            {
                var operation = StartPrepareNetworkPolicies(serviceName, networkIntentPolicyConfigurations, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Prepares a subnet by applying network intent policies. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being prepared for. </param>
        /// <param name="networkIntentPolicyConfigurations"> A list of NetworkIntentPolicyConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SubnetsPrepareNetworkPoliciesOperation> StartPrepareNetworkPoliciesAsync(string serviceName = null, IEnumerable<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.StartPrepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = await _restClient.PrepareNetworkPoliciesAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName, networkIntentPolicyConfigurations, cancellationToken).ConfigureAwait(false);
                return new SubnetsPrepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreatePrepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName, networkIntentPolicyConfigurations).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Prepares a subnet by applying network intent policies. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being prepared for. </param>
        /// <param name="networkIntentPolicyConfigurations"> A list of NetworkIntentPolicyConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetsPrepareNetworkPoliciesOperation StartPrepareNetworkPolicies(string serviceName = null, IEnumerable<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.StartPrepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = _restClient.PrepareNetworkPolicies(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName, networkIntentPolicyConfigurations, cancellationToken);
                return new SubnetsPrepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreatePrepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName, networkIntentPolicyConfigurations).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being unprepared for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> UnprepareNetworkPoliciesAsync(string serviceName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.UnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var operation = await StartUnprepareNetworkPoliciesAsync(serviceName, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being unprepared for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UnprepareNetworkPolicies(string serviceName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.UnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var operation = StartUnprepareNetworkPolicies(serviceName, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being unprepared for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SubnetsUnprepareNetworkPoliciesOperation> StartUnprepareNetworkPoliciesAsync(string serviceName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.StartUnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = await _restClient.UnprepareNetworkPoliciesAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName, cancellationToken).ConfigureAwait(false);
                return new SubnetsUnprepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreateUnprepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being unprepared for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetsUnprepareNetworkPoliciesOperation StartUnprepareNetworkPolicies(string serviceName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetOperations.StartUnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var response = _restClient.UnprepareNetworkPolicies(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName, cancellationToken);
                return new SubnetsUnprepareNetworkPoliciesOperation(_clientDiagnostics, Pipeline, _restClient.CreateUnprepareNetworkPoliciesRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, serviceName).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
