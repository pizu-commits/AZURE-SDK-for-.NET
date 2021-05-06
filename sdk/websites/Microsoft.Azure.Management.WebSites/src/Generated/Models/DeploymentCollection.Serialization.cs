// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal partial class DeploymentCollection
    {
        internal static DeploymentCollection DeserializeDeploymentCollection(JsonElement element)
        {
            IReadOnlyList<Deployment> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<Deployment> array = new List<Deployment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Deployment.DeserializeDeployment(item));
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
            return new DeploymentCollection(value, nextLink.Value);
        }
    }
}
