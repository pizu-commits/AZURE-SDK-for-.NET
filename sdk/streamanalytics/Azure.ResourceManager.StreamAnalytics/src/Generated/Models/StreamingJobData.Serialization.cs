// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    public partial class StreamingJobData : IUtf8JsonSerializable, IJsonModel<StreamingJobData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(JobState))
            {
                writer.WritePropertyName("jobState"u8);
                writer.WriteStringValue(JobState);
            }
            if (Optional.IsDefined(JobType))
            {
                writer.WritePropertyName("jobType"u8);
                writer.WriteStringValue(JobType.Value.ToString());
            }
            if (Optional.IsDefined(OutputStartMode))
            {
                writer.WritePropertyName("outputStartMode"u8);
                writer.WriteStringValue(OutputStartMode.Value.ToString());
            }
            if (Optional.IsDefined(OutputStartOn))
            {
                writer.WritePropertyName("outputStartTime"u8);
                writer.WriteStringValue(OutputStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastOutputEventOn))
            {
                writer.WritePropertyName("lastOutputEventTime"u8);
                writer.WriteStringValue(LastOutputEventOn.Value, "O");
            }
            if (Optional.IsDefined(EventsOutOfOrderPolicy))
            {
                writer.WritePropertyName("eventsOutOfOrderPolicy"u8);
                writer.WriteStringValue(EventsOutOfOrderPolicy.Value.ToString());
            }
            if (Optional.IsDefined(OutputErrorPolicy))
            {
                writer.WritePropertyName("outputErrorPolicy"u8);
                writer.WriteStringValue(OutputErrorPolicy.Value.ToString());
            }
            if (Optional.IsDefined(EventsOutOfOrderMaxDelayInSeconds))
            {
                writer.WritePropertyName("eventsOutOfOrderMaxDelayInSeconds"u8);
                writer.WriteNumberValue(EventsOutOfOrderMaxDelayInSeconds.Value);
            }
            if (Optional.IsDefined(EventsLateArrivalMaxDelayInSeconds))
            {
                writer.WritePropertyName("eventsLateArrivalMaxDelayInSeconds"u8);
                writer.WriteNumberValue(EventsLateArrivalMaxDelayInSeconds.Value);
            }
            if (Optional.IsDefined(DataLocalion))
            {
                writer.WritePropertyName("dataLocale"u8);
                writer.WriteStringValue(DataLocalion.Value);
            }
            if (Optional.IsDefined(CompatibilityLevel))
            {
                writer.WritePropertyName("compatibilityLevel"u8);
                writer.WriteStringValue(CompatibilityLevel.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Transformation))
            {
                writer.WritePropertyName("transformation"u8);
                writer.WriteObjectValue(Transformation);
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Functions))
            {
                writer.WritePropertyName("functions"u8);
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(JobStorageAccount))
            {
                if (JobStorageAccount != null)
                {
                    writer.WritePropertyName("jobStorageAccount"u8);
                    writer.WriteObjectValue(JobStorageAccount);
                }
                else
                {
                    writer.WriteNull("jobStorageAccount");
                }
            }
            if (Optional.IsDefined(ContentStoragePolicy))
            {
                writer.WritePropertyName("contentStoragePolicy"u8);
                writer.WriteStringValue(ContentStoragePolicy.Value.ToString());
            }
            if (Optional.IsDefined(Externals))
            {
                writer.WritePropertyName("externals"u8);
                writer.WriteObjectValue(Externals);
            }
            if (Optional.IsDefined(Cluster))
            {
                if (Cluster != null)
                {
                    writer.WritePropertyName("cluster"u8);
                    writer.WriteObjectValue(Cluster);
                }
                else
                {
                    writer.WriteNull("cluster");
                }
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
            writer.WriteEndObject();
        }

        StreamingJobData IJsonModel<StreamingJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobData(document.RootElement, options);
        }

        internal static StreamingJobData DeserializeStreamingJobData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<StreamAnalyticsSku> sku = default;
            Optional<Guid> jobId = default;
            Optional<string> provisioningState = default;
            Optional<string> jobState = default;
            Optional<StreamingJobType> jobType = default;
            Optional<StreamingJobOutputStartMode> outputStartMode = default;
            Optional<DateTimeOffset> outputStartTime = default;
            Optional<DateTimeOffset> lastOutputEventTime = default;
            Optional<EventsOutOfOrderPolicy> eventsOutOfOrderPolicy = default;
            Optional<StreamingJobOutputErrorPolicy> outputErrorPolicy = default;
            Optional<int> eventsOutOfOrderMaxDelayInSeconds = default;
            Optional<int> eventsLateArrivalMaxDelayInSeconds = default;
            Optional<AzureLocation> dataLocale = default;
            Optional<StreamingJobCompatibilityLevel> compatibilityLevel = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<IList<StreamingJobInputData>> inputs = default;
            Optional<StreamingJobTransformationData> transformation = default;
            Optional<IList<StreamingJobOutputData>> outputs = default;
            Optional<IList<StreamingJobFunctionData>> functions = default;
            Optional<ETag> etag = default;
            Optional<StreamingJobStorageAccount> jobStorageAccount = default;
            Optional<StreamingJobContentStoragePolicy> contentStoragePolicy = default;
            Optional<StreamingJobExternal> externals = default;
            Optional<ClusterInfo> cluster = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = StreamAnalyticsSku.DeserializeStreamAnalyticsSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("jobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("jobState"u8))
                        {
                            jobState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("jobType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobType = new StreamingJobType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outputStartMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputStartMode = new StreamingJobOutputStartMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outputStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastOutputEventTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastOutputEventTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("eventsOutOfOrderPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventsOutOfOrderPolicy = new EventsOutOfOrderPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outputErrorPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputErrorPolicy = new StreamingJobOutputErrorPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventsOutOfOrderMaxDelayInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventsOutOfOrderMaxDelayInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("eventsLateArrivalMaxDelayInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventsLateArrivalMaxDelayInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dataLocale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataLocale = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("compatibilityLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compatibilityLevel = new StreamingJobCompatibilityLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamingJobInputData> array = new List<StreamingJobInputData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamingJobInputData.DeserializeStreamingJobInputData(item));
                            }
                            inputs = array;
                            continue;
                        }
                        if (property0.NameEquals("transformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            transformation = StreamingJobTransformationData.DeserializeStreamingJobTransformationData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamingJobOutputData> array = new List<StreamingJobOutputData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamingJobOutputData.DeserializeStreamingJobOutputData(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("functions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamingJobFunctionData> array = new List<StreamingJobFunctionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamingJobFunctionData.DeserializeStreamingJobFunctionData(item));
                            }
                            functions = array;
                            continue;
                        }
                        if (property0.NameEquals("etag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            etag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("jobStorageAccount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                jobStorageAccount = null;
                                continue;
                            }
                            jobStorageAccount = StreamingJobStorageAccount.DeserializeStreamingJobStorageAccount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contentStoragePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contentStoragePolicy = new StreamingJobContentStoragePolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("externals"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            externals = StreamingJobExternal.DeserializeStreamingJobExternal(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cluster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cluster = null;
                                continue;
                            }
                            cluster = ClusterInfo.DeserializeClusterInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingJobData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, sku.Value, Optional.ToNullable(jobId), provisioningState.Value, jobState.Value, Optional.ToNullable(jobType), Optional.ToNullable(outputStartMode), Optional.ToNullable(outputStartTime), Optional.ToNullable(lastOutputEventTime), Optional.ToNullable(eventsOutOfOrderPolicy), Optional.ToNullable(outputErrorPolicy), Optional.ToNullable(eventsOutOfOrderMaxDelayInSeconds), Optional.ToNullable(eventsLateArrivalMaxDelayInSeconds), Optional.ToNullable(dataLocale), Optional.ToNullable(compatibilityLevel), Optional.ToNullable(createdDate), Optional.ToList(inputs), transformation.Value, Optional.ToList(outputs), Optional.ToList(functions), Optional.ToNullable(etag), jobStorageAccount.Value, Optional.ToNullable(contentStoragePolicy), externals.Value, cluster.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Identity))
            {
                builder.Append("  identity:");
                AppendChildObject(builder, Identity, options, 2, false);
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(Sku))
            {
                builder.Append("    sku:");
                AppendChildObject(builder, Sku, options, 4, false);
            }

            if (Optional.IsDefined(JobId))
            {
                builder.Append("    jobId:");
                builder.AppendLine($" '{JobId.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState}'");
            }

            if (Optional.IsDefined(JobState))
            {
                builder.Append("    jobState:");
                builder.AppendLine($" '{JobState}'");
            }

            if (Optional.IsDefined(JobType))
            {
                builder.Append("    jobType:");
                builder.AppendLine($" '{JobType.ToString()}'");
            }

            if (Optional.IsDefined(OutputStartMode))
            {
                builder.Append("    outputStartMode:");
                builder.AppendLine($" '{OutputStartMode.ToString()}'");
            }

            if (Optional.IsDefined(OutputStartOn))
            {
                builder.Append("    outputStartTime:");
                var formattedDateTimeString = TypeFormatters.ToString(OutputStartOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastOutputEventOn))
            {
                builder.Append("    lastOutputEventTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastOutputEventOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(EventsOutOfOrderPolicy))
            {
                builder.Append("    eventsOutOfOrderPolicy:");
                builder.AppendLine($" '{EventsOutOfOrderPolicy.ToString()}'");
            }

            if (Optional.IsDefined(OutputErrorPolicy))
            {
                builder.Append("    outputErrorPolicy:");
                builder.AppendLine($" '{OutputErrorPolicy.ToString()}'");
            }

            if (Optional.IsDefined(EventsOutOfOrderMaxDelayInSeconds))
            {
                builder.Append("    eventsOutOfOrderMaxDelayInSeconds:");
                builder.AppendLine($" {EventsOutOfOrderMaxDelayInSeconds.Value}");
            }

            if (Optional.IsDefined(EventsLateArrivalMaxDelayInSeconds))
            {
                builder.Append("    eventsLateArrivalMaxDelayInSeconds:");
                builder.AppendLine($" {EventsLateArrivalMaxDelayInSeconds.Value}");
            }

            if (Optional.IsDefined(DataLocalion))
            {
                builder.Append("    dataLocale:");
                builder.AppendLine($" '{DataLocalion.Value.ToString()}'");
            }

            if (Optional.IsDefined(CompatibilityLevel))
            {
                builder.Append("    compatibilityLevel:");
                builder.AppendLine($" '{CompatibilityLevel.ToString()}'");
            }

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("    createdDate:");
                var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsCollectionDefined(Inputs))
            {
                if (Inputs.Any())
                {
                    builder.Append("    inputs:");
                    builder.AppendLine(" [");
                    foreach (var item in Inputs)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(Transformation))
            {
                builder.Append("    transformation:");
                AppendChildObject(builder, Transformation, options, 4, false);
            }

            if (Optional.IsCollectionDefined(Outputs))
            {
                if (Outputs.Any())
                {
                    builder.Append("    outputs:");
                    builder.AppendLine(" [");
                    foreach (var item in Outputs)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(Functions))
            {
                if (Functions.Any())
                {
                    builder.Append("    functions:");
                    builder.AppendLine(" [");
                    foreach (var item in Functions)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(ETag))
            {
                builder.Append("    etag:");
                builder.AppendLine($" '{ETag.Value.ToString()}'");
            }

            if (Optional.IsDefined(JobStorageAccount))
            {
                builder.Append("    jobStorageAccount:");
                AppendChildObject(builder, JobStorageAccount, options, 4, false);
            }

            if (Optional.IsDefined(ContentStoragePolicy))
            {
                builder.Append("    contentStoragePolicy:");
                builder.AppendLine($" '{ContentStoragePolicy.ToString()}'");
            }

            if (Optional.IsDefined(Externals))
            {
                builder.Append("    externals:");
                AppendChildObject(builder, Externals, options, 4, false);
            }

            if (Optional.IsDefined(Cluster))
            {
                builder.Append("    cluster:");
                AppendChildObject(builder, Cluster, options, 4, false);
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<StreamingJobData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobData)} does not support '{options.Format}' format.");
            }
        }

        StreamingJobData IPersistableModel<StreamingJobData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(StreamingJobData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
