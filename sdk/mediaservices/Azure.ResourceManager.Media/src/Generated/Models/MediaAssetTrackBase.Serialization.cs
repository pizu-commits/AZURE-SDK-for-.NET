// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaAssetTrackBase : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static MediaAssetTrackBase DeserializeMediaAssetTrackBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AudioTrack": return AudioTrack.DeserializeAudioTrack(element);
                    case "#Microsoft.Media.TextTrack": return TextTrack.DeserializeTextTrack(element);
                    case "#Microsoft.Media.VideoTrack": return VideoTrack.DeserializeVideoTrack(element);
                }
            }
            return UnknownTrackBase.DeserializeUnknownTrackBase(element);
        }
    }
}
