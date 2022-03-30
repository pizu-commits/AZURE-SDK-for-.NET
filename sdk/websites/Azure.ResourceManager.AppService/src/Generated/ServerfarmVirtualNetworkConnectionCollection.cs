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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerfarmVirtualNetworkConnectionResource" /> and their operations.
    /// Each <see cref="ServerfarmVirtualNetworkConnectionResource" /> in the collection will belong to the same instance of <see cref="AppServicePlanResource" />.
    /// To get a <see cref="ServerfarmVirtualNetworkConnectionCollection" /> instance call the GetServerfarmVirtualNetworkConnections method from an instance of <see cref="AppServicePlanResource" />.
    /// </summary>
    public partial class ServerfarmVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<ServerfarmVirtualNetworkConnectionResource>, IAsyncEnumerable<ServerfarmVirtualNetworkConnectionResource>
    {
        private readonly ClientDiagnostics _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _serverfarmVirtualNetworkConnectionAppServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ServerfarmVirtualNetworkConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerfarmVirtualNetworkConnectionResource.ResourceType, out string serverfarmVirtualNetworkConnectionAppServicePlansApiVersion);
            _serverfarmVirtualNetworkConnectionAppServicePlansRestClient = new AppServicePlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverfarmVirtualNetworkConnectionAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServicePlanResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServicePlanResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get a Virtual Network associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual async Task<Response<ServerfarmVirtualNetworkConnectionResource>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a Virtual Network associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnectionResource> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all Virtual Networks associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// Operation Id: AppServicePlans_ListVnets
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerfarmVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerfarmVirtualNetworkConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerfarmVirtualNetworkConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.ListVnetsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new ServerfarmVirtualNetworkConnectionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Description for Get all Virtual Networks associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// Operation Id: AppServicePlans_ListVnets
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerfarmVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerfarmVirtualNetworkConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerfarmVirtualNetworkConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.ListVnets(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new ServerfarmVirtualNetworkConnectionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vnetName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual async Task<Response<ServerfarmVirtualNetworkConnectionResource>> GetIfExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnectionResource> GetIfExists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerfarmVirtualNetworkConnectionResource> IEnumerable<ServerfarmVirtualNetworkConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerfarmVirtualNetworkConnectionResource> IAsyncEnumerable<ServerfarmVirtualNetworkConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
