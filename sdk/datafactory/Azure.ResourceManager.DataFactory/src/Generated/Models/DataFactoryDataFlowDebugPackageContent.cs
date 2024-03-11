// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Request body structure for starting data flow debug session. </summary>
    public partial class DataFactoryDataFlowDebugPackageContent
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowDebugPackageContent"/>. </summary>
        public DataFactoryDataFlowDebugPackageContent()
        {
            DataFlows = new ChangeTrackingList<DataFactoryDataFlowDebugInfo>();
            Datasets = new ChangeTrackingList<DataFactoryDatasetDebugInfo>();
            LinkedServices = new ChangeTrackingList<DataFactoryLinkedServiceDebugInfo>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowDebugPackageContent"/>. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="dataFlow"> Data flow instance. </param>
        /// <param name="dataFlows"> List of Data flows. </param>
        /// <param name="datasets"> List of datasets. </param>
        /// <param name="linkedServices"> List of linked services. </param>
        /// <param name="staging"> Staging info for debug session. </param>
        /// <param name="debugSettings"> Data flow debug settings. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryDataFlowDebugPackageContent(Guid? sessionId, DataFactoryDataFlowDebugInfo dataFlow, IList<DataFactoryDataFlowDebugInfo> dataFlows, IList<DataFactoryDatasetDebugInfo> datasets, IList<DataFactoryLinkedServiceDebugInfo> linkedServices, DataFlowStagingInfo staging, DataFlowDebugPackageDebugSettings debugSettings, IDictionary<string, BinaryData> additionalProperties)
        {
            SessionId = sessionId;
            DataFlow = dataFlow;
            DataFlows = dataFlows;
            Datasets = datasets;
            LinkedServices = linkedServices;
            Staging = staging;
            DebugSettings = debugSettings;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The ID of data flow debug session. </summary>
        public Guid? SessionId { get; set; }
        /// <summary> Data flow instance. </summary>
        public DataFactoryDataFlowDebugInfo DataFlow { get; set; }
        /// <summary> List of Data flows. </summary>
        public IList<DataFactoryDataFlowDebugInfo> DataFlows { get; }
        /// <summary> List of datasets. </summary>
        public IList<DataFactoryDatasetDebugInfo> Datasets { get; }
        /// <summary> List of linked services. </summary>
        public IList<DataFactoryLinkedServiceDebugInfo> LinkedServices { get; }
        /// <summary> Staging info for debug session. </summary>
        public DataFlowStagingInfo Staging { get; set; }
        /// <summary> Data flow debug settings. </summary>
        public DataFlowDebugPackageDebugSettings DebugSettings { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
