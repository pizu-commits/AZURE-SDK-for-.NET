// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SharesOperations operations.
    /// </summary>
    public partial interface ISharesOperations
    {
        /// <summary>
        /// Get a specified share
        /// </summary>
        /// <remarks>
        /// Get a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Share>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a share in the given account.
        /// </summary>
        /// <remarks>
        /// Create a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='share'>
        /// The share payload
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Share>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, Share share, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a share
        /// </summary>
        /// <remarks>
        /// Delete a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationResponse>> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List of available shares under an account.
        /// </summary>
        /// <remarks>
        /// List shares in an account
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation Token
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Share>>> ListByAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Synchronizations in a share
        /// </summary>
        /// <remarks>
        /// List synchronizations of a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation token
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ShareSynchronization>>> ListSynchronizationsWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List data set level details for a share synchronization
        /// </summary>
        /// <remarks>
        /// List synchronization details
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='shareSynchronization'>
        /// Share Synchronization payload.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation token
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SynchronizationDetails>>> ListSynchronizationDetailsWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, ShareSynchronization shareSynchronization, string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a share
        /// </summary>
        /// <remarks>
        /// Delete a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationResponse>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List of available shares under an account.
        /// </summary>
        /// <remarks>
        /// List shares in an account
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
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Share>>> ListByAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Synchronizations in a share
        /// </summary>
        /// <remarks>
        /// List synchronizations of a share
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
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ShareSynchronization>>> ListSynchronizationsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List data set level details for a share synchronization
        /// </summary>
        /// <remarks>
        /// List synchronization details
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
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SynchronizationDetails>>> ListSynchronizationDetailsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
