// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ManagedRulesDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions");
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("managedRuleSets");
            writer.WriteStartArray();
            foreach (var item in ManagedRuleSets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ManagedRulesDefinition DeserializeManagedRulesDefinition(JsonElement element)
        {
            Optional<IList<OwaspCrsExclusionEntry>> exclusions = default;
            IList<ManagedRuleSet> managedRuleSets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exclusions"))
                {
                    List<OwaspCrsExclusionEntry> array = new List<OwaspCrsExclusionEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OwaspCrsExclusionEntry.DeserializeOwaspCrsExclusionEntry(item));
                    }
                    exclusions = array;
                    continue;
                }
                if (property.NameEquals("managedRuleSets"))
                {
                    List<ManagedRuleSet> array = new List<ManagedRuleSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleSet.DeserializeManagedRuleSet(item));
                    }
                    managedRuleSets = array;
                    continue;
                }
            }
            return new ManagedRulesDefinition(Optional.ToList(exclusions), managedRuleSets);
        }
    }
}
