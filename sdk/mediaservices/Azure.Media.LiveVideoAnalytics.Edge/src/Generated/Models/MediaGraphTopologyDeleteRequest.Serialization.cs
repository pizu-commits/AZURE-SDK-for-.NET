// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class MediaGraphTopologyDeleteRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteObjectValue(Data);
            }
            writer.WriteEndObject();
        }

        internal static MediaGraphTopologyDeleteRequest DeserializeMediaGraphTopologyDeleteRequest(JsonElement element)
        {
            Optional<ItemOperationBase> data = default;
            Optional<string> methodName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    data = ItemOperationBase.DeserializeItemOperationBase(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphTopologyDeleteRequest(methodName.Value, data.Value);
        }
    }
}
