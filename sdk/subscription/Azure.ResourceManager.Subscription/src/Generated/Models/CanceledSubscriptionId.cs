// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The ID of the canceled subscription. </summary>
    public partial class CanceledSubscriptionId
    {
        /// <summary> Initializes a new instance of <see cref="CanceledSubscriptionId"/>. </summary>
        internal CanceledSubscriptionId()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CanceledSubscriptionId"/>. </summary>
        /// <param name="subscriptionId"> The ID of the canceled subscription. </param>
        internal CanceledSubscriptionId(string subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        /// <summary> The ID of the canceled subscription. </summary>
        public string SubscriptionId { get; }
    }
}
