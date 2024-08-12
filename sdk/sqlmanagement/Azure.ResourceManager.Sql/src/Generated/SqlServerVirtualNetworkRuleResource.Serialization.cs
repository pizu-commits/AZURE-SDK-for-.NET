// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerVirtualNetworkRuleResource : IJsonModel<SqlServerVirtualNetworkRuleData>
    {
        void IJsonModel<SqlServerVirtualNetworkRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerVirtualNetworkRuleData>)Data).Write(writer, options);

        SqlServerVirtualNetworkRuleData IJsonModel<SqlServerVirtualNetworkRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerVirtualNetworkRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerVirtualNetworkRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SqlServerVirtualNetworkRuleData IPersistableModel<SqlServerVirtualNetworkRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerVirtualNetworkRuleData>(data, options);

        string IPersistableModel<SqlServerVirtualNetworkRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerVirtualNetworkRuleData>)Data).GetFormatFromOptions(options);
    }
}
