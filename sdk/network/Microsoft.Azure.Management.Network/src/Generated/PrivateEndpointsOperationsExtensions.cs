// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointsOperations.
    /// </summary>
    public static partial class PrivateEndpointsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified private endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            public static void Delete(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName)
            {
                operations.DeleteAsync(resourceGroupName, privateEndpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, privateEndpointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified private endpoint by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static PrivateEndpoint Get(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, privateEndpointName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified private endpoint by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpoint> GetAsync(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateEndpointName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an private endpoint in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private endpoint operation
            /// </param>
            public static PrivateEndpoint CreateOrUpdate(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, PrivateEndpoint parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, privateEndpointName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an private endpoint in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private endpoint operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpoint> CreateOrUpdateAsync(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, PrivateEndpoint parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private endpoints in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<PrivateEndpoint> List(this IPrivateEndpointsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoints in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpoint>> ListAsync(this IPrivateEndpointsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private endpoints in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PrivateEndpoint> ListBySubscription(this IPrivateEndpointsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoints in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpoint>> ListBySubscriptionAsync(this IPrivateEndpointsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            public static void BeginDelete(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName)
            {
                operations.BeginDeleteAsync(resourceGroupName, privateEndpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, privateEndpointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates an private endpoint in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private endpoint operation
            /// </param>
            public static PrivateEndpoint BeginCreateOrUpdate(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, PrivateEndpoint parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, privateEndpointName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an private endpoint in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateEndpointName'>
            /// The name of the private endpoint.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private endpoint operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpoint> BeginCreateOrUpdateAsync(this IPrivateEndpointsOperations operations, string resourceGroupName, string privateEndpointName, PrivateEndpoint parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private endpoints in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateEndpoint> ListNext(this IPrivateEndpointsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoints in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpoint>> ListNextAsync(this IPrivateEndpointsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private endpoints in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateEndpoint> ListBySubscriptionNext(this IPrivateEndpointsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoints in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpoint>> ListBySubscriptionNextAsync(this IPrivateEndpointsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
