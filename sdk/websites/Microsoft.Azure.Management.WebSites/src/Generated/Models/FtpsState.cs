// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> State of FTP / FTPS service. </summary>
    public readonly partial struct FtpsState : IEquatable<FtpsState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FtpsState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FtpsState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllAllowedValue = "AllAllowed";
        private const string FtpsOnlyValue = "FtpsOnly";
        private const string DisabledValue = "Disabled";

        /// <summary> AllAllowed. </summary>
        public static FtpsState AllAllowed { get; } = new FtpsState(AllAllowedValue);
        /// <summary> FtpsOnly. </summary>
        public static FtpsState FtpsOnly { get; } = new FtpsState(FtpsOnlyValue);
        /// <summary> Disabled. </summary>
        public static FtpsState Disabled { get; } = new FtpsState(DisabledValue);
        /// <summary> Determines if two <see cref="FtpsState"/> values are the same. </summary>
        public static bool operator ==(FtpsState left, FtpsState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FtpsState"/> values are not the same. </summary>
        public static bool operator !=(FtpsState left, FtpsState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FtpsState"/>. </summary>
        public static implicit operator FtpsState(string value) => new FtpsState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FtpsState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FtpsState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
