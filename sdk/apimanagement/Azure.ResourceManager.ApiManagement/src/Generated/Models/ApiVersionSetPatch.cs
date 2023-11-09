// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters to update or create an API Version Set Contract. </summary>
    public partial class ApiVersionSetPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiVersionSetPatch"/>. </summary>
        public ApiVersionSetPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiVersionSetPatch"/>. </summary>
        /// <param name="description"> Description of API Version Set. </param>
        /// <param name="versionQueryName"> Name of query parameter that indicates the API Version if versioningScheme is set to `query`. </param>
        /// <param name="versionHeaderName"> Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`. </param>
        /// <param name="displayName"> Name of API Version Set. </param>
        /// <param name="versioningScheme"> An value that determines where the API Version identifier will be located in a HTTP request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiVersionSetPatch(string description, string versionQueryName, string versionHeaderName, string displayName, VersioningScheme? versioningScheme, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            VersionQueryName = versionQueryName;
            VersionHeaderName = versionHeaderName;
            DisplayName = displayName;
            VersioningScheme = versioningScheme;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Description of API Version Set. </summary>
        public string Description { get; set; }
        /// <summary> Name of query parameter that indicates the API Version if versioningScheme is set to `query`. </summary>
        public string VersionQueryName { get; set; }
        /// <summary> Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`. </summary>
        public string VersionHeaderName { get; set; }
        /// <summary> Name of API Version Set. </summary>
        public string DisplayName { get; set; }
        /// <summary> An value that determines where the API Version identifier will be located in a HTTP request. </summary>
        public VersioningScheme? VersioningScheme { get; set; }
    }
}
