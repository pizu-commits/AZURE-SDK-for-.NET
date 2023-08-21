// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class OpenAuthenticationAccessPolicy : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(Claims))
            {
                writer.WritePropertyName("claims"u8);
                writer.WriteStartArray();
                foreach (var item in Claims)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OpenAuthenticationAccessPolicy DeserializeOpenAuthenticationAccessPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<OpenAuthenticationProviderType> type = default;
            Core.Optional<IList<OpenAuthenticationPolicyClaim>> claims = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OpenAuthenticationProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OpenAuthenticationPolicyClaim> array = new List<OpenAuthenticationPolicyClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OpenAuthenticationPolicyClaim.DeserializeOpenAuthenticationPolicyClaim(item));
                    }
                    claims = array;
                    continue;
                }
            }
            return new OpenAuthenticationAccessPolicy(Core.Optional.ToNullable(type), Core.Optional.ToList(claims));
        }
    }
}
