// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The PerfCounterDataSourceStream. </summary>
    public readonly partial struct PerfCounterDataSourceStream : IEquatable<PerfCounterDataSourceStream>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PerfCounterDataSourceStream"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PerfCounterDataSourceStream(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftPerfValue = "Microsoft-Perf";
        private const string MicrosoftInsightsMetricsValue = "Microsoft-InsightsMetrics";

        /// <summary> Microsoft-Perf. </summary>
        public static PerfCounterDataSourceStream MicrosoftPerf { get; } = new PerfCounterDataSourceStream(MicrosoftPerfValue);
        /// <summary> Microsoft-InsightsMetrics. </summary>
        public static PerfCounterDataSourceStream MicrosoftInsightsMetrics { get; } = new PerfCounterDataSourceStream(MicrosoftInsightsMetricsValue);
        /// <summary> Determines if two <see cref="PerfCounterDataSourceStream"/> values are the same. </summary>
        public static bool operator ==(PerfCounterDataSourceStream left, PerfCounterDataSourceStream right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PerfCounterDataSourceStream"/> values are not the same. </summary>
        public static bool operator !=(PerfCounterDataSourceStream left, PerfCounterDataSourceStream right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PerfCounterDataSourceStream"/>. </summary>
        public static implicit operator PerfCounterDataSourceStream(string value) => new PerfCounterDataSourceStream(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PerfCounterDataSourceStream other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PerfCounterDataSourceStream other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
