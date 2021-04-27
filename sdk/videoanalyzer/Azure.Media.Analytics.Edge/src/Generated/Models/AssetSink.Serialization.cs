// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class AssetSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("assetContainerSasUrl");
            writer.WriteStringValue(AssetContainerSasUrl);
            if (Optional.IsDefined(SegmentLength))
            {
                writer.WritePropertyName("segmentLength");
                writer.WriteStringValue(SegmentLength);
            }
            writer.WritePropertyName("localMediaCachePath");
            writer.WriteStringValue(LocalMediaCachePath);
            writer.WritePropertyName("localMediaCacheMaximumSizeMiB");
            writer.WriteStringValue(LocalMediaCacheMaximumSizeMiB);
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static AssetSink DeserializeAssetSink(JsonElement element)
        {
            string assetContainerSasUrl = default;
            Optional<string> segmentLength = default;
            string localMediaCachePath = default;
            string localMediaCacheMaximumSizeMiB = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetContainerSasUrl"))
                {
                    assetContainerSasUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segmentLength"))
                {
                    segmentLength = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localMediaCachePath"))
                {
                    localMediaCachePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localMediaCacheMaximumSizeMiB"))
                {
                    localMediaCacheMaximumSizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new AssetSink(type, name, inputs, assetContainerSasUrl, segmentLength.Value, localMediaCachePath, localMediaCacheMaximumSizeMiB);
        }
    }
}
