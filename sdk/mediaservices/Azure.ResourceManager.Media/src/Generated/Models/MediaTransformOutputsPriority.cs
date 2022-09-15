// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal. </summary>
    public readonly partial struct MediaTransformOutputsPriority : IEquatable<MediaTransformOutputsPriority>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaTransformOutputsPriority"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaTransformOutputsPriority(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "Low";
        private const string NormalValue = "Normal";
        private const string HighValue = "High";

        /// <summary> Used for TransformOutputs that can be generated after Normal and High priority TransformOutputs. </summary>
        public static MediaTransformOutputsPriority Low { get; } = new MediaTransformOutputsPriority(LowValue);
        /// <summary> Used for TransformOutputs that can be generated at Normal priority. </summary>
        public static MediaTransformOutputsPriority Normal { get; } = new MediaTransformOutputsPriority(NormalValue);
        /// <summary> Used for TransformOutputs that should take precedence over others. </summary>
        public static MediaTransformOutputsPriority High { get; } = new MediaTransformOutputsPriority(HighValue);
        /// <summary> Determines if two <see cref="MediaTransformOutputsPriority"/> values are the same. </summary>
        public static bool operator ==(MediaTransformOutputsPriority left, MediaTransformOutputsPriority right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaTransformOutputsPriority"/> values are not the same. </summary>
        public static bool operator !=(MediaTransformOutputsPriority left, MediaTransformOutputsPriority right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaTransformOutputsPriority"/>. </summary>
        public static implicit operator MediaTransformOutputsPriority(string value) => new MediaTransformOutputsPriority(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaTransformOutputsPriority other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaTransformOutputsPriority other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
