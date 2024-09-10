// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> FQDN Outbound Rule for the managed network of a machine learning workspace. </summary>
    public partial class FqdnOutboundRule : MachineLearningOutboundRule
    {
        /// <summary> Initializes a new instance of <see cref="FqdnOutboundRule"/>. </summary>
        public FqdnOutboundRule()
        {
            OutboundRuleType = OutboundRuleType.Fqdn;
        }

        /// <summary> Initializes a new instance of <see cref="FqdnOutboundRule"/>. </summary>
        /// <param name="category"> Category of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="status"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="outboundRuleType"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="destination"></param>
        internal FqdnOutboundRule(OutboundRuleCategory? category, OutboundRuleStatus? status, OutboundRuleType outboundRuleType, IDictionary<string, BinaryData> serializedAdditionalRawData, string destination) : base(category, status, outboundRuleType, serializedAdditionalRawData)
        {
            Destination = destination;
            OutboundRuleType = outboundRuleType;
        }

        /// <summary> Gets or sets the destination. </summary>
        [WirePath("destination")]
        public string Destination { get; set; }
    }
}
