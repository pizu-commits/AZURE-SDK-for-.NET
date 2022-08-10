// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaTransformJobInputAsset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("assetName");
            writer.WriteStringValue(AssetName);
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files");
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start");
                writer.WriteObjectValue(Start);
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end");
                writer.WriteObjectValue(End);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(InputDefinitions))
            {
                writer.WritePropertyName("inputDefinitions");
                writer.WriteStartArray();
                foreach (var item in InputDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static MediaTransformJobInputAsset DeserializeMediaTransformJobInputAsset(JsonElement element)
        {
            string assetName = default;
            Optional<IList<string>> files = default;
            Optional<ClipTime> start = default;
            Optional<ClipTime> end = default;
            Optional<string> label = default;
            Optional<IList<MediaTransformJobInputDefinition>> inputDefinitions = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetName"))
                {
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("files"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("start"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    start = ClipTime.DeserializeClipTime(property.Value);
                    continue;
                }
                if (property.NameEquals("end"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    end = ClipTime.DeserializeClipTime(property.Value);
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDefinitions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MediaTransformJobInputDefinition> array = new List<MediaTransformJobInputDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaTransformJobInputDefinition.DeserializeMediaTransformJobInputDefinition(item));
                    }
                    inputDefinitions = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new MediaTransformJobInputAsset(odataType, Optional.ToList(files), start.Value, end.Value, label.Value, Optional.ToList(inputDefinitions), assetName);
        }
    }
}
