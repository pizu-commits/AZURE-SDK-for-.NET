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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="ConfigurationStoreResource" /> and their operations.
    /// Each <see cref="ConfigurationStoreResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ConfigurationStoreCollection" /> instance call the GetConfigurationStores method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ConfigurationStoreCollection : ArmCollection, IEnumerable<ConfigurationStoreResource>, IAsyncEnumerable<ConfigurationStoreResource>
    {
        private readonly ClientDiagnostics _configurationStoreClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _configurationStoreRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStoreCollection"/> class for mocking. </summary>
        protected ConfigurationStoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConfigurationStoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _configurationStoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ConfigurationStoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConfigurationStoreResource.ResourceType, out string configurationStoreApiVersion);
            _configurationStoreRestClient = new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, configurationStoreApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a configuration store with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="data"> The parameters for creating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConfigurationStoreResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configStoreName, ConfigurationStoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<ConfigurationStoreResource>(new ConfigurationStoreOperationSource(Client), _configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a configuration store with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="data"> The parameters for creating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConfigurationStoreResource> CreateOrUpdate(WaitUntil waitUntil, string configStoreName, ConfigurationStoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, data, cancellationToken);
                var operation = new AppConfigurationArmOperation<ConfigurationStoreResource>(new ConfigurationStoreOperationSource(Client), _configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<ConfigurationStoreResource>> GetAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<ConfigurationStoreResource> Get(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the configuration stores for a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_ListByResourceGroup
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationStoreResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ConfigurationStoreResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoreRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConfigurationStoreResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoreRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the configuration stores for a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_ListByResourceGroup
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationStoreResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ConfigurationStoreResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoreRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConfigurationStoreResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoreRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<ConfigurationStoreResource>> GetIfExistsAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ConfigurationStoreResource>(null, response.GetRawResponse());
                return Response.FromValue(new ConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<ConfigurationStoreResource> GetIfExists(string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configStoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ConfigurationStoreResource>(null, response.GetRawResponse());
                return Response.FromValue(new ConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConfigurationStoreResource> IEnumerable<ConfigurationStoreResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConfigurationStoreResource> IAsyncEnumerable<ConfigurationStoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
