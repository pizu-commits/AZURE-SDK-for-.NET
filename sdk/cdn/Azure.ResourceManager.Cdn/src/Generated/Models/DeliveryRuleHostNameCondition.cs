// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the HostName condition for the delivery rule. </summary>
    public partial class DeliveryRuleHostNameCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleHostNameCondition"/>. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleHostNameCondition(HostNameMatchCondition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = MatchVariable.HostName;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleHostNameCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeliveryRuleHostNameCondition(MatchVariable name, HostNameMatchCondition properties, Dictionary<string, BinaryData> rawData) : base(name, rawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleHostNameCondition"/> for deserialization. </summary>
        internal DeliveryRuleHostNameCondition()
        {
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public HostNameMatchCondition Properties { get; set; }
    }
}
