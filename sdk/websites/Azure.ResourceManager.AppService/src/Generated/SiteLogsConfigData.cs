// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SiteLogsConfig data model. </summary>
    public partial class SiteLogsConfigData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        public SiteLogsConfigData()
        {
        }

        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="applicationLogs"> Application logs configuration. </param>
        /// <param name="httpLogs"> HTTP logs configuration. </param>
        /// <param name="failedRequestsTracing"> Failed requests tracing configuration. </param>
        /// <param name="detailedErrorMessages"> Detailed error messages configuration. </param>
        internal SiteLogsConfigData(ResourceIdentifier id, string name, ResourceType type, string kind, ApplicationLogsConfig applicationLogs, HttpLogsConfig httpLogs, EnabledConfig failedRequestsTracing, EnabledConfig detailedErrorMessages) : base(id, name, type, kind)
        {
            ApplicationLogs = applicationLogs;
            HttpLogs = httpLogs;
            FailedRequestsTracing = failedRequestsTracing;
            DetailedErrorMessages = detailedErrorMessages;
        }

        /// <summary> Application logs configuration. </summary>
        public ApplicationLogsConfig ApplicationLogs { get; set; }
        /// <summary> HTTP logs configuration. </summary>
        public HttpLogsConfig HttpLogs { get; set; }
        /// <summary> Failed requests tracing configuration. </summary>
        public EnabledConfig FailedRequestsTracing { get; set; }
        /// <summary> Detailed error messages configuration. </summary>
        public EnabledConfig DetailedErrorMessages { get; set; }
    }
}
