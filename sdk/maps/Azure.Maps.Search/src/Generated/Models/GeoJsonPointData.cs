// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> Data contained by a `GeoJson Point`. </summary>
    public partial class GeoJsonPointData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GeoJsonPointData"/>. </summary>
        /// <param name="coordinates"> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonPointData(IEnumerable<double> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonPointData"/>. </summary>
        /// <param name="coordinates"> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoJsonPointData(IList<double> coordinates, Dictionary<string, BinaryData> rawData)
        {
            Coordinates = coordinates;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonPointData"/> for deserialization. </summary>
        internal GeoJsonPointData()
        {
        }

        /// <summary> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </summary>
        public IList<double> Coordinates { get; }
    }
}
