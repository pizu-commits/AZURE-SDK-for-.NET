// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class DataLakeSharedKeyCredentialEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue<DataLakeGen2SharedKeyParam>(Parameters);
            writer.WritePropertyName("dataSourceCredentialType"u8);
            writer.WriteStringValue(CredentialKind.ToString());
            writer.WritePropertyName("dataSourceCredentialName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("dataSourceCredentialDescription"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static DataLakeSharedKeyCredentialEntity DeserializeDataLakeSharedKeyCredentialEntity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataLakeGen2SharedKeyParam parameters = default;
            DataSourceCredentialKind dataSourceCredentialType = default;
            string dataSourceCredentialId = default;
            string dataSourceCredentialName = default;
            string dataSourceCredentialDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = DataLakeGen2SharedKeyParam.DeserializeDataLakeGen2SharedKeyParam(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialType"u8))
                {
                    dataSourceCredentialType = new DataSourceCredentialKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialId"u8))
                {
                    dataSourceCredentialId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"u8))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"u8))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeSharedKeyCredentialEntity(dataSourceCredentialType, dataSourceCredentialId, dataSourceCredentialName, dataSourceCredentialDescription, parameters);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new DataLakeSharedKeyCredentialEntity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataLakeSharedKeyCredentialEntity(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
