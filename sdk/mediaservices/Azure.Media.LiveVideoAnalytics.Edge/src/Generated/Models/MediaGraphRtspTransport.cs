// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> Underlying RTSP transport. This is used to enable or disable HTTP tunneling. </summary>
    public readonly partial struct MediaGraphRtspTransport : IEquatable<MediaGraphRtspTransport>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="MediaGraphRtspTransport"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaGraphRtspTransport(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "Http";
        private const string TcpValue = "Tcp";

        /// <summary> HTTP/HTTPS transport. This should be used when HTTP tunneling is desired. </summary>
        public static MediaGraphRtspTransport Http { get; } = new MediaGraphRtspTransport(HttpValue);
        /// <summary> TCP transport. This should be used when HTTP tunneling is NOT desired. </summary>
        public static MediaGraphRtspTransport Tcp { get; } = new MediaGraphRtspTransport(TcpValue);
        /// <summary> Determines if two <see cref="MediaGraphRtspTransport"/> values are the same. </summary>
        public static bool operator ==(MediaGraphRtspTransport left, MediaGraphRtspTransport right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaGraphRtspTransport"/> values are not the same. </summary>
        public static bool operator !=(MediaGraphRtspTransport left, MediaGraphRtspTransport right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaGraphRtspTransport"/>. </summary>
        public static implicit operator MediaGraphRtspTransport(string value) => new MediaGraphRtspTransport(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaGraphRtspTransport other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaGraphRtspTransport other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
