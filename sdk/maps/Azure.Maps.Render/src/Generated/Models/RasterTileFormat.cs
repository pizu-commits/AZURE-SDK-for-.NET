// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Render
{
    /// <summary> The RasterTileFormat. </summary>
    internal readonly partial struct RasterTileFormat : IEquatable<RasterTileFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RasterTileFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RasterTileFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PngValue = "png";

        /// <summary> An image in the png format. Supports zoom levels 0 through 18. </summary>
        public static RasterTileFormat Png { get; } = new RasterTileFormat(PngValue);
        /// <summary> Determines if two <see cref="RasterTileFormat"/> values are the same. </summary>
        public static bool operator ==(RasterTileFormat left, RasterTileFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RasterTileFormat"/> values are not the same. </summary>
        public static bool operator !=(RasterTileFormat left, RasterTileFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RasterTileFormat"/>. </summary>
        public static implicit operator RasterTileFormat(string value) => new RasterTileFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RasterTileFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RasterTileFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
