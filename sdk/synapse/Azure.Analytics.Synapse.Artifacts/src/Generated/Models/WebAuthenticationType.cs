// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Type of authentication used to connect to the web table source. </summary>
    public readonly partial struct WebAuthenticationType : IEquatable<WebAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string AnonymousValue = "Anonymous";
        private const string ClientCertificateValue = "ClientCertificate";

        /// <summary> Basic. </summary>
        public static WebAuthenticationType Basic { get; } = new WebAuthenticationType(BasicValue);
        /// <summary> Anonymous. </summary>
        public static WebAuthenticationType Anonymous { get; } = new WebAuthenticationType(AnonymousValue);
        /// <summary> ClientCertificate. </summary>
        public static WebAuthenticationType ClientCertificate { get; } = new WebAuthenticationType(ClientCertificateValue);
        /// <summary> Determines if two <see cref="WebAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(WebAuthenticationType left, WebAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(WebAuthenticationType left, WebAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebAuthenticationType"/>. </summary>
        public static implicit operator WebAuthenticationType(string value) => new WebAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
