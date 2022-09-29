// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SiteLogsConfig data model. </summary>
    public partial class SiteLogsConfigData : ResourceData
    {
        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        public SiteLogsConfigData()
        {
        }

        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="applicationLogs"> Application logs configuration. </param>
        /// <param name="httpLogs"> HTTP logs configuration. </param>
        /// <param name="isFailedRequestsTracing"> Failed requests tracing configuration. </param>
        /// <param name="isDetailedErrorMessages"> Detailed error messages configuration. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal SiteLogsConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ApplicationLogsConfig applicationLogs, HttpLogsConfig httpLogs, EnabledConfig isFailedRequestsTracing, EnabledConfig isDetailedErrorMessages, string kind) : base(id, name, resourceType, systemData)
        {
            ApplicationLogs = applicationLogs;
            HttpLogs = httpLogs;
            IsFailedRequestsTracing = isFailedRequestsTracing;
            IsDetailedErrorMessages = isDetailedErrorMessages;
            Kind = kind;
        }

        /// <summary> Application logs configuration. </summary>
        public ApplicationLogsConfig ApplicationLogs { get; set; }
        /// <summary> HTTP logs configuration. </summary>
        public HttpLogsConfig HttpLogs { get; set; }
        /// <summary> Failed requests tracing configuration. </summary>
        internal EnabledConfig IsFailedRequestsTracing { get; set; }
        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? IsFailedRequestsTracingEnabled
        {
            get => IsFailedRequestsTracing is null ? default : IsFailedRequestsTracing.Enabled;
            set
            {
                if (IsFailedRequestsTracing is null)
                    IsFailedRequestsTracing = new EnabledConfig();
                IsFailedRequestsTracing.Enabled = value;
            }
        }

        /// <summary> Detailed error messages configuration. </summary>
        internal EnabledConfig IsDetailedErrorMessages { get; set; }
        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? IsDetailedErrorMessagesEnabled
        {
            get => IsDetailedErrorMessages is null ? default : IsDetailedErrorMessages.Enabled;
            set
            {
                if (IsDetailedErrorMessages is null)
                    IsDetailedErrorMessages = new EnabledConfig();
                IsDetailedErrorMessages.Enabled = value;
            }
        }

        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
