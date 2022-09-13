// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Render.Models
{
    /// <summary> The MapTileLayer. </summary>
    public readonly partial struct MapTileLayer : IEquatable<MapTileLayer>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapTileLayer"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapTileLayer(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "basic";
        private const string HybridValue = "hybrid";
        private const string LabelsValue = "labels";
        private const string TerraValue = "terra";

        /// <summary> Returns a tile containing all map features including polygons, borders, roads and labels. </summary>
        public static MapTileLayer Basic { get; } = new MapTileLayer(BasicValue);
        /// <summary> Returns a tile containing borders, roads, and labels, and can be overlaid on other tiles (such as satellite imagery) to produce hybrid tiles. </summary>
        public static MapTileLayer Hybrid { get; } = new MapTileLayer(HybridValue);
        /// <summary> Returns a tile of just the map&apos;s label information. </summary>
        public static MapTileLayer Labels { get; } = new MapTileLayer(LabelsValue);
        /// <summary> Map canvas complete with shaded relief tiles. Zoom levels 0-6 (inclusive) are supported. Png is the only supported TileFormat and only available MapTileSize is 512. </summary>
        public static MapTileLayer Terra { get; } = new MapTileLayer(TerraValue);
        /// <summary> Determines if two <see cref="MapTileLayer"/> values are the same. </summary>
        public static bool operator ==(MapTileLayer left, MapTileLayer right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapTileLayer"/> values are not the same. </summary>
        public static bool operator !=(MapTileLayer left, MapTileLayer right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MapTileLayer"/>. </summary>
        public static implicit operator MapTileLayer(string value) => new MapTileLayer(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapTileLayer other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapTileLayer other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
