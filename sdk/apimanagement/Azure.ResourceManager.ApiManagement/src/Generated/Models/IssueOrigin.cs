// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The origin of the issue. </summary>
    public readonly partial struct IssueOrigin : IEquatable<IssueOrigin>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IssueOrigin"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IssueOrigin(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocalValue = "Local";
        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Local. </summary>
        public static IssueOrigin Local { get; } = new IssueOrigin(LocalValue);
        /// <summary> Inbound. </summary>
        public static IssueOrigin Inbound { get; } = new IssueOrigin(InboundValue);
        /// <summary> Outbound. </summary>
        public static IssueOrigin Outbound { get; } = new IssueOrigin(OutboundValue);
        /// <summary> Determines if two <see cref="IssueOrigin"/> values are the same. </summary>
        public static bool operator ==(IssueOrigin left, IssueOrigin right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IssueOrigin"/> values are not the same. </summary>
        public static bool operator !=(IssueOrigin left, IssueOrigin right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IssueOrigin"/>. </summary>
        public static implicit operator IssueOrigin(string value) => new IssueOrigin(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IssueOrigin other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IssueOrigin other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
