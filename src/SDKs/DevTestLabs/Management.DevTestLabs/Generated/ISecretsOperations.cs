// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// SecretsOperations operations.
    /// </summary>
    public partial interface ISecretsOperations
    {
        /// <summary>
        /// List secrets in a given user profile.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='userName'>
        /// The name of the user profile.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Secret>>> ListWithHttpMessagesAsync(string labName, string userName, ODataQuery<Secret> odataQuery = default(ODataQuery<Secret>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get secret.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='userName'>
        /// The name of the user profile.
        /// </param>
        /// <param name='name'>
        /// The name of the secret.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example: 'properties($select=value)'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Secret>> GetWithHttpMessagesAsync(string labName, string userName, string name, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or replace an existing secret.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='userName'>
        /// The name of the user profile.
        /// </param>
        /// <param name='name'>
        /// The name of the secret.
        /// </param>
        /// <param name='secret'>
        /// A secret.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Secret>> CreateOrUpdateWithHttpMessagesAsync(string labName, string userName, string name, Secret secret, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete secret.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='userName'>
        /// The name of the user profile.
        /// </param>
        /// <param name='name'>
        /// The name of the secret.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string labName, string userName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List secrets in a given user profile.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Secret>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
