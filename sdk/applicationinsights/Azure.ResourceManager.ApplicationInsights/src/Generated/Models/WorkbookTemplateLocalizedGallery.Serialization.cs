// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WorkbookTemplateLocalizedGallery : IUtf8JsonSerializable, IJsonModel<WorkbookTemplateLocalizedGallery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkbookTemplateLocalizedGallery>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WorkbookTemplateLocalizedGallery>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateData))
            {
                writer.WritePropertyName("templateData"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TemplateData);
#else
                using (JsonDocument document = JsonDocument.Parse(TemplateData))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Galleries))
            {
                writer.WritePropertyName("galleries"u8);
                writer.WriteStartArray();
                foreach (var item in Galleries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        WorkbookTemplateLocalizedGallery IJsonModel<WorkbookTemplateLocalizedGallery>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkbookTemplateLocalizedGallery)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkbookTemplateLocalizedGallery(document.RootElement, options);
        }

        internal static WorkbookTemplateLocalizedGallery DeserializeWorkbookTemplateLocalizedGallery(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> templateData = default;
            Optional<IList<WorkbookTemplateGallery>> galleries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateData = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("galleries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkbookTemplateGallery> array = new List<WorkbookTemplateGallery>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkbookTemplateGallery.DeserializeWorkbookTemplateGallery(item));
                    }
                    galleries = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkbookTemplateLocalizedGallery(templateData.Value, Optional.ToList(galleries), serializedAdditionalRawData);
        }

        BinaryData IModel<WorkbookTemplateLocalizedGallery>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkbookTemplateLocalizedGallery)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WorkbookTemplateLocalizedGallery IModel<WorkbookTemplateLocalizedGallery>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkbookTemplateLocalizedGallery)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWorkbookTemplateLocalizedGallery(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WorkbookTemplateLocalizedGallery>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
