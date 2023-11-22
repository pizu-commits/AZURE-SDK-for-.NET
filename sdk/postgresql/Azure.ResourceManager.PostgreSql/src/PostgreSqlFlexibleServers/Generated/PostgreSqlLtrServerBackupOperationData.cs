// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing the PostgreSqlLtrServerBackupOperation data model.
    /// Response for the LTR backup Operation API call
    /// </summary>
    public partial class PostgreSqlLtrServerBackupOperationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlLtrServerBackupOperationData"/>. </summary>
        public PostgreSqlLtrServerBackupOperationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlLtrServerBackupOperationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="datasourceSizeInBytes"> Size of datasource in bytes. </param>
        /// <param name="dataTransferredInBytes"> Data transferred in bytes. </param>
        /// <param name="backupName"> Name of Backup operation. </param>
        /// <param name="backupMetadata"> Metadata to be stored in RP. Store everything that will be required to perform a successful restore using this Recovery point. e.g. Versions, DataFormat etc. </param>
        /// <param name="status"> Service-set extensible enum indicating the status of operation. </param>
        /// <param name="startOn"> Start time of the operation. </param>
        /// <param name="endOn"> End time of the operation. </param>
        /// <param name="percentComplete"> PercentageCompleted. </param>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorMessage"> The error message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlLtrServerBackupOperationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, long? datasourceSizeInBytes, long? dataTransferredInBytes, string backupName, string backupMetadata, PostgreSqlExecutionStatus? status, DateTimeOffset? startOn, DateTimeOffset? endOn, double? percentComplete, string errorCode, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DatasourceSizeInBytes = datasourceSizeInBytes;
            DataTransferredInBytes = dataTransferredInBytes;
            BackupName = backupName;
            BackupMetadata = backupMetadata;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            PercentComplete = percentComplete;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Size of datasource in bytes. </summary>
        public long? DatasourceSizeInBytes { get; set; }
        /// <summary> Data transferred in bytes. </summary>
        public long? DataTransferredInBytes { get; set; }
        /// <summary> Name of Backup operation. </summary>
        public string BackupName { get; set; }
        /// <summary> Metadata to be stored in RP. Store everything that will be required to perform a successful restore using this Recovery point. e.g. Versions, DataFormat etc. </summary>
        public string BackupMetadata { get; set; }
        /// <summary> Service-set extensible enum indicating the status of operation. </summary>
        public PostgreSqlExecutionStatus? Status { get; set; }
        /// <summary> Start time of the operation. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the operation. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> PercentageCompleted. </summary>
        public double? PercentComplete { get; set; }
        /// <summary> The error code. </summary>
        public string ErrorCode { get; }
        /// <summary> The error message. </summary>
        public string ErrorMessage { get; }
    }
}
