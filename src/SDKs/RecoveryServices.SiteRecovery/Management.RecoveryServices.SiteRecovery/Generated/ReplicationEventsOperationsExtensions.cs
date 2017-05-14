// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ReplicationEventsOperations.
    /// </summary>
    public static partial class ReplicationEventsOperationsExtensions
    {
            /// <summary>
            /// Get the details of an Azure Site recovery event.
            /// </summary>
            /// The operation to get the details of an Azure Site recovery event.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventName'>
            /// The name of the Azure Site Recovery event.
            /// </param>
            public static EventModel Get(this IReplicationEventsOperations operations, string eventName)
            {
                return Task.Factory.StartNew(s => ((IReplicationEventsOperations)s).GetAsync(eventName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the details of an Azure Site recovery event.
            /// </summary>
            /// The operation to get the details of an Azure Site recovery event.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventName'>
            /// The name of the Azure Site Recovery event.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventModel> GetAsync(this IReplicationEventsOperations operations, string eventName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(eventName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<EventModel> List(this IReplicationEventsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IReplicationEventsOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventModel>> ListAsync(this IReplicationEventsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventModel> ListNext(this IReplicationEventsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IReplicationEventsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Azure Site Recovery events.
            /// </summary>
            /// Gets the list of Azure Site Recovery events for the vault.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventModel>> ListNextAsync(this IReplicationEventsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
