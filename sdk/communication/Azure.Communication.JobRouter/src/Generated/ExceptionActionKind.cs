// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> The ExceptionActionKind. </summary>
    public readonly partial struct ExceptionActionKind : IEquatable<ExceptionActionKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExceptionActionKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExceptionActionKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CancelValue = "cancel";
        private const string ManualReclassifyValue = "manualReclassify";
        private const string ReclassifyValue = "reclassify";

        /// <summary> cancel. </summary>
        public static ExceptionActionKind Cancel { get; } = new ExceptionActionKind(CancelValue);
        /// <summary> manualReclassify. </summary>
        public static ExceptionActionKind ManualReclassify { get; } = new ExceptionActionKind(ManualReclassifyValue);
        /// <summary> reclassify. </summary>
        public static ExceptionActionKind Reclassify { get; } = new ExceptionActionKind(ReclassifyValue);
        /// <summary> Determines if two <see cref="ExceptionActionKind"/> values are the same. </summary>
        public static bool operator ==(ExceptionActionKind left, ExceptionActionKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExceptionActionKind"/> values are not the same. </summary>
        public static bool operator !=(ExceptionActionKind left, ExceptionActionKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExceptionActionKind"/>. </summary>
        public static implicit operator ExceptionActionKind(string value) => new ExceptionActionKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExceptionActionKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExceptionActionKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
