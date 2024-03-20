// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// The Azure Synapse nested object which contains the information and credential which can be used to connect with related store or compute resource.
    /// Please note <see cref="LinkedService"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AmazonMWSLinkedService"/>, <see cref="AmazonRdsForOracleLinkedService"/>, <see cref="AmazonRdsForSqlServerLinkedService"/>, <see cref="AmazonRedshiftLinkedService"/>, <see cref="AmazonS3LinkedService"/>, <see cref="AppFiguresLinkedService"/>, <see cref="AsanaLinkedService"/>, <see cref="AzureBatchLinkedService"/>, <see cref="AzureBlobFSLinkedService"/>, <see cref="AzureBlobStorageLinkedService"/>, <see cref="AzureDatabricksLinkedService"/>, <see cref="AzureDatabricksDeltaLakeLinkedService"/>, <see cref="AzureDataExplorerLinkedService"/>, <see cref="AzureDataLakeAnalyticsLinkedService"/>, <see cref="AzureDataLakeStoreLinkedService"/>, <see cref="AzureFileStorageLinkedService"/>, <see cref="AzureFunctionLinkedService"/>, <see cref="AzureKeyVaultLinkedService"/>, <see cref="AzureMariaDBLinkedService"/>, <see cref="AzureMLLinkedService"/>, <see cref="AzureMLServiceLinkedService"/>, <see cref="AzureMySqlLinkedService"/>, <see cref="AzurePostgreSqlLinkedService"/>, <see cref="AzureSearchLinkedService"/>, <see cref="AzureSqlDatabaseLinkedService"/>, <see cref="AzureSqlDWLinkedService"/>, <see cref="AzureSqlMILinkedService"/>, <see cref="AzureStorageLinkedService"/>, <see cref="AzureSynapseArtifactsLinkedService"/>, <see cref="AzureTableStorageLinkedService"/>, <see cref="CassandraLinkedService"/>, <see cref="CommonDataServiceForAppsLinkedService"/>, <see cref="ConcurLinkedService"/>, <see cref="CosmosDbLinkedService"/>, <see cref="CosmosDbMongoDbApiLinkedService"/>, <see cref="CouchbaseLinkedService"/>, <see cref="CustomDataSourceLinkedService"/>, <see cref="DataworldLinkedService"/>, <see cref="Db2LinkedService"/>, <see cref="DrillLinkedService"/>, <see cref="DynamicsLinkedService"/>, <see cref="DynamicsAXLinkedService"/>, <see cref="DynamicsCrmLinkedService"/>, <see cref="EloquaLinkedService"/>, <see cref="FileServerLinkedService"/>, <see cref="FtpServerLinkedService"/>, <see cref="GoogleAdWordsLinkedService"/>, <see cref="GoogleBigQueryLinkedService"/>, <see cref="GoogleCloudStorageLinkedService"/>, <see cref="GoogleSheetsLinkedService"/>, <see cref="GreenplumLinkedService"/>, <see cref="HBaseLinkedService"/>, <see cref="HdfsLinkedService"/>, <see cref="HDInsightLinkedService"/>, <see cref="HDInsightOnDemandLinkedService"/>, <see cref="HiveLinkedService"/>, <see cref="HttpLinkedService"/>, <see cref="HubspotLinkedService"/>, <see cref="ImpalaLinkedService"/>, <see cref="InformixLinkedService"/>, <see cref="JiraLinkedService"/>, <see cref="MagentoLinkedService"/>, <see cref="MariaDBLinkedService"/>, <see cref="MarketoLinkedService"/>, <see cref="MicrosoftAccessLinkedService"/>, <see cref="MongoDbLinkedService"/>, <see cref="MongoDbAtlasLinkedService"/>, <see cref="MongoDbV2LinkedService"/>, <see cref="MySqlLinkedService"/>, <see cref="NetezzaLinkedService"/>, <see cref="ODataLinkedService"/>, <see cref="OdbcLinkedService"/>, <see cref="Office365LinkedService"/>, <see cref="OracleLinkedService"/>, <see cref="OracleServiceCloudLinkedService"/>, <see cref="PaypalLinkedService"/>, <see cref="PhoenixLinkedService"/>, <see cref="PostgreSqlLinkedService"/>, <see cref="PowerBIWorkspaceLinkedService"/>, <see cref="PrestoLinkedService"/>, <see cref="QuickbaseLinkedService"/>, <see cref="QuickBooksLinkedService"/>, <see cref="ResponsysLinkedService"/>, <see cref="RestServiceLinkedService"/>, <see cref="SalesforceLinkedService"/>, <see cref="SalesforceMarketingCloudLinkedService"/>, <see cref="SalesforceServiceCloudLinkedService"/>, <see cref="SapBWLinkedService"/>, <see cref="SapCloudForCustomerLinkedService"/>, <see cref="SapEccLinkedService"/>, <see cref="SapHanaLinkedService"/>, <see cref="SapOdpLinkedService"/>, <see cref="SapOpenHubLinkedService"/>, <see cref="SapTableLinkedService"/>, <see cref="ServiceNowLinkedService"/>, <see cref="SftpServerLinkedService"/>, <see cref="SharePointOnlineListLinkedService"/>, <see cref="ShopifyLinkedService"/>, <see cref="SmartsheetLinkedService"/>, <see cref="SnowflakeLinkedService"/>, <see cref="SparkLinkedService"/>, <see cref="SqlServerLinkedService"/>, <see cref="SquareLinkedService"/>, <see cref="SybaseLinkedService"/>, <see cref="TeamDeskLinkedService"/>, <see cref="TeradataLinkedService"/>, <see cref="TwilioLinkedService"/>, <see cref="VerticaLinkedService"/>, <see cref="WebLinkedService"/>, <see cref="XeroLinkedService"/>, <see cref="ZendeskLinkedService"/> and <see cref="ZohoLinkedService"/>.
    /// </summary>
    public abstract partial class LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="LinkedService"/>. </summary>
        protected LinkedService()
        {
            Parameters = new ChangeTrackingDictionary<string, ParameterSpecification>();
            Annotations = new ChangeTrackingList<object>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="LinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal LinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            ConnectVia = connectVia;
            Description = description;
            Parameters = parameters;
            Annotations = annotations;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of linked service. </summary>
        internal string Type { get; set; }
        /// <summary> The integration runtime reference. </summary>
        public IntegrationRuntimeReference ConnectVia { get; set; }
        /// <summary> Linked service description. </summary>
        public string Description { get; set; }
        /// <summary> Parameters for linked service. </summary>
        public IDictionary<string, ParameterSpecification> Parameters { get; }
        /// <summary> List of tags that can be used for describing the linked service. </summary>
        public IList<object> Annotations { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
