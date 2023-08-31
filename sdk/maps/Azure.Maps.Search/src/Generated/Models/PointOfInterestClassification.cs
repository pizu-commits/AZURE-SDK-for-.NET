// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> The classification for the POI being returned. </summary>
    public partial class PointOfInterestClassification
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PointOfInterestClassification"/>. </summary>
        internal PointOfInterestClassification()
        {
            Names = new ChangeTrackingList<ClassificationName>();
        }

        /// <summary> Initializes a new instance of <see cref="PointOfInterestClassification"/>. </summary>
        /// <param name="code"> Code property. </param>
        /// <param name="names"> Names array. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PointOfInterestClassification(string code, IReadOnlyList<ClassificationName> names, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Names = names;
            _rawData = rawData;
        }

        /// <summary> Code property. </summary>
        public string Code { get; }
        /// <summary> Names array. </summary>
        public IReadOnlyList<ClassificationName> Names { get; }
    }
}
