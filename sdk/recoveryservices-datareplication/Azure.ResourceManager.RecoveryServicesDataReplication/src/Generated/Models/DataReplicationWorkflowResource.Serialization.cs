// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class DataReplicationWorkflowResource : IJsonModel<DataReplicationWorkflowData>
    {
        void IJsonModel<DataReplicationWorkflowData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DataReplicationWorkflowData IJsonModel<DataReplicationWorkflowData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataReplicationWorkflowData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DataReplicationWorkflowData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DataReplicationWorkflowData IPersistableModel<DataReplicationWorkflowData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataReplicationWorkflowData>(data, options);
        }

        string IPersistableModel<DataReplicationWorkflowData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
