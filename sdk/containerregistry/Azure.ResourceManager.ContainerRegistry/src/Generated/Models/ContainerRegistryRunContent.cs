// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary>
    /// The request parameters for scheduling a run.
    /// Please note <see cref="ContainerRegistryRunContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContainerRegistryDockerBuildContent"/>, <see cref="ContainerRegistryEncodedTaskRunContent"/>, <see cref="ContainerRegistryFileTaskRunContent"/> and <see cref="ContainerRegistryTaskRunContent"/>.
    /// </summary>
    public abstract partial class ContainerRegistryRunContent
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryRunContent"/>. </summary>
        protected ContainerRegistryRunContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryRunContent"/>. </summary>
        /// <param name="runRequestType"> The type of the run request. </param>
        /// <param name="isArchiveEnabled"> The value that indicates whether archiving is enabled for the run or not. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the run. </param>
        /// <param name="logTemplate"> The template that describes the repository and tag information for run log artifact. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryRunContent(string runRequestType, bool? isArchiveEnabled, string agentPoolName, string logTemplate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RunRequestType = runRequestType;
            IsArchiveEnabled = isArchiveEnabled;
            AgentPoolName = agentPoolName;
            LogTemplate = logTemplate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the run request. </summary>
        internal string RunRequestType { get; set; }
        /// <summary> The value that indicates whether archiving is enabled for the run or not. </summary>
        [WirePath("isArchiveEnabled")]
        public bool? IsArchiveEnabled { get; set; }
        /// <summary> The dedicated agent pool for the run. </summary>
        [WirePath("agentPoolName")]
        public string AgentPoolName { get; set; }
        /// <summary> The template that describes the repository and tag information for run log artifact. </summary>
        [WirePath("logTemplate")]
        public string LogTemplate { get; set; }
    }
}
