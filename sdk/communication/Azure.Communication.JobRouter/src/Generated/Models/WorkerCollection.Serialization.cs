// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    internal partial class WorkerCollection
    {
        internal static WorkerCollection DeserializeWorkerCollection(JsonElement element)
        {
            IReadOnlyList<RouterWorker> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<RouterWorker> array = new List<RouterWorker>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorker.DeserializeRouterWorker(item));
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
            return new WorkerCollection(value, nextLink.Value);
        }
    }
}
