// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Optimized way point object. </summary>
    public partial class RouteOptimizedWaypoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RouteOptimizedWaypoint"/>. </summary>
        internal RouteOptimizedWaypoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouteOptimizedWaypoint"/>. </summary>
        /// <param name="providedIndex"> Way point index provided by the user. </param>
        /// <param name="optimizedIndex"> Optimized way point index from the system. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteOptimizedWaypoint(int? providedIndex, int? optimizedIndex, Dictionary<string, BinaryData> rawData)
        {
            ProvidedIndex = providedIndex;
            OptimizedIndex = optimizedIndex;
            _rawData = rawData;
        }

        /// <summary> Way point index provided by the user. </summary>
        public int? ProvidedIndex { get; }
        /// <summary> Optimized way point index from the system. </summary>
        public int? OptimizedIndex { get; }
    }
}
