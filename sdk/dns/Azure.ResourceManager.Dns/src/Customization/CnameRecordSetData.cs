// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    /// <summary> A class representing the CnameRecordSet data model. </summary>
    public partial class CnameRecordSetData : ResourceData
    {
        /// <summary> Initializes a new instance of CnameRecordSetData. </summary>
        public CnameRecordSetData()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of CnameRecordSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> The etag of the record set. </param>
        /// <param name="metadata"> The metadata attached to the record set. </param>
        /// <param name="ttl"> The Ttl (time-to-live) of the records in the record set. </param>
        /// <param name="fqdn"> Fully qualified domain name of the record set. </param>
        /// <param name="provisioningState"> provisioning State of the record set. </param>
        /// <param name="targetResource"> A reference to an azure resource from where the dns resource value is taken. </param>
        /// <param name="cnameRecord"> The CNAME record in the  record set. </param>
        internal CnameRecordSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, IDictionary<string, string> metadata, long? ttl, string fqdn, string provisioningState, WritableSubResource targetResource, DnsCnameRecord cnameRecord) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Metadata = metadata;
            TtlInSeconds = ttl;
            Fqdn = fqdn;
            ProvisioningState = provisioningState;
            TargetResource = targetResource;
            CnameRecord = cnameRecord;
        }

        /// <summary> The etag of the record set. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The metadata attached to the record set. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The Ttl (time-to-live) of the records in the record set. </summary>
        public long? TtlInSeconds { get; set; }
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

        /// <summary> The CNAME record in the  record set. </summary>
        internal DnsCnameRecord CnameRecord { get; set; }
        /// <summary> The canonical name for this CNAME record. </summary>
        public string Cname
        {
            get => CnameRecord is null ? default : CnameRecord.Cname;
            set
            {
                if (CnameRecord is null)
                    CnameRecord = new DnsCnameRecord();
                CnameRecord.Cname = value;
            }
        }
    }
}
