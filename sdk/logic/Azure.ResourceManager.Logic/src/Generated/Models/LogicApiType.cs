// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The LogicApiType. </summary>
    public readonly partial struct LogicApiType : IEquatable<LogicApiType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicApiType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicApiType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string RestValue = "Rest";
        private const string SoapValue = "Soap";

        /// <summary> NotSpecified. </summary>
        public static LogicApiType NotSpecified { get; } = new LogicApiType(NotSpecifiedValue);
        /// <summary> Rest. </summary>
        public static LogicApiType Rest { get; } = new LogicApiType(RestValue);
        /// <summary> Soap. </summary>
        public static LogicApiType Soap { get; } = new LogicApiType(SoapValue);
        /// <summary> Determines if two <see cref="LogicApiType"/> values are the same. </summary>
        public static bool operator ==(LogicApiType left, LogicApiType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicApiType"/> values are not the same. </summary>
        public static bool operator !=(LogicApiType left, LogicApiType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogicApiType"/>. </summary>
        public static implicit operator LogicApiType(string value) => new LogicApiType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicApiType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicApiType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
