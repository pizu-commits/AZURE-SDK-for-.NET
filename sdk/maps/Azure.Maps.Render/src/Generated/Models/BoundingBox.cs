// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Render
{
    /// <summary> Parameter group. </summary>
    internal partial class BoundingBox
    {
        /// <summary> Initializes a new instance of BoundingBox. </summary>
        /// <param name="southWest"> Minimum coordinates (south-west point) of bounding box in latitude longitude coordinate system. E.g. 52.41064,4.84228. </param>
        /// <param name="northEast"> Maximum coordinates (north-east point) of bounding box in latitude longitude coordinate system. E.g. 52.41064,4.84228. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="southWest"/> or <paramref name="northEast"/> is null. </exception>
        public BoundingBox(IEnumerable<double> southWest, IEnumerable<double> northEast)
        {
            if (southWest == null)
            {
                throw new ArgumentNullException(nameof(southWest));
            }
            if (northEast == null)
            {
                throw new ArgumentNullException(nameof(northEast));
            }

            SouthWest = southWest.ToList();
            NorthEast = northEast.ToList();
        }

        /// <summary> Minimum coordinates (south-west point) of bounding box in latitude longitude coordinate system. E.g. 52.41064,4.84228. </summary>
        public IList<double> SouthWest { get; }
        /// <summary> Maximum coordinates (north-east point) of bounding box in latitude longitude coordinate system. E.g. 52.41064,4.84228. </summary>
        public IList<double> NorthEast { get; }
    }
}
