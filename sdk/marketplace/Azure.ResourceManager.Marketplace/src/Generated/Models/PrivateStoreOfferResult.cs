// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The PrivateStoreOfferResult. </summary>
    public partial class PrivateStoreOfferResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateStoreOfferResult"/>. </summary>
        internal PrivateStoreOfferResult()
        {
            SpecificPlanIdsLimitation = new ChangeTrackingList<string>();
            IconFileUris = new ChangeTrackingDictionary<string, Uri>();
            Plans = new ChangeTrackingList<PrivateStorePlan>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateStoreOfferResult"/>. </summary>
        /// <param name="uniqueOfferId"> Offers unique id. </param>
        /// <param name="offerDisplayName"> It will be displayed prominently in the marketplace. </param>
        /// <param name="publisherDisplayName"> Publisher name that will be displayed prominently in the marketplace. </param>
        /// <param name="eTag"> Identifier for purposes of race condition. </param>
        /// <param name="privateStoreId"> Private store unique id. </param>
        /// <param name="createdOn"> Private store offer creation date. </param>
        /// <param name="modifiedOn"> Private store offer modification date. </param>
        /// <param name="specificPlanIdsLimitation"> Plan ids limitation for this offer. </param>
        /// <param name="isUpdateSuppressedDueToIdempotence"> Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated. </param>
        /// <param name="iconFileUris"> Icon File Uris. </param>
        /// <param name="plans"> Offer plans. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateStoreOfferResult(string uniqueOfferId, string offerDisplayName, string publisherDisplayName, ETag? eTag, Guid? privateStoreId, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, IReadOnlyList<string> specificPlanIdsLimitation, bool? isUpdateSuppressedDueToIdempotence, IReadOnlyDictionary<string, Uri> iconFileUris, IReadOnlyList<PrivateStorePlan> plans, Dictionary<string, BinaryData> rawData)
        {
            UniqueOfferId = uniqueOfferId;
            OfferDisplayName = offerDisplayName;
            PublisherDisplayName = publisherDisplayName;
            ETag = eTag;
            PrivateStoreId = privateStoreId;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            SpecificPlanIdsLimitation = specificPlanIdsLimitation;
            IsUpdateSuppressedDueToIdempotence = isUpdateSuppressedDueToIdempotence;
            IconFileUris = iconFileUris;
            Plans = plans;
            _rawData = rawData;
        }

        /// <summary> Offers unique id. </summary>
        public string UniqueOfferId { get; }
        /// <summary> It will be displayed prominently in the marketplace. </summary>
        public string OfferDisplayName { get; }
        /// <summary> Publisher name that will be displayed prominently in the marketplace. </summary>
        public string PublisherDisplayName { get; }
        /// <summary> Identifier for purposes of race condition. </summary>
        public ETag? ETag { get; }
        /// <summary> Private store unique id. </summary>
        public Guid? PrivateStoreId { get; }
        /// <summary> Private store offer creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Private store offer modification date. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Plan ids limitation for this offer. </summary>
        public IReadOnlyList<string> SpecificPlanIdsLimitation { get; }
        /// <summary> Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated. </summary>
        public bool? IsUpdateSuppressedDueToIdempotence { get; }
        /// <summary> Icon File Uris. </summary>
        public IReadOnlyDictionary<string, Uri> IconFileUris { get; }
        /// <summary> Offer plans. </summary>
        public IReadOnlyList<PrivateStorePlan> Plans { get; }
    }
}
