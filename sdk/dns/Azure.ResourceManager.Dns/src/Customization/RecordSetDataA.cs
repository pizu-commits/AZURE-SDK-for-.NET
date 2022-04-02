// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    /// <summary> A class representing the RecordSet data model. </summary>
    public partial class RecordSetDataA : ResourceData
    {
        /// <summary> Initializes a new instance of RecordSetData. </summary>
        public RecordSetDataA()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
            ARecords = new ChangeTrackingList<ARecord>();
        }

        /// <summary> Initializes a new instance of RecordSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> The etag of the record set. </param>
        /// <param name="metadata"> The metadata attached to the record set. </param>
        /// <param name="ttl"> The TTL (time-to-live) of the records in the record set. </param>
        /// <param name="fqdn"> Fully qualified domain name of the record set. </param>
        /// <param name="provisioningState"> provisioning State of the record set. </param>
        /// <param name="targetResource"> A reference to an azure resource from where the dns resource value is taken. </param>
        /// <param name="aRecords"> The list of A records in the record set. </param>
        internal RecordSetDataA(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string etag, IDictionary<string, string> metadata, long? ttl, string fqdn, string provisioningState, WritableSubResource targetResource, IList<ARecord> aRecords) : base(id, name, resourceType, systemData)
        {
            Etag = etag;
            Metadata = metadata;
            TTL = ttl;
            Fqdn = fqdn;
            ProvisioningState = provisioningState;
            TargetResource = targetResource;
            ARecords = aRecords;
        }

        /// <summary> The etag of the record set. </summary>
        public string Etag { get; set; }
        /// <summary> The metadata attached to the record set. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The TTL (time-to-live) of the records in the record set. </summary>
        public long? TTL { get; set; }
        /// <summary> Fully qualified domain name of the record set. </summary>
        public string Fqdn { get; }
        /// <summary> provisioning State of the record set. </summary>
        public string ProvisioningState { get; }
        /// <summary> A reference to an azure resource from where the dns resource value is taken. </summary>
        internal WritableSubResource TargetResource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier TargetResourceId
        {
            get => TargetResource is null ? default : TargetResource.Id;
            set
            {
                if (TargetResource is null)
                    TargetResource = new WritableSubResource();
                TargetResource.Id = value;
            }
        }

        /// <summary> The list of A records in the record set. </summary>
        public IList<ARecord> ARecords { get; }
    }
}
