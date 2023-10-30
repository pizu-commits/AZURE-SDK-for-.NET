// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    public partial class TableAccessPolicy : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "AccessPolicy");
            writer.WriteStartElement("Start");
            writer.WriteValue(StartsOn.Value, "O");
            writer.WriteEndElement();
            writer.WriteStartElement("Expiry");
            writer.WriteValue(ExpiresOn.Value, "O");
            writer.WriteEndElement();
            if (Permission != null)
            {
                writer.WriteStartElement("Permission");
                writer.WriteValue(Permission);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static TableAccessPolicy DeserializeTableAccessPolicy(XElement element)
        {
            DateTimeOffset? startsOn = default;
            DateTimeOffset? expiresOn = default;
            string permission = default;
            if (element.Element("Start") is XElement startElement)
            {
                startsOn = startElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Expiry") is XElement expiryElement)
            {
                expiresOn = expiryElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Permission") is XElement permissionElement)
            {
                permission = (string)permissionElement;
            }
            return new TableAccessPolicy(startsOn, expiresOn, permission);
        }
    }
}
