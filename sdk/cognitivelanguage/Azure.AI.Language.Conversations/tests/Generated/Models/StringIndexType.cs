// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> Specifies the method used to interpret string offsets. Set this to &quot;Utf16CodeUnit&quot; for .NET strings, which are encoded as UTF-16. </summary>
    public readonly partial struct StringIndexType : IEquatable<StringIndexType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StringIndexType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StringIndexType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextElementsV8Value = "TextElements_v8";
        private const string UnicodeCodePointValue = "UnicodeCodePoint";
        private const string Utf16CodeUnitValue = "Utf16CodeUnit";

        /// <summary> Returned offset and length values will correspond to TextElements (Graphemes and Grapheme clusters) confirming to the Unicode 8.0.0 standard. Use this option if your application is written in .Net Framework or .Net Core and you will be using StringInfo. </summary>
        public static StringIndexType TextElementsV8 { get; } = new StringIndexType(TextElementsV8Value);
        /// <summary> Returned offset and length values will correspond to Unicode code points. Use this option if your application is written in a language that support Unicode, for example Python. </summary>
        public static StringIndexType UnicodeCodePoint { get; } = new StringIndexType(UnicodeCodePointValue);
        /// <summary> Returned offset and length values will correspond to UTF-16 code units. Use this option if your application is written in a language that support Unicode, for example Java, JavaScript. </summary>
        public static StringIndexType Utf16CodeUnit { get; } = new StringIndexType(Utf16CodeUnitValue);
        /// <summary> Determines if two <see cref="StringIndexType"/> values are the same. </summary>
        public static bool operator ==(StringIndexType left, StringIndexType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StringIndexType"/> values are not the same. </summary>
        public static bool operator !=(StringIndexType left, StringIndexType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StringIndexType"/>. </summary>
        public static implicit operator StringIndexType(string value) => new StringIndexType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StringIndexType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StringIndexType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
