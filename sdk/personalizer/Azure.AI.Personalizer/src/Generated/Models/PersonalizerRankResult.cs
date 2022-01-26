// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    /// <summary> Returns which action to use as rewardActionId, and additional information about each action as a result of a Rank request. </summary>
    public partial class PersonalizerRankResult
    {
        /// <summary> Initializes a new instance of PersonalizerRankResult. </summary>
        internal PersonalizerRankResult()
        {
            Ranking = new ChangeTrackingList<PersonalizerRankedAction>();
        }

        /// <summary> Initializes a new instance of PersonalizerRankResult. </summary>
        /// <param name="ranking"> The calculated ranking for the current request. </param>
        /// <param name="eventId"> The eventId for the round trip from request to response. </param>
        /// <param name="rewardActionId">
        /// The action chosen by the Personalizer service.
        /// This is the action your application should display, and for which to report the reward.
        /// This might not be the first found in &apos;ranking&apos;.
        /// </param>
        internal PersonalizerRankResult(IReadOnlyList<PersonalizerRankedAction> ranking, string eventId, string rewardActionId)
        {
            Ranking = ranking;
            EventId = eventId;
            RewardActionId = rewardActionId;
        }

        /// <summary> The calculated ranking for the current request. </summary>
        public IReadOnlyList<PersonalizerRankedAction> Ranking { get; set; }
        /// <summary> The eventId for the round trip from request to response. </summary>
        public string EventId { get; set; }
        /// <summary>
        /// The action chosen by the Personalizer service.
        /// This is the action your application should display, and for which to report the reward.
        /// This might not be the first found in &apos;ranking&apos;.
        /// </summary>
        public string RewardActionId { get; set; }
    }
}
