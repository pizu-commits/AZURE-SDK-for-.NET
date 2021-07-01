// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class CopyRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId");
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("targetResourceRegion");
            writer.WriteStringValue(TargetResourceRegion);
            writer.WritePropertyName("copyAuthorization");
            writer.WriteObjectValue(CopyAuthorization);
            writer.WriteEndObject();
        }
    }
}
