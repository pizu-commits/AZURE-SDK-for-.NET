// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SsisPackageLocationConverter))]
    public partial class SsisPackageLocation : IUtf8JsonSerializable, IJsonModel<SsisPackageLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SsisPackageLocation>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SsisPackageLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SsisPackageLocation>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SsisPackageLocation>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PackagePath))
            {
                writer.WritePropertyName("packagePath"u8);
                writer.WriteObjectValue(PackagePath);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PackagePassword))
            {
                writer.WritePropertyName("packagePassword"u8);
                writer.WriteObjectValue(PackagePassword);
            }
            if (Optional.IsDefined(AccessCredential))
            {
                writer.WritePropertyName("accessCredential"u8);
                writer.WriteObjectValue(AccessCredential);
            }
            if (Optional.IsDefined(ConfigurationPath))
            {
                writer.WritePropertyName("configurationPath"u8);
                writer.WriteObjectValue(ConfigurationPath);
            }
            if (Optional.IsDefined(ConfigurationAccessCredential))
            {
                writer.WritePropertyName("configurationAccessCredential"u8);
                writer.WriteObjectValue(ConfigurationAccessCredential);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            if (Optional.IsDefined(PackageContent))
            {
                writer.WritePropertyName("packageContent"u8);
                writer.WriteObjectValue(PackageContent);
            }
            if (Optional.IsDefined(PackageLastModifiedDate))
            {
                writer.WritePropertyName("packageLastModifiedDate"u8);
                writer.WriteStringValue(PackageLastModifiedDate);
            }
            if (Optional.IsCollectionDefined(ChildPackages))
            {
                writer.WritePropertyName("childPackages"u8);
                writer.WriteStartArray();
                foreach (var item in ChildPackages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SsisPackageLocation IJsonModel<SsisPackageLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SsisPackageLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisPackageLocation(document.RootElement, options);
        }

        internal static SsisPackageLocation DeserializeSsisPackageLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> packagePath = default;
            Optional<SsisPackageLocationType> type = default;
            Optional<SecretBase> packagePassword = default;
            Optional<SsisAccessCredential> accessCredential = default;
            Optional<object> configurationPath = default;
            Optional<SsisAccessCredential> configurationAccessCredential = default;
            Optional<string> packageName = default;
            Optional<object> packageContent = default;
            Optional<string> packageLastModifiedDate = default;
            Optional<IList<SsisChildPackage>> childPackages = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packagePath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    packagePath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SsisPackageLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packagePassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packagePassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("configurationPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("configurationAccessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationAccessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("packageName"u8))
                        {
                            packageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageContent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageContent = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("packageLastModifiedDate"u8))
                        {
                            packageLastModifiedDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("childPackages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SsisChildPackage> array = new List<SsisChildPackage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SsisChildPackage.DeserializeSsisChildPackage(item));
                            }
                            childPackages = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SsisPackageLocation(packagePath.Value, Optional.ToNullable(type), packagePassword.Value, accessCredential.Value, configurationPath.Value, configurationAccessCredential.Value, packageName.Value, packageContent.Value, packageLastModifiedDate.Value, Optional.ToList(childPackages), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SsisPackageLocation>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SsisPackageLocation)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SsisPackageLocation IPersistableModel<SsisPackageLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SsisPackageLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSsisPackageLocation(document.RootElement, options);
        }

        string IPersistableModel<SsisPackageLocation>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class SsisPackageLocationConverter : JsonConverter<SsisPackageLocation>
        {
            public override void Write(Utf8JsonWriter writer, SsisPackageLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SsisPackageLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisPackageLocation(document.RootElement);
            }
        }
    }
}
