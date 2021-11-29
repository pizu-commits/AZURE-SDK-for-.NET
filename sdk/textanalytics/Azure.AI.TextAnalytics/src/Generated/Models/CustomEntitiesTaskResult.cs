// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The CustomEntitiesTaskResult. </summary>
    internal partial class CustomEntitiesTaskResult
    {
        /// <summary> Initializes a new instance of CustomEntitiesTaskResult. </summary>
        internal CustomEntitiesTaskResult()
        {
        }

        /// <summary> Initializes a new instance of CustomEntitiesTaskResult. </summary>
        /// <param name="results"></param>
        internal CustomEntitiesTaskResult(CustomEntitiesResult results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public CustomEntitiesResult Results { get; }
    }
}
