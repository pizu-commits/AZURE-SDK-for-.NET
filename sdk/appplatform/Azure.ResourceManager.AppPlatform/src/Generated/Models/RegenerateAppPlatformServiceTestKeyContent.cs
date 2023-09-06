// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Regenerate test key request payload. </summary>
    public partial class RegenerateAppPlatformServiceTestKeyContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RegenerateAppPlatformServiceTestKeyContent"/>. </summary>
        /// <param name="keyType"> Type of the test key. </param>
        public RegenerateAppPlatformServiceTestKeyContent(AppPlatformServiceTestKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Initializes a new instance of <see cref="RegenerateAppPlatformServiceTestKeyContent"/>. </summary>
        /// <param name="keyType"> Type of the test key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RegenerateAppPlatformServiceTestKeyContent(AppPlatformServiceTestKeyType keyType, Dictionary<string, BinaryData> rawData)
        {
            KeyType = keyType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RegenerateAppPlatformServiceTestKeyContent"/> for deserialization. </summary>
        internal RegenerateAppPlatformServiceTestKeyContent()
        {
        }

        /// <summary> Type of the test key. </summary>
        public AppPlatformServiceTestKeyType KeyType { get; }
    }
}
