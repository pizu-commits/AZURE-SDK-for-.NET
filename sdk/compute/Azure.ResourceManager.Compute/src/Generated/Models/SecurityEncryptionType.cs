// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and NonPersistedTPM for not persisting firmware state in the VMGuestState blob.. **Note:** It can be set for only Confidential VMs. </summary>
    public readonly partial struct SecurityEncryptionType : IEquatable<SecurityEncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityEncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityEncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VmGuestStateOnlyValue = "VMGuestStateOnly";
        private const string DiskWithVmGuestStateValue = "DiskWithVMGuestState";
        private const string NonPersistedTPMValue = "NonPersistedTPM";

        /// <summary> VMGuestStateOnly. </summary>
        public static SecurityEncryptionType VmGuestStateOnly { get; } = new SecurityEncryptionType(VmGuestStateOnlyValue);
        /// <summary> DiskWithVMGuestState. </summary>
        public static SecurityEncryptionType DiskWithVmGuestState { get; } = new SecurityEncryptionType(DiskWithVmGuestStateValue);
        /// <summary> NonPersistedTPM. </summary>
        public static SecurityEncryptionType NonPersistedTPM { get; } = new SecurityEncryptionType(NonPersistedTPMValue);
        /// <summary> Determines if two <see cref="SecurityEncryptionType"/> values are the same. </summary>
        public static bool operator ==(SecurityEncryptionType left, SecurityEncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityEncryptionType"/> values are not the same. </summary>
        public static bool operator !=(SecurityEncryptionType left, SecurityEncryptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityEncryptionType"/>. </summary>
        public static implicit operator SecurityEncryptionType(string value) => new SecurityEncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityEncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityEncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
