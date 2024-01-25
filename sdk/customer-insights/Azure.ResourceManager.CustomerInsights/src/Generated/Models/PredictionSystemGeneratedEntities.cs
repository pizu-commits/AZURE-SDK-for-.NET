// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> System generated entities. </summary>
    public partial class PredictionSystemGeneratedEntities
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

        /// <summary> Initializes a new instance of <see cref="PredictionSystemGeneratedEntities"/>. </summary>
        internal PredictionSystemGeneratedEntities()
        {
            GeneratedInteractionTypes = new ChangeTrackingList<string>();
            GeneratedLinks = new ChangeTrackingList<string>();
            GeneratedKpis = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="PredictionSystemGeneratedEntities"/>. </summary>
        /// <param name="generatedInteractionTypes"> Generated interaction types. </param>
        /// <param name="generatedLinks"> Generated links. </param>
        /// <param name="generatedKpis"> Generated KPIs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PredictionSystemGeneratedEntities(IReadOnlyList<string> generatedInteractionTypes, IReadOnlyList<string> generatedLinks, IReadOnlyDictionary<string, string> generatedKpis, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GeneratedInteractionTypes = generatedInteractionTypes;
            GeneratedLinks = generatedLinks;
            GeneratedKpis = generatedKpis;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Generated interaction types. </summary>
        public IReadOnlyList<string> GeneratedInteractionTypes { get; }
        /// <summary> Generated links. </summary>
        public IReadOnlyList<string> GeneratedLinks { get; }
        /// <summary> Generated KPIs. </summary>
        public IReadOnlyDictionary<string, string> GeneratedKpis { get; }
    }
}
