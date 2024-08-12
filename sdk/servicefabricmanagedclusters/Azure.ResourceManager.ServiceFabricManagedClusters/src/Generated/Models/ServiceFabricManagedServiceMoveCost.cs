// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Specifies the move cost for the service. </summary>
    public readonly partial struct ServiceFabricManagedServiceMoveCost : IEquatable<ServiceFabricManagedServiceMoveCost>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedServiceMoveCost"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceFabricManagedServiceMoveCost(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ZeroValue = "Zero";
        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> Zero move cost. This value is zero. </summary>
        public static ServiceFabricManagedServiceMoveCost Zero { get; } = new ServiceFabricManagedServiceMoveCost(ZeroValue);
        /// <summary> Specifies the move cost of the service as Low. The value is 1. </summary>
        public static ServiceFabricManagedServiceMoveCost Low { get; } = new ServiceFabricManagedServiceMoveCost(LowValue);
        /// <summary> Specifies the move cost of the service as Medium. The value is 2. </summary>
        public static ServiceFabricManagedServiceMoveCost Medium { get; } = new ServiceFabricManagedServiceMoveCost(MediumValue);
        /// <summary> Specifies the move cost of the service as High. The value is 3. </summary>
        public static ServiceFabricManagedServiceMoveCost High { get; } = new ServiceFabricManagedServiceMoveCost(HighValue);
        /// <summary> Determines if two <see cref="ServiceFabricManagedServiceMoveCost"/> values are the same. </summary>
        public static bool operator ==(ServiceFabricManagedServiceMoveCost left, ServiceFabricManagedServiceMoveCost right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceFabricManagedServiceMoveCost"/> values are not the same. </summary>
        public static bool operator !=(ServiceFabricManagedServiceMoveCost left, ServiceFabricManagedServiceMoveCost right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceFabricManagedServiceMoveCost"/>. </summary>
        public static implicit operator ServiceFabricManagedServiceMoveCost(string value) => new ServiceFabricManagedServiceMoveCost(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceFabricManagedServiceMoveCost other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceFabricManagedServiceMoveCost other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
