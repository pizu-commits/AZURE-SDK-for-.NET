// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServiceOperations operations.
    /// </summary>
    public partial interface IServiceOperations
    {
        /// <summary>
        /// This method provides the list of available skus for the given
        /// subscription and location.
        /// </summary>
        /// <param name='location'>
        /// The location of the resource
        /// </param>
        /// <param name='availableSkuRequest'>
        /// Filters for showing the available skus.
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
        Task<AzureOperationResponse<IPage<SkuInformation>>> ListAvailableSkusWithHttpMessagesAsync(string location, AvailableSkuRequest availableSkuRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method provides the list of available skus for the given
        /// subscription, resource group and location.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='location'>
        /// The location of the resource
        /// </param>
        /// <param name='availableSkuRequest'>
        /// Filters for showing the available skus.
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
        Task<AzureOperationResponse<IPage<SkuInformation>>> ListAvailableSkusByResourceGroupWithHttpMessagesAsync(string resourceGroupName, string location, AvailableSkuRequest availableSkuRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// [DEPRECATED NOTICE: This operation will soon be removed] This
        /// method validates the customer shipping address and provide
        /// alternate addresses if any.
        /// </summary>
        /// <param name='location'>
        /// The location of the resource
        /// </param>
        /// <param name='validateAddress'>
        /// Shipping address of the customer.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<AzureOperationResponse<AddressValidationOutput>> ValidateAddressMethodWithHttpMessagesAsync(string location, ValidateAddress validateAddress, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method does all necessary pre-job creation validation under
        /// resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='location'>
        /// The location of the resource
        /// </param>
        /// <param name='validationRequest'>
        /// Inputs of the customer.
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
        Task<AzureOperationResponse<ValidationResponse>> ValidateInputsByResourceGroupWithHttpMessagesAsync(string resourceGroupName, string location, ValidationRequest validationRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method does all necessary pre-job creation validation under
        /// subscription.
        /// </summary>
        /// <param name='location'>
        /// The location of the resource
        /// </param>
        /// <param name='validationRequest'>
        /// Inputs of the customer.
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
        Task<AzureOperationResponse<ValidationResponse>> ValidateInputsWithHttpMessagesAsync(string location, ValidationRequest validationRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This API provides configuration details specific to given
        /// region/location.
        /// </summary>
        /// <param name='location'>
        /// The location of the resource
        /// </param>
        /// <param name='scheduleAvailabilityRequest'>
        /// Request body to get the availability for scheduling orders.
        /// </param>
        /// <param name='transportAvailabilityRequest'>
        /// Request body to get the transport availability for given sku.
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
        Task<AzureOperationResponse<RegionConfigurationResponse>> RegionConfigurationWithHttpMessagesAsync(string location, ScheduleAvailabilityRequest scheduleAvailabilityRequest = default(ScheduleAvailabilityRequest), TransportAvailabilityRequest transportAvailabilityRequest = default(TransportAvailabilityRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method provides the list of available skus for the given
        /// subscription and location.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuInformation>>> ListAvailableSkusNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method provides the list of available skus for the given
        /// subscription, resource group and location.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuInformation>>> ListAvailableSkusByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
