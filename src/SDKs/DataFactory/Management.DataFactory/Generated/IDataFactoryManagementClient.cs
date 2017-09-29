// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IDataFactoryManagementClient : System.IDisposable
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
        /// The subscription identifier.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The API version.
        /// </summary>
        string ApiVersion { get; }

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
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IFactoriesOperations.
        /// </summary>
        IFactoriesOperations Factories { get; }

        /// <summary>
        /// Gets the IIntegrationRuntimesOperations.
        /// </summary>
        IIntegrationRuntimesOperations IntegrationRuntimes { get; }

        /// <summary>
        /// Gets the ILinkedServicesOperations.
        /// </summary>
        ILinkedServicesOperations LinkedServices { get; }

        /// <summary>
        /// Gets the IDatasetsOperations.
        /// </summary>
        IDatasetsOperations Datasets { get; }

        /// <summary>
        /// Gets the IPipelinesOperations.
        /// </summary>
        IPipelinesOperations Pipelines { get; }

        /// <summary>
        /// Gets the IPipelineRunsOperations.
        /// </summary>
        IPipelineRunsOperations PipelineRuns { get; }

        /// <summary>
        /// Gets the IActivityRunsOperations.
        /// </summary>
        IActivityRunsOperations ActivityRuns { get; }

        /// <summary>
        /// Gets the ITriggersOperations.
        /// </summary>
        ITriggersOperations Triggers { get; }

    }
}
