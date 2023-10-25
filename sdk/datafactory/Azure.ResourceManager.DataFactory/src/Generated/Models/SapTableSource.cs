// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity source for SAP Table source. </summary>
    public partial class SapTableSource : TabularSource
    {
        /// <summary> Initializes a new instance of SapTableSource. </summary>
        public SapTableSource()
        {
            CopySourceType = "SapTableSource";
        }

        /// <summary> Initializes a new instance of SapTableSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="rowCount"> The number of rows to be retrieved. Type: integer(or Expression with resultType integer). </param>
        /// <param name="rowSkips"> The number of rows that will be skipped. Type: integer (or Expression with resultType integer). </param>
        /// <param name="rfcTableFields"> The fields of the SAP table that will be retrieved. For example, column0, column1. Type: string (or Expression with resultType string). </param>
        /// <param name="rfcTableOptions"> The options for the filtering of the SAP Table. For example, COLUMN0 EQ SOME VALUE. Type: string (or Expression with resultType string). </param>
        /// <param name="batchSize"> Specifies the maximum number of rows that will be retrieved at a time when retrieving data from SAP Table. Type: integer (or Expression with resultType integer). </param>
        /// <param name="customRfcReadTableFunctionModule"> Specifies the custom RFC function module that will be used to read data from SAP Table. Type: string (or Expression with resultType string). </param>
        /// <param name="sapDataColumnDelimiter"> The single character that will be used as delimiter passed to SAP RFC as well as splitting the output data retrieved. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for SAP table read in parallel. Possible values include: "None", "PartitionOnInt", "PartitionOnCalendarYear", "PartitionOnCalendarMonth", "PartitionOnCalendarDate", "PartitionOnTime". </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for SAP table source partitioning. </param>
        internal SapTableSource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> queryTimeout, BinaryData additionalColumns, DataFactoryElement<int> rowCount, DataFactoryElement<int> rowSkips, DataFactoryElement<string> rfcTableFields, DataFactoryElement<string> rfcTableOptions, DataFactoryElement<int> batchSize, DataFactoryElement<string> customRfcReadTableFunctionModule, DataFactoryElement<string> sapDataColumnDelimiter, BinaryData partitionOption, SapTablePartitionSettings partitionSettings) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties, queryTimeout, additionalColumns)
        {
            RowCount = rowCount;
            RowSkips = rowSkips;
            RfcTableFields = rfcTableFields;
            RfcTableOptions = rfcTableOptions;
            BatchSize = batchSize;
            CustomRfcReadTableFunctionModule = customRfcReadTableFunctionModule;
            SapDataColumnDelimiter = sapDataColumnDelimiter;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            CopySourceType = copySourceType ?? "SapTableSource";
        }

        /// <summary> The number of rows to be retrieved. Type: integer(or Expression with resultType integer). </summary>
        public DataFactoryElement<int> RowCount { get; set; }
        /// <summary> The number of rows that will be skipped. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> RowSkips { get; set; }
        /// <summary> The fields of the SAP table that will be retrieved. For example, column0, column1. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> RfcTableFields { get; set; }
        /// <summary> The options for the filtering of the SAP Table. For example, COLUMN0 EQ SOME VALUE. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> RfcTableOptions { get; set; }
        /// <summary> Specifies the maximum number of rows that will be retrieved at a time when retrieving data from SAP Table. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> BatchSize { get; set; }
        /// <summary> Specifies the custom RFC function module that will be used to read data from SAP Table. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> CustomRfcReadTableFunctionModule { get; set; }
        /// <summary> The single character that will be used as delimiter passed to SAP RFC as well as splitting the output data retrieved. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SapDataColumnDelimiter { get; set; }
        /// <summary>
        /// The partition mechanism that will be used for SAP table read in parallel. Possible values include: "None", "PartitionOnInt", "PartitionOnCalendarYear", "PartitionOnCalendarMonth", "PartitionOnCalendarDate", "PartitionOnTime".
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
        public BinaryData PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for SAP table source partitioning. </summary>
        public SapTablePartitionSettings PartitionSettings { get; set; }
    }
}
