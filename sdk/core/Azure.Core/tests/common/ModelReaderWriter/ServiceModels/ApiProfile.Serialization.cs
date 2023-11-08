// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core.Tests.Common;

namespace Azure.Core.Tests.Models.ResourceManager.Resources
{
    public partial class ApiProfile : IUtf8JsonSerializable, IJsonModel<ApiProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiProfile>)this).Write(writer, ModelReaderWriterOptions.Wire);

        internal static ApiProfile DeserializeApiProfile(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> profileVersion = default;
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileVersion"u8))
                {
                    profileVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ApiProfile(profileVersion.Value, apiVersion.Value);
        }

        void IJsonModel<ApiProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProfileVersion))
            {
                writer.WritePropertyName("profileVersion"u8);
                writer.WriteStringValue(ProfileVersion);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        private struct ApiProfileProperties
        {
            public Optional<string> ProfileVersion { get; set; }
            public Optional<string> ApiVersion { get; set; }
        }

        ApiProfile IJsonModel<ApiProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApiProfile(doc.RootElement, options);
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ApiProfileProperties properties, ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            if (propertyName.SequenceEqual("profileVersion"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ProfileVersion = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("apiVersion"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ApiVersion = reader.GetString();
                return;
            }
            reader.Skip();
        }

        ApiProfile IModel<ApiProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeApiProfile(doc.RootElement, options);
        }

        BinaryData IModel<ApiProfile>.Write(ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IModel<ApiProfile>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
