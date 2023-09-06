// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes an available API Management service SKU. </summary>
    public partial class AvailableApiManagementServiceSkuResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailableApiManagementServiceSkuResult"/>. </summary>
        internal AvailableApiManagementServiceSkuResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailableApiManagementServiceSkuResult"/>. </summary>
        /// <param name="resourceType"> The type of resource the SKU applies to. </param>
        /// <param name="sku"> Specifies API Management SKU. </param>
        /// <param name="capacity"> Specifies the number of API Management units. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableApiManagementServiceSkuResult(ResourceType? resourceType, ResourceSku sku, ApiManagementResourceSkuCapacity capacity, Dictionary<string, BinaryData> rawData)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
            _rawData = rawData;
        }

        /// <summary> The type of resource the SKU applies to. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Specifies API Management SKU. </summary>
        internal ResourceSku Sku { get; }
        /// <summary> Name of the Sku. </summary>
        public ApiManagementServiceSkuType? SkuName
        {
            get => Sku?.Name;
        }

        /// <summary> Specifies the number of API Management units. </summary>
        public ApiManagementResourceSkuCapacity Capacity { get; }
    }
}
