// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> MarketplaceDetails of PAN Firewall resource. </summary>
    public partial class PanFirewallMarketplaceDetails
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PanFirewallMarketplaceDetails"/>. </summary>
        /// <param name="offerId"> Offer Id. </param>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> or <paramref name="publisherId"/> is null. </exception>
        public PanFirewallMarketplaceDetails(string offerId, string publisherId)
        {
            Argument.AssertNotNull(offerId, nameof(offerId));
            Argument.AssertNotNull(publisherId, nameof(publisherId));

            OfferId = offerId;
            PublisherId = publisherId;
        }

        /// <summary> Initializes a new instance of <see cref="PanFirewallMarketplaceDetails"/>. </summary>
        /// <param name="marketplaceSubscriptionId"> Marketplace Subscription Id. </param>
        /// <param name="offerId"> Offer Id. </param>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="marketplaceSubscriptionStatus"> Marketplace Subscription Status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PanFirewallMarketplaceDetails(string marketplaceSubscriptionId, string offerId, string publisherId, MarketplaceSubscriptionStatus? marketplaceSubscriptionStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MarketplaceSubscriptionId = marketplaceSubscriptionId;
            OfferId = offerId;
            PublisherId = publisherId;
            MarketplaceSubscriptionStatus = marketplaceSubscriptionStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PanFirewallMarketplaceDetails"/> for deserialization. </summary>
        internal PanFirewallMarketplaceDetails()
        {
        }

        /// <summary> Marketplace Subscription Id. </summary>
        public string MarketplaceSubscriptionId { get; }
        /// <summary> Offer Id. </summary>
        public string OfferId { get; set; }
        /// <summary> Publisher Id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Marketplace Subscription Status. </summary>
        public MarketplaceSubscriptionStatus? MarketplaceSubscriptionStatus { get; set; }
    }
}
