// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Enum to indicate whether value is 'Enabled' or 'Disabled'. </summary>
    public readonly partial struct MySqlFlexibleServerEnableStatusEnum : IEquatable<MySqlFlexibleServerEnableStatusEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerEnableStatusEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerEnableStatusEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static MySqlFlexibleServerEnableStatusEnum Enabled { get; } = new MySqlFlexibleServerEnableStatusEnum(EnabledValue);
        /// <summary> Disabled. </summary>
        public static MySqlFlexibleServerEnableStatusEnum Disabled { get; } = new MySqlFlexibleServerEnableStatusEnum(DisabledValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerEnableStatusEnum"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerEnableStatusEnum left, MySqlFlexibleServerEnableStatusEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerEnableStatusEnum"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerEnableStatusEnum left, MySqlFlexibleServerEnableStatusEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MySqlFlexibleServerEnableStatusEnum"/>. </summary>
        public static implicit operator MySqlFlexibleServerEnableStatusEnum(string value) => new MySqlFlexibleServerEnableStatusEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerEnableStatusEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerEnableStatusEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
