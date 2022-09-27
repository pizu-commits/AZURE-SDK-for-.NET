// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RetentionVolume
    {
        internal static RetentionVolume DeserializeRetentionVolume(JsonElement element)
        {
            Optional<string> volumeName = default;
            Optional<long> capacityInBytes = default;
            Optional<long> freeSpaceInBytes = default;
            Optional<int> thresholdPercentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeName"))
                {
                    volumeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("freeSpaceInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    freeSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("thresholdPercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    thresholdPercentage = property.Value.GetInt32();
                    continue;
                }
            }
            return new RetentionVolume(volumeName.Value, Optional.ToNullable(capacityInBytes), Optional.ToNullable(freeSpaceInBytes), Optional.ToNullable(thresholdPercentage));
        }
    }
}
