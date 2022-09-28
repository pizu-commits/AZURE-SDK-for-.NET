// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The NotificationMode. </summary>
    public readonly partial struct NotificationMode : IEquatable<NotificationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NotificationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotificationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string EventHubValue = "EventHub";
        private const string WebHookValue = "WebHook";

        /// <summary> NotSpecified. </summary>
        public static NotificationMode NotSpecified { get; } = new NotificationMode(NotSpecifiedValue);
        /// <summary> EventHub. </summary>
        public static NotificationMode EventHub { get; } = new NotificationMode(EventHubValue);
        /// <summary> WebHook. </summary>
        public static NotificationMode WebHook { get; } = new NotificationMode(WebHookValue);
        /// <summary> Determines if two <see cref="NotificationMode"/> values are the same. </summary>
        public static bool operator ==(NotificationMode left, NotificationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotificationMode"/> values are not the same. </summary>
        public static bool operator !=(NotificationMode left, NotificationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotificationMode"/>. </summary>
        public static implicit operator NotificationMode(string value) => new NotificationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotificationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotificationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
