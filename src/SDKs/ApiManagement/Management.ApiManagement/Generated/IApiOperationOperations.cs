// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ApiOperationOperations operations.
    /// </summary>
    public partial interface IApiOperationOperations
    {
        /// <summary>
        /// Lists a collection of the operations for the specified API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API identifier. Must be unique in the current API Management
        /// service instance.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationContract>>> ListByApiWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, ODataQuery<OperationContract> odataQuery = default(ODataQuery<OperationContract>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of the API Operation specified by its identifier.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API identifier. Must be unique in the current API Management
        /// service instance.
        /// </param>
        /// <param name='operationId'>
        /// Operation identifier within an API. Must be unique in the current
        /// API Management service instance.
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
        Task<AzureOperationResponse<OperationContract,ApiOperationGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new operation in the API or updates an existing one.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API identifier. Must be unique in the current API Management
        /// service instance.
        /// </param>
        /// <param name='operationId'>
        /// Operation identifier within an API. Must be unique in the current
        /// API Management service instance.
        /// </param>
        /// <param name='parameters'>
        /// Create parameters.
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
        Task<AzureOperationResponse<OperationContract>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string operationId, OperationContract parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the details of the operation in the API specified by its
        /// identifier.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API identifier. Must be unique in the current API Management
        /// service instance.
        /// </param>
        /// <param name='operationId'>
        /// Operation identifier within an API. Must be unique in the current
        /// API Management service instance.
        /// </param>
        /// <param name='parameters'>
        /// API Operation Update parameters.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the API Operation Entity. ETag should match the current
        /// entity state from the header response of the GET request or it
        /// should be * for unconditional update.
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
        Task<AzureOperationResponse> UpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string operationId, OperationUpdateContract parameters, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified operation in the API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API identifier. Must be unique in the current API Management
        /// service instance.
        /// </param>
        /// <param name='operationId'>
        /// Operation identifier within an API. Must be unique in the current
        /// API Management service instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the API Operation Entity. ETag should match the current
        /// entity state from the header response of the GET request or it
        /// should be * for unconditional update.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string operationId, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists a collection of the operations for the specified API.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationContract>>> ListByApiNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
