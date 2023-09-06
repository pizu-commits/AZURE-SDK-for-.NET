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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformAzureFileVolume : IUtf8JsonSerializable, IModelJsonSerializable<AppPlatformAzureFileVolume>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppPlatformAzureFileVolume>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppPlatformAzureFileVolume>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformAzureFileVolume>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("shareName"u8);
            writer.WriteStringValue(ShareName);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UnderlyingResourceType.ToString());
            writer.WritePropertyName("mountPath"u8);
            writer.WriteStringValue(MountPath);
            if (Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("readOnly"u8);
                writer.WriteBooleanValue(IsReadOnly.Value);
            }
            if (Optional.IsCollectionDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStartArray();
                foreach (var item in MountOptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static AppPlatformAzureFileVolume DeserializeAppPlatformAzureFileVolume(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string shareName = default;
            UnderlyingResourceType type = default;
            string mountPath = default;
            Optional<bool> readOnly = default;
            Optional<IList<string>> mountOptions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareName"u8))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new UnderlyingResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    mountOptions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppPlatformAzureFileVolume(type, mountPath, Optional.ToNullable(readOnly), Optional.ToList(mountOptions), shareName, rawData);
        }

        AppPlatformAzureFileVolume IModelJsonSerializable<AppPlatformAzureFileVolume>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformAzureFileVolume>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformAzureFileVolume(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppPlatformAzureFileVolume>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformAzureFileVolume>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppPlatformAzureFileVolume IModelSerializable<AppPlatformAzureFileVolume>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformAzureFileVolume>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppPlatformAzureFileVolume(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppPlatformAzureFileVolume"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppPlatformAzureFileVolume"/> to convert. </param>
        public static implicit operator RequestContent(AppPlatformAzureFileVolume model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppPlatformAzureFileVolume"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppPlatformAzureFileVolume(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppPlatformAzureFileVolume(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
