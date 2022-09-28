// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class ILRRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static ILRRequest DeserializeILRRequest(JsonElement element)
        {
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareProvisionILRRequest": return AzureFileShareProvisionILRRequest.DeserializeAzureFileShareProvisionILRRequest(element);
                    case "IaasVMILRRegistrationRequest": return IaasVmilrRegistrationRequest.DeserializeIaasVmilrRegistrationRequest(element);
                }
            }
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownILRRequest(objectType);
        }
    }
}
