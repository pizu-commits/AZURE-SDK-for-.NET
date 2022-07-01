// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class EmailReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("emailAddress");
            writer.WriteStringValue(EmailAddress);
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema");
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            writer.WriteEndObject();
        }

        internal static EmailReceiver DeserializeEmailReceiver(JsonElement element)
        {
            string name = default;
            string emailAddress = default;
            Optional<bool> useCommonAlertSchema = default;
            Optional<ReceiverStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailAddress"))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToReceiverStatus();
                    continue;
                }
            }
            return new EmailReceiver(name, emailAddress, Optional.ToNullable(useCommonAlertSchema), Optional.ToNullable(status));
        }
    }
}
