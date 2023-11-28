// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure File Share workload specific backup copy. </summary>
    public partial class FileShareRecoveryPoint : BackupGenericRecoveryPoint
    {
        /// <summary> Initializes a new instance of <see cref="FileShareRecoveryPoint"/>. </summary>
        public FileShareRecoveryPoint()
        {
            ObjectType = "AzureFileShareRecoveryPoint";
        }

        /// <summary> Initializes a new instance of <see cref="FileShareRecoveryPoint"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryPointType"> Type of the backup copy. Specifies whether it is a crash consistent backup or app consistent. </param>
        /// <param name="recoveryPointOn"> Time at which this backup copy was created. </param>
        /// <param name="fileShareSnapshotUri"> Contains Url to the snapshot of fileshare, if applicable. </param>
        /// <param name="recoveryPointSizeInGB"> Contains recovery point size. </param>
        /// <param name="recoveryPointProperties"> Properties of Recovery Point. </param>
        internal FileShareRecoveryPoint(string objectType, string recoveryPointType, DateTimeOffset? recoveryPointOn, Uri fileShareSnapshotUri, int? recoveryPointSizeInGB, RecoveryPointProperties recoveryPointProperties) : base(objectType)
        {
            RecoveryPointType = recoveryPointType;
            RecoveryPointOn = recoveryPointOn;
            FileShareSnapshotUri = fileShareSnapshotUri;
            RecoveryPointSizeInGB = recoveryPointSizeInGB;
            RecoveryPointProperties = recoveryPointProperties;
            ObjectType = objectType ?? "AzureFileShareRecoveryPoint";
        }

        /// <summary> Type of the backup copy. Specifies whether it is a crash consistent backup or app consistent. </summary>
        public string RecoveryPointType { get; set; }
        /// <summary> Time at which this backup copy was created. </summary>
        public DateTimeOffset? RecoveryPointOn { get; set; }
        /// <summary> Contains Url to the snapshot of fileshare, if applicable. </summary>
        public Uri FileShareSnapshotUri { get; set; }
        /// <summary> Contains recovery point size. </summary>
        public int? RecoveryPointSizeInGB { get; set; }
        /// <summary> Properties of Recovery Point. </summary>
        public RecoveryPointProperties RecoveryPointProperties { get; set; }
    }
}
