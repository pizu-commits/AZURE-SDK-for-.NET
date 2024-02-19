// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Monitor
{
    public partial class MonitorPrivateLinkScopeResource : IJsonModel<MonitorPrivateLinkScopeData>
    {
        void IJsonModel<MonitorPrivateLinkScopeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MonitorPrivateLinkScopeData IJsonModel<MonitorPrivateLinkScopeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MonitorPrivateLinkScopeData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MonitorPrivateLinkScopeData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MonitorPrivateLinkScopeData IPersistableModel<MonitorPrivateLinkScopeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MonitorPrivateLinkScopeData>(data, options);
        }

        string IPersistableModel<MonitorPrivateLinkScopeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
