// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownCopySource))]
    public partial class CopyActivitySource : IUtf8JsonSerializable, IJsonModel<CopyActivitySource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopyActivitySource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CopyActivitySource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivitySource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyActivitySource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                JsonSerializer.Serialize(writer, SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                JsonSerializer.Serialize(writer, SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        CopyActivitySource IJsonModel<CopyActivitySource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivitySource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyActivitySource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyActivitySource(document.RootElement, options);
        }

        internal static CopyActivitySource DeserializeCopyActivitySource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWSSource": return AmazonMwsSource.DeserializeAmazonMwsSource(element, options);
                    case "AmazonRdsForOracleSource": return AmazonRdsForOracleSource.DeserializeAmazonRdsForOracleSource(element, options);
                    case "AmazonRdsForSqlServerSource": return AmazonRdsForSqlServerSource.DeserializeAmazonRdsForSqlServerSource(element, options);
                    case "AmazonRedshiftSource": return AmazonRedshiftSource.DeserializeAmazonRedshiftSource(element, options);
                    case "AvroSource": return AvroSource.DeserializeAvroSource(element, options);
                    case "AzureBlobFSSource": return AzureBlobFSSource.DeserializeAzureBlobFSSource(element, options);
                    case "AzureDatabricksDeltaLakeSource": return AzureDatabricksDeltaLakeSource.DeserializeAzureDatabricksDeltaLakeSource(element, options);
                    case "AzureDataExplorerSource": return AzureDataExplorerSource.DeserializeAzureDataExplorerSource(element, options);
                    case "AzureDataLakeStoreSource": return AzureDataLakeStoreSource.DeserializeAzureDataLakeStoreSource(element, options);
                    case "AzureMariaDBSource": return AzureMariaDBSource.DeserializeAzureMariaDBSource(element, options);
                    case "AzureMySqlSource": return AzureMySqlSource.DeserializeAzureMySqlSource(element, options);
                    case "AzurePostgreSqlSource": return AzurePostgreSqlSource.DeserializeAzurePostgreSqlSource(element, options);
                    case "AzureSqlSource": return AzureSqlSource.DeserializeAzureSqlSource(element, options);
                    case "AzureTableSource": return AzureTableSource.DeserializeAzureTableSource(element, options);
                    case "BinarySource": return BinarySource.DeserializeBinarySource(element, options);
                    case "BlobSource": return DataFactoryBlobSource.DeserializeDataFactoryBlobSource(element, options);
                    case "CassandraSource": return CassandraSource.DeserializeCassandraSource(element, options);
                    case "CommonDataServiceForAppsSource": return CommonDataServiceForAppsSource.DeserializeCommonDataServiceForAppsSource(element, options);
                    case "ConcurSource": return ConcurSource.DeserializeConcurSource(element, options);
                    case "CosmosDbMongoDbApiSource": return CosmosDBMongoDBApiSource.DeserializeCosmosDBMongoDBApiSource(element, options);
                    case "CosmosDbSqlApiSource": return CosmosDBSqlApiSource.DeserializeCosmosDBSqlApiSource(element, options);
                    case "CouchbaseSource": return CouchbaseSource.DeserializeCouchbaseSource(element, options);
                    case "Db2Source": return Db2Source.DeserializeDb2Source(element, options);
                    case "DelimitedTextSource": return DelimitedTextSource.DeserializeDelimitedTextSource(element, options);
                    case "DocumentDbCollectionSource": return DocumentDBCollectionSource.DeserializeDocumentDBCollectionSource(element, options);
                    case "DrillSource": return DrillSource.DeserializeDrillSource(element, options);
                    case "DynamicsAXSource": return DynamicsAXSource.DeserializeDynamicsAXSource(element, options);
                    case "DynamicsCrmSource": return DynamicsCrmSource.DeserializeDynamicsCrmSource(element, options);
                    case "DynamicsSource": return DynamicsSource.DeserializeDynamicsSource(element, options);
                    case "EloquaSource": return EloquaSource.DeserializeEloquaSource(element, options);
                    case "ExcelSource": return ExcelSource.DeserializeExcelSource(element, options);
                    case "FileSystemSource": return FileSystemSource.DeserializeFileSystemSource(element, options);
                    case "GoogleAdWordsSource": return GoogleAdWordsSource.DeserializeGoogleAdWordsSource(element, options);
                    case "GoogleBigQuerySource": return GoogleBigQuerySource.DeserializeGoogleBigQuerySource(element, options);
                    case "GoogleBigQueryV2Source": return GoogleBigQueryV2Source.DeserializeGoogleBigQueryV2Source(element, options);
                    case "GreenplumSource": return GreenplumSource.DeserializeGreenplumSource(element, options);
                    case "HBaseSource": return HBaseSource.DeserializeHBaseSource(element, options);
                    case "HdfsSource": return HdfsSource.DeserializeHdfsSource(element, options);
                    case "HiveSource": return HiveSource.DeserializeHiveSource(element, options);
                    case "HttpSource": return DataFactoryHttpFileSource.DeserializeDataFactoryHttpFileSource(element, options);
                    case "HubspotSource": return HubspotSource.DeserializeHubspotSource(element, options);
                    case "ImpalaSource": return ImpalaSource.DeserializeImpalaSource(element, options);
                    case "InformixSource": return InformixSource.DeserializeInformixSource(element, options);
                    case "JiraSource": return JiraSource.DeserializeJiraSource(element, options);
                    case "JsonSource": return JsonSource.DeserializeJsonSource(element, options);
                    case "LakeHouseTableSource": return LakeHouseTableSource.DeserializeLakeHouseTableSource(element, options);
                    case "MagentoSource": return MagentoSource.DeserializeMagentoSource(element, options);
                    case "MariaDBSource": return MariaDBSource.DeserializeMariaDBSource(element, options);
                    case "MarketoSource": return MarketoSource.DeserializeMarketoSource(element, options);
                    case "MicrosoftAccessSource": return MicrosoftAccessSource.DeserializeMicrosoftAccessSource(element, options);
                    case "MongoDbAtlasSource": return MongoDBAtlasSource.DeserializeMongoDBAtlasSource(element, options);
                    case "MongoDbSource": return MongoDBSource.DeserializeMongoDBSource(element, options);
                    case "MongoDbV2Source": return MongoDBV2Source.DeserializeMongoDBV2Source(element, options);
                    case "MySqlSource": return MySqlSource.DeserializeMySqlSource(element, options);
                    case "NetezzaSource": return NetezzaSource.DeserializeNetezzaSource(element, options);
                    case "ODataSource": return ODataSource.DeserializeODataSource(element, options);
                    case "OdbcSource": return OdbcSource.DeserializeOdbcSource(element, options);
                    case "Office365Source": return Office365Source.DeserializeOffice365Source(element, options);
                    case "OracleServiceCloudSource": return OracleServiceCloudSource.DeserializeOracleServiceCloudSource(element, options);
                    case "OracleSource": return OracleSource.DeserializeOracleSource(element, options);
                    case "OrcSource": return OrcSource.DeserializeOrcSource(element, options);
                    case "ParquetSource": return ParquetSource.DeserializeParquetSource(element, options);
                    case "PaypalSource": return PaypalSource.DeserializePaypalSource(element, options);
                    case "PhoenixSource": return PhoenixSource.DeserializePhoenixSource(element, options);
                    case "PostgreSqlSource": return PostgreSqlSource.DeserializePostgreSqlSource(element, options);
                    case "PostgreSqlV2Source": return PostgreSqlV2Source.DeserializePostgreSqlV2Source(element, options);
                    case "PrestoSource": return PrestoSource.DeserializePrestoSource(element, options);
                    case "QuickBooksSource": return QuickBooksSource.DeserializeQuickBooksSource(element, options);
                    case "RelationalSource": return RelationalSource.DeserializeRelationalSource(element, options);
                    case "ResponsysSource": return ResponsysSource.DeserializeResponsysSource(element, options);
                    case "RestSource": return RestSource.DeserializeRestSource(element, options);
                    case "SalesforceMarketingCloudSource": return SalesforceMarketingCloudSource.DeserializeSalesforceMarketingCloudSource(element, options);
                    case "SalesforceServiceCloudSource": return SalesforceServiceCloudSource.DeserializeSalesforceServiceCloudSource(element, options);
                    case "SalesforceServiceCloudV2Source": return SalesforceServiceCloudV2Source.DeserializeSalesforceServiceCloudV2Source(element, options);
                    case "SalesforceSource": return SalesforceSource.DeserializeSalesforceSource(element, options);
                    case "SalesforceV2Source": return SalesforceV2Source.DeserializeSalesforceV2Source(element, options);
                    case "SapBwSource": return SapBWSource.DeserializeSapBWSource(element, options);
                    case "SapCloudForCustomerSource": return SapCloudForCustomerSource.DeserializeSapCloudForCustomerSource(element, options);
                    case "SapEccSource": return SapEccSource.DeserializeSapEccSource(element, options);
                    case "SapHanaSource": return SapHanaSource.DeserializeSapHanaSource(element, options);
                    case "SapOdpSource": return SapOdpSource.DeserializeSapOdpSource(element, options);
                    case "SapOpenHubSource": return SapOpenHubSource.DeserializeSapOpenHubSource(element, options);
                    case "SapTableSource": return SapTableSource.DeserializeSapTableSource(element, options);
                    case "ServiceNowSource": return ServiceNowSource.DeserializeServiceNowSource(element, options);
                    case "ServiceNowV2Source": return ServiceNowV2Source.DeserializeServiceNowV2Source(element, options);
                    case "SharePointOnlineListSource": return SharePointOnlineListSource.DeserializeSharePointOnlineListSource(element, options);
                    case "ShopifySource": return ShopifySource.DeserializeShopifySource(element, options);
                    case "SnowflakeSource": return SnowflakeSource.DeserializeSnowflakeSource(element, options);
                    case "SnowflakeV2Source": return SnowflakeV2Source.DeserializeSnowflakeV2Source(element, options);
                    case "SparkSource": return SparkSource.DeserializeSparkSource(element, options);
                    case "SqlDWSource": return SqlDWSource.DeserializeSqlDWSource(element, options);
                    case "SqlMISource": return SqlMISource.DeserializeSqlMISource(element, options);
                    case "SqlServerSource": return SqlServerSource.DeserializeSqlServerSource(element, options);
                    case "SqlSource": return SqlSource.DeserializeSqlSource(element, options);
                    case "SquareSource": return SquareSource.DeserializeSquareSource(element, options);
                    case "SybaseSource": return SybaseSource.DeserializeSybaseSource(element, options);
                    case "TabularSource": return TabularSource.DeserializeTabularSource(element, options);
                    case "TeradataSource": return TeradataSource.DeserializeTeradataSource(element, options);
                    case "VerticaSource": return VerticaSource.DeserializeVerticaSource(element, options);
                    case "WarehouseSource": return WarehouseSource.DeserializeWarehouseSource(element, options);
                    case "WebSource": return WebSource.DeserializeWebSource(element, options);
                    case "XeroSource": return XeroSource.DeserializeXeroSource(element, options);
                    case "XmlSource": return XmlSource.DeserializeXmlSource(element, options);
                    case "ZohoSource": return ZohoSource.DeserializeZohoSource(element, options);
                }
            }
            return UnknownCopySource.DeserializeUnknownCopySource(element, options);
        }

        BinaryData IPersistableModel<CopyActivitySource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivitySource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CopyActivitySource)} does not support '{options.Format}' format.");
            }
        }

        CopyActivitySource IPersistableModel<CopyActivitySource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivitySource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCopyActivitySource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CopyActivitySource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CopyActivitySource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
