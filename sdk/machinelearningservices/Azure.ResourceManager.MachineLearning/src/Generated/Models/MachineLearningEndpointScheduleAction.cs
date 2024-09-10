// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningEndpointScheduleAction. </summary>
    public partial class MachineLearningEndpointScheduleAction : MachineLearningScheduleAction
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointScheduleAction"/>. </summary>
        /// <param name="endpointInvocationDefinition">
        /// [Required] Defines Schedule action definition details.
        /// &lt;see href="TBD" /&gt;
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointInvocationDefinition"/> is null. </exception>
        public MachineLearningEndpointScheduleAction(BinaryData endpointInvocationDefinition)
        {
            Argument.AssertNotNull(endpointInvocationDefinition, nameof(endpointInvocationDefinition));

            EndpointInvocationDefinition = endpointInvocationDefinition;
            ActionType = ScheduleActionType.InvokeBatchEndpoint;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointScheduleAction"/>. </summary>
        /// <param name="actionType"> [Required] Specifies the action type of the schedule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="endpointInvocationDefinition">
        /// [Required] Defines Schedule action definition details.
        /// &lt;see href="TBD" /&gt;
        /// </param>
        internal MachineLearningEndpointScheduleAction(ScheduleActionType actionType, IDictionary<string, BinaryData> serializedAdditionalRawData, BinaryData endpointInvocationDefinition) : base(actionType, serializedAdditionalRawData)
        {
            EndpointInvocationDefinition = endpointInvocationDefinition;
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointScheduleAction"/> for deserialization. </summary>
        internal MachineLearningEndpointScheduleAction()
        {
        }

        /// <summary>
        /// [Required] Defines Schedule action definition details.
        /// &lt;see href="TBD" /&gt;
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("endpointInvocationDefinition")]
        public BinaryData EndpointInvocationDefinition { get; set; }
    }
}
