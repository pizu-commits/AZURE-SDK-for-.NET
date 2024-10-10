// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> The action the Batch service should take when all Tasks in the Job are in the completed state. </summary>
    public readonly partial struct OnAllBatchTasksComplete : IEquatable<OnAllBatchTasksComplete>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OnAllBatchTasksComplete"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OnAllBatchTasksComplete(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoActionValue = "noaction";
        private const string TerminateJobValue = "terminatejob";

        /// <summary> Do nothing. The Job remains active unless terminated or disabled by some other means. </summary>
        public static OnAllBatchTasksComplete NoAction { get; } = new OnAllBatchTasksComplete(NoActionValue);
        /// <summary> Terminate the Job. The Job's terminationReason is set to 'AllTasksComplete'. </summary>
        public static OnAllBatchTasksComplete TerminateJob { get; } = new OnAllBatchTasksComplete(TerminateJobValue);
        /// <summary> Determines if two <see cref="OnAllBatchTasksComplete"/> values are the same. </summary>
        public static bool operator ==(OnAllBatchTasksComplete left, OnAllBatchTasksComplete right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OnAllBatchTasksComplete"/> values are not the same. </summary>
        public static bool operator !=(OnAllBatchTasksComplete left, OnAllBatchTasksComplete right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OnAllBatchTasksComplete"/>. </summary>
        public static implicit operator OnAllBatchTasksComplete(string value) => new OnAllBatchTasksComplete(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OnAllBatchTasksComplete other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OnAllBatchTasksComplete other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
