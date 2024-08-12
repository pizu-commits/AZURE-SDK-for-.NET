// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The GitHub action configuration. </summary>
    public partial class GitHubActionConfiguration
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

        /// <summary> Initializes a new instance of <see cref="GitHubActionConfiguration"/>. </summary>
        public GitHubActionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubActionConfiguration"/>. </summary>
        /// <param name="codeConfiguration"> GitHub Action code configuration. </param>
        /// <param name="containerConfiguration"> GitHub Action container configuration. </param>
        /// <param name="isLinux"> This will help determine the workflow configuration to select. </param>
        /// <param name="generateWorkflowFile"> Workflow option to determine whether the workflow file should be generated and written to the repository. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubActionConfiguration(GitHubActionCodeConfiguration codeConfiguration, GitHubActionContainerConfiguration containerConfiguration, bool? isLinux, bool? generateWorkflowFile, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CodeConfiguration = codeConfiguration;
            ContainerConfiguration = containerConfiguration;
            IsLinux = isLinux;
            GenerateWorkflowFile = generateWorkflowFile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> GitHub Action code configuration. </summary>
        [WirePath("codeConfiguration")]
        public GitHubActionCodeConfiguration CodeConfiguration { get; set; }
        /// <summary> GitHub Action container configuration. </summary>
        [WirePath("containerConfiguration")]
        public GitHubActionContainerConfiguration ContainerConfiguration { get; set; }
        /// <summary> This will help determine the workflow configuration to select. </summary>
        [WirePath("isLinux")]
        public bool? IsLinux { get; set; }
        /// <summary> Workflow option to determine whether the workflow file should be generated and written to the repository. </summary>
        [WirePath("generateWorkflowFile")]
        public bool? GenerateWorkflowFile { get; set; }
    }
}
