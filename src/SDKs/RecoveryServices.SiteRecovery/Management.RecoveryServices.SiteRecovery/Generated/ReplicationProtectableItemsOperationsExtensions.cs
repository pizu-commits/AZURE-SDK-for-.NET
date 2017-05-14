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
    /// Extension methods for ReplicationProtectableItemsOperations.
    /// </summary>
    public static partial class ReplicationProtectableItemsOperationsExtensions
    {
            /// <summary>
            /// Gets the details of a protectable item.
            /// </summary>
            /// The operation to get the details of a protectable item.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='protectableItemName'>
            /// Protectable item name.
            /// </param>
            public static ProtectableItem Get(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName, string protectableItemName)
            {
                return Task.Factory.StartNew(s => ((IReplicationProtectableItemsOperations)s).GetAsync(fabricName, protectionContainerName, protectableItemName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a protectable item.
            /// </summary>
            /// The operation to get the details of a protectable item.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='protectableItemName'>
            /// Protectable item name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectableItem> GetAsync(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName, string protectableItemName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, protectionContainerName, protectableItemName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// Lists the protectable items in a protection container.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            public static IPage<ProtectableItem> ListByReplicationProtectionContainers(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName)
            {
                return Task.Factory.StartNew(s => ((IReplicationProtectableItemsOperations)s).ListByReplicationProtectionContainersAsync(fabricName, protectionContainerName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// Lists the protectable items in a protection container.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectableItem>> ListByReplicationProtectionContainersAsync(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationProtectionContainersWithHttpMessagesAsync(fabricName, protectionContainerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// Lists the protectable items in a protection container.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProtectableItem> ListByReplicationProtectionContainersNext(this IReplicationProtectableItemsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IReplicationProtectableItemsOperations)s).ListByReplicationProtectionContainersNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// Lists the protectable items in a protection container.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectableItem>> ListByReplicationProtectionContainersNextAsync(this IReplicationProtectableItemsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationProtectionContainersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
