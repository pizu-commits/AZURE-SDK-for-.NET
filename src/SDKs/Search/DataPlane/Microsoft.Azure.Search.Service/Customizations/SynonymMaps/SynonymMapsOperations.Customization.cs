﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest.Azure;
    using Models;

    internal partial class SynonymMapsOperations
    {
        /// <summary>
        /// Creates a new Azure Search synonymmap or updates a synonymmap if
        /// it already exists.
        /// </summary>
        /// <param name='synonymMap'>
        /// The definition of the synonymmap to create or update.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='accessCondition'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public Task<AzureOperationResponse<SynonymMap>> CreateOrUpdateWithHttpMessagesAsync(SynonymMap synonymMap, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateOrUpdateWithHttpMessagesAsync(synonymMap?.Name, synonymMap, searchRequestOptions, accessCondition, customHeaders, cancellationToken);
        }

        /// <summary>
        /// Determines whether or not the given synonym map exists in the Azure Search service.
        /// </summary>
        /// <param name="synonymMapName">
        /// The name of the synonym map.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <returns>
        /// A response with the value <c>true</c> if the synonym map exists; <c>false</c> otherwise.
        /// </returns>
        public Task<AzureOperationResponse<bool>> ExistsWithHttpMessagesAsync(
            string synonymMapName,
            SearchRequestOptions searchRequestOptions = default(SearchRequestOptions),
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExistsHelper.ExistsFromGetResponse(() =>
                this.GetWithHttpMessagesAsync(synonymMapName, searchRequestOptions, customHeaders, cancellationToken));
        }
    }
}
