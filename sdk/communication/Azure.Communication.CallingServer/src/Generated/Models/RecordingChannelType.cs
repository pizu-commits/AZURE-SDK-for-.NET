// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The channel type of a call recording. </summary>
    public readonly partial struct RecordingChannelType : IEquatable<RecordingChannelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecordingChannelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecordingChannelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MixedValue = "mixed";
        private const string UnmixedValue = "unmixed";

        /// <summary> mixed. </summary>
        public static RecordingChannelType Mixed { get; } = new RecordingChannelType(MixedValue);
        /// <summary> unmixed. </summary>
        public static RecordingChannelType Unmixed { get; } = new RecordingChannelType(UnmixedValue);
        /// <summary> Determines if two <see cref="RecordingChannelType"/> values are the same. </summary>
        public static bool operator ==(RecordingChannelType left, RecordingChannelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecordingChannelType"/> values are not the same. </summary>
        public static bool operator !=(RecordingChannelType left, RecordingChannelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecordingChannelType"/>. </summary>
        public static implicit operator RecordingChannelType(string value) => new RecordingChannelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecordingChannelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecordingChannelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
