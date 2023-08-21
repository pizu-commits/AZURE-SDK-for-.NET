// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningManagedIdentity : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (Core.Optional.IsDefined(ObjectId))
            {
                if (ObjectId != null)
                {
                    writer.WritePropertyName("objectId"u8);
                    writer.WriteStringValue(ObjectId.Value);
                }
                else
                {
                    writer.WriteNull("objectId");
                }
            }
            if (Core.Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            writer.WritePropertyName("identityType"u8);
            writer.WriteStringValue(IdentityType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningManagedIdentity DeserializeMachineLearningManagedIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Guid?> clientId = default;
            Core.Optional<Guid?> objectId = default;
            Core.Optional<ResourceIdentifier> resourceId = default;
            IdentityConfigurationType identityType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        objectId = null;
                        continue;
                    }
                    objectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityType"u8))
                {
                    identityType = new IdentityConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningManagedIdentity(identityType, Core.Optional.ToNullable(clientId), Core.Optional.ToNullable(objectId), resourceId.Value);
        }
    }
}
