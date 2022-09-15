// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class UserAccessRight : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("userId");
            writer.WriteStringValue(UserId);
            writer.WritePropertyName("accessType");
            writer.WriteStringValue(AccessType.ToString());
            writer.WriteEndObject();
        }

        internal static UserAccessRight DeserializeUserAccessRight(JsonElement element)
        {
            ResourceIdentifier userId = default;
            ShareAccessType accessType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userId"))
                {
                    userId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessType"))
                {
                    accessType = new ShareAccessType(property.Value.GetString());
                    continue;
                }
            }
            return new UserAccessRight(userId, accessType);
        }
    }
}
