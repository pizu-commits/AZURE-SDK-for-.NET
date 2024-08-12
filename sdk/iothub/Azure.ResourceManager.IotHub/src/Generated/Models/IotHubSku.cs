// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The name of the SKU. </summary>
    public readonly partial struct IotHubSku : IEquatable<IotHubSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotHubSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotHubSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string F1Value = "F1";
        private const string S1Value = "S1";
        private const string S2Value = "S2";
        private const string S3Value = "S3";
        private const string B1Value = "B1";
        private const string B2Value = "B2";
        private const string B3Value = "B3";

        /// <summary> F1. </summary>
        public static IotHubSku F1 { get; } = new IotHubSku(F1Value);
        /// <summary> S1. </summary>
        public static IotHubSku S1 { get; } = new IotHubSku(S1Value);
        /// <summary> S2. </summary>
        public static IotHubSku S2 { get; } = new IotHubSku(S2Value);
        /// <summary> S3. </summary>
        public static IotHubSku S3 { get; } = new IotHubSku(S3Value);
        /// <summary> B1. </summary>
        public static IotHubSku B1 { get; } = new IotHubSku(B1Value);
        /// <summary> B2. </summary>
        public static IotHubSku B2 { get; } = new IotHubSku(B2Value);
        /// <summary> B3. </summary>
        public static IotHubSku B3 { get; } = new IotHubSku(B3Value);
        /// <summary> Determines if two <see cref="IotHubSku"/> values are the same. </summary>
        public static bool operator ==(IotHubSku left, IotHubSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotHubSku"/> values are not the same. </summary>
        public static bool operator !=(IotHubSku left, IotHubSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IotHubSku"/>. </summary>
        public static implicit operator IotHubSku(string value) => new IotHubSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotHubSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotHubSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
