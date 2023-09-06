// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningVirtualMachineProperties : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningVirtualMachineProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningVirtualMachineProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningVirtualMachineProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningVirtualMachineProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualMachineSize))
            {
                writer.WritePropertyName("virtualMachineSize"u8);
                writer.WriteStringValue(VirtualMachineSize);
            }
            if (Optional.IsDefined(SshPort))
            {
                writer.WritePropertyName("sshPort"u8);
                writer.WriteNumberValue(SshPort.Value);
            }
            if (Optional.IsDefined(NotebookServerPort))
            {
                writer.WritePropertyName("notebookServerPort"u8);
                writer.WriteNumberValue(NotebookServerPort.Value);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address.ToString());
            }
            if (Optional.IsDefined(AdministratorAccount))
            {
                if (AdministratorAccount != null)
                {
                    writer.WritePropertyName("administratorAccount"u8);
                    if (AdministratorAccount is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningVmSshCredentials>)AdministratorAccount).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("administratorAccount");
                }
            }
            if (Optional.IsDefined(IsNotebookInstanceCompute))
            {
                writer.WritePropertyName("isNotebookInstanceCompute"u8);
                writer.WriteBooleanValue(IsNotebookInstanceCompute.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningVirtualMachineProperties DeserializeMachineLearningVirtualMachineProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> virtualMachineSize = default;
            Optional<int> sshPort = default;
            Optional<int> notebookServerPort = default;
            Optional<IPAddress> address = default;
            Optional<MachineLearningVmSshCredentials> administratorAccount = default;
            Optional<bool> isNotebookInstanceCompute = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachineSize"u8))
                {
                    virtualMachineSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("notebookServerPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notebookServerPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("administratorAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        administratorAccount = null;
                        continue;
                    }
                    administratorAccount = MachineLearningVmSshCredentials.DeserializeMachineLearningVmSshCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("isNotebookInstanceCompute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNotebookInstanceCompute = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningVirtualMachineProperties(virtualMachineSize.Value, Optional.ToNullable(sshPort), Optional.ToNullable(notebookServerPort), address.Value, administratorAccount.Value, Optional.ToNullable(isNotebookInstanceCompute), rawData);
        }

        MachineLearningVirtualMachineProperties IModelJsonSerializable<MachineLearningVirtualMachineProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningVirtualMachineProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningVirtualMachineProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningVirtualMachineProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningVirtualMachineProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningVirtualMachineProperties IModelSerializable<MachineLearningVirtualMachineProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningVirtualMachineProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningVirtualMachineProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningVirtualMachineProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningVirtualMachineProperties"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningVirtualMachineProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningVirtualMachineProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningVirtualMachineProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningVirtualMachineProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
