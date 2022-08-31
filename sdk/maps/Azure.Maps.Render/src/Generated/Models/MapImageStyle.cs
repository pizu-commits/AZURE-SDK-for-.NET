// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Render
{
    /// <summary> The MapImageStyle. </summary>
    public readonly partial struct MapImageStyle : IEquatable<MapImageStyle>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapImageStyle"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapImageStyle(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MainValue = "main";
        private const string DarkValue = "dark";

        /// <summary> Azure Maps main style. </summary>
        public static MapImageStyle Main { get; } = new MapImageStyle(MainValue);
        /// <summary> Dark grey version of the Azure Maps main style. </summary>
        public static MapImageStyle Dark { get; } = new MapImageStyle(DarkValue);
        /// <summary> Determines if two <see cref="MapImageStyle"/> values are the same. </summary>
        public static bool operator ==(MapImageStyle left, MapImageStyle right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapImageStyle"/> values are not the same. </summary>
        public static bool operator !=(MapImageStyle left, MapImageStyle right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MapImageStyle"/>. </summary>
        public static implicit operator MapImageStyle(string value) => new MapImageStyle(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapImageStyle other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapImageStyle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
