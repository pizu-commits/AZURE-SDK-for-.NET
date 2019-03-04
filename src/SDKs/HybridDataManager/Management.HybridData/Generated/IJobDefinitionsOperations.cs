// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// JobDefinitionsOperations operations.
    /// </summary>
    public partial interface IJobDefinitionsOperations
    {
        /// <summary>
        /// This method gets all the job definitions of the given data service
        /// name.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service type of interest.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobDefinition>>> ListByDataServiceWithHttpMessagesAsync(string dataServiceName, string resourceGroupName, string dataManagerName, ODataQuery<JobDefinitionFilter> odataQuery = default(ODataQuery<JobDefinitionFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method gets job definition object by name.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service name of the job definition
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The job definition name that is being queried.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        Task<AzureOperationResponse<JobDefinition>> GetWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a job definition.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service type of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The job definition name to be created or updated.
        /// </param>
        /// <param name='jobDefinition'>
        /// Job Definition object to be created or updated.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        Task<AzureOperationResponse<JobDefinition>> CreateOrUpdateWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, JobDefinition jobDefinition, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method deletes the given job definition.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service type of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The job definition name to be deleted.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method runs a job instance of the given job definition.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service type of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// Name of the job definition.
        /// </param>
        /// <param name='runParameters'>
        /// Run time parameters for the job definition.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        Task<AzureOperationResponse> RunWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, RunParameters runParameters, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method gets all the job definitions of the given data manager
        /// resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobDefinition>>> ListByDataManagerWithHttpMessagesAsync(string resourceGroupName, string dataManagerName, ODataQuery<JobDefinitionFilter> odataQuery = default(ODataQuery<JobDefinitionFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a job definition.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service type of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The job definition name to be created or updated.
        /// </param>
        /// <param name='jobDefinition'>
        /// Job Definition object to be created or updated.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        Task<AzureOperationResponse<JobDefinition>> BeginCreateOrUpdateWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, JobDefinition jobDefinition, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method deletes the given job definition.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service type of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// The job definition name to be deleted.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method runs a job instance of the given job definition.
        /// </summary>
        /// <param name='dataServiceName'>
        /// The data service type of the job definition.
        /// </param>
        /// <param name='jobDefinitionName'>
        /// Name of the job definition.
        /// </param>
        /// <param name='runParameters'>
        /// Run time parameters for the job definition.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name
        /// </param>
        /// <param name='dataManagerName'>
        /// The name of the DataManager Resource within the specified resource
        /// group. DataManager names must be between 3 and 24 characters in
        /// length and use any alphanumeric and underscore only
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
        Task<AzureOperationResponse> BeginRunWithHttpMessagesAsync(string dataServiceName, string jobDefinitionName, RunParameters runParameters, string resourceGroupName, string dataManagerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method gets all the job definitions of the given data service
        /// name.
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
        Task<AzureOperationResponse<IPage<JobDefinition>>> ListByDataServiceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This method gets all the job definitions of the given data manager
        /// resource.
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
        Task<AzureOperationResponse<IPage<JobDefinition>>> ListByDataManagerNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
