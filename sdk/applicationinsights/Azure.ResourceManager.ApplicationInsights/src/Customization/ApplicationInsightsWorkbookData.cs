// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing the ApplicationInsightsWorkbook data model.
    /// A workbook definition.
    /// </summary>
    [CodeGenSerialization(nameof(ResourceType), DeserializationValueHook = nameof(DeserializeTypeValue))]
    public partial class ApplicationInsightsWorkbookData : TrackedResourceData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void DeserializeTypeValue(JsonProperty property, ref ResourceType type)
        {
            try
            {
                type = new ResourceType(property.Value.GetString());
            }
            catch (Exception)
            {
                // type always is null, https://github.com/Azure/azure-sdk-for-net/issues/38780, so we need to handle the exception
                type = default;
            }
        }
    }
}
