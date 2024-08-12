// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Type of the Update. </summary>
    public readonly partial struct DataBoxEdgeUpdateType : IEquatable<DataBoxEdgeUpdateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeUpdateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeUpdateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SoftwareValue = "Software";
        private const string KubernetesValue = "Kubernetes";
        private const string FirmwareValue = "Firmware";

        /// <summary> Software. </summary>
        public static DataBoxEdgeUpdateType Software { get; } = new DataBoxEdgeUpdateType(SoftwareValue);
        /// <summary> Kubernetes. </summary>
        public static DataBoxEdgeUpdateType Kubernetes { get; } = new DataBoxEdgeUpdateType(KubernetesValue);
        /// <summary> Firmware. </summary>
        public static DataBoxEdgeUpdateType Firmware { get; } = new DataBoxEdgeUpdateType(FirmwareValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeUpdateType"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeUpdateType left, DataBoxEdgeUpdateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeUpdateType"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeUpdateType left, DataBoxEdgeUpdateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoxEdgeUpdateType"/>. </summary>
        public static implicit operator DataBoxEdgeUpdateType(string value) => new DataBoxEdgeUpdateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeUpdateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeUpdateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
