// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The type of key used to encrypt the data of the disk. </summary>
    public readonly partial struct DiskEncryptionSetType : IEquatable<DiskEncryptionSetType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskEncryptionSetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EncryptionAtRestWithCustomerKeyValue = "EncryptionAtRestWithCustomerKey";
        private const string EncryptionAtRestWithPlatformAndCustomerKeysValue = "EncryptionAtRestWithPlatformAndCustomerKeys";
        private const string ConfidentialVmEncryptedWithCustomerKeyValue = "ConfidentialVmEncryptedWithCustomerKey";

        /// <summary> Resource using diskEncryptionSet would be encrypted at rest with Customer managed key that can be changed and revoked by a customer. </summary>
        public static DiskEncryptionSetType EncryptionAtRestWithCustomerKey { get; } = new DiskEncryptionSetType(EncryptionAtRestWithCustomerKeyValue);
        /// <summary> Resource using diskEncryptionSet would be encrypted at rest with two layers of encryption. One of the keys is Customer managed and the other key is Platform managed. </summary>
        public static DiskEncryptionSetType EncryptionAtRestWithPlatformAndCustomerKeys { get; } = new DiskEncryptionSetType(EncryptionAtRestWithPlatformAndCustomerKeysValue);
        /// <summary> Confidential VM supported disk and VM guest state would be encrypted with customer managed key. </summary>
        public static DiskEncryptionSetType ConfidentialVmEncryptedWithCustomerKey { get; } = new DiskEncryptionSetType(ConfidentialVmEncryptedWithCustomerKeyValue);
        /// <summary> Determines if two <see cref="DiskEncryptionSetType"/> values are the same. </summary>
        public static bool operator ==(DiskEncryptionSetType left, DiskEncryptionSetType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskEncryptionSetType"/> values are not the same. </summary>
        public static bool operator !=(DiskEncryptionSetType left, DiskEncryptionSetType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskEncryptionSetType"/>. </summary>
        public static implicit operator DiskEncryptionSetType(string value) => new DiskEncryptionSetType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskEncryptionSetType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskEncryptionSetType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
