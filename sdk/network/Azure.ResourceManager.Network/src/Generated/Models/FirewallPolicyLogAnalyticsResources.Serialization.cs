// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyLogAnalyticsResources : IUtf8JsonSerializable, IJsonModel<FirewallPolicyLogAnalyticsResources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyLogAnalyticsResources>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPolicyLogAnalyticsResources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyLogAnalyticsResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FirewallPolicyLogAnalyticsResources)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Workspaces))
            {
                writer.WritePropertyName("workspaces"u8);
                writer.WriteStartArray();
                foreach (var item in Workspaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultWorkspaceId))
            {
                writer.WritePropertyName("defaultWorkspaceId"u8);
                JsonSerializer.Serialize(writer, DefaultWorkspaceId);
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

        FirewallPolicyLogAnalyticsResources IJsonModel<FirewallPolicyLogAnalyticsResources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyLogAnalyticsResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FirewallPolicyLogAnalyticsResources)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyLogAnalyticsResources(document.RootElement, options);
        }

        internal static FirewallPolicyLogAnalyticsResources DeserializeFirewallPolicyLogAnalyticsResources(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<FirewallPolicyLogAnalyticsWorkspace>> workspaces = default;
            Optional<WritableSubResource> defaultWorkspaceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyLogAnalyticsWorkspace> array = new List<FirewallPolicyLogAnalyticsWorkspace>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyLogAnalyticsWorkspace.DeserializeFirewallPolicyLogAnalyticsWorkspace(item));
                    }
                    workspaces = array;
                    continue;
                }
                if (property.NameEquals("defaultWorkspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultWorkspaceId = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallPolicyLogAnalyticsResources(Optional.ToList(workspaces), defaultWorkspaceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPolicyLogAnalyticsResources>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyLogAnalyticsResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(FirewallPolicyLogAnalyticsResources)} does not support '{options.Format}' format.");
            }
        }

        FirewallPolicyLogAnalyticsResources IPersistableModel<FirewallPolicyLogAnalyticsResources>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyLogAnalyticsResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPolicyLogAnalyticsResources(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(FirewallPolicyLogAnalyticsResources)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicyLogAnalyticsResources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
