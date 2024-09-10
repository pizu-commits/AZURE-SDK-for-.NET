// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Operation status. </summary>
    public readonly partial struct MachineLearningOperationStatus : IEquatable<MachineLearningOperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningOperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string CreateFailedValue = "CreateFailed";
        private const string StartFailedValue = "StartFailed";
        private const string StopFailedValue = "StopFailed";
        private const string RestartFailedValue = "RestartFailed";
        private const string ReimageFailedValue = "ReimageFailed";
        private const string DeleteFailedValue = "DeleteFailed";

        /// <summary> InProgress. </summary>
        public static MachineLearningOperationStatus InProgress { get; } = new MachineLearningOperationStatus(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static MachineLearningOperationStatus Succeeded { get; } = new MachineLearningOperationStatus(SucceededValue);
        /// <summary> CreateFailed. </summary>
        public static MachineLearningOperationStatus CreateFailed { get; } = new MachineLearningOperationStatus(CreateFailedValue);
        /// <summary> StartFailed. </summary>
        public static MachineLearningOperationStatus StartFailed { get; } = new MachineLearningOperationStatus(StartFailedValue);
        /// <summary> StopFailed. </summary>
        public static MachineLearningOperationStatus StopFailed { get; } = new MachineLearningOperationStatus(StopFailedValue);
        /// <summary> RestartFailed. </summary>
        public static MachineLearningOperationStatus RestartFailed { get; } = new MachineLearningOperationStatus(RestartFailedValue);
        /// <summary> ReimageFailed. </summary>
        public static MachineLearningOperationStatus ReimageFailed { get; } = new MachineLearningOperationStatus(ReimageFailedValue);
        /// <summary> DeleteFailed. </summary>
        public static MachineLearningOperationStatus DeleteFailed { get; } = new MachineLearningOperationStatus(DeleteFailedValue);
        /// <summary> Determines if two <see cref="MachineLearningOperationStatus"/> values are the same. </summary>
        public static bool operator ==(MachineLearningOperationStatus left, MachineLearningOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningOperationStatus left, MachineLearningOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningOperationStatus"/>. </summary>
        public static implicit operator MachineLearningOperationStatus(string value) => new MachineLearningOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
