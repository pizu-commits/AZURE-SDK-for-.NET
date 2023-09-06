// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> Open authentication policy claim. </summary>
    public partial class OpenAuthenticationPolicyClaim
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OpenAuthenticationPolicyClaim"/>. </summary>
        public OpenAuthenticationPolicyClaim()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OpenAuthenticationPolicyClaim"/>. </summary>
        /// <param name="name"> The name of the claim. </param>
        /// <param name="value"> The value of the claim. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OpenAuthenticationPolicyClaim(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The name of the claim. </summary>
        public string Name { get; set; }
        /// <summary> The value of the claim. </summary>
        public string Value { get; set; }
    }
}
