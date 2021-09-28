// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AssetFiltersOperations operations.
    /// </summary>
    public partial interface IAssetFiltersOperations
    {
        /// <summary>
        /// List Asset Filters
        /// </summary>
        /// <remarks>
        /// List Asset Filters associated with the specified Asset.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='assetName'>
        /// The Asset name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AssetFilter>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, string assetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get an Asset Filter.
        /// </summary>
        /// <remarks>
        /// Get the details of an Asset Filter associated with the specified
        /// Asset.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='assetName'>
        /// The Asset name.
        /// </param>
        /// <param name='filterName'>
        /// The Asset Filter name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AssetFilter>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string assetName, string filterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an Asset Filter
        /// </summary>
        /// <remarks>
        /// Creates or updates an Asset Filter associated with the specified
        /// Asset.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='assetName'>
        /// The Asset name.
        /// </param>
        /// <param name='filterName'>
        /// The Asset Filter name
        /// </param>
        /// <param name='parameters'>
        /// The request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AssetFilter>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string assetName, string filterName, AssetFilter parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an Asset Filter.
        /// </summary>
        /// <remarks>
        /// Deletes an Asset Filter associated with the specified Asset.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='assetName'>
        /// The Asset name.
        /// </param>
        /// <param name='filterName'>
        /// The Asset Filter name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string assetName, string filterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an Asset Filter
        /// </summary>
        /// <remarks>
        /// Updates an existing Asset Filter associated with the specified
        /// Asset.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='assetName'>
        /// The Asset name.
        /// </param>
        /// <param name='filterName'>
        /// The Asset Filter name
        /// </param>
        /// <param name='parameters'>
        /// The request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AssetFilter>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string assetName, string filterName, AssetFilter parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Asset Filters
        /// </summary>
        /// <remarks>
        /// List Asset Filters associated with the specified Asset.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AssetFilter>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
