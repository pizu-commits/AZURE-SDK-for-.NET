// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of a backup which will be performed. </summary>
    public partial class WebAppBackupInfo : ResourceData
    {
        /// <summary> Initializes a new instance of WebAppBackupInfo. </summary>
        public WebAppBackupInfo()
        {
            Databases = new ChangeTrackingList<AppServiceDatabaseBackupSetting>();
        }

        /// <summary> Initializes a new instance of WebAppBackupInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="backupName"> Name of the backup. </param>
        /// <param name="isEnabled"> True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled. </param>
        /// <param name="storageAccountUri"> SAS URL to the container. </param>
        /// <param name="backupSchedule"> Schedule for the backup if it is executed periodically. </param>
        /// <param name="databases"> Databases included in the backup. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal WebAppBackupInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string backupName, bool? isEnabled, Uri storageAccountUri, WebAppBackupSchedule backupSchedule, IList<AppServiceDatabaseBackupSetting> databases, string kind) : base(id, name, resourceType, systemData)
        {
            BackupName = backupName;
            IsEnabled = isEnabled;
            StorageAccountUri = storageAccountUri;
            BackupSchedule = backupSchedule;
            Databases = databases;
            Kind = kind;
        }

        /// <summary> Name of the backup. </summary>
        public string BackupName { get; set; }
        /// <summary> True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> SAS URL to the container. </summary>
        public Uri StorageAccountUri { get; set; }
        /// <summary> Schedule for the backup if it is executed periodically. </summary>
        public WebAppBackupSchedule BackupSchedule { get; set; }
        /// <summary> Databases included in the backup. </summary>
        public IList<AppServiceDatabaseBackupSetting> Databases { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
