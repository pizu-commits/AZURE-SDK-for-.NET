// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    /// <summary> A list of serverless runtime resources as fetched using the informatica APIs. </summary>
    public partial class InformaticaServerlessRuntimeResourceList
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

        /// <summary> Initializes a new instance of <see cref="InformaticaServerlessRuntimeResourceList"/>. </summary>
        /// <param name="informaticaRuntimeResources"> List of runtime resources for the fetch all API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="informaticaRuntimeResources"/> is null. </exception>
        internal InformaticaServerlessRuntimeResourceList(IEnumerable<InformaticaRuntimeResourceFetchMetadata> informaticaRuntimeResources)
        {
            Argument.AssertNotNull(informaticaRuntimeResources, nameof(informaticaRuntimeResources));

            InformaticaRuntimeResources = informaticaRuntimeResources.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="InformaticaServerlessRuntimeResourceList"/>. </summary>
        /// <param name="informaticaRuntimeResources"> List of runtime resources for the fetch all API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InformaticaServerlessRuntimeResourceList(IReadOnlyList<InformaticaRuntimeResourceFetchMetadata> informaticaRuntimeResources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InformaticaRuntimeResources = informaticaRuntimeResources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InformaticaServerlessRuntimeResourceList"/> for deserialization. </summary>
        internal InformaticaServerlessRuntimeResourceList()
        {
        }

        /// <summary> List of runtime resources for the fetch all API. </summary>
        public IReadOnlyList<InformaticaRuntimeResourceFetchMetadata> InformaticaRuntimeResources { get; }
    }
}
