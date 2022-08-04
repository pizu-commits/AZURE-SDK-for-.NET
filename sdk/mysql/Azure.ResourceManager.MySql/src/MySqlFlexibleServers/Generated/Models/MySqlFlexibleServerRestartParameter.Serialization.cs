// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerRestartParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RestartWithFailover))
            {
                writer.WritePropertyName("restartWithFailover");
                writer.WriteStringValue(RestartWithFailover.Value.ToString());
            }
            if (Optional.IsDefined(MaxFailoverSeconds))
            {
                writer.WritePropertyName("maxFailoverSeconds");
                writer.WriteNumberValue(MaxFailoverSeconds.Value);
            }
            writer.WriteEndObject();
        }
    }
}
