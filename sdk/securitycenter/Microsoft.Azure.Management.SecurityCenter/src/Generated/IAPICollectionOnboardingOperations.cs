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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// APICollectionOnboardingOperations operations.
    /// </summary>
    public partial interface IAPICollectionOnboardingOperations
    {
        /// <summary>
        /// Onboard an Azure API Management API to Defender for APIs
        /// </summary>
        /// <remarks>
        /// Onboard an Azure API Management API to Defender for APIs. The
        /// system will start monitoring the operations within the Azure
        /// Management API for intrusive behaviors and provide alerts for
        /// attacks that have been detected.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiCollectionId'>
        /// A string representing the apiCollections resource within the
        /// Microsoft.Security provider namespace. This string matches the
        /// Azure API Management API name.
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
        Task<AzureOperationResponse<ApiCollectionResponse>> CreateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiCollectionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
