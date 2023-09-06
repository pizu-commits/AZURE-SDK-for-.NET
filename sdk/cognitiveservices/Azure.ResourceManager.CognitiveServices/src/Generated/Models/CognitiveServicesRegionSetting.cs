// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The call rate limit Cognitive Services account. </summary>
    public partial class CognitiveServicesRegionSetting
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesRegionSetting"/>. </summary>
        public CognitiveServicesRegionSetting()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesRegionSetting"/>. </summary>
        /// <param name="name"> Name of the region. </param>
        /// <param name="value"> A value for priority or weighted routing methods. </param>
        /// <param name="customsubdomain"> Maps the region to the regional custom subdomain. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesRegionSetting(string name, float? value, string customsubdomain, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            Customsubdomain = customsubdomain;
            _rawData = rawData;
        }

        /// <summary> Name of the region. </summary>
        public string Name { get; set; }
        /// <summary> A value for priority or weighted routing methods. </summary>
        public float? Value { get; set; }
        /// <summary> Maps the region to the regional custom subdomain. </summary>
        public string Customsubdomain { get; set; }
    }
}
