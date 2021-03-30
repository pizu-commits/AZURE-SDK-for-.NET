// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> System generated.  Ignored at creation. The status of the job. </summary>
    public readonly partial struct JobResponseStatus : IEquatable<JobResponseStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobResponseStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobResponseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string EnqueuedValue = "enqueued";
        private const string RunningValue = "running";
        private const string CompletedValue = "completed";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";
        private const string ScheduledValue = "scheduled";
        private const string QueuedValue = "queued";

        /// <summary> unknown. </summary>
        public static JobResponseStatus Unknown { get; } = new JobResponseStatus(UnknownValue);
        /// <summary> enqueued. </summary>
        public static JobResponseStatus Enqueued { get; } = new JobResponseStatus(EnqueuedValue);
        /// <summary> running. </summary>
        public static JobResponseStatus Running { get; } = new JobResponseStatus(RunningValue);
        /// <summary> completed. </summary>
        public static JobResponseStatus Completed { get; } = new JobResponseStatus(CompletedValue);
        /// <summary> failed. </summary>
        public static JobResponseStatus Failed { get; } = new JobResponseStatus(FailedValue);
        /// <summary> cancelled. </summary>
        public static JobResponseStatus Cancelled { get; } = new JobResponseStatus(CancelledValue);
        /// <summary> scheduled. </summary>
        public static JobResponseStatus Scheduled { get; } = new JobResponseStatus(ScheduledValue);
        /// <summary> queued. </summary>
        public static JobResponseStatus Queued { get; } = new JobResponseStatus(QueuedValue);
        /// <summary> Determines if two <see cref="JobResponseStatus"/> values are the same. </summary>
        public static bool operator ==(JobResponseStatus left, JobResponseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobResponseStatus"/> values are not the same. </summary>
        public static bool operator !=(JobResponseStatus left, JobResponseStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobResponseStatus"/>. </summary>
        public static implicit operator JobResponseStatus(string value) => new JobResponseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobResponseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobResponseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
