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
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkSecurityPerimeterConfigurationResource"/> and their operations.
    /// Each <see cref="NetworkSecurityPerimeterConfigurationResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="NetworkSecurityPerimeterConfigurationCollection"/> instance call the GetNetworkSecurityPerimeterConfigurations method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class NetworkSecurityPerimeterConfigurationCollection : ArmCollection, IEnumerable<NetworkSecurityPerimeterConfigurationResource>, IAsyncEnumerable<NetworkSecurityPerimeterConfigurationResource>
    {
        private readonly ClientDiagnostics _networkSecurityPerimeterConfigurationClientDiagnostics;
        private readonly NetworkSecurityPerimeterConfigurationsRestOperations _networkSecurityPerimeterConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterConfigurationCollection"/> class for mocking. </summary>
        protected NetworkSecurityPerimeterConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkSecurityPerimeterConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityPerimeterConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", NetworkSecurityPerimeterConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkSecurityPerimeterConfigurationResource.ResourceType, out string networkSecurityPerimeterConfigurationApiVersion);
            _networkSecurityPerimeterConfigurationRestClient = new NetworkSecurityPerimeterConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkSecurityPerimeterConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets effective Network Security Perimeter Configuration for association
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations/{networkSecurityPerimeterConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityPerimeterConfigurationResource>> GetAsync(string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var scope = _networkSecurityPerimeterConfigurationClientDiagnostics.CreateScope("NetworkSecurityPerimeterConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkSecurityPerimeterConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets effective Network Security Perimeter Configuration for association
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations/{networkSecurityPerimeterConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        public virtual Response<NetworkSecurityPerimeterConfigurationResource> Get(string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var scope = _networkSecurityPerimeterConfigurationClientDiagnostics.CreateScope("NetworkSecurityPerimeterConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkSecurityPerimeterConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets list of effective Network Security Perimeter Configuration for cosmos db account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityPerimeterConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityPerimeterConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterConfigurationResource(Client, NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(e)), _networkSecurityPerimeterConfigurationClientDiagnostics, Pipeline, "NetworkSecurityPerimeterConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets list of effective Network Security Perimeter Configuration for cosmos db account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityPerimeterConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityPerimeterConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterConfigurationResource(Client, NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(e)), _networkSecurityPerimeterConfigurationClientDiagnostics, Pipeline, "NetworkSecurityPerimeterConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations/{networkSecurityPerimeterConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var scope = _networkSecurityPerimeterConfigurationClientDiagnostics.CreateScope("NetworkSecurityPerimeterConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkSecurityPerimeterConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations/{networkSecurityPerimeterConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var scope = _networkSecurityPerimeterConfigurationClientDiagnostics.CreateScope("NetworkSecurityPerimeterConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkSecurityPerimeterConfigurationName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations/{networkSecurityPerimeterConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkSecurityPerimeterConfigurationResource>> GetIfExistsAsync(string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var scope = _networkSecurityPerimeterConfigurationClientDiagnostics.CreateScope("NetworkSecurityPerimeterConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkSecurityPerimeterConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/networkSecurityPerimeterConfigurations/{networkSecurityPerimeterConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        public virtual NullableResponse<NetworkSecurityPerimeterConfigurationResource> GetIfExists(string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var scope = _networkSecurityPerimeterConfigurationClientDiagnostics.CreateScope("NetworkSecurityPerimeterConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkSecurityPerimeterConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityPerimeterConfigurationResource> IEnumerable<NetworkSecurityPerimeterConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityPerimeterConfigurationResource> IAsyncEnumerable<NetworkSecurityPerimeterConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
