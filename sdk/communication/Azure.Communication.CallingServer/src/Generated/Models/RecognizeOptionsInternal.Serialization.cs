// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class RecognizeOptionsInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PausePlayOnResponse))
            {
                writer.WritePropertyName("pausePlayOnResponse");
                writer.WriteBooleanValue(PausePlayOnResponse.Value);
            }
            if (Optional.IsDefined(InitialSilenceTimeoutInSeconds))
            {
                writer.WritePropertyName("initialSilenceTimeoutInSeconds");
                writer.WriteNumberValue(InitialSilenceTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(DtmfOptions))
            {
                writer.WritePropertyName("dtmfOptions");
                writer.WriteObjectValue(DtmfOptions);
            }
            writer.WriteEndObject();
        }
    }
}
