// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class SubnetAssociation
    {
        internal static SubnetAssociation DeserializeSubnetAssociation(JsonElement element)
        {
            Optional<string> id = default;
            Optional<IReadOnlyList<SecurityRule>> securityRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityRules"))
                {
                    List<SecurityRule> array = new List<SecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityRule.DeserializeSecurityRule(item));
                    }
                    securityRules = array;
                    continue;
                }
            }
            return new SubnetAssociation(id.Value, Optional.ToList(securityRules));
        }
    }
}
