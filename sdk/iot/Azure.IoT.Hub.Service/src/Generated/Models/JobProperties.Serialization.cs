// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class JobProperties : IUtf8JsonSerializable, IModelJsonSerializable<JobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JobProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JobProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (Optional.IsDefined(StartTimeUtc))
            {
                writer.WritePropertyName("startTimeUtc"u8);
                writer.WriteStringValue(StartTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(EndTimeUtc))
            {
                writer.WritePropertyName("endTimeUtc"u8);
                writer.WriteStringValue(EndTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Progress))
            {
                writer.WritePropertyName("progress"u8);
                writer.WriteNumberValue(Progress.Value);
            }
            if (Optional.IsDefined(InputBlobContainerUri))
            {
                writer.WritePropertyName("inputBlobContainerUri"u8);
                writer.WriteStringValue(InputBlobContainerUri);
            }
            if (Optional.IsDefined(InputBlobName))
            {
                writer.WritePropertyName("inputBlobName"u8);
                writer.WriteStringValue(InputBlobName);
            }
            if (Optional.IsDefined(OutputBlobContainerUri))
            {
                writer.WritePropertyName("outputBlobContainerUri"u8);
                writer.WriteStringValue(OutputBlobContainerUri);
            }
            if (Optional.IsDefined(OutputBlobName))
            {
                writer.WritePropertyName("outputBlobName"u8);
                writer.WriteStringValue(OutputBlobName);
            }
            if (Optional.IsDefined(ExcludeKeysInExport))
            {
                writer.WritePropertyName("excludeKeysInExport"u8);
                writer.WriteBooleanValue(ExcludeKeysInExport.Value);
            }
            if (Optional.IsDefined(StorageAuthenticationType))
            {
                writer.WritePropertyName("storageAuthenticationType"u8);
                writer.WriteStringValue(StorageAuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(FailureReason))
            {
                writer.WritePropertyName("failureReason"u8);
                writer.WriteStringValue(FailureReason);
            }
            if (Optional.IsDefined(IncludeConfigurations))
            {
                writer.WritePropertyName("includeConfigurations"u8);
                writer.WriteBooleanValue(IncludeConfigurations.Value);
            }
            if (Optional.IsDefined(ConfigurationsBlobName))
            {
                writer.WritePropertyName("configurationsBlobName"u8);
                writer.WriteStringValue(ConfigurationsBlobName);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static JobProperties DeserializeJobProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> jobId = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<JobPropertiesType> type = default;
            Optional<JobPropertiesStatus> status = default;
            Optional<int> progress = default;
            Optional<string> inputBlobContainerUri = default;
            Optional<string> inputBlobName = default;
            Optional<string> outputBlobContainerUri = default;
            Optional<string> outputBlobName = default;
            Optional<bool> excludeKeysInExport = default;
            Optional<JobPropertiesStorageAuthenticationType> storageAuthenticationType = default;
            Optional<string> failureReason = default;
            Optional<bool> includeConfigurations = default;
            Optional<string> configurationsBlobName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new JobPropertiesType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new JobPropertiesStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("progress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inputBlobContainerUri"u8))
                {
                    inputBlobContainerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputBlobName"u8))
                {
                    inputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputBlobContainerUri"u8))
                {
                    outputBlobContainerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputBlobName"u8))
                {
                    outputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludeKeysInExport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeKeysInExport = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageAuthenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAuthenticationType = new JobPropertiesStorageAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failureReason"u8))
                {
                    failureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includeConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeConfigurations = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationsBlobName"u8))
                {
                    configurationsBlobName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JobProperties(jobId.Value, Optional.ToNullable(startTimeUtc), Optional.ToNullable(endTimeUtc), Optional.ToNullable(type), Optional.ToNullable(status), Optional.ToNullable(progress), inputBlobContainerUri.Value, inputBlobName.Value, outputBlobContainerUri.Value, outputBlobName.Value, Optional.ToNullable(excludeKeysInExport), Optional.ToNullable(storageAuthenticationType), failureReason.Value, Optional.ToNullable(includeConfigurations), configurationsBlobName.Value, rawData);
        }

        JobProperties IModelJsonSerializable<JobProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJobProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JobProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JobProperties IModelSerializable<JobProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJobProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JobProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JobProperties"/> to convert. </param>
        public static implicit operator RequestContent(JobProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JobProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JobProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJobProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
