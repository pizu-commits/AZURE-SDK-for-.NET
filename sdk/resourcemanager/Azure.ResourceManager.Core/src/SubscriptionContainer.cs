// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    /// <summary>
    /// A class representing collection of Subscription and their operations
    /// </summary>
    public class SubscriptionContainer : ContainerBase<SubscriptionResourceIdentifier, Subscription>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionContainer"/> class for mocking.
        /// </summary>
        protected SubscriptionContainer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionContainer"/> class.
        /// </summary>
        /// <param name="clientContext"></param>
        internal SubscriptionContainer(ClientContext clientContext)
            : base(clientContext, null)
        {
            Operations = new SubscriptionOperations(clientContext, Guid.NewGuid().ToString());
        }

        /// <summary>
        /// Gets the valid resource type associated with the container.
        /// </summary>
        protected override ResourceType ValidResourceType => SubscriptionOperations.ResourceType;

        /// <summary>
        /// Gets the operations that can be performed on the container.
        /// </summary>
        private SubscriptionOperations Operations;

        /// <summary>
        /// Lists all subscriptions in the current container.
        /// </summary>
        /// <param name="cancellationToken">A token to allow the caller to cancel the call to the service.
        /// The default value is <see cref="CancellationToken.None" />.</param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        [ForwardsClientCalls]
        public virtual Pageable<Subscription> List(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("SubscriptionContainer.List");
            scope.Start();

            try
            {
                return Operations.List(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all subscriptions in the current container.
        /// </summary>
        /// <param name="cancellationToken">A token to allow the caller to cancel the call to the service.
        /// The default value is <see cref="CancellationToken.None" />.</param>
        /// <returns> An async collection of resource operations that may take multiple service requests to iterate over. </returns>
        [ForwardsClientCalls]
        public virtual AsyncPageable<Subscription> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("SubscriptionContainer.List");
            scope.Start();

            try
            {
                return Operations.ListAsync(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate the resource identifier is supported in the current container.
        /// </summary>
        /// <param name="identifier"> The identifier of the resource. </param>
        protected override void Validate(ResourceIdentifier identifier)
        {
            if (!(identifier is null))
                throw new ArgumentException("Invalid parent for subscription container", nameof(identifier));
        }

        /// <summary>
        /// Get an instance of the operations this container holds.
        /// </summary>
        /// <param name="subscriptionGuid"> The guid of the subscription to be found. </param>
        /// <returns> An instance of <see cref="ResourceOperationsBase{TenantResourceIdentifier, Subscription}"/>. </returns>
        protected override ResourceOperationsBase<SubscriptionResourceIdentifier, Subscription> GetOperation(string subscriptionGuid)
        {
            return new SubscriptionOperations(new ClientContext(ClientOptions, Credential, BaseUri, Pipeline), subscriptionGuid);
        }

        //TODO: can make static?
        private Func<SubscriptionData, Subscription> Converter()
        {
            return s => new Subscription(new SubscriptionOperations(new ClientContext(ClientOptions, Credential, BaseUri, Pipeline), s.Id), s);
        }
    }
}
