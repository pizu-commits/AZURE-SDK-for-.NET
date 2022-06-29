// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// A condition for the delivery rule.
    /// Please note <see cref="DeliveryRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DeliveryRuleClientPortCondition"/>, <see cref="DeliveryRuleCookiesCondition"/>, <see cref="DeliveryRuleHostNameCondition"/>, <see cref="DeliveryRuleHttpVersionCondition"/>, <see cref="DeliveryRuleIsDeviceCondition"/>, <see cref="DeliveryRulePostArgsCondition"/>, <see cref="DeliveryRuleQueryStringCondition"/>, <see cref="DeliveryRuleRemoteAddressCondition"/>, <see cref="DeliveryRuleRequestBodyCondition"/>, <see cref="DeliveryRuleRequestHeaderCondition"/>, <see cref="DeliveryRuleRequestMethodCondition"/>, <see cref="DeliveryRuleRequestSchemeCondition"/>, <see cref="DeliveryRuleRequestUriCondition"/>, <see cref="DeliveryRuleServerPortCondition"/>, <see cref="DeliveryRuleSocketAddressCondition"/>, <see cref="DeliveryRuleSslProtocolCondition"/>, <see cref="DeliveryRuleUriFileExtensionCondition"/>, <see cref="DeliveryRuleUriFileNameCondition"/> and <see cref="DeliveryRuleUriPathCondition"/>.
    /// </summary>
    public partial class DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleCondition. </summary>
        public DeliveryRuleCondition()
        {
        }

        /// <summary> Initializes a new instance of DeliveryRuleCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        internal DeliveryRuleCondition(MatchVariable name)
        {
            Name = name;
        }

        /// <summary> The name of the condition for the delivery rule. </summary>
        internal MatchVariable Name { get; set; }
    }
}
