// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the ClientPort condition for the delivery rule. </summary>
    public partial class DeliveryRuleClientPortCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleClientPortCondition. </summary>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleClientPortCondition(ClientPortMatchCondition parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = MatchVariable.ClientPort;
        }

        /// <summary> Initializes a new instance of DeliveryRuleClientPortCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        internal DeliveryRuleClientPortCondition(MatchVariable name, ClientPortMatchCondition parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public ClientPortMatchCondition Parameters { get; set; }
    }
}
