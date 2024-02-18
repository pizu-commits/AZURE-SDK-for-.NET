// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedDatabaseSecurityAlertPolicyResource : IJsonModel<ManagedDatabaseSecurityAlertPolicyData>
    {
        void IJsonModel<ManagedDatabaseSecurityAlertPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ManagedDatabaseSecurityAlertPolicyData IJsonModel<ManagedDatabaseSecurityAlertPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedDatabaseSecurityAlertPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ManagedDatabaseSecurityAlertPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ManagedDatabaseSecurityAlertPolicyData IPersistableModel<ManagedDatabaseSecurityAlertPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedDatabaseSecurityAlertPolicyData>(data, options);
        }

        string IPersistableModel<ManagedDatabaseSecurityAlertPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
