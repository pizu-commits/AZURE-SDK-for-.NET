// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Role based access control provides you a way to apply granular level
    /// policy administration down to individual resources or resource groups.
    /// These operations enable you to manage role definitions and role
    /// assignments. A role definition describes the set of actions that can be
    /// performed on resources. A role assignment grants access to Azure Active
    /// Directory users.
    /// </summary>
    public partial interface IAuthorizationManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IClassicAdministratorsOperations.
        /// </summary>
        IClassicAdministratorsOperations ClassicAdministrators { get; }

        /// <summary>
        /// Gets the IPermissionsOperations.
        /// </summary>
        IPermissionsOperations Permissions { get; }

        /// <summary>
        /// Gets the IProviderOperationsMetadataOperations.
        /// </summary>
        IProviderOperationsMetadataOperations ProviderOperationsMetadata { get; }

        /// <summary>
        /// Gets the IRoleDefinitionsOperations.
        /// </summary>
        IRoleDefinitionsOperations RoleDefinitions { get; }

        /// <summary>
        /// Gets the IRoleAssignmentsOperations.
        /// </summary>
        IRoleAssignmentsOperations RoleAssignments { get; }

    }
}
