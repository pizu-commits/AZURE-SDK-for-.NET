// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Input definition for planned failover input properties.
    /// </summary>
    public partial class TestFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the TestFailoverInputProperties
        /// class.
        /// </summary>
        public TestFailoverInputProperties() { }

        /// <summary>
        /// Initializes a new instance of the TestFailoverInputProperties
        /// class.
        /// </summary>
        public TestFailoverInputProperties(string failoverDirection = default(string), string networkType = default(string), string networkId = default(string), string skipTestFailoverCleanup = default(string), ProviderSpecificFailoverInput providerSpecificDetails = default(ProviderSpecificFailoverInput))
        {
            FailoverDirection = failoverDirection;
            NetworkType = networkType;
            NetworkId = networkId;
            SkipTestFailoverCleanup = skipTestFailoverCleanup;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// Failover direction.
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public string FailoverDirection { get; set; }

        /// <summary>
        /// Network type to be used for test failover.
        /// </summary>
        [JsonProperty(PropertyName = "networkType")]
        public string NetworkType { get; set; }

        /// <summary>
        /// The id of the network to be used for test failover
        /// </summary>
        [JsonProperty(PropertyName = "networkId")]
        public string NetworkId { get; set; }

        /// <summary>
        /// A value indicating whether the test failover cleanup is to be
        /// skipped.
        /// </summary>
        [JsonProperty(PropertyName = "skipTestFailoverCleanup")]
        public string SkipTestFailoverCleanup { get; set; }

        /// <summary>
        /// Provider specific settings
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ProviderSpecificFailoverInput ProviderSpecificDetails { get; set; }

    }
}
