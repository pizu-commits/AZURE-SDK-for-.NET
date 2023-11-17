// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The grounding enhancement that returns the bounding box of the objects detected in the image. </summary>
    public partial class AzureGroundingEnhancement
    {
        /// <summary> Initializes a new instance of AzureGroundingEnhancement. </summary>
        /// <param name="lines"> The lines of text detected by the grounding enhancement. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lines"/> is null. </exception>
        internal AzureGroundingEnhancement(IEnumerable<AzureGroundingEnhancementLine> lines)
        {
            Argument.AssertNotNull(lines, nameof(lines));

            Lines = lines.ToList();
        }

        /// <summary> Initializes a new instance of AzureGroundingEnhancement. </summary>
        /// <param name="lines"> The lines of text detected by the grounding enhancement. </param>
        internal AzureGroundingEnhancement(IReadOnlyList<AzureGroundingEnhancementLine> lines)
        {
            Lines = lines;
        }

        /// <summary> The lines of text detected by the grounding enhancement. </summary>
        public IReadOnlyList<AzureGroundingEnhancementLine> Lines { get; }
    }
}
