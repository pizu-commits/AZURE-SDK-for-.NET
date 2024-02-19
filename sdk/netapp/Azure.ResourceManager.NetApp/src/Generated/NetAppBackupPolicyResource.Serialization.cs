// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppBackupPolicyResource : IJsonModel<NetAppBackupPolicyData>
    {
        void IJsonModel<NetAppBackupPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        NetAppBackupPolicyData IJsonModel<NetAppBackupPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetAppBackupPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<NetAppBackupPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        NetAppBackupPolicyData IPersistableModel<NetAppBackupPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetAppBackupPolicyData>(data, options);
        }

        string IPersistableModel<NetAppBackupPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
