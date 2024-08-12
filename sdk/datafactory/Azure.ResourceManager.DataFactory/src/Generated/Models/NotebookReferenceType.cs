// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Synapse notebook reference type. </summary>
    public readonly partial struct NotebookReferenceType : IEquatable<NotebookReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NotebookReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotebookReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotebookReferenceValue = "NotebookReference";

        /// <summary> NotebookReference. </summary>
        public static NotebookReferenceType NotebookReference { get; } = new NotebookReferenceType(NotebookReferenceValue);
        /// <summary> Determines if two <see cref="NotebookReferenceType"/> values are the same. </summary>
        public static bool operator ==(NotebookReferenceType left, NotebookReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotebookReferenceType"/> values are not the same. </summary>
        public static bool operator !=(NotebookReferenceType left, NotebookReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotebookReferenceType"/>. </summary>
        public static implicit operator NotebookReferenceType(string value) => new NotebookReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotebookReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotebookReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
