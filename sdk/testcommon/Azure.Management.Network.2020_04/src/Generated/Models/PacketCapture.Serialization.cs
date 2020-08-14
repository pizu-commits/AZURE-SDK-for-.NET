// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PacketCapture : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("target");
            writer.WriteStringValue(Target);
            if (Optional.IsDefined(BytesToCapturePerPacket))
            {
                writer.WritePropertyName("bytesToCapturePerPacket");
                writer.WriteNumberValue(BytesToCapturePerPacket.Value);
            }
            if (Optional.IsDefined(TotalBytesPerSession))
            {
                writer.WritePropertyName("totalBytesPerSession");
                writer.WriteNumberValue(TotalBytesPerSession.Value);
            }
            if (Optional.IsDefined(TimeLimitInSeconds))
            {
                writer.WritePropertyName("timeLimitInSeconds");
                writer.WriteNumberValue(TimeLimitInSeconds.Value);
            }
            writer.WritePropertyName("storageLocation");
            writer.WriteObjectValue(StorageLocation);
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters");
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
