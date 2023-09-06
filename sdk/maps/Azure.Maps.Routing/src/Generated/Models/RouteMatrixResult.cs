// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> This object is returned from a successful Route Matrix call. For ex, if 2 origins and 3 destinations are provided, there are going to 2 arrays with 3 elements in each. Each element's content depends on the options provided in the query. </summary>
    public partial class RouteMatrixResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RouteMatrixResult"/>. </summary>
        internal RouteMatrixResult()
        {
            Matrix = new ChangeTrackingList<IList<RouteMatrix>>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteMatrixResult"/>. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="matrix"> Results as a 2 dimensional array of route summaries. </param>
        /// <param name="summary"> Summary object. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteMatrixResult(string formatVersion, IReadOnlyList<IList<RouteMatrix>> matrix, RouteMatrixSummary summary, Dictionary<string, BinaryData> rawData)
        {
            FormatVersion = formatVersion;
            Matrix = matrix;
            Summary = summary;
            _rawData = rawData;
        }

        /// <summary> Format Version property. </summary>
        public string FormatVersion { get; }
        /// <summary> Results as a 2 dimensional array of route summaries. </summary>
        public IReadOnlyList<IList<RouteMatrix>> Matrix { get; }
        /// <summary> Summary object. </summary>
        public RouteMatrixSummary Summary { get; }
    }
}
