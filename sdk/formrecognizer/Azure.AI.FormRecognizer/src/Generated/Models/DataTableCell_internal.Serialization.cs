// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class DataTableCell_internal
    {
        internal static DataTableCell_internal DeserializeDataTableCell_internal(JsonElement element)
        {
            DataTableCell_internal result = new DataTableCell_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rowIndex"))
                {
                    result.RowIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnIndex"))
                {
                    result.ColumnIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rowSpan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RowSpan = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnSpan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ColumnSpan = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    result.Text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.BoundingBox.Add(item.GetSingle());
                    }
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    result.Confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("elements"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Elements = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Elements.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("isHeader"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IsHeader = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isFooter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IsFooter = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}
