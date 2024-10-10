// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The authentication type to be used to connect to the FTP server. </summary>
    public readonly partial struct SftpAuthenticationType : IEquatable<SftpAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SftpAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SftpAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string SshPublicKeyValue = "SshPublicKey";

        /// <summary> Basic. </summary>
        public static SftpAuthenticationType Basic { get; } = new SftpAuthenticationType(BasicValue);
        /// <summary> SshPublicKey. </summary>
        public static SftpAuthenticationType SshPublicKey { get; } = new SftpAuthenticationType(SshPublicKeyValue);
        /// <summary> Determines if two <see cref="SftpAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(SftpAuthenticationType left, SftpAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SftpAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(SftpAuthenticationType left, SftpAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SftpAuthenticationType"/>. </summary>
        public static implicit operator SftpAuthenticationType(string value) => new SftpAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SftpAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SftpAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
