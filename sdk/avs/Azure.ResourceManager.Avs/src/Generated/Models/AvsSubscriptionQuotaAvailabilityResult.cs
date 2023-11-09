// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Subscription quotas. </summary>
    public partial class AvsSubscriptionQuotaAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvsSubscriptionQuotaAvailabilityResult"/>. </summary>
        internal AvsSubscriptionQuotaAvailabilityResult()
        {
            HostsRemaining = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsSubscriptionQuotaAvailabilityResult"/>. </summary>
        /// <param name="hostsRemaining"> Remaining hosts quota by sku type. </param>
        /// <param name="quotaEnabled"> Host quota is active for current subscription. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsSubscriptionQuotaAvailabilityResult(IReadOnlyDictionary<string, int> hostsRemaining, AvsSubscriptionQuotaEnabled? quotaEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HostsRemaining = hostsRemaining;
            QuotaEnabled = quotaEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Remaining hosts quota by sku type. </summary>
        public IReadOnlyDictionary<string, int> HostsRemaining { get; }
        /// <summary> Host quota is active for current subscription. </summary>
        public AvsSubscriptionQuotaEnabled? QuotaEnabled { get; }
    }
}
