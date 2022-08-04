// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactValidationOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("messageId");
            writer.WriteStringValue(MessageId);
            writer.WritePropertyName("enforceCharacterSet");
            writer.WriteBooleanValue(EnforceCharacterSet);
            writer.WritePropertyName("validateEDITypes");
            writer.WriteBooleanValue(ValidateEdiTypes);
            writer.WritePropertyName("validateXSDTypes");
            writer.WriteBooleanValue(ValidateXsdTypes);
            writer.WritePropertyName("allowLeadingAndTrailingSpacesAndZeroes");
            writer.WriteBooleanValue(AllowLeadingAndTrailingSpacesAndZeroes);
            writer.WritePropertyName("trailingSeparatorPolicy");
            writer.WriteStringValue(TrailingSeparatorPolicy.ToString());
            writer.WritePropertyName("trimLeadingAndTrailingSpacesAndZeroes");
            writer.WriteBooleanValue(TrimLeadingAndTrailingSpacesAndZeroes);
            writer.WriteEndObject();
        }

        internal static EdifactValidationOverride DeserializeEdifactValidationOverride(JsonElement element)
        {
            string messageId = default;
            bool enforceCharacterSet = default;
            bool validateEdiTypes = default;
            bool validateXsdTypes = default;
            bool allowLeadingAndTrailingSpacesAndZeroes = default;
            TrailingSeparatorPolicy trailingSeparatorPolicy = default;
            bool trimLeadingAndTrailingSpacesAndZeroes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enforceCharacterSet"))
                {
                    enforceCharacterSet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateEDITypes"))
                {
                    validateEdiTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateXSDTypes"))
                {
                    validateXsdTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowLeadingAndTrailingSpacesAndZeroes"))
                {
                    allowLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trailingSeparatorPolicy"))
                {
                    trailingSeparatorPolicy = new TrailingSeparatorPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trimLeadingAndTrailingSpacesAndZeroes"))
                {
                    trimLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EdifactValidationOverride(messageId, enforceCharacterSet, validateEdiTypes, validateXsdTypes, allowLeadingAndTrailingSpacesAndZeroes, trailingSeparatorPolicy, trimLeadingAndTrailingSpacesAndZeroes);
        }
    }
}
