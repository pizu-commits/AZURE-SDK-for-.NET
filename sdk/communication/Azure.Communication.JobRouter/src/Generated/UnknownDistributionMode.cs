// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> Unknown version of DistributionMode. </summary>
    internal partial class UnknownDistributionMode : DistributionMode
    {
        /// <summary> Initializes a new instance of UnknownDistributionMode. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors">
        /// (Optional)
        /// If set to true, then router will match workers to jobs even if they
        /// don't match label selectors.
        /// Warning: You may get workers that are not
        /// qualified for the job they are matched with if you set this
        /// variable to true.
        /// This flag is intended more for temporary usage.
        /// By default, set to false.
        /// </param>
        internal UnknownDistributionMode(string kind, int minConcurrentOffers, int maxConcurrentOffers, bool? bypassSelectors) : base(kind, minConcurrentOffers, maxConcurrentOffers, bypassSelectors)
        {
        }
    }
}
