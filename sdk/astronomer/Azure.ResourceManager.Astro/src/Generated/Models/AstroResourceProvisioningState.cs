// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Astro.Models
{
    /// <summary> The provisioning state of a resource type. </summary>
    public readonly partial struct AstroResourceProvisioningState : IEquatable<AstroResourceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AstroResourceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AstroResourceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Resource has been created. </summary>
        public static AstroResourceProvisioningState Succeeded { get; } = new AstroResourceProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static AstroResourceProvisioningState Failed { get; } = new AstroResourceProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static AstroResourceProvisioningState Canceled { get; } = new AstroResourceProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="AstroResourceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AstroResourceProvisioningState left, AstroResourceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AstroResourceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AstroResourceProvisioningState left, AstroResourceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AstroResourceProvisioningState"/>. </summary>
        public static implicit operator AstroResourceProvisioningState(string value) => new AstroResourceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AstroResourceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AstroResourceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
