// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServices
{
    public partial class RecoveryServicesVaultExtendedInfoResource : IJsonModel<RecoveryServicesVaultExtendedInfoData>
    {
        void IJsonModel<RecoveryServicesVaultExtendedInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        RecoveryServicesVaultExtendedInfoData IJsonModel<RecoveryServicesVaultExtendedInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RecoveryServicesVaultExtendedInfoData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<RecoveryServicesVaultExtendedInfoData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        RecoveryServicesVaultExtendedInfoData IPersistableModel<RecoveryServicesVaultExtendedInfoData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RecoveryServicesVaultExtendedInfoData>(data, options);
        }

        string IPersistableModel<RecoveryServicesVaultExtendedInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
