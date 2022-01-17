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
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class representing collection of ConfigurationStore and their operations over its parent. </summary>
    public partial class ConfigurationStoreCollection : ArmCollection, IEnumerable<ConfigurationStore>, IAsyncEnumerable<ConfigurationStore>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ConfigurationStoresRestOperations _configurationStoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStoreCollection"/> class for mocking. </summary>
        protected ConfigurationStoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStoreCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ConfigurationStoreCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _configurationStoresRestClient = new ConfigurationStoresRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a configuration store with the specified parameters. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreCreationParameters"> The parameters for creating a configuration store. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> or <paramref name="configStoreCreationParameters"/> is null. </exception>
        public virtual ConfigurationStoreCreateOperation CreateOrUpdate(bool waitForCompletion, string configStoreName, ConfigurationStoreData configStoreCreationParameters, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (configStoreCreationParameters == null)
            {
                throw new ArgumentNullException(nameof(configStoreCreationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _configurationStoresRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters, cancellationToken);
                var operation = new ConfigurationStoreCreateOperation(Parent, _clientDiagnostics, Pipeline, _configurationStoresRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters).Request, response);
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

        /// <summary> Creates a configuration store with the specified parameters. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreCreationParameters"> The parameters for creating a configuration store. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> or <paramref name="configStoreCreationParameters"/> is null. </exception>
        public async virtual Task<ConfigurationStoreCreateOperation> CreateOrUpdateAsync(bool waitForCompletion, string configStoreName, ConfigurationStoreData configStoreCreationParameters, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (configStoreCreationParameters == null)
            {
                throw new ArgumentNullException(nameof(configStoreCreationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _configurationStoresRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new ConfigurationStoreCreateOperation(Parent, _clientDiagnostics, Pipeline, _configurationStoresRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, configStoreCreationParameters).Request, response);
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

        /// <summary> Gets the properties of the specified configuration store. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<ConfigurationStore> Get(string configStoreName, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = _configurationStoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of the specified configuration store. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public async virtual Task<Response<ConfigurationStore>> GetAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _configurationStoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ConfigurationStore(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<ConfigurationStore> GetIfExists(string configStoreName, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _configurationStoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ConfigurationStore>(null, response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public async virtual Task<Response<ConfigurationStore>> GetIfExistsAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _configurationStoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ConfigurationStore>(null, response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string configStoreName, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(configStoreName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the configuration stores for a given resource group. </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationStore" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationStore> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ConfigurationStore> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoresRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConfigurationStore> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoresRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the configuration stores for a given resource group. </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationStore" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationStore> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ConfigurationStore>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoresRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConfigurationStore>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoresRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStore(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ConfigurationStore" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ConfigurationStore.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ConfigurationStore" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ConfigurationStore.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConfigurationStore> IEnumerable<ConfigurationStore>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConfigurationStore> IAsyncEnumerable<ConfigurationStore>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ConfigurationStore, ConfigurationStoreData> Construct() { }
    }
}
