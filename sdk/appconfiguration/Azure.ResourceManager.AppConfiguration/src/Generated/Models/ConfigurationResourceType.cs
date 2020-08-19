// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The resource type to check for name availability. </summary>
    public readonly partial struct ConfigurationResourceType : IEquatable<ConfigurationResourceType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ConfigurationResourceType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfigurationResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftAppConfigurationConfigurationStoresValue = "Microsoft.AppConfiguration/configurationStores";

        /// <summary> Microsoft.AppConfiguration/configurationStores. </summary>
        public static ConfigurationResourceType MicrosoftAppConfigurationConfigurationStores { get; } = new ConfigurationResourceType(MicrosoftAppConfigurationConfigurationStoresValue);
        /// <summary> Determines if two <see cref="ConfigurationResourceType"/> values are the same. </summary>
        public static bool operator ==(ConfigurationResourceType left, ConfigurationResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfigurationResourceType"/> values are not the same. </summary>
        public static bool operator !=(ConfigurationResourceType left, ConfigurationResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConfigurationResourceType"/>. </summary>
        public static implicit operator ConfigurationResourceType(string value) => new ConfigurationResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfigurationResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfigurationResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
