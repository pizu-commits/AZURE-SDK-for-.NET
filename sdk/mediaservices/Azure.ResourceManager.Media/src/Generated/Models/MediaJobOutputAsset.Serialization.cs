// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobOutputAsset : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("assetName"u8);
            writer.WriteStringValue(AssetName);
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Core.Optional.IsDefined(PresetOverride))
            {
                writer.WritePropertyName("presetOverride"u8);
                writer.WriteObjectValue(PresetOverride);
            }
            if (Core.Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            writer.WriteEndObject();
        }

        internal static MediaJobOutputAsset DeserializeMediaJobOutputAsset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assetName = default;
            string odataType = default;
            Core.Optional<MediaJobError> error = default;
            Core.Optional<MediaTransformPreset> presetOverride = default;
            Core.Optional<MediaJobState> state = default;
            Core.Optional<int> progress = default;
            Core.Optional<string> label = default;
            Core.Optional<DateTimeOffset?> startTime = default;
            Core.Optional<DateTimeOffset?> endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetName"u8))
                {
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = MediaJobError.DeserializeMediaJobError(property.Value);
                    continue;
                }
                if (property.NameEquals("presetOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    presetOverride = MediaTransformPreset.DeserializeMediaTransformPreset(property.Value);
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MediaJobState(property.Value.GetString());
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
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new MediaJobOutputAsset(odataType, error.Value, presetOverride.Value, Core.Optional.ToNullable(state), Core.Optional.ToNullable(progress), label.Value, Core.Optional.ToNullable(startTime), Core.Optional.ToNullable(endTime), assetName);
        }
    }
}
