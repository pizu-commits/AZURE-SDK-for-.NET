// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The replication mode of a distributed availability group. Parameter will be ignored during link creation. </summary>
    public readonly partial struct DistributedAvailabilityGroupReplicationMode : IEquatable<DistributedAvailabilityGroupReplicationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DistributedAvailabilityGroupReplicationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DistributedAvailabilityGroupReplicationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AsyncValue = "Async";
        private const string SyncValue = "Sync";

        /// <summary> Async. </summary>
        public static DistributedAvailabilityGroupReplicationMode Async { get; } = new DistributedAvailabilityGroupReplicationMode(AsyncValue);
        /// <summary> Sync. </summary>
        public static DistributedAvailabilityGroupReplicationMode Sync { get; } = new DistributedAvailabilityGroupReplicationMode(SyncValue);
        /// <summary> Determines if two <see cref="DistributedAvailabilityGroupReplicationMode"/> values are the same. </summary>
        public static bool operator ==(DistributedAvailabilityGroupReplicationMode left, DistributedAvailabilityGroupReplicationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DistributedAvailabilityGroupReplicationMode"/> values are not the same. </summary>
        public static bool operator !=(DistributedAvailabilityGroupReplicationMode left, DistributedAvailabilityGroupReplicationMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DistributedAvailabilityGroupReplicationMode"/>. </summary>
        public static implicit operator DistributedAvailabilityGroupReplicationMode(string value) => new DistributedAvailabilityGroupReplicationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DistributedAvailabilityGroupReplicationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DistributedAvailabilityGroupReplicationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
