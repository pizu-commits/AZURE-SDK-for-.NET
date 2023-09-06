// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Input of CheckNameAvailability API. </summary>
    public partial class CdnNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CdnNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The resource name to validate. </param>
        /// <param name="resourceType"> The type of the resource whose name is to be validated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CdnNameAvailabilityContent(string name, CdnResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="CdnNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The resource name to validate. </param>
        /// <param name="resourceType"> The type of the resource whose name is to be validated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnNameAvailabilityContent(string name, CdnResourceType resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CdnNameAvailabilityContent"/> for deserialization. </summary>
        internal CdnNameAvailabilityContent()
        {
        }

        /// <summary> The resource name to validate. </summary>
        public string Name { get; }
        /// <summary> The type of the resource whose name is to be validated. </summary>
        public CdnResourceType ResourceType { get; }
    }
}
