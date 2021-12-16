// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the VirtualMachineExtensionImage data model. </summary>
    public partial class VirtualMachineExtensionImageData : TrackedResource
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionImageData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineExtensionImageData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="operatingSystem"> The operating system this extension supports. </param>
        /// <param name="computeRole"> The type of role (IaaS or PaaS) this extension supports. </param>
        /// <param name="handlerSchema"> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </param>
        /// <param name="vmScaleSetEnabled"> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </param>
        /// <param name="supportsMultipleExtensions"> Whether the handler can support multiple extensions. </param>
        internal VirtualMachineExtensionImageData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, string operatingSystem, string computeRole, string handlerSchema, bool? vmScaleSetEnabled, bool? supportsMultipleExtensions) : base(id, name, type, tags, location)
        {
            OperatingSystem = operatingSystem;
            ComputeRole = computeRole;
            HandlerSchema = handlerSchema;
            VmScaleSetEnabled = vmScaleSetEnabled;
            SupportsMultipleExtensions = supportsMultipleExtensions;
        }

        /// <summary> The operating system this extension supports. </summary>
        public string OperatingSystem { get; set; }
        /// <summary> The type of role (IaaS or PaaS) this extension supports. </summary>
        public string ComputeRole { get; set; }
        /// <summary> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </summary>
        public string HandlerSchema { get; set; }
        /// <summary> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </summary>
        public bool? VmScaleSetEnabled { get; set; }
        /// <summary> Whether the handler can support multiple extensions. </summary>
        public bool? SupportsMultipleExtensions { get; set; }
    }
}
