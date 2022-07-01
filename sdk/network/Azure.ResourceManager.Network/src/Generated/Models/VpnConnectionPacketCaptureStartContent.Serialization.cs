// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnConnectionPacketCaptureStartContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FilterData))
            {
                writer.WritePropertyName("filterData");
                writer.WriteStringValue(FilterData);
            }
            if (Optional.IsCollectionDefined(LinkConnectionNames))
            {
                writer.WritePropertyName("linkConnectionNames");
                writer.WriteStartArray();
                foreach (var item in LinkConnectionNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
