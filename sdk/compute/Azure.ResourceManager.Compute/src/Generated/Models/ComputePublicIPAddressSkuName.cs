// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specify public IP sku name. </summary>
    public readonly partial struct ComputePublicIPAddressSkuName : IEquatable<ComputePublicIPAddressSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputePublicIPAddressSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputePublicIPAddressSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";

        /// <summary> Basic. </summary>
        public static ComputePublicIPAddressSkuName Basic { get; } = new ComputePublicIPAddressSkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static ComputePublicIPAddressSkuName Standard { get; } = new ComputePublicIPAddressSkuName(StandardValue);
        /// <summary> Determines if two <see cref="ComputePublicIPAddressSkuName"/> values are the same. </summary>
        public static bool operator ==(ComputePublicIPAddressSkuName left, ComputePublicIPAddressSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputePublicIPAddressSkuName"/> values are not the same. </summary>
        public static bool operator !=(ComputePublicIPAddressSkuName left, ComputePublicIPAddressSkuName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputePublicIPAddressSkuName"/>. </summary>
        public static implicit operator ComputePublicIPAddressSkuName(string value) => new ComputePublicIPAddressSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputePublicIPAddressSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputePublicIPAddressSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
