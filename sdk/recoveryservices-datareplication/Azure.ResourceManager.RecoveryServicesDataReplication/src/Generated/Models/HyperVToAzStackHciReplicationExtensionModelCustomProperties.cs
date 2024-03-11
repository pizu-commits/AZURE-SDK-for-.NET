// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> HyperV to AzStackHCI Replication extension model custom properties. </summary>
    public partial class HyperVToAzStackHciReplicationExtensionModelCustomProperties : ReplicationExtensionModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="HyperVToAzStackHciReplicationExtensionModelCustomProperties"/>. </summary>
        /// <param name="hyperVFabricArmId"> Gets or sets the ARM Id of the source HyperV fabric. </param>
        /// <param name="azStackHciFabricArmId"> Gets or sets the ARM Id of the target AzStackHCI fabric. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVFabricArmId"/> or <paramref name="azStackHciFabricArmId"/> is null. </exception>
        public HyperVToAzStackHciReplicationExtensionModelCustomProperties(ResourceIdentifier hyperVFabricArmId, ResourceIdentifier azStackHciFabricArmId)
        {
            Argument.AssertNotNull(hyperVFabricArmId, nameof(hyperVFabricArmId));
            Argument.AssertNotNull(azStackHciFabricArmId, nameof(azStackHciFabricArmId));

            HyperVFabricArmId = hyperVFabricArmId;
            AzStackHciFabricArmId = azStackHciFabricArmId;
            InstanceType = "HyperVToAzStackHCI";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVToAzStackHciReplicationExtensionModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="hyperVFabricArmId"> Gets or sets the ARM Id of the source HyperV fabric. </param>
        /// <param name="hyperVSiteId"> Gets or sets the ARM Id of the HyperV site. </param>
        /// <param name="azStackHciFabricArmId"> Gets or sets the ARM Id of the target AzStackHCI fabric. </param>
        /// <param name="azStackHciSiteId"> Gets or sets the ARM Id of the AzStackHCI site. </param>
        /// <param name="storageAccountId"> Gets or sets the storage account Id. </param>
        /// <param name="storageAccountSasSecretName"> Gets or sets the Sas Secret of storage account. </param>
        /// <param name="asrServiceUri"> Gets or sets the Uri of ASR. </param>
        /// <param name="rcmServiceUri"> Gets or sets the Uri of Rcm. </param>
        /// <param name="gatewayServiceUri"> Gets or sets the Uri of Gateway. </param>
        /// <param name="sourceGatewayServiceId"> Gets or sets the gateway service Id of source. </param>
        /// <param name="targetGatewayServiceId"> Gets or sets the gateway service Id of target. </param>
        /// <param name="sourceStorageContainerName"> Gets or sets the source storage container name. </param>
        /// <param name="targetStorageContainerName"> Gets or sets the target storage container name. </param>
        /// <param name="resourceLocation"> Gets or sets the resource location. </param>
        /// <param name="subscriptionId"> Gets or sets the subscription. </param>
        /// <param name="resourceGroup"> Gets or sets the resource group. </param>
        internal HyperVToAzStackHciReplicationExtensionModelCustomProperties(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier hyperVFabricArmId, ResourceIdentifier hyperVSiteId, ResourceIdentifier azStackHciFabricArmId, ResourceIdentifier azStackHciSiteId, string storageAccountId, string storageAccountSasSecretName, Uri asrServiceUri, Uri rcmServiceUri, Uri gatewayServiceUri, string sourceGatewayServiceId, string targetGatewayServiceId, string sourceStorageContainerName, string targetStorageContainerName, string resourceLocation, string subscriptionId, string resourceGroup) : base(instanceType, serializedAdditionalRawData)
        {
            HyperVFabricArmId = hyperVFabricArmId;
            HyperVSiteId = hyperVSiteId;
            AzStackHciFabricArmId = azStackHciFabricArmId;
            AzStackHciSiteId = azStackHciSiteId;
            StorageAccountId = storageAccountId;
            StorageAccountSasSecretName = storageAccountSasSecretName;
            AsrServiceUri = asrServiceUri;
            RcmServiceUri = rcmServiceUri;
            GatewayServiceUri = gatewayServiceUri;
            SourceGatewayServiceId = sourceGatewayServiceId;
            TargetGatewayServiceId = targetGatewayServiceId;
            SourceStorageContainerName = sourceStorageContainerName;
            TargetStorageContainerName = targetStorageContainerName;
            ResourceLocation = resourceLocation;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            InstanceType = instanceType ?? "HyperVToAzStackHCI";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVToAzStackHciReplicationExtensionModelCustomProperties"/> for deserialization. </summary>
        internal HyperVToAzStackHciReplicationExtensionModelCustomProperties()
        {
        }

        /// <summary> Gets or sets the ARM Id of the source HyperV fabric. </summary>
        public ResourceIdentifier HyperVFabricArmId { get; set; }
        /// <summary> Gets or sets the ARM Id of the HyperV site. </summary>
        public ResourceIdentifier HyperVSiteId { get; }
        /// <summary> Gets or sets the ARM Id of the target AzStackHCI fabric. </summary>
        public ResourceIdentifier AzStackHciFabricArmId { get; set; }
        /// <summary> Gets or sets the ARM Id of the AzStackHCI site. </summary>
        public ResourceIdentifier AzStackHciSiteId { get; }
        /// <summary> Gets or sets the storage account Id. </summary>
        public string StorageAccountId { get; set; }
        /// <summary> Gets or sets the Sas Secret of storage account. </summary>
        public string StorageAccountSasSecretName { get; set; }
        /// <summary> Gets or sets the Uri of ASR. </summary>
        public Uri AsrServiceUri { get; }
        /// <summary> Gets or sets the Uri of Rcm. </summary>
        public Uri RcmServiceUri { get; }
        /// <summary> Gets or sets the Uri of Gateway. </summary>
        public Uri GatewayServiceUri { get; }
        /// <summary> Gets or sets the gateway service Id of source. </summary>
        public string SourceGatewayServiceId { get; }
        /// <summary> Gets or sets the gateway service Id of target. </summary>
        public string TargetGatewayServiceId { get; }
        /// <summary> Gets or sets the source storage container name. </summary>
        public string SourceStorageContainerName { get; }
        /// <summary> Gets or sets the target storage container name. </summary>
        public string TargetStorageContainerName { get; }
        /// <summary> Gets or sets the resource location. </summary>
        public string ResourceLocation { get; }
        /// <summary> Gets or sets the subscription. </summary>
        public string SubscriptionId { get; }
        /// <summary> Gets or sets the resource group. </summary>
        public string ResourceGroup { get; }
    }
}
