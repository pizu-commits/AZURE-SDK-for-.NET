// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Type of the script. </summary>
    internal readonly partial struct ScriptType : IEquatable<ScriptType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzurePowerShellValue = "AzurePowerShell";
        private const string AzureCLIValue = "AzureCLI";

        /// <summary> AzurePowerShell. </summary>
        public static ScriptType AzurePowerShell { get; } = new ScriptType(AzurePowerShellValue);
        /// <summary> AzureCLI. </summary>
        public static ScriptType AzureCLI { get; } = new ScriptType(AzureCLIValue);
        /// <summary> Determines if two <see cref="ScriptType"/> values are the same. </summary>
        public static bool operator ==(ScriptType left, ScriptType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptType"/> values are not the same. </summary>
        public static bool operator !=(ScriptType left, ScriptType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScriptType"/>. </summary>
        public static implicit operator ScriptType(string value) => new ScriptType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
