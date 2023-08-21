// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralAppTemplate
    {
        internal static IotCentralAppTemplate DeserializeIotCentralAppTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> manifestId = default;
            Core.Optional<string> manifestVersion = default;
            Core.Optional<string> name = default;
            Core.Optional<string> title = default;
            Core.Optional<int> order = default;
            Core.Optional<string> description = default;
            Core.Optional<string> industry = default;
            Core.Optional<IReadOnlyList<IotCentralAppTemplateLocation>> locations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifestId"u8))
                {
                    manifestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestVersion"u8))
                {
                    manifestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("industry"u8))
                {
                    industry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotCentralAppTemplateLocation> array = new List<IotCentralAppTemplateLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralAppTemplateLocation.DeserializeIotCentralAppTemplateLocation(item));
                    }
                    locations = array;
                    continue;
                }
            }
            return new IotCentralAppTemplate(manifestId.Value, manifestVersion.Value, name.Value, title.Value, Core.Optional.ToNullable(order), description.Value, industry.Value, Core.Optional.ToList(locations));
        }
    }
}
