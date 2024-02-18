// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RedisEnterprise
{
    public partial class RedisEnterpriseClusterResource : IJsonModel<RedisEnterpriseClusterData>
    {
        void IJsonModel<RedisEnterpriseClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        RedisEnterpriseClusterData IJsonModel<RedisEnterpriseClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RedisEnterpriseClusterData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<RedisEnterpriseClusterData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        RedisEnterpriseClusterData IPersistableModel<RedisEnterpriseClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RedisEnterpriseClusterData>(data, options);
        }

        string IPersistableModel<RedisEnterpriseClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
