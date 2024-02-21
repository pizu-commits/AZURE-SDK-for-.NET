// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Search.Models
{
    /// <summary> A valid `GeoJSON Point` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.2) for details. </summary>
    internal partial class GeoJsonPoint : GeoJsonGeometry
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonPoint"/>. </summary>
        /// <param name="coordinates"> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonPoint(IEnumerable<double> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            Coordinates = coordinates.ToList();
            Type = GeoJsonObjectType.GeoJsonPoint;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonPoint"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="coordinates"> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </param>
        internal GeoJsonPoint(GeoJsonObjectType type, IList<double> coordinates) : base(type)
        {
            Coordinates = coordinates;
            Type = type;
        }

        /// <summary> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </summary>
        public IList<double> Coordinates { get; }
    }
}
