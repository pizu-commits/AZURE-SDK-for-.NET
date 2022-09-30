// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class EventSpecificDetails
    {
        internal static EventSpecificDetails DeserializeEventSpecificDetails(JsonElement element)
        {
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "JobStatus": return JobStatusEventDetails.DeserializeJobStatusEventDetails(element);
                }
            }
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownEventSpecificDetails(instanceType);
        }
    }
}
