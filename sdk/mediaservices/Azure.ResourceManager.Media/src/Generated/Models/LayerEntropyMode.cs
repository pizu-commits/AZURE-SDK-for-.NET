// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The entropy mode to be used for this layer. If not specified, the encoder chooses the mode that is appropriate for the profile and level. </summary>
    public readonly partial struct LayerEntropyMode : IEquatable<LayerEntropyMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LayerEntropyMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LayerEntropyMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CabacValue = "Cabac";
        private const string CavlcValue = "Cavlc";

        /// <summary> Context Adaptive Binary Arithmetic Coder (CABAC) entropy encoding. </summary>
        public static LayerEntropyMode Cabac { get; } = new LayerEntropyMode(CabacValue);
        /// <summary> Context Adaptive Variable Length Coder (CAVLC) entropy encoding. </summary>
        public static LayerEntropyMode Cavlc { get; } = new LayerEntropyMode(CavlcValue);
        /// <summary> Determines if two <see cref="LayerEntropyMode"/> values are the same. </summary>
        public static bool operator ==(LayerEntropyMode left, LayerEntropyMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LayerEntropyMode"/> values are not the same. </summary>
        public static bool operator !=(LayerEntropyMode left, LayerEntropyMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LayerEntropyMode"/>. </summary>
        public static implicit operator LayerEntropyMode(string value) => new LayerEntropyMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LayerEntropyMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LayerEntropyMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
