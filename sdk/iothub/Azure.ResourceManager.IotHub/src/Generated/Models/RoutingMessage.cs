// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Routing message. </summary>
    public partial class RoutingMessage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoutingMessage"/>. </summary>
        public RoutingMessage()
        {
            AppProperties = new ChangeTrackingDictionary<string, string>();
            SystemProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="RoutingMessage"/>. </summary>
        /// <param name="body"> Body of routing message. </param>
        /// <param name="appProperties"> App properties. </param>
        /// <param name="systemProperties"> System properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingMessage(string body, IDictionary<string, string> appProperties, IDictionary<string, string> systemProperties, Dictionary<string, BinaryData> rawData)
        {
            Body = body;
            AppProperties = appProperties;
            SystemProperties = systemProperties;
            _rawData = rawData;
        }

        /// <summary> Body of routing message. </summary>
        public string Body { get; set; }
        /// <summary> App properties. </summary>
        public IDictionary<string, string> AppProperties { get; }
        /// <summary> System properties. </summary>
        public IDictionary<string, string> SystemProperties { get; }
    }
}
