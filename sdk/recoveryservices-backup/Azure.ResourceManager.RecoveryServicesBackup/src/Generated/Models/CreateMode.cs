// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Create mode to indicate recovery of existing soft deleted data source or creation of new data source. </summary>
    public readonly partial struct CreateMode : IEquatable<CreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string DefaultValue = "Default";
        private const string RecoverValue = "Recover";

        /// <summary> Invalid. </summary>
        public static CreateMode Invalid { get; } = new CreateMode(InvalidValue);
        /// <summary> Default. </summary>
        public static CreateMode Default { get; } = new CreateMode(DefaultValue);
        /// <summary> Recover. </summary>
        public static CreateMode Recover { get; } = new CreateMode(RecoverValue);
        /// <summary> Determines if two <see cref="CreateMode"/> values are the same. </summary>
        public static bool operator ==(CreateMode left, CreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateMode"/> values are not the same. </summary>
        public static bool operator !=(CreateMode left, CreateMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateMode"/>. </summary>
        public static implicit operator CreateMode(string value) => new CreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
