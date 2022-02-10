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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of VnetGateway and their operations over its parent. </summary>
    public partial class ServerfarmVirtualNetworkConnectionGatewayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionGatewayCollection"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnectionGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ServerfarmVirtualNetworkConnectionGateway.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ServerfarmVirtualNetworkConnectionGateway.ResourceType, out string serverfarmVirtualNetworkConnectionGatewayAppServicePlansApiVersion);
            _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient = new AppServicePlansRestOperations(_serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverfarmVirtualNetworkConnectionGatewayAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerfarmVirtualNetworkConnection.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerfarmVirtualNetworkConnection.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_UpdateVnetGateway
        /// <summary> Description for Update a Virtual Network gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="connectionEnvelope"> Definition of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<ArmOperation<ServerfarmVirtualNetworkConnectionGateway>> CreateOrUpdateAsync(bool waitForCompletion, string gatewayName, VnetGatewayData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.UpdateVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<ServerfarmVirtualNetworkConnectionGateway>(Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_UpdateVnetGateway
        /// <summary> Description for Update a Virtual Network gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="connectionEnvelope"> Definition of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual ArmOperation<ServerfarmVirtualNetworkConnectionGateway> CreateOrUpdate(bool waitForCompletion, string gatewayName, VnetGatewayData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.UpdateVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, connectionEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<ServerfarmVirtualNetworkConnectionGateway>(Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Description for Get a Virtual Network gateway. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnectionGateway>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Description for Get a Virtual Network gateway. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnectionGateway> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnectionGateway>> GetIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnectionGateway>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnectionGateway> GetIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnectionGateway>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
