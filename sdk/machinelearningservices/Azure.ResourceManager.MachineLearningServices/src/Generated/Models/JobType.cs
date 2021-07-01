// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Specifies the type of job. </summary>
    public readonly partial struct JobType : IEquatable<JobType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CommandValue = "Command";
        private const string SweepValue = "Sweep";
        private const string LabelingValue = "Labeling";
        private const string PipelineValue = "Pipeline";
        private const string DataValue = "Data";
        private const string AutoMLValue = "AutoML";

        /// <summary> Command. </summary>
        public static JobType Command { get; } = new JobType(CommandValue);
        /// <summary> Sweep. </summary>
        public static JobType Sweep { get; } = new JobType(SweepValue);
        /// <summary> Labeling. </summary>
        public static JobType Labeling { get; } = new JobType(LabelingValue);
        /// <summary> Pipeline. </summary>
        public static JobType Pipeline { get; } = new JobType(PipelineValue);
        /// <summary> Data. </summary>
        public static JobType Data { get; } = new JobType(DataValue);
        /// <summary> AutoML. </summary>
        public static JobType AutoML { get; } = new JobType(AutoMLValue);
        /// <summary> Determines if two <see cref="JobType"/> values are the same. </summary>
        public static bool operator ==(JobType left, JobType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobType"/> values are not the same. </summary>
        public static bool operator !=(JobType left, JobType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobType"/>. </summary>
        public static implicit operator JobType(string value) => new JobType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
