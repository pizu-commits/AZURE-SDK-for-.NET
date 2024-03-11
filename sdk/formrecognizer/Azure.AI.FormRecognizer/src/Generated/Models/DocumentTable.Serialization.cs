// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentTable
    {
        internal static DocumentTable DeserializeDocumentTable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int rowCount = default;
            int columnCount = default;
            IReadOnlyList<DocumentTableCell> cells = default;
            IReadOnlyList<BoundingRegion> boundingRegions = default;
            IReadOnlyList<DocumentSpan> spans = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rowCount"u8))
                {
                    rowCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnCount"u8))
                {
                    columnCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cells"u8))
                {
                    List<DocumentTableCell> array = new List<DocumentTableCell>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentTableCell.DeserializeDocumentTableCell(item));
                    }
                    cells = array;
                    continue;
                }
                if (property.NameEquals("boundingRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BoundingRegion> array = new List<BoundingRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BoundingRegion.DeserializeBoundingRegion(item));
                    }
                    boundingRegions = array;
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
                    continue;
                }
            }
            return new DocumentTable(rowCount, columnCount, cells, boundingRegions ?? new ChangeTrackingList<BoundingRegion>(), spans);
        }
    }
}
