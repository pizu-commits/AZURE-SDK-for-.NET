// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Property to indicate if the Express Route Gateway serves traffic when there are multiple Express Route Gateways in the vnet. </summary>
    public readonly partial struct ExpressRouteGatewayAdminState : IEquatable<ExpressRouteGatewayAdminState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteGatewayAdminState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRouteGatewayAdminState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ExpressRouteGatewayAdminState Enabled { get; } = new ExpressRouteGatewayAdminState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ExpressRouteGatewayAdminState Disabled { get; } = new ExpressRouteGatewayAdminState(DisabledValue);
        /// <summary> Determines if two <see cref="ExpressRouteGatewayAdminState"/> values are the same. </summary>
        public static bool operator ==(ExpressRouteGatewayAdminState left, ExpressRouteGatewayAdminState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRouteGatewayAdminState"/> values are not the same. </summary>
        public static bool operator !=(ExpressRouteGatewayAdminState left, ExpressRouteGatewayAdminState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExpressRouteGatewayAdminState"/>. </summary>
        public static implicit operator ExpressRouteGatewayAdminState(string value) => new ExpressRouteGatewayAdminState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRouteGatewayAdminState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRouteGatewayAdminState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
