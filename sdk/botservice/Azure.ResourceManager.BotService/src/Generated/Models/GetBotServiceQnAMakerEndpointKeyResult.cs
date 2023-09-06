// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Schema for EndpointKeys generate/refresh operations. </summary>
    public partial class GetBotServiceQnAMakerEndpointKeyResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GetBotServiceQnAMakerEndpointKeyResult"/>. </summary>
        internal GetBotServiceQnAMakerEndpointKeyResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GetBotServiceQnAMakerEndpointKeyResult"/>. </summary>
        /// <param name="primaryEndpointKey"> Primary Access Key. </param>
        /// <param name="secondaryEndpointKey"> Secondary Access Key. </param>
        /// <param name="installedVersion"> Current version of runtime. </param>
        /// <param name="lastStableVersion"> Latest version of runtime. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GetBotServiceQnAMakerEndpointKeyResult(string primaryEndpointKey, string secondaryEndpointKey, string installedVersion, string lastStableVersion, Dictionary<string, BinaryData> rawData)
        {
            PrimaryEndpointKey = primaryEndpointKey;
            SecondaryEndpointKey = secondaryEndpointKey;
            InstalledVersion = installedVersion;
            LastStableVersion = lastStableVersion;
            _rawData = rawData;
        }

        /// <summary> Primary Access Key. </summary>
        public string PrimaryEndpointKey { get; }
        /// <summary> Secondary Access Key. </summary>
        public string SecondaryEndpointKey { get; }
        /// <summary> Current version of runtime. </summary>
        public string InstalledVersion { get; }
        /// <summary> Latest version of runtime. </summary>
        public string LastStableVersion { get; }
    }
}
