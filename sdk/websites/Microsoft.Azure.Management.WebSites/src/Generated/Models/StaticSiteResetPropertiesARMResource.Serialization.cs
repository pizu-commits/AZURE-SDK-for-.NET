// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class StaticSiteResetPropertiesARMResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RepositoryToken))
            {
                writer.WritePropertyName("repositoryToken");
                writer.WriteStringValue(RepositoryToken);
            }
            if (Optional.IsDefined(ShouldUpdateRepository))
            {
                writer.WritePropertyName("shouldUpdateRepository");
                writer.WriteBooleanValue(ShouldUpdateRepository.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StaticSiteResetPropertiesARMResource DeserializeStaticSiteResetPropertiesARMResource(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> kind = default;
            Optional<string> type = default;
            Optional<string> repositoryToken = default;
            Optional<bool> shouldUpdateRepository = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("repositoryToken"))
                        {
                            repositoryToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shouldUpdateRepository"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            shouldUpdateRepository = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StaticSiteResetPropertiesARMResource(id.Value, name.Value, kind.Value, type.Value, repositoryToken.Value, Optional.ToNullable(shouldUpdateRepository));
        }
    }
}
