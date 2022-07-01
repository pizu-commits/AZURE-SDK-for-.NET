// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The access key to regenerate. </summary>
    public readonly partial struct CosmosDBAccountKeyKind : IEquatable<CosmosDBAccountKeyKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountKeyKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBAccountKeyKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "primary";
        private const string SecondaryValue = "secondary";
        private const string PrimaryReadonlyValue = "primaryReadonly";
        private const string SecondaryReadonlyValue = "secondaryReadonly";

        /// <summary> primary. </summary>
        public static CosmosDBAccountKeyKind Primary { get; } = new CosmosDBAccountKeyKind(PrimaryValue);
        /// <summary> secondary. </summary>
        public static CosmosDBAccountKeyKind Secondary { get; } = new CosmosDBAccountKeyKind(SecondaryValue);
        /// <summary> primaryReadonly. </summary>
        public static CosmosDBAccountKeyKind PrimaryReadonly { get; } = new CosmosDBAccountKeyKind(PrimaryReadonlyValue);
        /// <summary> secondaryReadonly. </summary>
        public static CosmosDBAccountKeyKind SecondaryReadonly { get; } = new CosmosDBAccountKeyKind(SecondaryReadonlyValue);
        /// <summary> Determines if two <see cref="CosmosDBAccountKeyKind"/> values are the same. </summary>
        public static bool operator ==(CosmosDBAccountKeyKind left, CosmosDBAccountKeyKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBAccountKeyKind"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBAccountKeyKind left, CosmosDBAccountKeyKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBAccountKeyKind"/>. </summary>
        public static implicit operator CosmosDBAccountKeyKind(string value) => new CosmosDBAccountKeyKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBAccountKeyKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBAccountKeyKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
