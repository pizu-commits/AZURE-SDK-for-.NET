// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The state of integration runtime auto update. </summary>
    public readonly partial struct SynapseIntegrationRuntimeAutoUpdate : IEquatable<SynapseIntegrationRuntimeAutoUpdate>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeAutoUpdate"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseIntegrationRuntimeAutoUpdate(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "On";
        private const string OffValue = "Off";

        /// <summary> On. </summary>
        public static SynapseIntegrationRuntimeAutoUpdate On { get; } = new SynapseIntegrationRuntimeAutoUpdate(OnValue);
        /// <summary> Off. </summary>
        public static SynapseIntegrationRuntimeAutoUpdate Off { get; } = new SynapseIntegrationRuntimeAutoUpdate(OffValue);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeAutoUpdate"/> values are the same. </summary>
        public static bool operator ==(SynapseIntegrationRuntimeAutoUpdate left, SynapseIntegrationRuntimeAutoUpdate right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeAutoUpdate"/> values are not the same. </summary>
        public static bool operator !=(SynapseIntegrationRuntimeAutoUpdate left, SynapseIntegrationRuntimeAutoUpdate right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseIntegrationRuntimeAutoUpdate"/>. </summary>
        public static implicit operator SynapseIntegrationRuntimeAutoUpdate(string value) => new SynapseIntegrationRuntimeAutoUpdate(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseIntegrationRuntimeAutoUpdate other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseIntegrationRuntimeAutoUpdate other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
