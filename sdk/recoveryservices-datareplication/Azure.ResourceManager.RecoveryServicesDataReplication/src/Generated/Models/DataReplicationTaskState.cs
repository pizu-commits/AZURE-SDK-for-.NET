// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Gets or sets the task state. </summary>
    public readonly partial struct DataReplicationTaskState : IEquatable<DataReplicationTaskState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataReplicationTaskState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataReplicationTaskState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string StartedValue = "Started";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";
        private const string SkippedValue = "Skipped";

        /// <summary> Pending. </summary>
        public static DataReplicationTaskState Pending { get; } = new DataReplicationTaskState(PendingValue);
        /// <summary> Started. </summary>
        public static DataReplicationTaskState Started { get; } = new DataReplicationTaskState(StartedValue);
        /// <summary> Succeeded. </summary>
        public static DataReplicationTaskState Succeeded { get; } = new DataReplicationTaskState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DataReplicationTaskState Failed { get; } = new DataReplicationTaskState(FailedValue);
        /// <summary> Cancelled. </summary>
        public static DataReplicationTaskState Cancelled { get; } = new DataReplicationTaskState(CancelledValue);
        /// <summary> Skipped. </summary>
        public static DataReplicationTaskState Skipped { get; } = new DataReplicationTaskState(SkippedValue);
        /// <summary> Determines if two <see cref="DataReplicationTaskState"/> values are the same. </summary>
        public static bool operator ==(DataReplicationTaskState left, DataReplicationTaskState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataReplicationTaskState"/> values are not the same. </summary>
        public static bool operator !=(DataReplicationTaskState left, DataReplicationTaskState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataReplicationTaskState"/>. </summary>
        public static implicit operator DataReplicationTaskState(string value) => new DataReplicationTaskState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataReplicationTaskState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataReplicationTaskState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
