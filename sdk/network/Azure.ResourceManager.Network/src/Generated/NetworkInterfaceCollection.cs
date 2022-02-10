// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkInterface and their operations over its parent. </summary>
    public partial class NetworkInterfaceCollection : ArmCollection, IEnumerable<NetworkInterface>, IAsyncEnumerable<NetworkInterface>
    {
        private readonly ClientDiagnostics _networkInterfaceClientDiagnostics;
        private readonly NetworkInterfacesRestOperations _networkInterfaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceCollection"/> class for mocking. </summary>
        protected NetworkInterfaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkInterfaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkInterface.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NetworkInterface.ResourceType, out string networkInterfaceApiVersion);
            _networkInterfaceRestClient = new NetworkInterfacesRestOperations(_networkInterfaceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkInterfaceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a network interface. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network interface operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<NetworkInterface>> CreateOrUpdateAsync(bool waitForCompletion, string networkInterfaceName, NetworkInterfaceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkInterface>(new NetworkInterfaceOperationSource(Client), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a network interface. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network interface operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<NetworkInterface> CreateOrUpdate(bool waitForCompletion, string networkInterfaceName, NetworkInterfaceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<NetworkInterface>(new NetworkInterfaceOperationSource(Client), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary> Gets information about the specified network interface. </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterface>> GetAsync(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkInterfaceClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterface(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified network interface. </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Response<NetworkInterface> Get(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken);
                if (response.Value == null)
                    throw _networkInterfaceClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterface(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all network interfaces in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterface" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterface> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterface>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterface>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network interfaces in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterface" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterface> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterface> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterface> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(networkInterfaceName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(networkInterfaceName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterface>> GetIfExistsAsync(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterface>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterface(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Response<NetworkInterface> GetIfExists(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterface>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterface(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkInterface> IEnumerable<NetworkInterface>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkInterface> IAsyncEnumerable<NetworkInterface>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
