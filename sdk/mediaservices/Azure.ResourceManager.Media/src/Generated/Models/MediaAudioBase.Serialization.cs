// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaAudioBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Channels))
            {
                writer.WritePropertyName("channels");
                writer.WriteNumberValue(Channels.Value);
            }
            if (Optional.IsDefined(SamplingRate))
            {
                writer.WritePropertyName("samplingRate");
                writer.WriteNumberValue(SamplingRate.Value);
            }
            if (Optional.IsDefined(Bitrate))
            {
                writer.WritePropertyName("bitrate");
                writer.WriteNumberValue(Bitrate.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            writer.WriteEndObject();
        }

        internal static MediaAudioBase DeserializeMediaAudioBase(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AacAudio": return AacAudio.DeserializeAacAudio(element);
                }
            }
            Optional<int> channels = default;
            Optional<int> samplingRate = default;
            Optional<int> bitrate = default;
            string odataType = default;
            Optional<string> label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    channels = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("samplingRate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    samplingRate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bitrate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new MediaAudioBase(odataType, label.Value, Optional.ToNullable(channels), Optional.ToNullable(samplingRate), Optional.ToNullable(bitrate));
        }
    }
}
