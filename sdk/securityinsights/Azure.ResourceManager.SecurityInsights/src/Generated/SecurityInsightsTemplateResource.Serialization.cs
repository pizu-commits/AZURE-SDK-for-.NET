// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsTemplateResource : IJsonModel<SecurityInsightsTemplateData>
    {
        void IJsonModel<SecurityInsightsTemplateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsTemplateData>)Data).Write(writer, options);

        SecurityInsightsTemplateData IJsonModel<SecurityInsightsTemplateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsTemplateData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsTemplateData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityInsightsTemplateData IPersistableModel<SecurityInsightsTemplateData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsTemplateData>(data, options);

        string IPersistableModel<SecurityInsightsTemplateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsTemplateData>)Data).GetFormatFromOptions(options);
    }
}
