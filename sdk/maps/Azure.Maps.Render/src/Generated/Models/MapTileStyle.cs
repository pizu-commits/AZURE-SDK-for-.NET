// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Render.Models
{
    /// <summary> The MapTileStyle. </summary>
    public readonly partial struct MapTileStyle : IEquatable<MapTileStyle>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapTileStyle"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapTileStyle(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MainValue = "main";
        private const string DarkValue = "dark";
        private const string ShadedReliefValue = "shaded_relief";

        /// <summary> Azure Maps main style. </summary>
        public static MapTileStyle Main { get; } = new MapTileStyle(MainValue);
        /// <summary> Dark grey version of the Azure Maps main style. PNG is the only supported TileFormat. </summary>
        public static MapTileStyle Dark { get; } = new MapTileStyle(DarkValue);
        /// <summary> Azure Maps main style completed with shaded relief. Supported by Layer terra. </summary>
        public static MapTileStyle ShadedRelief { get; } = new MapTileStyle(ShadedReliefValue);
        /// <summary> Determines if two <see cref="MapTileStyle"/> values are the same. </summary>
        public static bool operator ==(MapTileStyle left, MapTileStyle right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapTileStyle"/> values are not the same. </summary>
        public static bool operator !=(MapTileStyle left, MapTileStyle right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MapTileStyle"/>. </summary>
        public static implicit operator MapTileStyle(string value) => new MapTileStyle(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapTileStyle other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapTileStyle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
