// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Tells source of creation of lab virtual machine. Output property only. </summary>
    public readonly partial struct DevTestLabVmCreationSource : IEquatable<DevTestLabVmCreationSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmCreationSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabVmCreationSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FromCustomImageValue = "FromCustomImage";
        private const string FromGalleryImageValue = "FromGalleryImage";
        private const string FromSharedGalleryImageValue = "FromSharedGalleryImage";

        /// <summary> FromCustomImage. </summary>
        public static DevTestLabVmCreationSource FromCustomImage { get; } = new DevTestLabVmCreationSource(FromCustomImageValue);
        /// <summary> FromGalleryImage. </summary>
        public static DevTestLabVmCreationSource FromGalleryImage { get; } = new DevTestLabVmCreationSource(FromGalleryImageValue);
        /// <summary> FromSharedGalleryImage. </summary>
        public static DevTestLabVmCreationSource FromSharedGalleryImage { get; } = new DevTestLabVmCreationSource(FromSharedGalleryImageValue);
        /// <summary> Determines if two <see cref="DevTestLabVmCreationSource"/> values are the same. </summary>
        public static bool operator ==(DevTestLabVmCreationSource left, DevTestLabVmCreationSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabVmCreationSource"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabVmCreationSource left, DevTestLabVmCreationSource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevTestLabVmCreationSource"/>. </summary>
        public static implicit operator DevTestLabVmCreationSource(string value) => new DevTestLabVmCreationSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabVmCreationSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabVmCreationSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
