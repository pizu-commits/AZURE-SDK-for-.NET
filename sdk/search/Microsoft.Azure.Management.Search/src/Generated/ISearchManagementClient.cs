// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Client that can be used to manage Azure Cognitive Search services and
    /// API keys.
    /// </summary>
    public partial interface ISearchManagementClient : System.IDisposable
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
        /// The unique identifier for a Microsoft Azure subscription. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The API version to use for each request. The current version is
        /// 2019-10-01-Preview.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAdminKeysOperations.
        /// </summary>
        IAdminKeysOperations AdminKeys { get; }

        /// <summary>
        /// Gets the IQueryKeysOperations.
        /// </summary>
        IQueryKeysOperations QueryKeys { get; }

        /// <summary>
        /// Gets the IServicesOperations.
        /// </summary>
        IServicesOperations Services { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the ISharedPrivateLinkResourcesOperations.
        /// </summary>
        ISharedPrivateLinkResourcesOperations SharedPrivateLinkResources { get; }

    }
}
