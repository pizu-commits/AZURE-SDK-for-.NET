// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PeerAsnsOperations.
    /// </summary>
    public static partial class PeerAsnsOperationsExtensions
    {
            /// <summary>
            /// Gets the peer ASN with the specified name under the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerAsnName'>
            /// The peer ASN name.
            /// </param>
            public static PeerAsn Get(this IPeerAsnsOperations operations, string peerAsnName)
            {
                return operations.GetAsync(peerAsnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the peer ASN with the specified name under the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerAsnName'>
            /// The peer ASN name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PeerAsn> GetAsync(this IPeerAsnsOperations operations, string peerAsnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(peerAsnName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new peer ASN or updates an existing peer ASN with the specified
            /// name under the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerAsnName'>
            /// The peer ASN name.
            /// </param>
            /// <param name='peerAsn'>
            /// The peer ASN.
            /// </param>
            public static PeerAsn CreateOrUpdate(this IPeerAsnsOperations operations, string peerAsnName, PeerAsn peerAsn)
            {
                return operations.CreateOrUpdateAsync(peerAsnName, peerAsn).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new peer ASN or updates an existing peer ASN with the specified
            /// name under the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerAsnName'>
            /// The peer ASN name.
            /// </param>
            /// <param name='peerAsn'>
            /// The peer ASN.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PeerAsn> CreateOrUpdateAsync(this IPeerAsnsOperations operations, string peerAsnName, PeerAsn peerAsn, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(peerAsnName, peerAsn, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing peer ASN with the specified name under the given
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerAsnName'>
            /// The peer ASN name.
            /// </param>
            public static void Delete(this IPeerAsnsOperations operations, string peerAsnName)
            {
                operations.DeleteAsync(peerAsnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing peer ASN with the specified name under the given
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerAsnName'>
            /// The peer ASN name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPeerAsnsOperations operations, string peerAsnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(peerAsnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all of the peer ASNs under the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PeerAsn> ListBySubscription(this IPeerAsnsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the peer ASNs under the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PeerAsn>> ListBySubscriptionAsync(this IPeerAsnsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the peer ASNs under the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PeerAsn> ListBySubscriptionNext(this IPeerAsnsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the peer ASNs under the given subscription.
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
            public static async Task<IPage<PeerAsn>> ListBySubscriptionNextAsync(this IPeerAsnsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
