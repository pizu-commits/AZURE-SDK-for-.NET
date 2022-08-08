// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.ResourceManager
{
    /// <inheritdoc/>
#pragma warning disable SA1649 // File name should match first type name
    public abstract class ArmOperation<T> : Operation<T>
#pragma warning restore SA1649 // File name should match first type name
    {
        /// <summary>
        /// Async method that will return the interim status of the long-running opeartion.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The interim status received from the server.</returns>
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public virtual async ValueTask<T> GetCurrentStatusAsync(CancellationToken cancellationToken = default)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            throw new NotImplementedException("This method is not implemented for the current long-running operation. Please use configuration to enable this feature.");
        }

        /// <summary>
        /// Sync method that returns the interim status of the long-running opeartion.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The interim status received from the server.</returns>
        public virtual T GetCurrentStatus(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException("This method is not implemented for the current long-running operation. Please use configuration to enable this feature.");
        }
    }
}
