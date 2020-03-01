// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Language code. </summary>
    internal readonly partial struct Language_internal : IEquatable<Language_internal>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Language_internal"/> values are the same. </summary>
        public Language_internal(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnValue = "en";
        private const string EsValue = "es";

        /// <summary> en. </summary>
        public static Language_internal En { get; } = new Language_internal(EnValue);
        /// <summary> es. </summary>
        public static Language_internal Es { get; } = new Language_internal(EsValue);
        /// <summary> Determines if two <see cref="Language_internal"/> values are the same. </summary>
        public static bool operator ==(Language_internal left, Language_internal right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Language_internal"/> values are not the same. </summary>
        public static bool operator !=(Language_internal left, Language_internal right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Language_internal"/>. </summary>
        public static implicit operator Language_internal(string value) => new Language_internal(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Language_internal other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Language_internal other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
