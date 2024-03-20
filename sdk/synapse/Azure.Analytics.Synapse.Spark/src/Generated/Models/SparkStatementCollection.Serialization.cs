// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkStatementCollection
    {
        internal static SparkStatementCollection DeserializeSparkStatementCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int totalStatements = default;
            IReadOnlyList<SparkStatement> statements = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("total_statements"u8))
                {
                    totalStatements = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkStatement> array = new List<SparkStatement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkStatement.DeserializeSparkStatement(item));
                    }
                    statements = array;
                    continue;
                }
            }
            return new SparkStatementCollection(totalStatements, statements ?? new ChangeTrackingList<SparkStatement>());
        }
    }
}
