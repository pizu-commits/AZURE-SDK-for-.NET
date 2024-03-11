// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Unknown version of TrackBase. </summary>
    internal partial class UnknownTrackBase : MediaAssetTrackBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTrackBase"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTrackBase(string odataType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, serializedAdditionalRawData)
        {
            OdataType = odataType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTrackBase"/> for deserialization. </summary>
        internal UnknownTrackBase()
        {
        }
    }
}
