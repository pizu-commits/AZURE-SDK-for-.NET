// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactoryLinkedService data model.
    /// Linked service resource type.
    /// </summary>
    public partial class DataFactoryLinkedServiceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DataFactoryLinkedServiceData"/>. </summary>
        /// <param name="properties">
        /// Properties of linked service.
        /// Please note <see cref="DataFactoryLinkedServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsLinkedService"/>, <see cref="AmazonRdsForOracleLinkedService"/>, <see cref="AmazonRdsForSqlServerLinkedService"/>, <see cref="AmazonRedshiftLinkedService"/>, <see cref="AmazonS3LinkedService"/>, <see cref="AmazonS3CompatibleLinkedService"/>, <see cref="AppFiguresLinkedService"/>, <see cref="AsanaLinkedService"/>, <see cref="AzureBatchLinkedService"/>, <see cref="AzureBlobFSLinkedService"/>, <see cref="AzureBlobStorageLinkedService"/>, <see cref="AzureDataExplorerLinkedService"/>, <see cref="AzureDataLakeAnalyticsLinkedService"/>, <see cref="AzureDataLakeStoreLinkedService"/>, <see cref="AzureDatabricksLinkedService"/>, <see cref="AzureDatabricksDeltaLakeLinkedService"/>, <see cref="AzureFileStorageLinkedService"/>, <see cref="AzureFunctionLinkedService"/>, <see cref="AzureKeyVaultLinkedService"/>, <see cref="AzureMLLinkedService"/>, <see cref="AzureMLServiceLinkedService"/>, <see cref="AzureMariaDBLinkedService"/>, <see cref="AzureMySqlLinkedService"/>, <see cref="AzurePostgreSqlLinkedService"/>, <see cref="AzureSearchLinkedService"/>, <see cref="AzureSqlDWLinkedService"/>, <see cref="AzureSqlDatabaseLinkedService"/>, <see cref="AzureSqlMILinkedService"/>, <see cref="AzureStorageLinkedService"/>, <see cref="AzureSynapseArtifactsLinkedService"/>, <see cref="AzureTableStorageLinkedService"/>, <see cref="CassandraLinkedService"/>, <see cref="CommonDataServiceForAppsLinkedService"/>, <see cref="ConcurLinkedService"/>, <see cref="CosmosDBLinkedService"/>, <see cref="CosmosDBMongoDBApiLinkedService"/>, <see cref="CouchbaseLinkedService"/>, <see cref="CustomDataSourceLinkedService"/>, <see cref="DataworldLinkedService"/>, <see cref="Db2LinkedService"/>, <see cref="DrillLinkedService"/>, <see cref="DynamicsLinkedService"/>, <see cref="DynamicsAXLinkedService"/>, <see cref="DynamicsCrmLinkedService"/>, <see cref="EloquaLinkedService"/>, <see cref="FileServerLinkedService"/>, <see cref="FtpServerLinkedService"/>, <see cref="GoogleAdWordsLinkedService"/>, <see cref="GoogleBigQueryLinkedService"/>, <see cref="GoogleCloudStorageLinkedService"/>, <see cref="GoogleSheetsLinkedService"/>, <see cref="GreenplumLinkedService"/>, <see cref="HBaseLinkedService"/>, <see cref="HDInsightLinkedService"/>, <see cref="HDInsightOnDemandLinkedService"/>, <see cref="HdfsLinkedService"/>, <see cref="HiveLinkedService"/>, <see cref="HttpLinkedService"/>, <see cref="HubspotLinkedService"/>, <see cref="ImpalaLinkedService"/>, <see cref="InformixLinkedService"/>, <see cref="JiraLinkedService"/>, <see cref="LakeHouseLinkedService"/>, <see cref="MagentoLinkedService"/>, <see cref="MariaDBLinkedService"/>, <see cref="MarketoLinkedService"/>, <see cref="MicrosoftAccessLinkedService"/>, <see cref="MongoDBLinkedService"/>, <see cref="MongoDBAtlasLinkedService"/>, <see cref="MongoDBV2LinkedService"/>, <see cref="MySqlLinkedService"/>, <see cref="NetezzaLinkedService"/>, <see cref="ODataLinkedService"/>, <see cref="OdbcLinkedService"/>, <see cref="Office365LinkedService"/>, <see cref="OracleLinkedService"/>, <see cref="OracleCloudStorageLinkedService"/>, <see cref="OracleServiceCloudLinkedService"/>, <see cref="PaypalLinkedService"/>, <see cref="PhoenixLinkedService"/>, <see cref="PostgreSqlLinkedService"/>, <see cref="PrestoLinkedService"/>, <see cref="QuickBooksLinkedService"/>, <see cref="QuickbaseLinkedService"/>, <see cref="ResponsysLinkedService"/>, <see cref="RestServiceLinkedService"/>, <see cref="SalesforceLinkedService"/>, <see cref="SalesforceMarketingCloudLinkedService"/>, <see cref="SalesforceServiceCloudLinkedService"/>, <see cref="SalesforceServiceCloudV2LinkedService"/>, <see cref="SalesforceV2LinkedService"/>, <see cref="SapBWLinkedService"/>, <see cref="SapCloudForCustomerLinkedService"/>, <see cref="SapEccLinkedService"/>, <see cref="SapHanaLinkedService"/>, <see cref="SapOdpLinkedService"/>, <see cref="SapOpenHubLinkedService"/>, <see cref="SapTableLinkedService"/>, <see cref="ServiceNowLinkedService"/>, <see cref="SftpServerLinkedService"/>, <see cref="SharePointOnlineListLinkedService"/>, <see cref="ShopifyLinkedService"/>, <see cref="SmartsheetLinkedService"/>, <see cref="SnowflakeLinkedService"/>, <see cref="SnowflakeV2LinkedService"/>, <see cref="SparkLinkedService"/>, <see cref="SqlServerLinkedService"/>, <see cref="SquareLinkedService"/>, <see cref="SybaseLinkedService"/>, <see cref="TeamDeskLinkedService"/>, <see cref="TeradataLinkedService"/>, <see cref="TwilioLinkedService"/>, <see cref="VerticaLinkedService"/>, <see cref="WarehouseLinkedService"/>, <see cref="WebLinkedService"/>, <see cref="XeroLinkedService"/>, <see cref="ZendeskLinkedService"/> and <see cref="ZohoLinkedService"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryLinkedServiceData(DataFactoryLinkedServiceProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryLinkedServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of linked service.
        /// Please note <see cref="DataFactoryLinkedServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsLinkedService"/>, <see cref="AmazonRdsForOracleLinkedService"/>, <see cref="AmazonRdsForSqlServerLinkedService"/>, <see cref="AmazonRedshiftLinkedService"/>, <see cref="AmazonS3LinkedService"/>, <see cref="AmazonS3CompatibleLinkedService"/>, <see cref="AppFiguresLinkedService"/>, <see cref="AsanaLinkedService"/>, <see cref="AzureBatchLinkedService"/>, <see cref="AzureBlobFSLinkedService"/>, <see cref="AzureBlobStorageLinkedService"/>, <see cref="AzureDataExplorerLinkedService"/>, <see cref="AzureDataLakeAnalyticsLinkedService"/>, <see cref="AzureDataLakeStoreLinkedService"/>, <see cref="AzureDatabricksLinkedService"/>, <see cref="AzureDatabricksDeltaLakeLinkedService"/>, <see cref="AzureFileStorageLinkedService"/>, <see cref="AzureFunctionLinkedService"/>, <see cref="AzureKeyVaultLinkedService"/>, <see cref="AzureMLLinkedService"/>, <see cref="AzureMLServiceLinkedService"/>, <see cref="AzureMariaDBLinkedService"/>, <see cref="AzureMySqlLinkedService"/>, <see cref="AzurePostgreSqlLinkedService"/>, <see cref="AzureSearchLinkedService"/>, <see cref="AzureSqlDWLinkedService"/>, <see cref="AzureSqlDatabaseLinkedService"/>, <see cref="AzureSqlMILinkedService"/>, <see cref="AzureStorageLinkedService"/>, <see cref="AzureSynapseArtifactsLinkedService"/>, <see cref="AzureTableStorageLinkedService"/>, <see cref="CassandraLinkedService"/>, <see cref="CommonDataServiceForAppsLinkedService"/>, <see cref="ConcurLinkedService"/>, <see cref="CosmosDBLinkedService"/>, <see cref="CosmosDBMongoDBApiLinkedService"/>, <see cref="CouchbaseLinkedService"/>, <see cref="CustomDataSourceLinkedService"/>, <see cref="DataworldLinkedService"/>, <see cref="Db2LinkedService"/>, <see cref="DrillLinkedService"/>, <see cref="DynamicsLinkedService"/>, <see cref="DynamicsAXLinkedService"/>, <see cref="DynamicsCrmLinkedService"/>, <see cref="EloquaLinkedService"/>, <see cref="FileServerLinkedService"/>, <see cref="FtpServerLinkedService"/>, <see cref="GoogleAdWordsLinkedService"/>, <see cref="GoogleBigQueryLinkedService"/>, <see cref="GoogleCloudStorageLinkedService"/>, <see cref="GoogleSheetsLinkedService"/>, <see cref="GreenplumLinkedService"/>, <see cref="HBaseLinkedService"/>, <see cref="HDInsightLinkedService"/>, <see cref="HDInsightOnDemandLinkedService"/>, <see cref="HdfsLinkedService"/>, <see cref="HiveLinkedService"/>, <see cref="HttpLinkedService"/>, <see cref="HubspotLinkedService"/>, <see cref="ImpalaLinkedService"/>, <see cref="InformixLinkedService"/>, <see cref="JiraLinkedService"/>, <see cref="LakeHouseLinkedService"/>, <see cref="MagentoLinkedService"/>, <see cref="MariaDBLinkedService"/>, <see cref="MarketoLinkedService"/>, <see cref="MicrosoftAccessLinkedService"/>, <see cref="MongoDBLinkedService"/>, <see cref="MongoDBAtlasLinkedService"/>, <see cref="MongoDBV2LinkedService"/>, <see cref="MySqlLinkedService"/>, <see cref="NetezzaLinkedService"/>, <see cref="ODataLinkedService"/>, <see cref="OdbcLinkedService"/>, <see cref="Office365LinkedService"/>, <see cref="OracleLinkedService"/>, <see cref="OracleCloudStorageLinkedService"/>, <see cref="OracleServiceCloudLinkedService"/>, <see cref="PaypalLinkedService"/>, <see cref="PhoenixLinkedService"/>, <see cref="PostgreSqlLinkedService"/>, <see cref="PrestoLinkedService"/>, <see cref="QuickBooksLinkedService"/>, <see cref="QuickbaseLinkedService"/>, <see cref="ResponsysLinkedService"/>, <see cref="RestServiceLinkedService"/>, <see cref="SalesforceLinkedService"/>, <see cref="SalesforceMarketingCloudLinkedService"/>, <see cref="SalesforceServiceCloudLinkedService"/>, <see cref="SalesforceServiceCloudV2LinkedService"/>, <see cref="SalesforceV2LinkedService"/>, <see cref="SapBWLinkedService"/>, <see cref="SapCloudForCustomerLinkedService"/>, <see cref="SapEccLinkedService"/>, <see cref="SapHanaLinkedService"/>, <see cref="SapOdpLinkedService"/>, <see cref="SapOpenHubLinkedService"/>, <see cref="SapTableLinkedService"/>, <see cref="ServiceNowLinkedService"/>, <see cref="SftpServerLinkedService"/>, <see cref="SharePointOnlineListLinkedService"/>, <see cref="ShopifyLinkedService"/>, <see cref="SmartsheetLinkedService"/>, <see cref="SnowflakeLinkedService"/>, <see cref="SnowflakeV2LinkedService"/>, <see cref="SparkLinkedService"/>, <see cref="SqlServerLinkedService"/>, <see cref="SquareLinkedService"/>, <see cref="SybaseLinkedService"/>, <see cref="TeamDeskLinkedService"/>, <see cref="TeradataLinkedService"/>, <see cref="TwilioLinkedService"/>, <see cref="VerticaLinkedService"/>, <see cref="WarehouseLinkedService"/>, <see cref="WebLinkedService"/>, <see cref="XeroLinkedService"/>, <see cref="ZendeskLinkedService"/> and <see cref="ZohoLinkedService"/>.
        /// </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryLinkedServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataFactoryLinkedServiceProperties properties, ETag? eTag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryLinkedServiceData"/> for deserialization. </summary>
        internal DataFactoryLinkedServiceData()
        {
        }

        /// <summary>
        /// Properties of linked service.
        /// Please note <see cref="DataFactoryLinkedServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsLinkedService"/>, <see cref="AmazonRdsForOracleLinkedService"/>, <see cref="AmazonRdsForSqlServerLinkedService"/>, <see cref="AmazonRedshiftLinkedService"/>, <see cref="AmazonS3LinkedService"/>, <see cref="AmazonS3CompatibleLinkedService"/>, <see cref="AppFiguresLinkedService"/>, <see cref="AsanaLinkedService"/>, <see cref="AzureBatchLinkedService"/>, <see cref="AzureBlobFSLinkedService"/>, <see cref="AzureBlobStorageLinkedService"/>, <see cref="AzureDataExplorerLinkedService"/>, <see cref="AzureDataLakeAnalyticsLinkedService"/>, <see cref="AzureDataLakeStoreLinkedService"/>, <see cref="AzureDatabricksLinkedService"/>, <see cref="AzureDatabricksDeltaLakeLinkedService"/>, <see cref="AzureFileStorageLinkedService"/>, <see cref="AzureFunctionLinkedService"/>, <see cref="AzureKeyVaultLinkedService"/>, <see cref="AzureMLLinkedService"/>, <see cref="AzureMLServiceLinkedService"/>, <see cref="AzureMariaDBLinkedService"/>, <see cref="AzureMySqlLinkedService"/>, <see cref="AzurePostgreSqlLinkedService"/>, <see cref="AzureSearchLinkedService"/>, <see cref="AzureSqlDWLinkedService"/>, <see cref="AzureSqlDatabaseLinkedService"/>, <see cref="AzureSqlMILinkedService"/>, <see cref="AzureStorageLinkedService"/>, <see cref="AzureSynapseArtifactsLinkedService"/>, <see cref="AzureTableStorageLinkedService"/>, <see cref="CassandraLinkedService"/>, <see cref="CommonDataServiceForAppsLinkedService"/>, <see cref="ConcurLinkedService"/>, <see cref="CosmosDBLinkedService"/>, <see cref="CosmosDBMongoDBApiLinkedService"/>, <see cref="CouchbaseLinkedService"/>, <see cref="CustomDataSourceLinkedService"/>, <see cref="DataworldLinkedService"/>, <see cref="Db2LinkedService"/>, <see cref="DrillLinkedService"/>, <see cref="DynamicsLinkedService"/>, <see cref="DynamicsAXLinkedService"/>, <see cref="DynamicsCrmLinkedService"/>, <see cref="EloquaLinkedService"/>, <see cref="FileServerLinkedService"/>, <see cref="FtpServerLinkedService"/>, <see cref="GoogleAdWordsLinkedService"/>, <see cref="GoogleBigQueryLinkedService"/>, <see cref="GoogleCloudStorageLinkedService"/>, <see cref="GoogleSheetsLinkedService"/>, <see cref="GreenplumLinkedService"/>, <see cref="HBaseLinkedService"/>, <see cref="HDInsightLinkedService"/>, <see cref="HDInsightOnDemandLinkedService"/>, <see cref="HdfsLinkedService"/>, <see cref="HiveLinkedService"/>, <see cref="HttpLinkedService"/>, <see cref="HubspotLinkedService"/>, <see cref="ImpalaLinkedService"/>, <see cref="InformixLinkedService"/>, <see cref="JiraLinkedService"/>, <see cref="LakeHouseLinkedService"/>, <see cref="MagentoLinkedService"/>, <see cref="MariaDBLinkedService"/>, <see cref="MarketoLinkedService"/>, <see cref="MicrosoftAccessLinkedService"/>, <see cref="MongoDBLinkedService"/>, <see cref="MongoDBAtlasLinkedService"/>, <see cref="MongoDBV2LinkedService"/>, <see cref="MySqlLinkedService"/>, <see cref="NetezzaLinkedService"/>, <see cref="ODataLinkedService"/>, <see cref="OdbcLinkedService"/>, <see cref="Office365LinkedService"/>, <see cref="OracleLinkedService"/>, <see cref="OracleCloudStorageLinkedService"/>, <see cref="OracleServiceCloudLinkedService"/>, <see cref="PaypalLinkedService"/>, <see cref="PhoenixLinkedService"/>, <see cref="PostgreSqlLinkedService"/>, <see cref="PrestoLinkedService"/>, <see cref="QuickBooksLinkedService"/>, <see cref="QuickbaseLinkedService"/>, <see cref="ResponsysLinkedService"/>, <see cref="RestServiceLinkedService"/>, <see cref="SalesforceLinkedService"/>, <see cref="SalesforceMarketingCloudLinkedService"/>, <see cref="SalesforceServiceCloudLinkedService"/>, <see cref="SalesforceServiceCloudV2LinkedService"/>, <see cref="SalesforceV2LinkedService"/>, <see cref="SapBWLinkedService"/>, <see cref="SapCloudForCustomerLinkedService"/>, <see cref="SapEccLinkedService"/>, <see cref="SapHanaLinkedService"/>, <see cref="SapOdpLinkedService"/>, <see cref="SapOpenHubLinkedService"/>, <see cref="SapTableLinkedService"/>, <see cref="ServiceNowLinkedService"/>, <see cref="SftpServerLinkedService"/>, <see cref="SharePointOnlineListLinkedService"/>, <see cref="ShopifyLinkedService"/>, <see cref="SmartsheetLinkedService"/>, <see cref="SnowflakeLinkedService"/>, <see cref="SnowflakeV2LinkedService"/>, <see cref="SparkLinkedService"/>, <see cref="SqlServerLinkedService"/>, <see cref="SquareLinkedService"/>, <see cref="SybaseLinkedService"/>, <see cref="TeamDeskLinkedService"/>, <see cref="TeradataLinkedService"/>, <see cref="TwilioLinkedService"/>, <see cref="VerticaLinkedService"/>, <see cref="WarehouseLinkedService"/>, <see cref="WebLinkedService"/>, <see cref="XeroLinkedService"/>, <see cref="ZendeskLinkedService"/> and <see cref="ZohoLinkedService"/>.
        /// </summary>
        public DataFactoryLinkedServiceProperties Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
