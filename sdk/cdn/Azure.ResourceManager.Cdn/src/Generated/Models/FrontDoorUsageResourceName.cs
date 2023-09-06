// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The usage names. </summary>
    public partial class FrontDoorUsageResourceName
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorUsageResourceName"/>. </summary>
        internal FrontDoorUsageResourceName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorUsageResourceName"/>. </summary>
        /// <param name="value"> A string describing the resource name. </param>
        /// <param name="localizedValue"> A localized string describing the resource name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorUsageResourceName(string value, string localizedValue, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            LocalizedValue = localizedValue;
            _rawData = rawData;
        }

        /// <summary> A string describing the resource name. </summary>
        public string Value { get; }
        /// <summary> A localized string describing the resource name. </summary>
        public string LocalizedValue { get; }
    }
}
