// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PublicIPAddressesOperations.
    /// </summary>
    public static partial class PublicIPAddressesOperationsExtensions
    {
            
            /// <summary>
            /// Deletes the specified public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Gets the specified public IP address in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublicIPAddressInner> GetAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Creates or updates a static or dynamic public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the public IP address.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update public IP address operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublicIPAddressInner> CreateOrUpdateAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddressInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Gets all the public IP addresses in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PublicIPAddressInner>> ListAllAsync(this IPublicIPAddressesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Gets all public IP addresses in a resource group.
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
            public static async Task<IPage<PublicIPAddressInner>> ListAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Deletes the specified public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Creates or updates a static or dynamic public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the public IP address.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update public IP address operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublicIPAddressInner> BeginCreateOrUpdateAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddressInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Gets all the public IP addresses in a subscription.
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
            public static async Task<IPage<PublicIPAddressInner>> ListAllNextAsync(this IPublicIPAddressesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Gets all public IP addresses in a resource group.
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
            public static async Task<IPage<PublicIPAddressInner>> ListNextAsync(this IPublicIPAddressesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
