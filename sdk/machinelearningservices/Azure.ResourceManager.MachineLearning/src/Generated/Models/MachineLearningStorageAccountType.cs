// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> type of this storage account. </summary>
    public readonly partial struct MachineLearningStorageAccountType : IEquatable<MachineLearningStorageAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningStorageAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningStorageAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLrsValue = "Standard_LRS";
        private const string PremiumLrsValue = "Premium_LRS";

        /// <summary> Standard_LRS. </summary>
        public static MachineLearningStorageAccountType StandardLrs { get; } = new MachineLearningStorageAccountType(StandardLrsValue);
        /// <summary> Premium_LRS. </summary>
        public static MachineLearningStorageAccountType PremiumLrs { get; } = new MachineLearningStorageAccountType(PremiumLrsValue);
        /// <summary> Determines if two <see cref="MachineLearningStorageAccountType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningStorageAccountType left, MachineLearningStorageAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningStorageAccountType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningStorageAccountType left, MachineLearningStorageAccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningStorageAccountType"/>. </summary>
        public static implicit operator MachineLearningStorageAccountType(string value) => new MachineLearningStorageAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningStorageAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningStorageAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
