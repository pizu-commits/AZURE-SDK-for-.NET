﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Azure.Core.Spatial
{
    /// <summary>
    ///
    /// </summary>
    public sealed class MultiLineString : Geometry
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="lineStrings"></param>
        public MultiLineString(IEnumerable<LineString> lineStrings)
        {
            LineStrings = lineStrings.ToArray();
        }

        /// <summary>
        ///
        /// </summary>
        public IReadOnlyList<LineString> LineStrings { get; }
    }
}