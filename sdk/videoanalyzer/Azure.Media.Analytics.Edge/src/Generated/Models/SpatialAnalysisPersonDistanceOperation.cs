// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis Person Distance operation to be used in the Cognitive Services Vision processor. </summary>
    public partial class SpatialAnalysisPersonDistanceOperation : SpatialAnalysisTypedOperationBase
    {
        /// <summary> Initializes a new instance of SpatialAnalysisPersonDistanceOperation. </summary>
        /// <param name="zones"> The list of zones with optional events. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="zones"/> is null. </exception>
        public SpatialAnalysisPersonDistanceOperation(IEnumerable<SpatialAnalysisPersonDistanceZoneEvents> zones)
        {
            if (zones == null)
            {
                throw new ArgumentNullException(nameof(zones));
            }

            Zones = zones.ToList();
            Type = "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonDistanceOperation";
        }

        /// <summary> Initializes a new instance of SpatialAnalysisPersonDistanceOperation. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="debug"> Enables debugging for the Spatial Analysis operation. </param>
        /// <param name="cameraConfiguration"> Advanced camera configuration. </param>
        /// <param name="detectorNodeConfiguration"> Advanced detector node configuration. </param>
        /// <param name="enableFaceMaskClassifier"> Enables face mask detection. </param>
        /// <param name="zones"> The list of zones with optional events. </param>
        internal SpatialAnalysisPersonDistanceOperation(string type, string debug, string cameraConfiguration, string detectorNodeConfiguration, string enableFaceMaskClassifier, IList<SpatialAnalysisPersonDistanceZoneEvents> zones) : base(type, debug, cameraConfiguration, detectorNodeConfiguration, enableFaceMaskClassifier)
        {
            Zones = zones;
            Type = type ?? "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonDistanceOperation";
        }

        /// <summary> The list of zones with optional events. </summary>
        public IList<SpatialAnalysisPersonDistanceZoneEvents> Zones { get; }
    }
}
