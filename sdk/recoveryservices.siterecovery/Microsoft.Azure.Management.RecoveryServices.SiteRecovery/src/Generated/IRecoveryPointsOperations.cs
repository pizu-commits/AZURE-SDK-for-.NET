// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RecoveryPointsOperations operations.
    /// </summary>
    public partial interface IRecoveryPointsOperations
    {
        /// <summary>
        /// Get recovery points for a replication protected item.
        /// </summary>
        /// <remarks>
        /// Lists the available recovery points for a replication protected
        /// item.
        /// </remarks>
        /// <param name='fabricName'>
        /// The fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// The protection container name.
        /// </param>
        /// <param name='replicatedProtectedItemName'>
        /// The replication protected item's name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecoveryPoint>>> ListByReplicationProtectedItemsWithHttpMessagesAsync(string fabricName, string protectionContainerName, string replicatedProtectedItemName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a recovery point.
        /// </summary>
        /// <remarks>
        /// Get the details of specified recovery point.
        /// </remarks>
        /// <param name='fabricName'>
        /// The fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// The protection container name.
        /// </param>
        /// <param name='replicatedProtectedItemName'>
        /// The replication protected item's name.
        /// </param>
        /// <param name='recoveryPointName'>
        /// The recovery point name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPoint>> GetWithHttpMessagesAsync(string fabricName, string protectionContainerName, string replicatedProtectedItemName, string recoveryPointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get recovery points for a replication protected item.
        /// </summary>
        /// <remarks>
        /// Lists the available recovery points for a replication protected
        /// item.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecoveryPoint>>> ListByReplicationProtectedItemsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
