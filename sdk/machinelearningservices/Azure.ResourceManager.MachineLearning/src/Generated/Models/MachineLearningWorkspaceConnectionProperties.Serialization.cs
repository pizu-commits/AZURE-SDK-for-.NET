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
    [PersistableModelProxy(typeof(UnknownWorkspaceConnectionPropertiesV2))]
    public partial class MachineLearningWorkspaceConnectionProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningWorkspaceConnectionProperties>, IPersistableModel<MachineLearningWorkspaceConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWorkspaceConnectionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningWorkspaceConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceConnectionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
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

        MachineLearningWorkspaceConnectionProperties IJsonModel<MachineLearningWorkspaceConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceConnectionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspaceConnectionProperties(document.RootElement, options);
        }

        internal static MachineLearningWorkspaceConnectionProperties DeserializeMachineLearningWorkspaceConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AccessKey": return AccessKeyAuthTypeWorkspaceConnectionProperties.DeserializeAccessKeyAuthTypeWorkspaceConnectionProperties(element);
                    case "ApiKey": return ApiKeyAuthWorkspaceConnectionProperties.DeserializeApiKeyAuthWorkspaceConnectionProperties(element);
                    case "CustomKeys": return CustomKeysWorkspaceConnectionProperties.DeserializeCustomKeysWorkspaceConnectionProperties(element);
                    case "ManagedIdentity": return MachineLearningManagedIdentityAuthTypeWorkspaceConnection.DeserializeMachineLearningManagedIdentityAuthTypeWorkspaceConnection(element);
                    case "None": return MachineLearningNoneAuthTypeWorkspaceConnection.DeserializeMachineLearningNoneAuthTypeWorkspaceConnection(element);
                    case "PAT": return MachineLearningPatAuthTypeWorkspaceConnection.DeserializeMachineLearningPatAuthTypeWorkspaceConnection(element);
                    case "SAS": return MachineLearningSasAuthTypeWorkspaceConnection.DeserializeMachineLearningSasAuthTypeWorkspaceConnection(element);
                    case "ServicePrincipal": return ServicePrincipalAuthTypeWorkspaceConnectionProperties.DeserializeServicePrincipalAuthTypeWorkspaceConnectionProperties(element);
                    case "UsernamePassword": return MachineLearningUsernamePasswordAuthTypeWorkspaceConnection.DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(element);
                }
            }
            return UnknownWorkspaceConnectionPropertiesV2.DeserializeUnknownWorkspaceConnectionPropertiesV2(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AuthType))
            {
                builder.Append("  authType:");
                builder.AppendLine($" '{AuthType.ToString()}'");
            }

            if (Optional.IsDefined(Category))
            {
                builder.Append("  category:");
                builder.AppendLine($" '{Category.ToString()}'");
            }

            if (Optional.IsDefined(ExpiryOn))
            {
                builder.Append("  expiryTime:");
                builder.AppendLine($" '{ExpiryOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(Metadata))
            {
                builder.Append("  metadata:");
                builder.AppendLine($" '{Metadata.ToString()}'");
            }

            if (Optional.IsDefined(Target))
            {
                builder.Append("  target:");
                builder.AppendLine($" '{Target}'");
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

        BinaryData IPersistableModel<MachineLearningWorkspaceConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningWorkspaceConnectionProperties IPersistableModel<MachineLearningWorkspaceConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningWorkspaceConnectionProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWorkspaceConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
