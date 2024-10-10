// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The TopicTypeSourceScope. </summary>
    public readonly partial struct TopicTypeSourceScope : IEquatable<TopicTypeSourceScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TopicTypeSourceScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TopicTypeSourceScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ResourceValue = "Resource";
        private const string ResourceGroupValue = "ResourceGroup";
        private const string AzureSubscriptionValue = "AzureSubscription";
        private const string ManagementGroupValue = "ManagementGroup";

        /// <summary> Resource. </summary>
        public static TopicTypeSourceScope Resource { get; } = new TopicTypeSourceScope(ResourceValue);
        /// <summary> ResourceGroup. </summary>
        public static TopicTypeSourceScope ResourceGroup { get; } = new TopicTypeSourceScope(ResourceGroupValue);
        /// <summary> AzureSubscription. </summary>
        public static TopicTypeSourceScope AzureSubscription { get; } = new TopicTypeSourceScope(AzureSubscriptionValue);
        /// <summary> ManagementGroup. </summary>
        public static TopicTypeSourceScope ManagementGroup { get; } = new TopicTypeSourceScope(ManagementGroupValue);
        /// <summary> Determines if two <see cref="TopicTypeSourceScope"/> values are the same. </summary>
        public static bool operator ==(TopicTypeSourceScope left, TopicTypeSourceScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TopicTypeSourceScope"/> values are not the same. </summary>
        public static bool operator !=(TopicTypeSourceScope left, TopicTypeSourceScope right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TopicTypeSourceScope"/>. </summary>
        public static implicit operator TopicTypeSourceScope(string value) => new TopicTypeSourceScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TopicTypeSourceScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TopicTypeSourceScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
