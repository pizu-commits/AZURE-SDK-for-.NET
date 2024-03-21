// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The NetworkFabric resource definition. </summary>
    public partial class NetworkTapPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkTapPatch"/>. </summary>
        public NetworkTapPatch()
        {
            Destinations = new ChangeTrackingList<NetworkTapPatchableParametersDestinationsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="pollingType"> Polling type. </param>
        /// <param name="destinations"> List of destination properties to send the filter traffic. </param>
        internal NetworkTapPatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, string annotation, NetworkTapPollingType? pollingType, IList<NetworkTapPatchableParametersDestinationsItem> destinations) : base(tags, serializedAdditionalRawData)
        {
            Annotation = annotation;
            PollingType = pollingType;
            Destinations = destinations;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Polling type. </summary>
        public NetworkTapPollingType? PollingType { get; set; }
        /// <summary> List of destination properties to send the filter traffic. </summary>
        public IList<NetworkTapPatchableParametersDestinationsItem> Destinations { get; }
    }
}
