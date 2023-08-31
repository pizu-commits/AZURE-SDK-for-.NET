// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> This type represents the request body for the Search Inside Geometry service. </summary>
    internal partial class SearchInsideGeometryRequest
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SearchInsideGeometryRequest"/>. </summary>
        public SearchInsideGeometryRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchInsideGeometryRequest"/>. </summary>
        /// <param name="geometry">
        /// A valid `GeoJSON` object. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3) for details.
        /// Please note <see cref="GeoJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonFeature"/>, <see cref="GeoJsonFeatureCollection"/>, <see cref="GeoJsonGeometry"/>, <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchInsideGeometryRequest(GeoJsonObject geometry, Dictionary<string, BinaryData> rawData)
        {
            Geometry = geometry;
            _rawData = rawData;
        }

        /// <summary>
        /// A valid `GeoJSON` object. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3) for details.
        /// Please note <see cref="GeoJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonFeature"/>, <see cref="GeoJsonFeatureCollection"/>, <see cref="GeoJsonGeometry"/>, <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </summary>
        public GeoJsonObject Geometry { get; set; }
    }
}
