// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownPackageInputPathBase))]
    public partial class PackageInputPathBase : IUtf8JsonSerializable, IJsonModel<PackageInputPathBase>, IPersistableModel<PackageInputPathBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PackageInputPathBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PackageInputPathBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("inputPathType"u8);
            writer.WriteStringValue(InputPathType.ToString());
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

        PackageInputPathBase IJsonModel<PackageInputPathBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePackageInputPathBase(document.RootElement, options);
        }

        internal static PackageInputPathBase DeserializePackageInputPathBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("inputPathType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "PathId": return PackageInputPathId.DeserializePackageInputPathId(element);
                    case "PathVersion": return PackageInputPathVersion.DeserializePackageInputPathVersion(element);
                    case "Url": return PackageInputPathUri.DeserializePackageInputPathUri(element);
                }
            }
            return UnknownPackageInputPathBase.DeserializeUnknownPackageInputPathBase(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(InputPathType))
            {
                builder.Append("  inputPathType:");
                builder.AppendLine($" '{InputPathType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<PackageInputPathBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support '{options.Format}' format.");
            }
        }

        PackageInputPathBase IPersistableModel<PackageInputPathBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePackageInputPathBase(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PackageInputPathBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
