// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// List private endpoint connections
            /// </summary>
            /// <remarks>
            /// List private endpoint connection properties
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static IList<PrivateEndpointConnection> List(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private endpoint connections
            /// </summary>
            /// <remarks>
            /// List private endpoint connection properties
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PrivateEndpointConnection>> ListAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get private endpoint connection
            /// </summary>
            /// <remarks>
            /// Get private endpoint connection properties
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, resourceName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get private endpoint connection
            /// </summary>
            /// <remarks>
            /// Get private endpoint connection properties
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update private endpoint connection
            /// </summary>
            /// <remarks>
            /// Update the status of a private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection with updated properties
            /// </param>
            public static PrivateEndpointConnection Update(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection)
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, privateEndpointConnectionName, privateEndpointConnection).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update private endpoint connection
            /// </summary>
            /// <remarks>
            /// Update the status of a private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection with updated properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> UpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateEndpointConnectionName, privateEndpointConnection, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete private endpoint connection
            /// </summary>
            /// <remarks>
            /// Delete private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            public static PrivateEndpointConnection Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName)
            {
                return operations.DeleteAsync(resourceGroupName, resourceName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete private endpoint connection
            /// </summary>
            /// <remarks>
            /// Delete private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update private endpoint connection
            /// </summary>
            /// <remarks>
            /// Update the status of a private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection with updated properties
            /// </param>
            public static PrivateEndpointConnection BeginUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection)
            {
                return operations.BeginUpdateAsync(resourceGroupName, resourceName, privateEndpointConnectionName, privateEndpointConnection).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update private endpoint connection
            /// </summary>
            /// <remarks>
            /// Update the status of a private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection with updated properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateEndpointConnectionName, privateEndpointConnection, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete private endpoint connection
            /// </summary>
            /// <remarks>
            /// Delete private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            public static PrivateEndpointConnection BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, resourceName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete private endpoint connection
            /// </summary>
            /// <remarks>
            /// Delete private endpoint connection with the specified name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string resourceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
