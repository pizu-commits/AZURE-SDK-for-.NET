// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Api tier. </summary>
    public readonly partial struct LogicApiTier : IEquatable<LogicApiTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicApiTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicApiTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string EnterpriseValue = "Enterprise";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> NotSpecified. </summary>
        public static LogicApiTier NotSpecified { get; } = new LogicApiTier(NotSpecifiedValue);
        /// <summary> Enterprise. </summary>
        public static LogicApiTier Enterprise { get; } = new LogicApiTier(EnterpriseValue);
        /// <summary> Standard. </summary>
        public static LogicApiTier Standard { get; } = new LogicApiTier(StandardValue);
        /// <summary> Premium. </summary>
        public static LogicApiTier Premium { get; } = new LogicApiTier(PremiumValue);
        /// <summary> Determines if two <see cref="LogicApiTier"/> values are the same. </summary>
        public static bool operator ==(LogicApiTier left, LogicApiTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicApiTier"/> values are not the same. </summary>
        public static bool operator !=(LogicApiTier left, LogicApiTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogicApiTier"/>. </summary>
        public static implicit operator LogicApiTier(string value) => new LogicApiTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicApiTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicApiTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
