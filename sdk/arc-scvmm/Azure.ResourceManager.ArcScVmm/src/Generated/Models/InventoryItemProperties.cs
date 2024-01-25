// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary>
    /// Defines the resource properties.
    /// Please note <see cref="InventoryItemProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CloudInventoryItem"/>, <see cref="VirtualMachineInventoryItem"/>, <see cref="VirtualMachineTemplateInventoryItem"/> and <see cref="VirtualNetworkInventoryItem"/>.
    /// </summary>
    public abstract partial class InventoryItemProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InventoryItemProperties"/>. </summary>
        protected InventoryItemProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InventoryItemProperties"/>. </summary>
        /// <param name="inventoryType"> They inventory type. </param>
        /// <param name="managedResourceId"> Gets the tracked resource id corresponding to the inventory resource. </param>
        /// <param name="uuid"> Gets the UUID (which is assigned by VMM) for the inventory item. </param>
        /// <param name="inventoryItemName"> Gets the Managed Object name in VMM for the inventory item. </param>
        /// <param name="provisioningState"> Gets the provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InventoryItemProperties(InventoryType inventoryType, string managedResourceId, string uuid, string inventoryItemName, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InventoryType = inventoryType;
            ManagedResourceId = managedResourceId;
            Uuid = uuid;
            InventoryItemName = inventoryItemName;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> They inventory type. </summary>
        internal InventoryType InventoryType { get; set; }
        /// <summary> Gets the tracked resource id corresponding to the inventory resource. </summary>
        public string ManagedResourceId { get; }
        /// <summary> Gets the UUID (which is assigned by VMM) for the inventory item. </summary>
        public string Uuid { get; }
        /// <summary> Gets the Managed Object name in VMM for the inventory item. </summary>
        public string InventoryItemName { get; }
        /// <summary> Gets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
