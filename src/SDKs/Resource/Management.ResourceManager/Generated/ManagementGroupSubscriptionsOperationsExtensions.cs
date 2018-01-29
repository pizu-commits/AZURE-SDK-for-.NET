// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagementGroupSubscriptionsOperations.
    /// </summary>
    public static partial class ManagementGroupSubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Associates existing subscription with the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Create(this IManagementGroupSubscriptionsOperations operations)
            {
                operations.CreateAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates existing subscription with the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateAsync(this IManagementGroupSubscriptionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// De-associates subscription from the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Delete(this IManagementGroupSubscriptionsOperations operations)
            {
                operations.DeleteAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// De-associates subscription from the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagementGroupSubscriptionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
