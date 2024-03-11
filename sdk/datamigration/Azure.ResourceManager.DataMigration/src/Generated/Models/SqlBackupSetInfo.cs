// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Information of backup set. </summary>
    public partial class SqlBackupSetInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlBackupSetInfo"/>. </summary>
        internal SqlBackupSetInfo()
        {
            ListOfBackupFiles = new ChangeTrackingList<SqlBackupFileInfo>();
            IgnoreReasons = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlBackupSetInfo"/>. </summary>
        /// <param name="backupSetId"> Backup set id. </param>
        /// <param name="firstLSN"> First LSN of the backup set. </param>
        /// <param name="lastLSN"> Last LSN of the backup set. </param>
        /// <param name="backupType"> Backup type. </param>
        /// <param name="listOfBackupFiles"> List of files in the backup set. </param>
        /// <param name="backupStartOn"> Backup start date. </param>
        /// <param name="backupFinishOn"> Backup end time. </param>
        /// <param name="isBackupRestored"> Whether this backup set has been restored or not. </param>
        /// <param name="hasBackupChecksums"> Has Backup Checksums. </param>
        /// <param name="familyCount"> Media family count. </param>
        /// <param name="ignoreReasons"> The reasons why the backup set is ignored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlBackupSetInfo(Guid? backupSetId, string firstLSN, string lastLSN, string backupType, IReadOnlyList<SqlBackupFileInfo> listOfBackupFiles, DateTimeOffset? backupStartOn, DateTimeOffset? backupFinishOn, bool? isBackupRestored, bool? hasBackupChecksums, int? familyCount, IReadOnlyList<string> ignoreReasons, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackupSetId = backupSetId;
            FirstLSN = firstLSN;
            LastLSN = lastLSN;
            BackupType = backupType;
            ListOfBackupFiles = listOfBackupFiles;
            BackupStartOn = backupStartOn;
            BackupFinishOn = backupFinishOn;
            IsBackupRestored = isBackupRestored;
            HasBackupChecksums = hasBackupChecksums;
            FamilyCount = familyCount;
            IgnoreReasons = ignoreReasons;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Backup set id. </summary>
        public Guid? BackupSetId { get; }
        /// <summary> First LSN of the backup set. </summary>
        public string FirstLSN { get; }
        /// <summary> Last LSN of the backup set. </summary>
        public string LastLSN { get; }
        /// <summary> Backup type. </summary>
        public string BackupType { get; }
        /// <summary> List of files in the backup set. </summary>
        public IReadOnlyList<SqlBackupFileInfo> ListOfBackupFiles { get; }
        /// <summary> Backup start date. </summary>
        public DateTimeOffset? BackupStartOn { get; }
        /// <summary> Backup end time. </summary>
        public DateTimeOffset? BackupFinishOn { get; }
        /// <summary> Whether this backup set has been restored or not. </summary>
        public bool? IsBackupRestored { get; }
        /// <summary> Has Backup Checksums. </summary>
        public bool? HasBackupChecksums { get; }
        /// <summary> Media family count. </summary>
        public int? FamilyCount { get; }
        /// <summary> The reasons why the backup set is ignored. </summary>
        public IReadOnlyList<string> IgnoreReasons { get; }
    }
}
