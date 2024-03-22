// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class AccessRoleBindingCreateContent : IUtf8JsonSerializable, IJsonModel<AccessRoleBindingCreateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessRoleBindingCreateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessRoleBindingCreateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingCreateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessRoleBindingCreateContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Principal))
            {
                writer.WritePropertyName("principal"u8);
                writer.WriteStringValue(Principal);
            }
            if (Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("role_name"u8);
                writer.WriteStringValue(RoleName);
            }
            if (Optional.IsDefined(CrnPattern))
            {
                writer.WritePropertyName("crn_pattern"u8);
                writer.WriteStringValue(CrnPattern);
            }
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

        AccessRoleBindingCreateContent IJsonModel<AccessRoleBindingCreateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingCreateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessRoleBindingCreateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessRoleBindingCreateContent(document.RootElement, options);
        }

        internal static AccessRoleBindingCreateContent DeserializeAccessRoleBindingCreateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string principal = default;
            string roleName = default;
            string crnPattern = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principal"u8))
                {
                    principal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role_name"u8))
                {
                    roleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crn_pattern"u8))
                {
                    crnPattern = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessRoleBindingCreateContent(principal, roleName, crnPattern, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AccessRoleBindingCreateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingCreateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AccessRoleBindingCreateContent)} does not support writing '{options.Format}' format.");
            }
        }

        AccessRoleBindingCreateContent IPersistableModel<AccessRoleBindingCreateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingCreateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessRoleBindingCreateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessRoleBindingCreateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessRoleBindingCreateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
