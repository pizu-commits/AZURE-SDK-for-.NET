// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationModule data model.
    /// Definition of the module type.
    /// </summary>
    public partial class AutomationModuleData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationModuleData"/>. </summary>
        /// <param name="location"> The location. </param>
        public AutomationModuleData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationModuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Gets or sets the etag of the resource. </param>
        /// <param name="isGlobal"> Gets or sets the isGlobal flag of the module. </param>
        /// <param name="version"> Gets or sets the version of the module. </param>
        /// <param name="sizeInBytes"> Gets or sets the size in bytes of the module. </param>
        /// <param name="activityCount"> Gets or sets the activity count of the module. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state of the module. </param>
        /// <param name="contentLink"> Gets or sets the contentLink of the module. </param>
        /// <param name="error"> Gets or sets the error info of the module. </param>
        /// <param name="createdOn"> Gets or sets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time. </param>
        /// <param name="description"> Gets or sets the description. </param>
        /// <param name="isComposite"> Gets or sets type of module, if its composite or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationModuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, bool? isGlobal, string version, long? sizeInBytes, int? activityCount, ModuleProvisioningState? provisioningState, AutomationContentLink contentLink, AutomationModuleErrorInfo error, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string description, bool? isComposite, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            IsGlobal = isGlobal;
            Version = version;
            SizeInBytes = sizeInBytes;
            ActivityCount = activityCount;
            ProvisioningState = provisioningState;
            ContentLink = contentLink;
            Error = error;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Description = description;
            IsComposite = isComposite;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationModuleData"/> for deserialization. </summary>
        internal AutomationModuleData()
        {
        }

        /// <summary> Gets or sets the etag of the resource. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Gets or sets the isGlobal flag of the module. </summary>
        public bool? IsGlobal { get; set; }
        /// <summary> Gets or sets the version of the module. </summary>
        public string Version { get; set; }
        /// <summary> Gets or sets the size in bytes of the module. </summary>
        public long? SizeInBytes { get; set; }
        /// <summary> Gets or sets the activity count of the module. </summary>
        public int? ActivityCount { get; set; }
        /// <summary> Gets or sets the provisioning state of the module. </summary>
        public ModuleProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets the contentLink of the module. </summary>
        public AutomationContentLink ContentLink { get; set; }
        /// <summary> Gets or sets the error info of the module. </summary>
        public AutomationModuleErrorInfo Error { get; set; }
        /// <summary> Gets or sets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Gets or sets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets type of module, if its composite or not. </summary>
        public bool? IsComposite { get; set; }
    }
}
