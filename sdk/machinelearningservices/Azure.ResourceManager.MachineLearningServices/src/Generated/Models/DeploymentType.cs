// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The deployment type for the service. </summary>
    public readonly partial struct DeploymentType : IEquatable<DeploymentType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DeploymentType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GrpcRealtimeEndpointValue = "GRPCRealtimeEndpoint";
        private const string HttpRealtimeEndpointValue = "HttpRealtimeEndpoint";
        private const string BatchValue = "Batch";

        /// <summary> GRPCRealtimeEndpoint. </summary>
        public static DeploymentType GrpcRealtimeEndpoint { get; } = new DeploymentType(GrpcRealtimeEndpointValue);
        /// <summary> HttpRealtimeEndpoint. </summary>
        public static DeploymentType HttpRealtimeEndpoint { get; } = new DeploymentType(HttpRealtimeEndpointValue);
        /// <summary> Batch. </summary>
        public static DeploymentType Batch { get; } = new DeploymentType(BatchValue);
        /// <summary> Determines if two <see cref="DeploymentType"/> values are the same. </summary>
        public static bool operator ==(DeploymentType left, DeploymentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentType"/> values are not the same. </summary>
        public static bool operator !=(DeploymentType left, DeploymentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentType"/>. </summary>
        public static implicit operator DeploymentType(string value) => new DeploymentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
