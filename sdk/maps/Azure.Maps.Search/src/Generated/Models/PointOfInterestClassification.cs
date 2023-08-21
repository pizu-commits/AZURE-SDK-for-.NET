// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> The classification for the POI being returned. </summary>
    public partial class PointOfInterestClassification
    {
        /// <summary> Initializes a new instance of PointOfInterestClassification. </summary>
        internal PointOfInterestClassification()
        {
            Names = new Core.ChangeTrackingList<ClassificationName>();
        }

        /// <summary> Initializes a new instance of PointOfInterestClassification. </summary>
        /// <param name="code"> Code property. </param>
        /// <param name="names"> Names array. </param>
        internal PointOfInterestClassification(string code, IReadOnlyList<ClassificationName> names)
        {
            Code = code;
            Names = names;
        }

        /// <summary> Code property. </summary>
        public string Code { get; }
        /// <summary> Names array. </summary>
        public IReadOnlyList<ClassificationName> Names { get; }
    }
}
