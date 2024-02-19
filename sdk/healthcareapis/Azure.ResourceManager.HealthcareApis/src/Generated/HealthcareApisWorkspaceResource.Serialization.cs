// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HealthcareApis
{
    public partial class HealthcareApisWorkspaceResource : IJsonModel<HealthcareApisWorkspaceData>
    {
        void IJsonModel<HealthcareApisWorkspaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        HealthcareApisWorkspaceData IJsonModel<HealthcareApisWorkspaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<HealthcareApisWorkspaceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<HealthcareApisWorkspaceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        HealthcareApisWorkspaceData IPersistableModel<HealthcareApisWorkspaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<HealthcareApisWorkspaceData>(data, options);
        }

        string IPersistableModel<HealthcareApisWorkspaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
