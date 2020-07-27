// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The job type. </summary>
    public readonly partial struct JobRequestType : IEquatable<JobRequestType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobRequestType"/> values are the same. </summary>
        public JobRequestType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string ExportValue = "export";
        private const string ImportValue = "import";
        private const string BackupValue = "backup";
        private const string ReadDevicePropertiesValue = "readDeviceProperties";
        private const string WriteDevicePropertiesValue = "writeDeviceProperties";
        private const string UpdateDeviceConfigurationValue = "updateDeviceConfiguration";
        private const string RebootDeviceValue = "rebootDevice";
        private const string FactoryResetDeviceValue = "factoryResetDevice";
        private const string FirmwareUpdateValue = "firmwareUpdate";
        private const string ScheduleDeviceMethodValue = "scheduleDeviceMethod";
        private const string ScheduleUpdateTwinValue = "scheduleUpdateTwin";
        private const string RestoreFromBackupValue = "restoreFromBackup";
        private const string FailoverDataCopyValue = "failoverDataCopy";

        /// <summary> unknown. </summary>
        public static JobRequestType Unknown { get; } = new JobRequestType(UnknownValue);
        /// <summary> export. </summary>
        public static JobRequestType Export { get; } = new JobRequestType(ExportValue);
        /// <summary> import. </summary>
        public static JobRequestType Import { get; } = new JobRequestType(ImportValue);
        /// <summary> backup. </summary>
        public static JobRequestType Backup { get; } = new JobRequestType(BackupValue);
        /// <summary> readDeviceProperties. </summary>
        public static JobRequestType ReadDeviceProperties { get; } = new JobRequestType(ReadDevicePropertiesValue);
        /// <summary> writeDeviceProperties. </summary>
        public static JobRequestType WriteDeviceProperties { get; } = new JobRequestType(WriteDevicePropertiesValue);
        /// <summary> updateDeviceConfiguration. </summary>
        public static JobRequestType UpdateDeviceConfiguration { get; } = new JobRequestType(UpdateDeviceConfigurationValue);
        /// <summary> rebootDevice. </summary>
        public static JobRequestType RebootDevice { get; } = new JobRequestType(RebootDeviceValue);
        /// <summary> factoryResetDevice. </summary>
        public static JobRequestType FactoryResetDevice { get; } = new JobRequestType(FactoryResetDeviceValue);
        /// <summary> firmwareUpdate. </summary>
        public static JobRequestType FirmwareUpdate { get; } = new JobRequestType(FirmwareUpdateValue);
        /// <summary> scheduleDeviceMethod. </summary>
        public static JobRequestType ScheduleDeviceMethod { get; } = new JobRequestType(ScheduleDeviceMethodValue);
        /// <summary> scheduleUpdateTwin. </summary>
        public static JobRequestType ScheduleUpdateTwin { get; } = new JobRequestType(ScheduleUpdateTwinValue);
        /// <summary> restoreFromBackup. </summary>
        public static JobRequestType RestoreFromBackup { get; } = new JobRequestType(RestoreFromBackupValue);
        /// <summary> failoverDataCopy. </summary>
        public static JobRequestType FailoverDataCopy { get; } = new JobRequestType(FailoverDataCopyValue);
        /// <summary> Determines if two <see cref="JobRequestType"/> values are the same. </summary>
        public static bool operator ==(JobRequestType left, JobRequestType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobRequestType"/> values are not the same. </summary>
        public static bool operator !=(JobRequestType left, JobRequestType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobRequestType"/>. </summary>
        public static implicit operator JobRequestType(string value) => new JobRequestType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobRequestType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobRequestType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
