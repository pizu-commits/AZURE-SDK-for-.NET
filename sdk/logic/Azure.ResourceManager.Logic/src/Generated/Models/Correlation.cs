// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The correlation property.
    /// Serialized Name: Correlation
    /// </summary>
    internal partial class Correlation
    {
        /// <summary> Initializes a new instance of Correlation. </summary>
        internal Correlation()
        {
        }

        /// <summary> Initializes a new instance of Correlation. </summary>
        /// <param name="clientTrackingId">
        /// The client tracking id.
        /// Serialized Name: Correlation.clientTrackingId
        /// </param>
        internal Correlation(string clientTrackingId)
        {
            ClientTrackingId = clientTrackingId;
        }

        /// <summary>
        /// The client tracking id.
        /// Serialized Name: Correlation.clientTrackingId
        /// </summary>
        public string ClientTrackingId { get; }
    }
}
