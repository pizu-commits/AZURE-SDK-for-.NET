// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Can Overwrite if Target DataBase already exists. </summary>
    public readonly partial struct OverwriteOption : IEquatable<OverwriteOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OverwriteOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OverwriteOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string FailOnConflictValue = "FailOnConflict";
        private const string OverwriteValue = "Overwrite";

        /// <summary> Invalid. </summary>
        public static OverwriteOption Invalid { get; } = new OverwriteOption(InvalidValue);
        /// <summary> FailOnConflict. </summary>
        public static OverwriteOption FailOnConflict { get; } = new OverwriteOption(FailOnConflictValue);
        /// <summary> Overwrite. </summary>
        public static OverwriteOption Overwrite { get; } = new OverwriteOption(OverwriteValue);
        /// <summary> Determines if two <see cref="OverwriteOption"/> values are the same. </summary>
        public static bool operator ==(OverwriteOption left, OverwriteOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OverwriteOption"/> values are not the same. </summary>
        public static bool operator !=(OverwriteOption left, OverwriteOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OverwriteOption"/>. </summary>
        public static implicit operator OverwriteOption(string value) => new OverwriteOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OverwriteOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OverwriteOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
