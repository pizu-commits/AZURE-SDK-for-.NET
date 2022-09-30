// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class RestResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SuccessStatusCodes))
            {
                writer.WritePropertyName("successStatusCodes");
                writer.WriteStartArray();
                foreach (var item in SuccessStatusCodes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Regex))
            {
                writer.WritePropertyName("regex");
                writer.WriteObjectValue(Regex);
            }
            writer.WriteEndObject();
        }

        internal static RestResponse DeserializeRestResponse(JsonElement element)
        {
            Optional<IList<string>> successStatusCodes = default;
            Optional<RestResponseRegex> regex = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("successStatusCodes"))
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
                    successStatusCodes = array;
                    continue;
                }
                if (property.NameEquals("regex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    regex = RestResponseRegex.DeserializeRestResponseRegex(property.Value);
                    continue;
                }
            }
            return new RestResponse(Optional.ToList(successStatusCodes), regex.Value);
        }
    }
}
