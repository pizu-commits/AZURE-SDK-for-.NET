// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of a routing rule that your IoT hub uses to route messages to endpoints. </summary>
    public partial class RoutingRuleProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RoutingRuleProperties"/>. </summary>
        /// <param name="name"> The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a maximum length of 64 characters, and must be unique. </param>
        /// <param name="source"> The source that the routing rule is to be applied to, such as DeviceMessages. </param>
        /// <param name="endpointNames"> The list of endpoints to which messages that satisfy the condition are routed. Currently only one endpoint is allowed. </param>
        /// <param name="isEnabled"> Used to specify whether a route is enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="endpointNames"/> is null. </exception>
        public RoutingRuleProperties(string name, IotHubRoutingSource source, IEnumerable<string> endpointNames, bool isEnabled)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(endpointNames, nameof(endpointNames));

            Name = name;
            Source = source;
            EndpointNames = endpointNames.ToList();
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingRuleProperties"/>. </summary>
        /// <param name="name"> The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a maximum length of 64 characters, and must be unique. </param>
        /// <param name="source"> The source that the routing rule is to be applied to, such as DeviceMessages. </param>
        /// <param name="condition"> The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to true by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language. </param>
        /// <param name="endpointNames"> The list of endpoints to which messages that satisfy the condition are routed. Currently only one endpoint is allowed. </param>
        /// <param name="isEnabled"> Used to specify whether a route is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingRuleProperties(string name, IotHubRoutingSource source, string condition, IList<string> endpointNames, bool isEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Source = source;
            Condition = condition;
            EndpointNames = endpointNames;
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingRuleProperties"/> for deserialization. </summary>
        internal RoutingRuleProperties()
        {
        }

        /// <summary> The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a maximum length of 64 characters, and must be unique. </summary>
        public string Name { get; set; }
        /// <summary> The source that the routing rule is to be applied to, such as DeviceMessages. </summary>
        public IotHubRoutingSource Source { get; set; }
        /// <summary> The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to true by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language. </summary>
        public string Condition { get; set; }
        /// <summary> The list of endpoints to which messages that satisfy the condition are routed. Currently only one endpoint is allowed. </summary>
        public IList<string> EndpointNames { get; }
        /// <summary> Used to specify whether a route is enabled. </summary>
        public bool IsEnabled { get; set; }
    }
}
