// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Properties specific to each reserved resource type. Not required if not applicable. </summary>
    internal partial class ReservationOrderAliasRequestPropertiesReservedResourceProperties
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

        /// <summary> Initializes a new instance of <see cref="ReservationOrderAliasRequestPropertiesReservedResourceProperties"/>. </summary>
        public ReservationOrderAliasRequestPropertiesReservedResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationOrderAliasRequestPropertiesReservedResourceProperties"/>. </summary>
        /// <param name="instanceFlexibility"> Turning this on will apply the reservation discount to other VMs in the same VM size group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationOrderAliasRequestPropertiesReservedResourceProperties(BillingBenefitsInstanceFlexibility? instanceFlexibility, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceFlexibility = instanceFlexibility;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Turning this on will apply the reservation discount to other VMs in the same VM size group. </summary>
        public BillingBenefitsInstanceFlexibility? InstanceFlexibility { get; set; }
    }
}
