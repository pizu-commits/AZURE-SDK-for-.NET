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

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class FileProperty : IXmlSerializable, IPersistableModel<FileProperty>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "FileProperty");
            writer.WriteStartElement("Content-Length");
            writer.WriteValue(ContentLength);
            writer.WriteEndElement();
            if (Optional.IsDefined(CreationTime))
            {
                writer.WriteStartElement("CreationTime");
                writer.WriteValue(CreationTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LastAccessTime))
            {
                writer.WriteStartElement("LastAccessTime");
                writer.WriteValue(LastAccessTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LastWriteTime))
            {
                writer.WriteStartElement("LastWriteTime");
                writer.WriteValue(LastWriteTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ChangeTime))
            {
                writer.WriteStartElement("ChangeTime");
                writer.WriteValue(ChangeTime.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LastModified))
            {
                writer.WriteStartElement("Last-Modified");
                writer.WriteValue(LastModified.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WriteStartElement("Etag");
                writer.WriteValue(Etag);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static FileProperty DeserializeFileProperty(XElement element, ModelReaderWriterOptions options = null)
        {
            long contentLength = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? lastAccessTime = default;
            DateTimeOffset? lastWriteTime = default;
            DateTimeOffset? changeTime = default;
            DateTimeOffset? lastModified = default;
            string etag = default;
            if (element.Element("Content-Length") is XElement contentLengthElement)
            {
                contentLength = (long)contentLengthElement;
            }
            if (element.Element("CreationTime") is XElement creationTimeElement)
            {
                creationTime = creationTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("LastAccessTime") is XElement lastAccessTimeElement)
            {
                lastAccessTime = lastAccessTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("LastWriteTime") is XElement lastWriteTimeElement)
            {
                lastWriteTime = lastWriteTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("ChangeTime") is XElement changeTimeElement)
            {
                changeTime = changeTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Last-Modified") is XElement lastModifiedElement)
            {
                lastModified = lastModifiedElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Etag") is XElement etagElement)
            {
                etag = (string)etagElement;
            }
            return new FileProperty(contentLength, creationTime, lastAccessTime, lastWriteTime, changeTime, lastModified, etag, default);
        }

        BinaryData IPersistableModel<FileProperty>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<FileProperty>;
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

        FileProperty IPersistableModel<FileProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FileProperty)} does not support '{options.Format}' format.");
            }

            return DeserializeFileProperty(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<FileProperty>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
