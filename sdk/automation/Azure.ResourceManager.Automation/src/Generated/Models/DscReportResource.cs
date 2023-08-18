// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the DSC Report Resource. </summary>
    public partial class DscReportResource
    {
        /// <summary> Initializes a new instance of DscReportResource. </summary>
        internal DscReportResource()
        {
            DependsOn = new Core.ChangeTrackingList<DscReportResourceNavigation>();
        }

        /// <summary> Initializes a new instance of DscReportResource. </summary>
        /// <param name="resourceId"> Gets or sets the ID of the resource. </param>
        /// <param name="sourceInfo"> Gets or sets the source info of the resource. </param>
        /// <param name="dependsOn"> Gets or sets the Resource Navigation values for resources the resource depends on. </param>
        /// <param name="moduleName"> Gets or sets the module name of the resource. </param>
        /// <param name="moduleVersion"> Gets or sets the module version of the resource. </param>
        /// <param name="resourceName"> Gets or sets the name of the resource. </param>
        /// <param name="error"> Gets or sets the error of the resource. </param>
        /// <param name="status"> Gets or sets the status of the resource. </param>
        /// <param name="durationInSeconds"> Gets or sets the duration in seconds for the resource. </param>
        /// <param name="startOn"> Gets or sets the start date of the resource. </param>
        internal DscReportResource(string resourceId, string sourceInfo, IReadOnlyList<DscReportResourceNavigation> dependsOn, string moduleName, string moduleVersion, string resourceName, string error, string status, double? durationInSeconds, DateTimeOffset? startOn)
        {
            ResourceId = resourceId;
            SourceInfo = sourceInfo;
            DependsOn = dependsOn;
            ModuleName = moduleName;
            ModuleVersion = moduleVersion;
            ResourceName = resourceName;
            Error = error;
            Status = status;
            DurationInSeconds = durationInSeconds;
            StartOn = startOn;
        }

        /// <summary> Gets or sets the ID of the resource. </summary>
        public string ResourceId { get; }
        /// <summary> Gets or sets the source info of the resource. </summary>
        public string SourceInfo { get; }
        /// <summary> Gets or sets the Resource Navigation values for resources the resource depends on. </summary>
        public IReadOnlyList<DscReportResourceNavigation> DependsOn { get; }
        /// <summary> Gets or sets the module name of the resource. </summary>
        public string ModuleName { get; }
        /// <summary> Gets or sets the module version of the resource. </summary>
        public string ModuleVersion { get; }
        /// <summary> Gets or sets the name of the resource. </summary>
        public string ResourceName { get; }
        /// <summary> Gets or sets the error of the resource. </summary>
        public string Error { get; }
        /// <summary> Gets or sets the status of the resource. </summary>
        public string Status { get; }
        /// <summary> Gets or sets the duration in seconds for the resource. </summary>
        public double? DurationInSeconds { get; }
        /// <summary> Gets or sets the start date of the resource. </summary>
        public DateTimeOffset? StartOn { get; }
    }
}
