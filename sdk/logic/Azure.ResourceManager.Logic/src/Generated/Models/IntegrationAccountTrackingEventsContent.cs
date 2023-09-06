// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The tracking events definition. </summary>
    public partial class IntegrationAccountTrackingEventsContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountTrackingEventsContent"/>. </summary>
        /// <param name="sourceType"> The source type. </param>
        /// <param name="events"> The events. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceType"/> or <paramref name="events"/> is null. </exception>
        public IntegrationAccountTrackingEventsContent(string sourceType, IEnumerable<IntegrationAccountTrackingEvent> events)
        {
            Argument.AssertNotNull(sourceType, nameof(sourceType));
            Argument.AssertNotNull(events, nameof(events));

            SourceType = sourceType;
            Events = events.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountTrackingEventsContent"/>. </summary>
        /// <param name="sourceType"> The source type. </param>
        /// <param name="trackEventsOptions"> The track events options. </param>
        /// <param name="events"> The events. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountTrackingEventsContent(string sourceType, IntegrationAccountTrackEventOperationOption? trackEventsOptions, IList<IntegrationAccountTrackingEvent> events, Dictionary<string, BinaryData> rawData)
        {
            SourceType = sourceType;
            TrackEventsOptions = trackEventsOptions;
            Events = events;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountTrackingEventsContent"/> for deserialization. </summary>
        internal IntegrationAccountTrackingEventsContent()
        {
        }

        /// <summary> The source type. </summary>
        public string SourceType { get; }
        /// <summary> The track events options. </summary>
        public IntegrationAccountTrackEventOperationOption? TrackEventsOptions { get; set; }
        /// <summary> The events. </summary>
        public IList<IntegrationAccountTrackingEvent> Events { get; }
    }
}
