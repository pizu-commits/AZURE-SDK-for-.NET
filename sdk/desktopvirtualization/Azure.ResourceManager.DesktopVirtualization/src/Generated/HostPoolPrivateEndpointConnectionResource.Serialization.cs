// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class HostPoolPrivateEndpointConnectionResource : IJsonModel<DesktopVirtualizationPrivateEndpointConnectionDataData>
    {
        void IJsonModel<DesktopVirtualizationPrivateEndpointConnectionDataData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DesktopVirtualizationPrivateEndpointConnectionDataData IJsonModel<DesktopVirtualizationPrivateEndpointConnectionDataData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DesktopVirtualizationPrivateEndpointConnectionDataData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DesktopVirtualizationPrivateEndpointConnectionDataData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DesktopVirtualizationPrivateEndpointConnectionDataData IPersistableModel<DesktopVirtualizationPrivateEndpointConnectionDataData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DesktopVirtualizationPrivateEndpointConnectionDataData>(data, options);
        }

        string IPersistableModel<DesktopVirtualizationPrivateEndpointConnectionDataData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
