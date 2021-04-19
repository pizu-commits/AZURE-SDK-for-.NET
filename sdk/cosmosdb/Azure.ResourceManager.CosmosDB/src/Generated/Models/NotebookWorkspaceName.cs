// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The NotebookWorkspaceName. </summary>
    public readonly partial struct NotebookWorkspaceName : IEquatable<NotebookWorkspaceName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="NotebookWorkspaceName"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotebookWorkspaceName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static NotebookWorkspaceName Default { get; } = new NotebookWorkspaceName(DefaultValue);
        /// <summary> Determines if two <see cref="NotebookWorkspaceName"/> values are the same. </summary>
        public static bool operator ==(NotebookWorkspaceName left, NotebookWorkspaceName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotebookWorkspaceName"/> values are not the same. </summary>
        public static bool operator !=(NotebookWorkspaceName left, NotebookWorkspaceName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotebookWorkspaceName"/>. </summary>
        public static implicit operator NotebookWorkspaceName(string value) => new NotebookWorkspaceName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotebookWorkspaceName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotebookWorkspaceName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
