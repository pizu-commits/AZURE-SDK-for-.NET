// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Maps.Render
{
    /// <summary> Options for rendering tiles. </summary>
    public class RenderTileOptions
    {
        /// <summary> Desired format of the tile. Possible value: <c>TileFormat.Png</c> and <c>TileFormat.Pbf</c>. </summary>
        public TileFormat TileFormat { get; set; }
        /// <summary>
        /// Map layer requested. Possible value: <c>MapTileLayer.Basic</c>, <c>MapTileLayer.Labels</c>, <c>MapTileLayer.Hybrid</c> or <c>MapTileLayer.Terra</c>
        /// </summary>
        public MapTileLayer TileLayer { get; set; }
        /// <summary> Map style to be returned. Possible values are <c>MapTileStyle.Main</c>, <c>MapTileStyle.Dark</c> or <c>MapTileStyle.ShadedRelief</c>. </summary>
        public MapTileStyle TileStyle { get; set; }
        /// <summary>
        /// Zoom level, and coordinate of the tile on zoom grid.
        ///
        /// The value of X and Y coordinate in <c>TileIndex</c> must be in the range [0, (2^zoom)-1]].
        /// Please see <see href="https://docs.microsoft.com/azure/location-based-services/zoom-levels-and-tile-grid">Zoom Levels and Tile Grid</see> for details.
        /// </summary>
        public TileIndex TileIndex { get; set; }
        /// <summary>
        /// The size of the returned map tile in pixels. Possible value: <c>MapTileSize.Size256</c> and <c>MapTileSize.Size512</c>
        /// </summary>
        public MapTileSize? TileSize { get; set; }
        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used.
        ///
        /// Please refer to <see href="https://docs.microsoft.com/azure/azure-maps/supported-languages">Supported Languages</see> for details.
        /// </summary>
        public string RenderLanguage { get; set; }
        /// <summary>
        /// The View parameter (also called the "user region" parameter) allows you to show the correct maps for a certain country/region for geopolitically disputed regions. Different countries have different views of such regions, and the View parameter allows your application to comply with the view required by the country your application will be serving. By default, the View parameter is set to “Unified” even if you haven’t defined it in  the request. It is your responsibility to determine the location of your users, and then set the View parameter correctly for that location. Alternatively, you have the option to set ‘View=Auto’, which will return the map data based on the IP  address of the request. The View parameter in Azure Maps must be used in compliance with applicable laws, including those  regarding mapping, of the country where maps, images and other data and third party content that you are authorized to  access via Azure Maps is made available. Example: view=IN.
        ///
        /// Please refer to <see href="https://aka.ms/AzureMapsLocalizationViews">Supported Views</see> for details and to see the available Views.
        /// </summary>
        public Azure.Maps.LocalizedMapView? LocalizedMapView { get; set; }
    }
}
