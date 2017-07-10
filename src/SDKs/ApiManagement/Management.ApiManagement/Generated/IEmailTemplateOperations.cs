// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// EmailTemplateOperations operations.
    /// </summary>
    public partial interface IEmailTemplateOperations
    {
        /// <summary>
        /// Lists a collection of properties defined within a service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='top'>
        /// Number of records to return.
        /// </param>
        /// <param name='skip'>
        /// Number of records to skip.
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
        Task<AzureOperationResponse<IPage<EmailTemplateContract>>> ListByServiceWithHttpMessagesAsync(string resourceGroupName, string serviceName, int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of the email template specified by its identifier.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='templateName'>
        /// Email Template Name Identifier. Possible values include:
        /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
        /// 'quotaLimitApproachingDeveloperNotificationMessage',
        /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
        /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
        /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
        /// 'purchaseDeveloperNotificationMessage',
        /// 'passwordResetIdentityDefault',
        /// 'passwordResetByAdminNotificationMessage',
        /// 'rejectDeveloperNotificationMessage',
        /// 'requestDeveloperNotificationMessage'
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
        Task<AzureOperationResponse<EmailTemplateContract,EmailTemplateGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, string templateName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an Email Template.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='templateName'>
        /// Email Template Name Identifier. Possible values include:
        /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
        /// 'quotaLimitApproachingDeveloperNotificationMessage',
        /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
        /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
        /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
        /// 'purchaseDeveloperNotificationMessage',
        /// 'passwordResetIdentityDefault',
        /// 'passwordResetByAdminNotificationMessage',
        /// 'rejectDeveloperNotificationMessage',
        /// 'requestDeveloperNotificationMessage'
        /// </param>
        /// <param name='parameters'>
        /// Email Template update parameters.
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
        Task<AzureOperationResponse<EmailTemplateContract>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string templateName, EmailTemplateUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specific Email Template.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='templateName'>
        /// Email Template Name Identifier. Possible values include:
        /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
        /// 'quotaLimitApproachingDeveloperNotificationMessage',
        /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
        /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
        /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
        /// 'purchaseDeveloperNotificationMessage',
        /// 'passwordResetIdentityDefault',
        /// 'passwordResetByAdminNotificationMessage',
        /// 'rejectDeveloperNotificationMessage',
        /// 'requestDeveloperNotificationMessage'
        /// </param>
        /// <param name='parameters'>
        /// Update parameters.
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
        Task<AzureOperationResponse> UpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string templateName, EmailTemplateUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reset the Email Template to default template provided by the API
        /// Management service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='templateName'>
        /// Email Template Name Identifier. Possible values include:
        /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
        /// 'quotaLimitApproachingDeveloperNotificationMessage',
        /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
        /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
        /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
        /// 'purchaseDeveloperNotificationMessage',
        /// 'passwordResetIdentityDefault',
        /// 'passwordResetByAdminNotificationMessage',
        /// 'rejectDeveloperNotificationMessage',
        /// 'requestDeveloperNotificationMessage'
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (Etag) version of the Email Template to delete. A
        /// value of "*" can be used for If-Match to unconditionally apply the
        /// operation.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, string templateName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists a collection of properties defined within a service instance.
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
        Task<AzureOperationResponse<IPage<EmailTemplateContract>>> ListByServiceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
