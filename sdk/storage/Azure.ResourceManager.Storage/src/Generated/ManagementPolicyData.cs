// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the ManagementPolicy data model. </summary>
    public partial class ManagementPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagementPolicyData. </summary>
        public ManagementPolicyData()
        {
        }

        /// <summary> Initializes a new instance of ManagementPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastModifiedTime"> Returns the date and time the ManagementPolicies was last modified. </param>
        /// <param name="policy"> The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts. </param>
        internal ManagementPolicyData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, DateTimeOffset? lastModifiedTime, ManagementPolicySchema policy) : base(id, name, type, systemData)
        {
            LastModifiedTime = lastModifiedTime;
            Policy = policy;
        }

        /// <summary> Returns the date and time the ManagementPolicies was last modified. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
        /// <summary> The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts. </summary>
        internal ManagementPolicySchema Policy { get; set; }
        /// <summary> The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts. </summary>
        public IList<ManagementPolicyRule> Rules
        {
            get => Policy is null ? default : Policy.Rules;
            set => Policy = new ManagementPolicySchema(value);
        }
    }
}
