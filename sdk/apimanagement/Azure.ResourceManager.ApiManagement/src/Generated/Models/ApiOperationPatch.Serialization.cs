// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiOperationPatch : IUtf8JsonSerializable, IJsonModel<ApiOperationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiOperationPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiOperationPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiOperationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiOperationPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TemplateParameters))
            {
                writer.WritePropertyName("templateParameters"u8);
                writer.WriteStartArray();
                foreach (var item in TemplateParameters)
                {
                    writer.WriteObjectValue<ParameterContract>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Request))
            {
                writer.WritePropertyName("request"u8);
                writer.WriteObjectValue<RequestContract>(Request, options);
            }
            if (Optional.IsCollectionDefined(Responses))
            {
                writer.WritePropertyName("responses"u8);
                writer.WriteStartArray();
                foreach (var item in Responses)
                {
                    writer.WriteObjectValue<ResponseContract>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStringValue(Policies);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method);
            }
            if (Optional.IsDefined(UriTemplate))
            {
                writer.WritePropertyName("urlTemplate"u8);
                writer.WriteStringValue(UriTemplate);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApiOperationPatch IJsonModel<ApiOperationPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiOperationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiOperationPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiOperationPatch(document.RootElement, options);
        }

        internal static ApiOperationPatch DeserializeApiOperationPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ParameterContract> templateParameters = default;
            string description = default;
            RequestContract request = default;
            IList<ResponseContract> responses = default;
            string policies = default;
            string displayName = default;
            string method = default;
            string uriTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("templateParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ParameterContract> array = new List<ParameterContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ParameterContract.DeserializeParameterContract(item, options));
                            }
                            templateParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("request"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            request = RequestContract.DeserializeRequestContract(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("responses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResponseContract> array = new List<ResponseContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResponseContract.DeserializeResponseContract(item, options));
                            }
                            responses = array;
                            continue;
                        }
                        if (property0.NameEquals("policies"u8))
                        {
                            policies = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("method"u8))
                        {
                            method = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("urlTemplate"u8))
                        {
                            uriTemplate = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiOperationPatch(
                templateParameters ?? new ChangeTrackingList<ParameterContract>(),
                description,
                request,
                responses ?? new ChangeTrackingList<ResponseContract>(),
                policies,
                displayName,
                method,
                uriTemplate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiOperationPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiOperationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiOperationPatch)} does not support writing '{options.Format}' format.");
            }
        }

        ApiOperationPatch IPersistableModel<ApiOperationPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiOperationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiOperationPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiOperationPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiOperationPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
