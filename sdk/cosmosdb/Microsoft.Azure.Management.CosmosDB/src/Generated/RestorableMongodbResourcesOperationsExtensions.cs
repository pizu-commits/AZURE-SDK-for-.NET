// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorableMongodbResourcesOperations.
    /// </summary>
    public static partial class RestorableMongodbResourcesOperationsExtensions
    {
            /// <summary>
            /// Return a list of database and collection combo that exist on the account at
            /// the given timestamp and location. This helps in scenarios to validate what
            /// resources exist at given timestamp and location. This API requires
            /// 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/*/read'
            /// permission.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='instanceId'>
            /// The instanceId GUID of a restorable database account.
            /// </param>
            /// <param name='restoreLocation'>
            /// The location where the restorable resources are located.
            /// </param>
            /// <param name='restoreTimestampInUtc'>
            /// The timestamp when the restorable resources existed.
            /// </param>
            public static IEnumerable<DatabaseRestoreResource> List(this IRestorableMongodbResourcesOperations operations, string location, string instanceId, string restoreLocation = default(string), string restoreTimestampInUtc = default(string))
            {
                return operations.ListAsync(location, instanceId, restoreLocation, restoreTimestampInUtc).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return a list of database and collection combo that exist on the account at
            /// the given timestamp and location. This helps in scenarios to validate what
            /// resources exist at given timestamp and location. This API requires
            /// 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/*/read'
            /// permission.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='instanceId'>
            /// The instanceId GUID of a restorable database account.
            /// </param>
            /// <param name='restoreLocation'>
            /// The location where the restorable resources are located.
            /// </param>
            /// <param name='restoreTimestampInUtc'>
            /// The timestamp when the restorable resources existed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DatabaseRestoreResource>> ListAsync(this IRestorableMongodbResourcesOperations operations, string location, string instanceId, string restoreLocation = default(string), string restoreTimestampInUtc = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, instanceId, restoreLocation, restoreTimestampInUtc, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
