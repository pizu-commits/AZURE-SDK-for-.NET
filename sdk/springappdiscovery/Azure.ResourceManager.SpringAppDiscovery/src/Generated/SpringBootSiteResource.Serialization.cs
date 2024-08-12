// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SpringAppDiscovery
{
    public partial class SpringBootSiteResource : IJsonModel<SpringBootSiteData>
    {
        void IJsonModel<SpringBootSiteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SpringBootSiteData>)Data).Write(writer, options);

        SpringBootSiteData IJsonModel<SpringBootSiteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SpringBootSiteData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SpringBootSiteData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SpringBootSiteData IPersistableModel<SpringBootSiteData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SpringBootSiteData>(data, options);

        string IPersistableModel<SpringBootSiteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SpringBootSiteData>)Data).GetFormatFromOptions(options);
    }
}
