// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Greenplum Database dataset. </summary>
    public partial class GreenplumTableDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="GreenplumTableDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public GreenplumTableDataset(DataFactoryLinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            DatasetType = "GreenplumTable";
        }

        /// <summary> Initializes a new instance of <see cref="GreenplumTableDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="tableName"> This property will be retired. Please consider using schema + table properties instead. </param>
        /// <param name="table"> The table name of Greenplum. Type: string (or Expression with resultType string). </param>
        /// <param name="schemaTypePropertiesSchema"> The schema name of Greenplum. Type: string (or Expression with resultType string). </param>
        internal GreenplumTableDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, BinaryData tableName, DataFactoryElement<string> table, DataFactoryElement<string> schemaTypePropertiesSchema) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            TableName = tableName;
            Table = table;
            SchemaTypePropertiesSchema = schemaTypePropertiesSchema;
            DatasetType = datasetType ?? "GreenplumTable";
        }

        /// <summary> Initializes a new instance of <see cref="GreenplumTableDataset"/> for deserialization. </summary>
        internal GreenplumTableDataset()
        {
        }

        /// <summary>
        /// This property will be retired. Please consider using schema + table properties instead.
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
        public BinaryData TableName { get; set; }
        /// <summary> The table name of Greenplum. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Table { get; set; }
        /// <summary> The schema name of Greenplum. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SchemaTypePropertiesSchema { get; set; }
    }
}
