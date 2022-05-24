// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class JobOffer
    {
        internal static JobOffer DeserializeJobOffer(JsonElement element)
        {
            string id = default;
            string jobId = default;
            int capacityCost = default;
            Optional<DateTimeOffset> offerTimeUtc = default;
            Optional<DateTimeOffset> expiryTimeUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityCost"))
                {
                    capacityCost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("offerTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offerTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiryTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new JobOffer(id, jobId, capacityCost, Optional.ToNullable(offerTimeUtc), Optional.ToNullable(expiryTimeUtc));
        }
    }
}
