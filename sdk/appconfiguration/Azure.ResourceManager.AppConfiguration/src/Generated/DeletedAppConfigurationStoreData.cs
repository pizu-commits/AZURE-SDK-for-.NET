// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing the DeletedAppConfigurationStore data model.
    /// Deleted configuration store information with extended details.
    /// </summary>
    public partial class DeletedAppConfigurationStoreData : ResourceData
    {
        /// <summary> Initializes a new instance of DeletedAppConfigurationStoreData. </summary>
        internal DeletedAppConfigurationStoreData()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DeletedAppConfigurationStoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="configurationStoreId"> The resource id of the original configuration store. </param>
        /// <param name="location"> The location of the original configuration store. </param>
        /// <param name="deletedOn"> The deleted date. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purged date. </param>
        /// <param name="tags"> Tags of the original configuration store. </param>
        /// <param name="isPurgeProtectionEnabled"> Purge protection status of the original configuration store. </param>
        internal DeletedAppConfigurationStoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier configurationStoreId, AzureLocation? location, DateTimeOffset? deletedOn, DateTimeOffset? scheduledPurgeOn, IReadOnlyDictionary<string, string> tags, bool? isPurgeProtectionEnabled) : base(id, name, resourceType, systemData)
        {
            ConfigurationStoreId = configurationStoreId;
            Location = location;
            DeletedOn = deletedOn;
            ScheduledPurgeOn = scheduledPurgeOn;
            Tags = tags;
            IsPurgeProtectionEnabled = isPurgeProtectionEnabled;
        }

        /// <summary> The resource id of the original configuration store. </summary>
        public ResourceIdentifier ConfigurationStoreId { get; }
        /// <summary> The location of the original configuration store. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The deleted date. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The scheduled purged date. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; }
        /// <summary> Tags of the original configuration store. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Purge protection status of the original configuration store. </summary>
        public bool? IsPurgeProtectionEnabled { get; }
    }
}
