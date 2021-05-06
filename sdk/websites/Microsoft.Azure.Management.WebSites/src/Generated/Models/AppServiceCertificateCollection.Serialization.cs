// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal partial class AppServiceCertificateCollection
    {
        internal static AppServiceCertificateCollection DeserializeAppServiceCertificateCollection(JsonElement element)
        {
            IReadOnlyList<AppServiceCertificateResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AppServiceCertificateResource> array = new List<AppServiceCertificateResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceCertificateResource.DeserializeAppServiceCertificateResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceCertificateCollection(value, nextLink.Value);
        }
    }
}
