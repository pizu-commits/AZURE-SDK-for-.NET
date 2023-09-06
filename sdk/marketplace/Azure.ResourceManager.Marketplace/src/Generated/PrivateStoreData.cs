// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing the PrivateStore data model.
    /// The PrivateStore data structure.
    /// </summary>
    public partial class PrivateStoreData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateStoreData"/>. </summary>
        public PrivateStoreData()
        {
            CollectionIds = new ChangeTrackingList<Guid>();
            Branding = new ChangeTrackingDictionary<string, string>();
            Recipients = new ChangeTrackingList<NotificationRecipient>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateStoreData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="availability"> Indicates private store availability. </param>
        /// <param name="privateStoreId"> Private Store id. </param>
        /// <param name="eTag"> Identifier for purposes of race condition. </param>
        /// <param name="privateStoreName"> Private Store Name. </param>
        /// <param name="tenantId"> Tenant id. </param>
        /// <param name="isGov"> Is government. </param>
        /// <param name="collectionIds"> Gets list of associated collection ids. </param>
        /// <param name="branding"> Gets or sets list of branding characteristics. </param>
        /// <param name="recipients"> Gets or sets list of notified recipients for new requests. </param>
        /// <param name="sendToAllMarketplaceAdmins"> Gets or sets whether to send email to all marketplace admins for new requests. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateStoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PrivateStoreAvailability? availability, Guid? privateStoreId, ETag? eTag, string privateStoreName, Guid? tenantId, bool? isGov, IReadOnlyList<Guid> collectionIds, IDictionary<string, string> branding, IList<NotificationRecipient> recipients, bool? sendToAllMarketplaceAdmins, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Availability = availability;
            PrivateStoreId = privateStoreId;
            ETag = eTag;
            PrivateStoreName = privateStoreName;
            TenantId = tenantId;
            IsGov = isGov;
            CollectionIds = collectionIds;
            Branding = branding;
            Recipients = recipients;
            SendToAllMarketplaceAdmins = sendToAllMarketplaceAdmins;
            _rawData = rawData;
        }

        /// <summary> Indicates private store availability. </summary>
        public PrivateStoreAvailability? Availability { get; set; }
        /// <summary> Private Store id. </summary>
        public Guid? PrivateStoreId { get; }
        /// <summary> Identifier for purposes of race condition. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Private Store Name. </summary>
        public string PrivateStoreName { get; set; }
        /// <summary> Tenant id. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Is government. </summary>
        public bool? IsGov { get; set; }
        /// <summary> Gets list of associated collection ids. </summary>
        public IReadOnlyList<Guid> CollectionIds { get; }
        /// <summary> Gets or sets list of branding characteristics. </summary>
        public IDictionary<string, string> Branding { get; }
        /// <summary> Gets or sets list of notified recipients for new requests. </summary>
        public IList<NotificationRecipient> Recipients { get; }
        /// <summary> Gets or sets whether to send email to all marketplace admins for new requests. </summary>
        public bool? SendToAllMarketplaceAdmins { get; set; }
    }
}
