// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class SelectVideoTrackByAttribute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("attribute");
            writer.WriteStringValue(Attribute.ToString());
            writer.WritePropertyName("filter");
            writer.WriteStringValue(Filter.ToString());
            if (Optional.IsDefined(FilterValue))
            {
                writer.WritePropertyName("filterValue");
                writer.WriteStringValue(FilterValue);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static SelectVideoTrackByAttribute DeserializeSelectVideoTrackByAttribute(JsonElement element)
        {
            TrackAttribute attribute = default;
            TrackAttributeFilter filter = default;
            Optional<string> filterValue = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attribute"))
                {
                    attribute = new TrackAttribute(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    filter = new TrackAttributeFilter(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filterValue"))
                {
                    filterValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new SelectVideoTrackByAttribute(odataType, attribute, filter, filterValue.Value);
        }
    }
}
