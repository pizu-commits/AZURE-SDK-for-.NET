// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Defines the type of insights that you want the service to generate. The allowed values are 'AudioInsightsOnly', 'VideoInsightsOnly', and 'AllInsights'. The default is AllInsights. If you set this to AllInsights and the input is audio only, then only audio insights are generated. Similarly if the input is video only, then only video insights are generated. It is recommended that you not use AudioInsightsOnly if you expect some of your inputs to be video only; or use VideoInsightsOnly if you expect some of your inputs to be audio only. Your Jobs in such conditions would error out. </summary>
    public readonly partial struct InsightsType : IEquatable<InsightsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InsightsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InsightsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AudioInsightsOnlyValue = "AudioInsightsOnly";
        private const string VideoInsightsOnlyValue = "VideoInsightsOnly";
        private const string AllInsightsValue = "AllInsights";

        /// <summary> Generate audio only insights. Ignore video even if present. Fails if no audio is present. </summary>
        public static InsightsType AudioInsightsOnly { get; } = new InsightsType(AudioInsightsOnlyValue);
        /// <summary> Generate video only insights. Ignore audio if present. Fails if no video is present. </summary>
        public static InsightsType VideoInsightsOnly { get; } = new InsightsType(VideoInsightsOnlyValue);
        /// <summary> Generate both audio and video insights. Fails if either audio or video Insights fail. </summary>
        public static InsightsType AllInsights { get; } = new InsightsType(AllInsightsValue);
        /// <summary> Determines if two <see cref="InsightsType"/> values are the same. </summary>
        public static bool operator ==(InsightsType left, InsightsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InsightsType"/> values are not the same. </summary>
        public static bool operator !=(InsightsType left, InsightsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InsightsType"/>. </summary>
        public static implicit operator InsightsType(string value) => new InsightsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InsightsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InsightsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
