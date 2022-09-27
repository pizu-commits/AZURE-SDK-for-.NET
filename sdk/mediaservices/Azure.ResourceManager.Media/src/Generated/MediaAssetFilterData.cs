// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary> A class representing the MediaAssetFilter data model. </summary>
    public partial class MediaAssetFilterData : ResourceData
    {
        /// <summary> Initializes a new instance of MediaAssetFilterData. </summary>
        public MediaAssetFilterData()
        {
            Tracks = new ChangeTrackingList<FilterTrackSelection>();
        }

        /// <summary> Initializes a new instance of MediaAssetFilterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="presentationTimeRange"> The presentation time range. </param>
        /// <param name="firstQuality"> The first quality. </param>
        /// <param name="tracks"> The tracks selection conditions. </param>
        internal MediaAssetFilterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PresentationTimeRange presentationTimeRange, FirstQuality firstQuality, IList<FilterTrackSelection> tracks) : base(id, name, resourceType, systemData)
        {
            PresentationTimeRange = presentationTimeRange;
            FirstQuality = firstQuality;
            Tracks = tracks;
        }

        /// <summary> The presentation time range. </summary>
        public PresentationTimeRange PresentationTimeRange { get; set; }
        /// <summary> The first quality. </summary>
        internal FirstQuality FirstQuality { get; set; }
        /// <summary> The first quality bitrate. </summary>
        public int? FirstQualityBitrate
        {
            get => FirstQuality is null ? default(int?) : FirstQuality.Bitrate;
            set
            {
                FirstQuality = value.HasValue ? new FirstQuality(value.Value) : null;
            }
        }

        /// <summary> The tracks selection conditions. </summary>
        public IList<FilterTrackSelection> Tracks { get; }
    }
}
