// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Service level objectives for performance tier. </summary>
    public partial class MySqlPerformanceTierServiceLevelObjectives
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

        /// <summary> Initializes a new instance of <see cref="MySqlPerformanceTierServiceLevelObjectives"/>. </summary>
        internal MySqlPerformanceTierServiceLevelObjectives()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlPerformanceTierServiceLevelObjectives"/>. </summary>
        /// <param name="id"> ID for the service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCores"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="maxBackupRetentionDays"> Maximum Backup retention in days for the performance tier edition. </param>
        /// <param name="minBackupRetentionDays"> Minimum Backup retention in days for the performance tier edition. </param>
        /// <param name="maxStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlPerformanceTierServiceLevelObjectives(string id, string edition, int? vCores, string hardwareGeneration, int? maxBackupRetentionDays, int? minBackupRetentionDays, int? maxStorageInMB, int? minStorageInMB, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Edition = edition;
            VCores = vCores;
            HardwareGeneration = hardwareGeneration;
            MaxBackupRetentionDays = maxBackupRetentionDays;
            MinBackupRetentionDays = minBackupRetentionDays;
            MaxStorageInMB = maxStorageInMB;
            MinStorageInMB = minStorageInMB;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID for the service level objective. </summary>
        public string Id { get; }
        /// <summary> Edition of the performance tier. </summary>
        public string Edition { get; }
        /// <summary> vCore associated with the service level objective. </summary>
        public int? VCores { get; }
        /// <summary> Hardware generation associated with the service level objective. </summary>
        public string HardwareGeneration { get; }
        /// <summary> Maximum Backup retention in days for the performance tier edition. </summary>
        public int? MaxBackupRetentionDays { get; }
        /// <summary> Minimum Backup retention in days for the performance tier edition. </summary>
        public int? MinBackupRetentionDays { get; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? MaxStorageInMB { get; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? MinStorageInMB { get; }
    }
}
