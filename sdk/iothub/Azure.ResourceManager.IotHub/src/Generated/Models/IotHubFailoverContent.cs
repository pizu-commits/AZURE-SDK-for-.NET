// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Use to provide failover region when requesting manual Failover for a hub. </summary>
    public partial class IotHubFailoverContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IotHubFailoverContent"/>. </summary>
        /// <param name="failoverRegion"> Region the hub will be failed over to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverRegion"/> is null. </exception>
        public IotHubFailoverContent(string failoverRegion)
        {
            Argument.AssertNotNull(failoverRegion, nameof(failoverRegion));

            FailoverRegion = failoverRegion;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubFailoverContent"/>. </summary>
        /// <param name="failoverRegion"> Region the hub will be failed over to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubFailoverContent(string failoverRegion, Dictionary<string, BinaryData> rawData)
        {
            FailoverRegion = failoverRegion;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubFailoverContent"/> for deserialization. </summary>
        internal IotHubFailoverContent()
        {
        }

        /// <summary> Region the hub will be failed over to. </summary>
        public string FailoverRegion { get; }
    }
}
