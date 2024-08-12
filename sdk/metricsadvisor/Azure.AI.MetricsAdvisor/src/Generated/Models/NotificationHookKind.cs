// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> hook type. </summary>
    public readonly partial struct NotificationHookKind : IEquatable<NotificationHookKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NotificationHookKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotificationHookKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebhookValue = "Webhook";
        private const string EmailValue = "Email";
        /// <summary> Determines if two <see cref="NotificationHookKind"/> values are the same. </summary>
        public static bool operator ==(NotificationHookKind left, NotificationHookKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotificationHookKind"/> values are not the same. </summary>
        public static bool operator !=(NotificationHookKind left, NotificationHookKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotificationHookKind"/>. </summary>
        public static implicit operator NotificationHookKind(string value) => new NotificationHookKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotificationHookKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotificationHookKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
