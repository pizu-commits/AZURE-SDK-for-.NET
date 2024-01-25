// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the route configuration override action for the delivery rule. Only applicable to Frontdoor Standard/Premium Profiles. </summary>
    public partial class DeliveryRuleRouteConfigurationOverrideAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleRouteConfigurationOverrideAction(RouteConfigurationOverrideActionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = DeliveryRuleActionType.RouteConfigurationOverride;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal DeliveryRuleRouteConfigurationOverrideAction(DeliveryRuleActionType name, IDictionary<string, BinaryData> serializedAdditionalRawData, RouteConfigurationOverrideActionProperties properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRouteConfigurationOverrideAction"/> for deserialization. </summary>
        internal DeliveryRuleRouteConfigurationOverrideAction()
        {
        }

        /// <summary> Defines the parameters for the action. </summary>
        public RouteConfigurationOverrideActionProperties Properties { get; set; }
    }
}
