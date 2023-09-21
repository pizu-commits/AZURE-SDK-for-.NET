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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="MobileNetworkSiteResource" /> and their operations.
    /// Each <see cref="MobileNetworkSiteResource" /> in the collection will belong to the same instance of <see cref="MobileNetworkResource" />.
    /// To get a <see cref="MobileNetworkSiteCollection" /> instance call the GetMobileNetworkSites method from an instance of <see cref="MobileNetworkResource" />.
    /// </summary>
    public partial class MobileNetworkSiteCollection : ArmCollection, IEnumerable<MobileNetworkSiteResource>, IAsyncEnumerable<MobileNetworkSiteResource>
    {
        private readonly ClientDiagnostics _mobileNetworkSiteSitesClientDiagnostics;
        private readonly SitesRestOperations _mobileNetworkSiteSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSiteCollection"/> class for mocking. </summary>
        protected MobileNetworkSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MobileNetworkSiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkSiteSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", MobileNetworkSiteResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MobileNetworkSiteResource.ResourceType, out string mobileNetworkSiteSitesApiVersion);
            _mobileNetworkSiteSitesRestClient = new SitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkSiteSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MobileNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MobileNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a mobile network site. Must be created in the same location as its parent mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="data"> Parameters supplied to the create or update mobile network site operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileNetworkSiteResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string siteName, MobileNetworkSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkSiteResource>(new MobileNetworkSiteOperationSource(Client), _mobileNetworkSiteSitesClientDiagnostics, Pipeline, _mobileNetworkSiteSitesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a mobile network site. Must be created in the same location as its parent mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="data"> Parameters supplied to the create or update mobile network site operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileNetworkSiteResource> CreateOrUpdate(WaitUntil waitUntil, string siteName, MobileNetworkSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkSiteResource>(new MobileNetworkSiteOperationSource(Client), _mobileNetworkSiteSitesClientDiagnostics, Pipeline, _mobileNetworkSiteSitesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified mobile network site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSiteResource>> GetAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified mobile network site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<MobileNetworkSiteResource> Get(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all sites in the mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_ListByMobileNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileNetworkSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MobileNetworkSiteResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSiteSitesRestClient.CreateListByMobileNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSiteSitesRestClient.CreateListByMobileNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkSiteResource(Client, MobileNetworkSiteData.DeserializeMobileNetworkSiteData(e)), _mobileNetworkSiteSitesClientDiagnostics, Pipeline, "MobileNetworkSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all sites in the mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_ListByMobileNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileNetworkSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MobileNetworkSiteResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkSiteSitesRestClient.CreateListByMobileNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkSiteSitesRestClient.CreateListByMobileNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkSiteResource(Client, MobileNetworkSiteData.DeserializeMobileNetworkSiteData(e)), _mobileNetworkSiteSitesClientDiagnostics, Pipeline, "MobileNetworkSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<bool> Exists(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<NullableResponse<MobileNetworkSiteResource>> GetIfExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSiteResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteName"> The name of the mobile network site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual NullableResponse<MobileNetworkSiteResource> GetIfExists(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkSiteResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MobileNetworkSiteResource> IEnumerable<MobileNetworkSiteResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MobileNetworkSiteResource> IAsyncEnumerable<MobileNetworkSiteResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
