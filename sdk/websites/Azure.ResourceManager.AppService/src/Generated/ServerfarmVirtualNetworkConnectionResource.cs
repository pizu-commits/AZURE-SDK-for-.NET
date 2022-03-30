// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a ServerfarmVirtualNetworkConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServerfarmVirtualNetworkConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServerfarmVirtualNetworkConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServicePlanResource" /> using the GetServerfarmVirtualNetworkConnection method.
    /// </summary>
    public partial class ServerfarmVirtualNetworkConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerfarmVirtualNetworkConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _serverfarmVirtualNetworkConnectionAppServicePlansRestClient;
        private readonly VnetInfoResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionResource"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerfarmVirtualNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnectionResource(ArmClient client, VnetInfoResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serverfarmVirtualNetworkConnectionAppServicePlansApiVersion);
            _serverfarmVirtualNetworkConnectionAppServicePlansRestClient = new AppServicePlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverfarmVirtualNetworkConnectionAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/serverfarms/virtualNetworkConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VnetInfoResourceData Data
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

        /// <summary> Gets a collection of ServerfarmVirtualNetworkConnectionGatewayResources in the ServerfarmVirtualNetworkConnection. </summary>
        /// <returns> An object representing collection of ServerfarmVirtualNetworkConnectionGatewayResources and their operations over a ServerfarmVirtualNetworkConnectionGatewayResource. </returns>
        public virtual ServerfarmVirtualNetworkConnectionGatewayCollection GetServerfarmVirtualNetworkConnectionGateways()
        {
            return GetCachedClient(Client => new ServerfarmVirtualNetworkConnectionGatewayCollection(Client, Id));
        }

        /// <summary>
        /// Description for Get a Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: AppServicePlans_GetVnetGateway
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<ServerfarmVirtualNetworkConnectionGatewayResource>> GetServerfarmVirtualNetworkConnectionGatewayAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            return await GetServerfarmVirtualNetworkConnectionGateways().GetAsync(gatewayName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get a Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: AppServicePlans_GetVnetGateway
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnectionGatewayResource> GetServerfarmVirtualNetworkConnectionGateway(string gatewayName, CancellationToken cancellationToken = default)
        {
            return GetServerfarmVirtualNetworkConnectionGateways().Get(gatewayName, cancellationToken);
        }

        /// <summary>
        /// Description for Get a Virtual Network associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerfarmVirtualNetworkConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerfarmVirtualNetworkConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get all routes that are associated with a Virtual Network in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes
        /// Operation Id: AppServicePlans_ListRoutesForVnet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VnetRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VnetRoute> GetRoutesForVnetAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VnetRoute>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.GetRoutesForVnet");
                scope.Start();
                try
                {
                    var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.ListRoutesForVnetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
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
        /// Description for Get all routes that are associated with a Virtual Network in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes
        /// Operation Id: AppServicePlans_ListRoutesForVnet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VnetRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VnetRoute> GetRoutesForVnet(CancellationToken cancellationToken = default)
        {
            Page<VnetRoute> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.GetRoutesForVnet");
                scope.Start();
                try
                {
                    var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.ListRoutesForVnet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
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
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_CreateOrUpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual async Task<Response<VnetRoute>> CreateOrUpdateVnetRouteAsync(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.CreateOrUpdateVnetRoute");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.CreateOrUpdateVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_CreateOrUpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual Response<VnetRoute> CreateOrUpdateVnetRoute(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.CreateOrUpdateVnetRoute");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.CreateOrUpdateVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_DeleteVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual async Task<Response> DeleteVnetRouteAsync(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.DeleteVnetRoute");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.DeleteVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_DeleteVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response DeleteVnetRoute(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.DeleteVnetRoute");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.DeleteVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_UpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual async Task<Response<VnetRoute>> UpdateVnetRouteAsync(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.UpdateVnetRoute");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.UpdateVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_UpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual Response<VnetRoute> UpdateVnetRoute(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionResource.UpdateVnetRoute");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.UpdateVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
