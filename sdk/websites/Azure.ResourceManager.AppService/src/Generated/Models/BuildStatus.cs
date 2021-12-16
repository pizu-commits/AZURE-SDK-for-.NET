// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The status of the static site build. </summary>
    public readonly partial struct BuildStatus : IEquatable<BuildStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BuildStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BuildStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WaitingForDeploymentValue = "WaitingForDeployment";
        private const string UploadingValue = "Uploading";
        private const string DeployingValue = "Deploying";
        private const string ReadyValue = "Ready";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";
        private const string DetachedValue = "Detached";

        /// <summary> WaitingForDeployment. </summary>
        public static BuildStatus WaitingForDeployment { get; } = new BuildStatus(WaitingForDeploymentValue);
        /// <summary> Uploading. </summary>
        public static BuildStatus Uploading { get; } = new BuildStatus(UploadingValue);
        /// <summary> Deploying. </summary>
        public static BuildStatus Deploying { get; } = new BuildStatus(DeployingValue);
        /// <summary> Ready. </summary>
        public static BuildStatus Ready { get; } = new BuildStatus(ReadyValue);
        /// <summary> Failed. </summary>
        public static BuildStatus Failed { get; } = new BuildStatus(FailedValue);
        /// <summary> Deleting. </summary>
        public static BuildStatus Deleting { get; } = new BuildStatus(DeletingValue);
        /// <summary> Detached. </summary>
        public static BuildStatus Detached { get; } = new BuildStatus(DetachedValue);
        /// <summary> Determines if two <see cref="BuildStatus"/> values are the same. </summary>
        public static bool operator ==(BuildStatus left, BuildStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BuildStatus"/> values are not the same. </summary>
        public static bool operator !=(BuildStatus left, BuildStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BuildStatus"/>. </summary>
        public static implicit operator BuildStatus(string value) => new BuildStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BuildStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BuildStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
