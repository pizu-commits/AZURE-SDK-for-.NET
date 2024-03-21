// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The SpatialAnalysisPersonZoneCrossingZoneEvents. </summary>
    public partial class SpatialAnalysisPersonZoneCrossingZoneEvents
    {
        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonZoneCrossingZoneEvents"/>. </summary>
        /// <param name="zone">
        /// The named zone.
        /// Please note <see cref="NamedPolygonBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPolygonString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="zone"/> is null. </exception>
        public SpatialAnalysisPersonZoneCrossingZoneEvents(NamedPolygonBase zone)
        {
            Argument.AssertNotNull(zone, nameof(zone));

            Zone = zone;
            Events = new ChangeTrackingList<SpatialAnalysisPersonZoneCrossingEvent>();
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonZoneCrossingZoneEvents"/>. </summary>
        /// <param name="zone">
        /// The named zone.
        /// Please note <see cref="NamedPolygonBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPolygonString"/>.
        /// </param>
        /// <param name="events"> The event configuration. </param>
        internal SpatialAnalysisPersonZoneCrossingZoneEvents(NamedPolygonBase zone, IList<SpatialAnalysisPersonZoneCrossingEvent> events)
        {
            Zone = zone;
            Events = events;
        }

        /// <summary>
        /// The named zone.
        /// Please note <see cref="NamedPolygonBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPolygonString"/>.
        /// </summary>
        public NamedPolygonBase Zone { get; set; }
        /// <summary> The event configuration. </summary>
        public IList<SpatialAnalysisPersonZoneCrossingEvent> Events { get; }
    }
}
