// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((armClient) =>
            {
                return new SubscriptionExtensionClient(armClient, subscription.Id);
            }
            );
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<NameAvailability>> CheckWebPubSubNameAvailabilityAsync(this Subscription subscription, string location, NameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscription).CheckWebPubSubNameAvailabilityAsync(location, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<NameAvailability> CheckWebPubSubNameAvailability(this Subscription subscription, string location, NameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).CheckWebPubSubNameAvailability(location, parameters, cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<WebPubSub> GetWebPubSubsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetWebPubSubsAsync(cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<WebPubSub> GetWebPubSubs(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetWebPubSubs(cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the location like &quot;eastus&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SignalRServiceUsage> GetUsagesAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetUsagesAsync(location, cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the location like &quot;eastus&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<SignalRServiceUsage> GetUsages(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetUsages(location, cancellationToken);
        }
    }
}
