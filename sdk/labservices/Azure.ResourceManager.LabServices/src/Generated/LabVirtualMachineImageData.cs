// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A class representing the LabVirtualMachineImage data model.
    /// Lab services virtual machine image
    /// </summary>
    public partial class LabVirtualMachineImageData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImageData"/>. </summary>
        public LabVirtualMachineImageData()
        {
            AvailableRegions = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="enabledState"> Is the image enabled. </param>
        /// <param name="provisioningState"> Current provisioning state of the image. </param>
        /// <param name="displayName"> The image display name. </param>
        /// <param name="description"> A description of the image. </param>
        /// <param name="iconUri"> URL of the image icon. </param>
        /// <param name="author"> The image author. </param>
        /// <param name="osType"> The OS Type of the image. </param>
        /// <param name="plan"> The ID of marketplace plan associated with the image (optional). </param>
        /// <param name="termsStatus"> The status of image terms of use (enabled = accepted, disabled = not accepted). </param>
        /// <param name="offer"> The ID of an offer associated with the image. </param>
        /// <param name="publisher"> The ID of the publisher of the image. </param>
        /// <param name="sku"> The image SKU. </param>
        /// <param name="version"> The image version. </param>
        /// <param name="sharedGalleryId"> The ID for the image in the shared gallery. </param>
        /// <param name="availableRegions"> The available regions of the image in the shared gallery. </param>
        /// <param name="osState"> The OS State of the image. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LabVirtualMachineImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, LabServicesEnableState? enabledState, LabServicesProvisioningState? provisioningState, string displayName, string description, Uri iconUri, string author, LabVirtualMachineImageOSType? osType, string plan, LabServicesEnableState? termsStatus, string offer, string publisher, string sku, string version, ResourceIdentifier sharedGalleryId, IList<AzureLocation> availableRegions, LabVirtualMachineImageOSState? osState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DisplayName = displayName;
            Description = description;
            IconUri = iconUri;
            Author = author;
            OSType = osType;
            Plan = plan;
            TermsStatus = termsStatus;
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Version = version;
            SharedGalleryId = sharedGalleryId;
            AvailableRegions = availableRegions;
            OSState = osState;
            _rawData = rawData;
        }

        /// <summary> Is the image enabled. </summary>
        public LabServicesEnableState? EnabledState { get; set; }
        /// <summary> Current provisioning state of the image. </summary>
        public LabServicesProvisioningState? ProvisioningState { get; }
        /// <summary> The image display name. </summary>
        public string DisplayName { get; }
        /// <summary> A description of the image. </summary>
        public string Description { get; }
        /// <summary> URL of the image icon. </summary>
        public Uri IconUri { get; }
        /// <summary> The image author. </summary>
        public string Author { get; }
        /// <summary> The OS Type of the image. </summary>
        public LabVirtualMachineImageOSType? OSType { get; }
        /// <summary> The ID of marketplace plan associated with the image (optional). </summary>
        public string Plan { get; }
        /// <summary> The status of image terms of use (enabled = accepted, disabled = not accepted). </summary>
        public LabServicesEnableState? TermsStatus { get; }
        /// <summary> The ID of an offer associated with the image. </summary>
        public string Offer { get; }
        /// <summary> The ID of the publisher of the image. </summary>
        public string Publisher { get; }
        /// <summary> The image SKU. </summary>
        public string Sku { get; }
        /// <summary> The image version. </summary>
        public string Version { get; }
        /// <summary> The ID for the image in the shared gallery. </summary>
        public ResourceIdentifier SharedGalleryId { get; }
        /// <summary> The available regions of the image in the shared gallery. </summary>
        public IList<AzureLocation> AvailableRegions { get; }
        /// <summary> The OS State of the image. </summary>
        public LabVirtualMachineImageOSState? OSState { get; }
    }
}
