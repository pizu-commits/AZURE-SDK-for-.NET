// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> This type represents the request body for the Search Along Route service. </summary>
    internal partial class SearchAlongRouteRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SearchAlongRouteRequest"/>. </summary>
        public SearchAlongRouteRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchAlongRouteRequest"/>. </summary>
        /// <param name="route"> A valid `GeoJSON LineString` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.4) for details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchAlongRouteRequest(GeoJsonLineString route, Dictionary<string, BinaryData> rawData)
        {
            Route = route;
            _rawData = rawData;
        }

        /// <summary> A valid `GeoJSON LineString` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.4) for details. </summary>
        public GeoJsonLineString Route { get; set; }
    }
}
