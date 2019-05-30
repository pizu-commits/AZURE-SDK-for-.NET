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
    /// ReplicationRecoveryServicesProvidersOperations operations.
    /// </summary>
    public partial interface IReplicationRecoveryServicesProvidersOperations
    {
        /// <summary>
        /// Gets the list of registered recovery services providers for the
        /// fabric.
        /// </summary>
        /// <remarks>
        /// Lists the registered recovery services providers for the specified
        /// fabric.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name
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
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> ListByReplicationFabricsWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of a recovery services provider.
        /// </summary>
        /// <remarks>
        /// Gets the details of registered recovery services provider.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name
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
        Task<AzureOperationResponse<RecoveryServicesProvider>> GetWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a recovery services provider.
        /// </summary>
        /// <remarks>
        /// The operation to add a recovery services provider.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
        /// </param>
        /// <param name='addProviderInput'>
        /// Add provider input.
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
        Task<AzureOperationResponse<RecoveryServicesProvider>> CreateWithHttpMessagesAsync(string fabricName, string providerName, AddRecoveryServicesProviderInput addProviderInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges recovery service provider from fabric
        /// </summary>
        /// <remarks>
        /// The operation to purge(force delete) a recovery services provider
        /// from the vault.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PurgeWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Refresh details from the recovery services provider.
        /// </summary>
        /// <remarks>
        /// The operation to refresh the information from the recovery services
        /// provider.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
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
        Task<AzureOperationResponse<RecoveryServicesProvider>> RefreshProviderWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes provider from fabric. Note: Deleting provider for any
        /// fabric other than SingleHost is unsupported. To maintain backward
        /// compatibility for released clients the object "deleteRspInput" is
        /// used (if the object is empty we assume that it is old client and
        /// continue the old behavior).
        /// </summary>
        /// <remarks>
        /// The operation to removes/delete(unregister) a recovery services
        /// provider from the vault
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of registered recovery services providers in the
        /// vault. This is a view only api.
        /// </summary>
        /// <remarks>
        /// Lists the registered recovery services providers in the vault
        /// </remarks>
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
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a recovery services provider.
        /// </summary>
        /// <remarks>
        /// The operation to add a recovery services provider.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
        /// </param>
        /// <param name='addProviderInput'>
        /// Add provider input.
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
        Task<AzureOperationResponse<RecoveryServicesProvider>> BeginCreateWithHttpMessagesAsync(string fabricName, string providerName, AddRecoveryServicesProviderInput addProviderInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges recovery service provider from fabric
        /// </summary>
        /// <remarks>
        /// The operation to purge(force delete) a recovery services provider
        /// from the vault.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginPurgeWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Refresh details from the recovery services provider.
        /// </summary>
        /// <remarks>
        /// The operation to refresh the information from the recovery services
        /// provider.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
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
        Task<AzureOperationResponse<RecoveryServicesProvider>> BeginRefreshProviderWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes provider from fabric. Note: Deleting provider for any
        /// fabric other than SingleHost is unsupported. To maintain backward
        /// compatibility for released clients the object "deleteRspInput" is
        /// used (if the object is empty we assume that it is old client and
        /// continue the old behavior).
        /// </summary>
        /// <remarks>
        /// The operation to removes/delete(unregister) a recovery services
        /// provider from the vault
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Recovery services provider name.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of registered recovery services providers for the
        /// fabric.
        /// </summary>
        /// <remarks>
        /// Lists the registered recovery services providers for the specified
        /// fabric.
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
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> ListByReplicationFabricsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of registered recovery services providers in the
        /// vault. This is a view only api.
        /// </summary>
        /// <remarks>
        /// Lists the registered recovery services providers in the vault
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
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
