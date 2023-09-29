// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;

namespace Azure.Storage.Blobs.Models
{
    internal partial class FilterBlobSegment
    {
        internal static FilterBlobSegment DeserializeFilterBlobSegment(XElement element)
        {
            string serviceEndpoint = default;
            string @where = default;
            string nextMarker = default;
            IReadOnlyList<FilterBlobItem> blobs = default;
            if (element.Attribute("ServiceEndpoint") is XAttribute serviceEndpointAttribute)
            {
                serviceEndpoint = (string)serviceEndpointAttribute;
            }
            if (element.Element("Where") is XElement whereElement)
            {
                @where = (string)whereElement;
            }
            if (element.Element("NextMarker") is XElement nextMarkerElement)
            {
                nextMarker = (string)nextMarkerElement;
            }
            if (element.Element("Blobs") is XElement blobsElement)
            {
                var array = new List<FilterBlobItem>();
                foreach (var e in blobsElement.Elements("Blob"))
                {
                    array.Add(FilterBlobItem.DeserializeFilterBlobItem(e));
                }
                blobs = array;
            }
            return new FilterBlobSegment(serviceEndpoint, @where, blobs, nextMarker);
        }
    }
}
