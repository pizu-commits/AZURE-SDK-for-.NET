// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteSourceControlResource : IJsonModel<SiteSourceControlData>
    {
        void IJsonModel<SiteSourceControlData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SiteSourceControlData>)Data).Write(writer, options);

        SiteSourceControlData IJsonModel<SiteSourceControlData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SiteSourceControlData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SiteSourceControlData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SiteSourceControlData IPersistableModel<SiteSourceControlData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SiteSourceControlData>(data, options);

        string IPersistableModel<SiteSourceControlData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SiteSourceControlData>)Data).GetFormatFromOptions(options);
    }
}
