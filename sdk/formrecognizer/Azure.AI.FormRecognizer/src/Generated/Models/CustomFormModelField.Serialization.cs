// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.FormRecognizer.Training
{
    public partial class CustomFormModelField
    {
        internal static CustomFormModelField DeserializeCustomFormModelField(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fieldName = default;
            float? accuracy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accuracy"u8))
                {
                    accuracy = property.Value.GetSingle();
                    continue;
                }
            }
            return new CustomFormModelField(fieldName, accuracy);
        }
    }
}
