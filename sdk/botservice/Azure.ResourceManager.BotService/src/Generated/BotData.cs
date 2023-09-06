// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.BotService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BotService
{
    /// <summary>
    /// A class representing the Bot data model.
    /// Bot resource definition
    /// </summary>
    public partial class BotData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BotData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BotData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BotData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The set of properties specific to bot resource. </param>
        /// <param name="sku"> Gets or sets the SKU of the resource. </param>
        /// <param name="kind"> Required. Gets or sets the Kind of the resource. </param>
        /// <param name="etag"> Entity Tag. </param>
        /// <param name="zones"> Entity zones. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BotProperties properties, BotServiceSku sku, BotServiceKind? kind, ETag? etag, IReadOnlyList<string> zones, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Sku = sku;
            Kind = kind;
            ETag = etag;
            Zones = zones;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BotData"/> for deserialization. </summary>
        internal BotData()
        {
        }

        /// <summary> The set of properties specific to bot resource. </summary>
        public BotProperties Properties { get; set; }
        /// <summary> Gets or sets the SKU of the resource. </summary>
        public BotServiceSku Sku { get; set; }
        /// <summary> Required. Gets or sets the Kind of the resource. </summary>
        public BotServiceKind? Kind { get; set; }
        /// <summary> Entity Tag. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Entity zones. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
