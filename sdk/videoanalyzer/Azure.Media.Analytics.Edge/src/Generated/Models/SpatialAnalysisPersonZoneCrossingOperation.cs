// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis Person Zone Crossing operation to be used in the Cognitive Services Vision processor. </summary>
    public partial class SpatialAnalysisPersonZoneCrossingOperation : SpatialAnalysisTypedOperationBase
    {
        /// <summary> Initializes a new instance of SpatialAnalysisPersonZoneCrossingOperation. </summary>
        /// <param name="zones"> The list of zones with optional events. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="zones"/> is null. </exception>
        public SpatialAnalysisPersonZoneCrossingOperation(IEnumerable<SpatialAnalysisPersonZoneCrossingZoneEvents> zones)
        {
            if (zones == null)
            {
                throw new ArgumentNullException(nameof(zones));
            }

            Zones = zones.ToList();
            Type = "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonZoneCrossingOperation";
        }

        /// <summary> Initializes a new instance of SpatialAnalysisPersonZoneCrossingOperation. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="debug"> Enables debugging for the Spatial Analysis operation. </param>
        /// <param name="cameraConfiguration"> Advanced camera configuration. </param>
        /// <param name="detectorNodeConfiguration"> Advanced detector node configuration. </param>
        /// <param name="enableFaceMaskClassifier"> Enables face mask detection. </param>
        /// <param name="zones"> The list of zones with optional events. </param>
        internal SpatialAnalysisPersonZoneCrossingOperation(string type, string debug, string cameraConfiguration, string detectorNodeConfiguration, string enableFaceMaskClassifier, IList<SpatialAnalysisPersonZoneCrossingZoneEvents> zones) : base(type, debug, cameraConfiguration, detectorNodeConfiguration, enableFaceMaskClassifier)
        {
            Zones = zones;
            Type = type ?? "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonZoneCrossingOperation";
        }

        /// <summary> The list of zones with optional events. </summary>
        public IList<SpatialAnalysisPersonZoneCrossingZoneEvents> Zones { get; }
    }
}
