// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Allocation method. </summary>
    public readonly partial struct AllocationMethod : IEquatable<AllocationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AllocationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DynamicValue = "Dynamic";
        private const string StaticValue = "Static";

        /// <summary> Dynamic. </summary>
        public static AllocationMethod Dynamic { get; } = new AllocationMethod(DynamicValue);
        /// <summary> Static. </summary>
        public static AllocationMethod Static { get; } = new AllocationMethod(StaticValue);
        /// <summary> Determines if two <see cref="AllocationMethod"/> values are the same. </summary>
        public static bool operator ==(AllocationMethod left, AllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(AllocationMethod left, AllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AllocationMethod"/>. </summary>
        public static implicit operator AllocationMethod(string value) => new AllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
