// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueItem
    {
        internal static QueueItem DeserializeQueueItem(XElement element)
        {
            string name = default;
            IReadOnlyDictionary<string, string> metadata = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("Metadata") is XElement metadataElement)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var e in metadataElement.Elements())
                {
                    dictionary.Add(e.Name.LocalName, (string)e);
                }
                metadata = dictionary;
            }
            return new QueueItem(name, metadata);
        }
    }
}
