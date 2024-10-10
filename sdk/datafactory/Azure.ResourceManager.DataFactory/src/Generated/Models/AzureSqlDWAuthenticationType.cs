// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The type used for authentication. Type: string. </summary>
    public readonly partial struct AzureSqlDWAuthenticationType : IEquatable<AzureSqlDWAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureSqlDWAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureSqlDWAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SqlValue = "SQL";
        private const string ServicePrincipalValue = "ServicePrincipal";
        private const string SystemAssignedManagedIdentityValue = "SystemAssignedManagedIdentity";
        private const string UserAssignedManagedIdentityValue = "UserAssignedManagedIdentity";

        /// <summary> SQL. </summary>
        public static AzureSqlDWAuthenticationType Sql { get; } = new AzureSqlDWAuthenticationType(SqlValue);
        /// <summary> ServicePrincipal. </summary>
        public static AzureSqlDWAuthenticationType ServicePrincipal { get; } = new AzureSqlDWAuthenticationType(ServicePrincipalValue);
        /// <summary> SystemAssignedManagedIdentity. </summary>
        public static AzureSqlDWAuthenticationType SystemAssignedManagedIdentity { get; } = new AzureSqlDWAuthenticationType(SystemAssignedManagedIdentityValue);
        /// <summary> UserAssignedManagedIdentity. </summary>
        public static AzureSqlDWAuthenticationType UserAssignedManagedIdentity { get; } = new AzureSqlDWAuthenticationType(UserAssignedManagedIdentityValue);
        /// <summary> Determines if two <see cref="AzureSqlDWAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(AzureSqlDWAuthenticationType left, AzureSqlDWAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureSqlDWAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(AzureSqlDWAuthenticationType left, AzureSqlDWAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AzureSqlDWAuthenticationType"/>. </summary>
        public static implicit operator AzureSqlDWAuthenticationType(string value) => new AzureSqlDWAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureSqlDWAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureSqlDWAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
