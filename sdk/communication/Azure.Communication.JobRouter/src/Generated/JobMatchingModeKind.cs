// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> Discriminators for supported matching mode types. </summary>
    public readonly partial struct JobMatchingModeKind : IEquatable<JobMatchingModeKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobMatchingModeKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobMatchingModeKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QueueAndMatchValue = "queueAndMatch";
        private const string ScheduleAndSuspendValue = "scheduleAndSuspend";
        private const string SuspendValue = "suspend";

        /// <summary> Discriminator value for QueueAndMatchMode. </summary>
        public static JobMatchingModeKind QueueAndMatch { get; } = new JobMatchingModeKind(QueueAndMatchValue);
        /// <summary> Discriminator value for ScheduleAndSuspendMode. </summary>
        public static JobMatchingModeKind ScheduleAndSuspend { get; } = new JobMatchingModeKind(ScheduleAndSuspendValue);
        /// <summary> Discriminator value for SuspendMode. </summary>
        public static JobMatchingModeKind Suspend { get; } = new JobMatchingModeKind(SuspendValue);
        /// <summary> Determines if two <see cref="JobMatchingModeKind"/> values are the same. </summary>
        public static bool operator ==(JobMatchingModeKind left, JobMatchingModeKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobMatchingModeKind"/> values are not the same. </summary>
        public static bool operator !=(JobMatchingModeKind left, JobMatchingModeKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobMatchingModeKind"/>. </summary>
        public static implicit operator JobMatchingModeKind(string value) => new JobMatchingModeKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobMatchingModeKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobMatchingModeKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
