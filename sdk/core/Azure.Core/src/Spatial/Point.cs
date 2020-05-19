﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Core.Spatial
{
    /// <summary>
    ///
    /// </summary>
    public sealed class Point : Geometry
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="position"></param>
        public Point(Position position)
        {
            Position = position;
        }

        /// <summary>
        ///
        /// </summary>
        public Position Position { get; }

        /// <inheritdoc />
        public override string ToString() => $"Point: {Position}";
    }
}