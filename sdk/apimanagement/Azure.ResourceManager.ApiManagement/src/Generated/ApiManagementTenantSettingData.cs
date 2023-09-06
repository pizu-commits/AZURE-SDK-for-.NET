// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementTenantSetting data model.
    /// Tenant Settings.
    /// </summary>
    public partial class ApiManagementTenantSettingData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementTenantSettingData"/>. </summary>
        public ApiManagementTenantSettingData()
        {
            Settings = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementTenantSettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="settings"> Tenant settings. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementTenantSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> settings, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Settings = settings;
            _rawData = rawData;
        }

        /// <summary> Tenant settings. </summary>
        public IDictionary<string, string> Settings { get; }
    }
}
