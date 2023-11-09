// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The result of a request to list API keys. </summary>
    internal partial class AppConfigurationStoreApiKeyListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationStoreApiKeyListResult"/>. </summary>
        internal AppConfigurationStoreApiKeyListResult()
        {
            Value = new ChangeTrackingList<AppConfigurationStoreApiKey>();
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationStoreApiKeyListResult"/>. </summary>
        /// <param name="value"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationStoreApiKeyListResult(IReadOnlyList<AppConfigurationStoreApiKey> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<AppConfigurationStoreApiKey> Value { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}
