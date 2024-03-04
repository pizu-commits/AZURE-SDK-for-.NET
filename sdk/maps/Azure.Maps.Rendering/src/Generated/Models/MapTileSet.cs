// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Maps.Rendering
{
    /// <summary> Metadata for a tileset in the TileJSON format. </summary>
    public partial class MapTileSet
    {
        /// <summary> Initializes a new instance of <see cref="MapTileSet"/>. </summary>
        internal MapTileSet()
        {
            TileEndpoints = new ChangeTrackingList<string>();
            Grids = new ChangeTrackingList<string>();
            GeoJsonDataFiles = new ChangeTrackingList<string>();
            BoundsInternal = new ChangeTrackingList<float>();
            CenterInternal = new ChangeTrackingList<float>();
        }
    }
}
