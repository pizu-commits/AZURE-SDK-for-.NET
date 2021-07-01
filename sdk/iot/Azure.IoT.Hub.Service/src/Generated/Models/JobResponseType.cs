// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The job type. </summary>
    public readonly partial struct JobResponseType : IEquatable<JobResponseType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobResponseType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobResponseType(string value)
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
        public static JobResponseType Unknown { get; } = new JobResponseType(UnknownValue);
        /// <summary> export. </summary>
        public static JobResponseType Export { get; } = new JobResponseType(ExportValue);
        /// <summary> import. </summary>
        public static JobResponseType Import { get; } = new JobResponseType(ImportValue);
        /// <summary> backup. </summary>
        public static JobResponseType Backup { get; } = new JobResponseType(BackupValue);
        /// <summary> readDeviceProperties. </summary>
        public static JobResponseType ReadDeviceProperties { get; } = new JobResponseType(ReadDevicePropertiesValue);
        /// <summary> writeDeviceProperties. </summary>
        public static JobResponseType WriteDeviceProperties { get; } = new JobResponseType(WriteDevicePropertiesValue);
        /// <summary> updateDeviceConfiguration. </summary>
        public static JobResponseType UpdateDeviceConfiguration { get; } = new JobResponseType(UpdateDeviceConfigurationValue);
        /// <summary> rebootDevice. </summary>
        public static JobResponseType RebootDevice { get; } = new JobResponseType(RebootDeviceValue);
        /// <summary> factoryResetDevice. </summary>
        public static JobResponseType FactoryResetDevice { get; } = new JobResponseType(FactoryResetDeviceValue);
        /// <summary> firmwareUpdate. </summary>
        public static JobResponseType FirmwareUpdate { get; } = new JobResponseType(FirmwareUpdateValue);
        /// <summary> scheduleDeviceMethod. </summary>
        public static JobResponseType ScheduleDeviceMethod { get; } = new JobResponseType(ScheduleDeviceMethodValue);
        /// <summary> scheduleUpdateTwin. </summary>
        public static JobResponseType ScheduleUpdateTwin { get; } = new JobResponseType(ScheduleUpdateTwinValue);
        /// <summary> restoreFromBackup. </summary>
        public static JobResponseType RestoreFromBackup { get; } = new JobResponseType(RestoreFromBackupValue);
        /// <summary> failoverDataCopy. </summary>
        public static JobResponseType FailoverDataCopy { get; } = new JobResponseType(FailoverDataCopyValue);
        /// <summary> Determines if two <see cref="JobResponseType"/> values are the same. </summary>
        public static bool operator ==(JobResponseType left, JobResponseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobResponseType"/> values are not the same. </summary>
        public static bool operator !=(JobResponseType left, JobResponseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobResponseType"/>. </summary>
        public static implicit operator JobResponseType(string value) => new JobResponseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobResponseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobResponseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
