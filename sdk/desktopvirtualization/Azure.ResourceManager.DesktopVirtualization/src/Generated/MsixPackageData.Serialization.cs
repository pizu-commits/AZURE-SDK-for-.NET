// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class MsixPackageData : IUtf8JsonSerializable, IJsonModel<MsixPackageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MsixPackageData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MsixPackageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsixPackageData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(ImagePath))
            {
                writer.WritePropertyName("imagePath"u8);
                writer.WriteStringValue(ImagePath);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            if (Optional.IsDefined(PackageFamilyName))
            {
                writer.WritePropertyName("packageFamilyName"u8);
                writer.WriteStringValue(PackageFamilyName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(PackageRelativePath))
            {
                writer.WritePropertyName("packageRelativePath"u8);
                writer.WriteStringValue(PackageRelativePath);
            }
            if (Optional.IsDefined(IsRegularRegistration))
            {
                writer.WritePropertyName("isRegularRegistration"u8);
                writer.WriteBooleanValue(IsRegularRegistration.Value);
            }
            if (Optional.IsDefined(IsActive))
            {
                writer.WritePropertyName("isActive"u8);
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (Optional.IsCollectionDefined(PackageDependencies))
            {
                writer.WritePropertyName("packageDependencies"u8);
                writer.WriteStartArray();
                foreach (var item in PackageDependencies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(PackageApplications))
            {
                writer.WritePropertyName("packageApplications"u8);
                writer.WriteStartArray();
                foreach (var item in PackageApplications)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        MsixPackageData IJsonModel<MsixPackageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsixPackageData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMsixPackageData(document.RootElement, options);
        }

        internal static MsixPackageData DeserializeMsixPackageData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string imagePath = default;
            string packageName = default;
            string packageFamilyName = default;
            string displayName = default;
            string packageRelativePath = default;
            bool? isRegularRegistration = default;
            bool? isActive = default;
            IList<MsixPackageDependencies> packageDependencies = default;
            string version = default;
            DateTimeOffset? lastUpdated = default;
            IList<MsixPackageApplications> packageApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("imagePath"u8))
                        {
                            imagePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageName"u8))
                        {
                            packageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFamilyName"u8))
                        {
                            packageFamilyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                displayName = null;
                                continue;
                            }
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageRelativePath"u8))
                        {
                            packageRelativePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isRegularRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isRegularRegistration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isActive"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isActive = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("packageDependencies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MsixPackageDependencies> array = new List<MsixPackageDependencies>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MsixPackageDependencies.DeserializeMsixPackageDependencies(item, options));
                            }
                            packageDependencies = array;
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("packageApplications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MsixPackageApplications> array = new List<MsixPackageApplications>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MsixPackageApplications.DeserializeMsixPackageApplications(item, options));
                            }
                            packageApplications = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MsixPackageData(
                id,
                name,
                type,
                systemData,
                imagePath,
                packageName,
                packageFamilyName,
                displayName,
                packageRelativePath,
                isRegularRegistration,
                isActive,
                packageDependencies ?? new ChangeTrackingList<MsixPackageDependencies>(),
                version,
                lastUpdated,
                packageApplications ?? new ChangeTrackingList<MsixPackageApplications>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MsixPackageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MsixPackageData)} does not support writing '{options.Format}' format.");
            }
        }

        MsixPackageData IPersistableModel<MsixPackageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMsixPackageData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MsixPackageData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MsixPackageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
