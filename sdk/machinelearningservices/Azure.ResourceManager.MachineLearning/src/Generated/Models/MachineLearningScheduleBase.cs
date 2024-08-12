// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningScheduleBase. </summary>
    public partial class MachineLearningScheduleBase
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleBase"/>. </summary>
        public MachineLearningScheduleBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleBase"/>. </summary>
        /// <param name="id"> A system assigned id for the schedule. </param>
        /// <param name="provisioningStatus"> The current deployment state of schedule. </param>
        /// <param name="status"> Is the schedule enabled or disabled?. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningScheduleBase(string id, MachineLearningScheduleProvisioningState? provisioningStatus, MachineLearningScheduleStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ProvisioningStatus = provisioningStatus;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A system assigned id for the schedule. </summary>
        public string Id { get; set; }
        /// <summary> The current deployment state of schedule. </summary>
        public MachineLearningScheduleProvisioningState? ProvisioningStatus { get; set; }
        /// <summary> Is the schedule enabled or disabled?. </summary>
        public MachineLearningScheduleStatus? Status { get; set; }
    }
}
