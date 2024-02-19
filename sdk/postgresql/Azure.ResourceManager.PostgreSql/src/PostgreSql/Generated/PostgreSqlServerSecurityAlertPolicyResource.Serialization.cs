// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql
{
    public partial class PostgreSqlServerSecurityAlertPolicyResource : IJsonModel<PostgreSqlServerSecurityAlertPolicyData>
    {
        void IJsonModel<PostgreSqlServerSecurityAlertPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        PostgreSqlServerSecurityAlertPolicyData IJsonModel<PostgreSqlServerSecurityAlertPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PostgreSqlServerSecurityAlertPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<PostgreSqlServerSecurityAlertPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        PostgreSqlServerSecurityAlertPolicyData IPersistableModel<PostgreSqlServerSecurityAlertPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PostgreSqlServerSecurityAlertPolicyData>(data, options);
        }

        string IPersistableModel<PostgreSqlServerSecurityAlertPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
