// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> See [disable AAD Pod Identity for a specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more details. </summary>
    public partial class ManagedClusterPodIdentityException
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPodIdentityException"/>. </summary>
        /// <param name="name"> The name of the pod identity exception. </param>
        /// <param name="namespace"> The namespace of the pod identity exception. </param>
        /// <param name="podLabels"> The pod labels to match. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="namespace"/> or <paramref name="podLabels"/> is null. </exception>
        public ManagedClusterPodIdentityException(string name, string @namespace, IDictionary<string, string> podLabels)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(@namespace, nameof(@namespace));
            Argument.AssertNotNull(podLabels, nameof(podLabels));

            Name = name;
            Namespace = @namespace;
            PodLabels = podLabels;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPodIdentityException"/>. </summary>
        /// <param name="name"> The name of the pod identity exception. </param>
        /// <param name="namespace"> The namespace of the pod identity exception. </param>
        /// <param name="podLabels"> The pod labels to match. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterPodIdentityException(string name, string @namespace, IDictionary<string, string> podLabels, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Namespace = @namespace;
            PodLabels = podLabels;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPodIdentityException"/> for deserialization. </summary>
        internal ManagedClusterPodIdentityException()
        {
        }

        /// <summary> The name of the pod identity exception. </summary>
        public string Name { get; set; }
        /// <summary> The namespace of the pod identity exception. </summary>
        public string Namespace { get; set; }
        /// <summary> The pod labels to match. </summary>
        public IDictionary<string, string> PodLabels { get; }
    }
}
