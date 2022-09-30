// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptSecureStringExecutionParameterDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SecureValue))
            {
                writer.WritePropertyName("secureValue");
                writer.WriteStringValue(SecureValue);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(ParameterType.ToString());
            writer.WriteEndObject();
        }

        internal static ScriptSecureStringExecutionParameterDetails DeserializeScriptSecureStringExecutionParameterDetails(JsonElement element)
        {
            Optional<string> secureValue = default;
            string name = default;
            ScriptExecutionParameterType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secureValue"))
                {
                    secureValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ScriptExecutionParameterType(property.Value.GetString());
                    continue;
                }
            }
            return new ScriptSecureStringExecutionParameterDetails(name, type, secureValue.Value);
        }
    }
}
