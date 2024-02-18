// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Reservations
{
    public partial class ReservationQuotaResource : IJsonModel<ReservationQuotaData>
    {
        void IJsonModel<ReservationQuotaData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ReservationQuotaData IJsonModel<ReservationQuotaData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ReservationQuotaData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ReservationQuotaData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ReservationQuotaData IPersistableModel<ReservationQuotaData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ReservationQuotaData>(data, options);
        }

        string IPersistableModel<ReservationQuotaData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
