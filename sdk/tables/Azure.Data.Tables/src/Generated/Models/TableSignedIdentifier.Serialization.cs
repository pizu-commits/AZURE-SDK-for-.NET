// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    public partial class TableSignedIdentifier : IXmlSerializable, IPersistableModel<TableSignedIdentifier>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "SignedIdentifier");
            writer.WriteStartElement("Id");
            writer.WriteValue(Id);
            writer.WriteEndElement();
            if (AccessPolicy != null)
            {
                writer.WriteObjectValue(AccessPolicy, "AccessPolicy");
            }
            writer.WriteEndElement();
        }

        internal static TableSignedIdentifier DeserializeTableSignedIdentifier(XElement element, ModelReaderWriterOptions options = null)
        {
            string id = default;
            TableAccessPolicy accessPolicy = default;
            if (element.Element("Id") is XElement idElement)
            {
                id = (string)idElement;
            }
            if (element.Element("AccessPolicy") is XElement accessPolicyElement)
            {
                accessPolicy = TableAccessPolicy.DeserializeTableAccessPolicy(accessPolicyElement);
            }
            return new TableSignedIdentifier(id, accessPolicy, default);
        }

        BinaryData IPersistableModel<TableSignedIdentifier>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<TableSignedIdentifier>;
            bool isValid = options.Format == "J" && implementsJson || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            ((IXmlSerializable)this).Write(writer, null);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        TableSignedIdentifier IPersistableModel<TableSignedIdentifier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TableSignedIdentifier)} does not support '{options.Format}' format.");
            }

            return DeserializeTableSignedIdentifier(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<TableSignedIdentifier>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
