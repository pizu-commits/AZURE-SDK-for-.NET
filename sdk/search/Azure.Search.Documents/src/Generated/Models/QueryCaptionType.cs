// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> This parameter is only valid if the query type is 'semantic'. If set, the query returns captions extracted from key passages in the highest ranked documents. When Captions is set to 'extractive', highlighting is enabled by default, and can be configured by appending the pipe character '|' followed by the 'highlight-&lt;true/false&gt;' option, such as 'extractive|highlight-true'. Defaults to 'None'. </summary>
    public readonly partial struct QueryCaptionType : IEquatable<QueryCaptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryCaptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryCaptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string ExtractiveValue = "extractive";

        /// <summary> Do not return captions for the query. </summary>
        public static QueryCaptionType None { get; } = new QueryCaptionType(NoneValue);
        /// <summary> Extracts captions from the matching documents that contain passages relevant to the search query. </summary>
        public static QueryCaptionType Extractive { get; } = new QueryCaptionType(ExtractiveValue);
        /// <summary> Determines if two <see cref="QueryCaptionType"/> values are the same. </summary>
        public static bool operator ==(QueryCaptionType left, QueryCaptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryCaptionType"/> values are not the same. </summary>
        public static bool operator !=(QueryCaptionType left, QueryCaptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryCaptionType"/>. </summary>
        public static implicit operator QueryCaptionType(string value) => new QueryCaptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryCaptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryCaptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
