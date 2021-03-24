// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    public partial class AlignPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AlignMode))
            {
                writer.WritePropertyName("alignMode");
                writer.WriteStringValue(AlignMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(FillNAMethod))
            {
                writer.WritePropertyName("fillNAMethod");
                writer.WriteStringValue(FillNAMethod.Value.ToSerialString());
            }
            if (Optional.IsDefined(PaddingValue))
            {
                writer.WritePropertyName("paddingValue");
                writer.WriteNumberValue(PaddingValue.Value);
            }
            writer.WriteEndObject();
        }

        internal static AlignPolicy DeserializeAlignPolicy(JsonElement element)
        {
            Optional<AlignMode> alignMode = default;
            Optional<FillNAMethod> fillNAMethod = default;
            Optional<int> paddingValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alignMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alignMode = property.Value.GetString().ToAlignMode();
                    continue;
                }
                if (property.NameEquals("fillNAMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fillNAMethod = property.Value.GetString().ToFillNAMethod();
                    continue;
                }
                if (property.NameEquals("paddingValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paddingValue = property.Value.GetInt32();
                    continue;
                }
            }
            return new AlignPolicy(Optional.ToNullable(alignMode), Optional.ToNullable(fillNAMethod), Optional.ToNullable(paddingValue));
        }
    }
}
