// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class Contact : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressMailing))
            {
                writer.WritePropertyName("addressMailing");
                writer.WriteObjectValue(AddressMailing);
            }
            writer.WritePropertyName("email");
            writer.WriteStringValue(Email);
            if (Optional.IsDefined(Fax))
            {
                writer.WritePropertyName("fax");
                writer.WriteStringValue(Fax);
            }
            if (Optional.IsDefined(JobTitle))
            {
                writer.WritePropertyName("jobTitle");
                writer.WriteStringValue(JobTitle);
            }
            writer.WritePropertyName("nameFirst");
            writer.WriteStringValue(NameFirst);
            writer.WritePropertyName("nameLast");
            writer.WriteStringValue(NameLast);
            if (Optional.IsDefined(NameMiddle))
            {
                writer.WritePropertyName("nameMiddle");
                writer.WriteStringValue(NameMiddle);
            }
            if (Optional.IsDefined(Organization))
            {
                writer.WritePropertyName("organization");
                writer.WriteStringValue(Organization);
            }
            writer.WritePropertyName("phone");
            writer.WriteStringValue(Phone);
            writer.WriteEndObject();
        }

        internal static Contact DeserializeContact(JsonElement element)
        {
            Optional<Address> addressMailing = default;
            string email = default;
            Optional<string> fax = default;
            Optional<string> jobTitle = default;
            string nameFirst = default;
            string nameLast = default;
            Optional<string> nameMiddle = default;
            Optional<string> organization = default;
            string phone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressMailing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    addressMailing = Address.DeserializeAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fax"))
                {
                    fax = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobTitle"))
                {
                    jobTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameFirst"))
                {
                    nameFirst = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameLast"))
                {
                    nameLast = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameMiddle"))
                {
                    nameMiddle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organization"))
                {
                    organization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"))
                {
                    phone = property.Value.GetString();
                    continue;
                }
            }
            return new Contact(addressMailing.Value, email, fax.Value, jobTitle.Value, nameFirst, nameLast, nameMiddle.Value, organization.Value, phone);
        }
    }
}
