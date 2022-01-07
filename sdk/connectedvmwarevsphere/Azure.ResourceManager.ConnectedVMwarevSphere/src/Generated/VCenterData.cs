// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing the VCenter data model. </summary>
    public partial class VCenterData : TrackedResource
    {
        /// <summary> Initializes a new instance of VCenterData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="fqdn"> Gets or sets the FQDN/IPAddress of the vCenter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fqdn"/> is null. </exception>
        public VCenterData(Location location, string fqdn) : base(location)
        {
            if (fqdn == null)
            {
                throw new ArgumentNullException(nameof(fqdn));
            }

            Fqdn = fqdn;
            Statuses = new ChangeTrackingList<ResourceStatus>();
        }

        /// <summary> Initializes a new instance of VCenterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="systemData"> The system data. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="fqdn"> Gets or sets the FQDN/IPAddress of the vCenter. </param>
        /// <param name="port"> Gets or sets the port of the vCenter. </param>
        /// <param name="version"> Gets or sets the version of the vCenter. </param>
        /// <param name="instanceUuid"> Gets or sets the instance UUID of the vCenter. </param>
        /// <param name="connectionStatus"> Gets or sets the connection status to the vCenter. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="credentials"> Username / Password Credentials to connect to vcenter. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal VCenterData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, ExtendedLocation extendedLocation, SystemData systemData, string kind, string uuid, string fqdn, int? port, string version, string instanceUuid, string connectionStatus, string customResourceName, VICredential credentials, IReadOnlyList<ResourceStatus> statuses, string provisioningState) : base(id, name, type, tags, location)
        {
            ExtendedLocation = extendedLocation;
            SystemData = systemData;
            Kind = kind;
            Uuid = uuid;
            Fqdn = fqdn;
            Port = port;
            Version = version;
            InstanceUuid = instanceUuid;
            ConnectionStatus = connectionStatus;
            CustomResourceName = customResourceName;
            Credentials = credentials;
            Statuses = statuses;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The system data. </summary>
        public SystemData SystemData { get; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the FQDN/IPAddress of the vCenter. </summary>
        public string Fqdn { get; set; }
        /// <summary> Gets or sets the port of the vCenter. </summary>
        public int? Port { get; set; }
        /// <summary> Gets or sets the version of the vCenter. </summary>
        public string Version { get; }
        /// <summary> Gets or sets the instance UUID of the vCenter. </summary>
        public string InstanceUuid { get; }
        /// <summary> Gets or sets the connection status to the vCenter. </summary>
        public string ConnectionStatus { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Username / Password Credentials to connect to vcenter. </summary>
        public VICredential Credentials { get; set; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
