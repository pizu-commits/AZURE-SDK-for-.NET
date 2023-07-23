// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DefenderForStorageOperations.
    /// </summary>
    public static partial class DefenderForStorageOperationsExtensions
    {
            /// <summary>
            /// Gets the Defender for Storage settings for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            public static DefenderForStorageSetting Get(this IDefenderForStorageOperations operations, string resourceId)
            {
                return operations.GetAsync(resourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Defender for Storage settings for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DefenderForStorageSetting> GetAsync(this IDefenderForStorageOperations operations, string resourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the Defender for Storage settings on a specified storage
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='defenderForStorageSetting'>
            /// Defender for Storage Settings
            /// </param>
            public static DefenderForStorageSetting Create(this IDefenderForStorageOperations operations, string resourceId, DefenderForStorageSetting defenderForStorageSetting)
            {
                return operations.CreateAsync(resourceId, defenderForStorageSetting).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the Defender for Storage settings on a specified storage
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='defenderForStorageSetting'>
            /// Defender for Storage Settings
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DefenderForStorageSetting> CreateAsync(this IDefenderForStorageOperations operations, string resourceId, DefenderForStorageSetting defenderForStorageSetting, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceId, defenderForStorageSetting, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
