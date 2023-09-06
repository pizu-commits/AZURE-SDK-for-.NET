// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents a configuration for non-DRM keys. </summary>
    public partial class ContentKeyPolicyClearKeyConfiguration : ContentKeyPolicyConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyClearKeyConfiguration"/>. </summary>
        public ContentKeyPolicyClearKeyConfiguration()
        {
            OdataType = "#Microsoft.Media.ContentKeyPolicyClearKeyConfiguration";
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyClearKeyConfiguration"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentKeyPolicyClearKeyConfiguration(string odataType, Dictionary<string, BinaryData> rawData) : base(odataType, rawData)
        {
            OdataType = odataType ?? "#Microsoft.Media.ContentKeyPolicyClearKeyConfiguration";
        }
    }
}
