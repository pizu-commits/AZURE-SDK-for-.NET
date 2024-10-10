// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe. </summary>
    public readonly partial struct VolumeDefinitionType : IEquatable<VolumeDefinitionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VolumeDefinitionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VolumeDefinitionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BindValue = "bind";
        private const string VolumeValue = "volume";
        private const string TmpfsValue = "tmpfs";
        private const string NpipeValue = "npipe";

        /// <summary> bind. </summary>
        public static VolumeDefinitionType Bind { get; } = new VolumeDefinitionType(BindValue);
        /// <summary> volume. </summary>
        public static VolumeDefinitionType Volume { get; } = new VolumeDefinitionType(VolumeValue);
        /// <summary> tmpfs. </summary>
        public static VolumeDefinitionType Tmpfs { get; } = new VolumeDefinitionType(TmpfsValue);
        /// <summary> npipe. </summary>
        public static VolumeDefinitionType Npipe { get; } = new VolumeDefinitionType(NpipeValue);
        /// <summary> Determines if two <see cref="VolumeDefinitionType"/> values are the same. </summary>
        public static bool operator ==(VolumeDefinitionType left, VolumeDefinitionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VolumeDefinitionType"/> values are not the same. </summary>
        public static bool operator !=(VolumeDefinitionType left, VolumeDefinitionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VolumeDefinitionType"/>. </summary>
        public static implicit operator VolumeDefinitionType(string value) => new VolumeDefinitionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VolumeDefinitionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VolumeDefinitionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
