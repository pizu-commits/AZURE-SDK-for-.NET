﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Azure.Core.Spatial
{
    /// <summary>
    ///
    /// </summary>
    public sealed class MultiPointGeometry : Geometry
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="points"></param>
        public MultiPointGeometry(IEnumerable<PointGeometry> points): this(points, DefaultProperties)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="points"></param>
        /// <param name="properties"></param>
        public MultiPointGeometry(IEnumerable<PointGeometry> points, GeometryProperties properties): base(properties)
        {
            Argument.AssertNotNull(points, nameof(points));

            Points = points.ToArray();
        }

        /// <summary>
        ///
        /// </summary>
        public IReadOnlyList<PointGeometry> Points { get; }
    }
}