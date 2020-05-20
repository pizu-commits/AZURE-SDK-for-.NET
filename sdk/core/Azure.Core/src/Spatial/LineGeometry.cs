﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Azure.Core.Spatial
{
    /// <summary>
    ///
    /// </summary>
    public sealed class LineGeometry : Geometry
    {
        /// <summary>
        /// Initializes new instance of <see cref="LineGeometry"/>.
        /// </summary>
        /// <param name="positions"></param>
        public LineGeometry(IEnumerable<GeometryPosition> positions): this(positions, DefaultProperties)
        {
        }

        /// <summary>
        /// Initializes new instance of <see cref="LineGeometry"/>.
        /// </summary>
        /// <param name="positions"></param>
        /// <param name="properties">The <see cref="GeometryProperties"/> associated with the geometry.</param>
        public LineGeometry(IEnumerable<GeometryPosition> positions, GeometryProperties properties): base(properties)
        {
            Argument.AssertNotNull(positions, nameof(positions));

            Positions = positions.ToArray();
        }

        /// <summary>
        ///
        /// </summary>
        public IReadOnlyList<GeometryPosition> Positions { get; }
    }
}