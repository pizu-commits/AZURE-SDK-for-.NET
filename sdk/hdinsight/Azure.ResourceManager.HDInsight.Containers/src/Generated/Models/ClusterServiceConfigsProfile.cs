// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster service configs. </summary>
    public partial class ClusterServiceConfigsProfile
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

        /// <summary> Initializes a new instance of <see cref="ClusterServiceConfigsProfile"/>. </summary>
        /// <param name="serviceName"> Name of the service the configurations should apply to. </param>
        /// <param name="configs"> List of service configs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="configs"/> is null. </exception>
        public ClusterServiceConfigsProfile(string serviceName, IEnumerable<ClusterServiceConfig> configs)
        {
            Argument.AssertNotNull(serviceName, nameof(serviceName));
            Argument.AssertNotNull(configs, nameof(configs));

            ServiceName = serviceName;
            Configs = configs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterServiceConfigsProfile"/>. </summary>
        /// <param name="serviceName"> Name of the service the configurations should apply to. </param>
        /// <param name="configs"> List of service configs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterServiceConfigsProfile(string serviceName, IList<ClusterServiceConfig> configs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceName = serviceName;
            Configs = configs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterServiceConfigsProfile"/> for deserialization. </summary>
        internal ClusterServiceConfigsProfile()
        {
        }

        /// <summary> Name of the service the configurations should apply to. </summary>
        public string ServiceName { get; set; }
        /// <summary> List of service configs. </summary>
        public IList<ClusterServiceConfig> Configs { get; }
    }
}
