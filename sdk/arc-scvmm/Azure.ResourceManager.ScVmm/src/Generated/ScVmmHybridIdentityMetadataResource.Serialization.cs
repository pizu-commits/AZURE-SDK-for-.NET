// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ScVmm
{
    public partial class ScVmmHybridIdentityMetadataResource : IJsonModel<ScVmmHybridIdentityMetadataData>
    {
        void IJsonModel<ScVmmHybridIdentityMetadataData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ScVmmHybridIdentityMetadataData>)Data).Write(writer, options);

        ScVmmHybridIdentityMetadataData IJsonModel<ScVmmHybridIdentityMetadataData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ScVmmHybridIdentityMetadataData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ScVmmHybridIdentityMetadataData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ScVmmHybridIdentityMetadataData IPersistableModel<ScVmmHybridIdentityMetadataData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ScVmmHybridIdentityMetadataData>(data, options);

        string IPersistableModel<ScVmmHybridIdentityMetadataData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ScVmmHybridIdentityMetadataData>)Data).GetFormatFromOptions(options);
    }
}
