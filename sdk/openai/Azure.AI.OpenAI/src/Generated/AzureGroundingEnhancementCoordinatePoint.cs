// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary> A representation of a single polygon point as used by the Azure grounding enhancement. </summary>
    public partial class AzureGroundingEnhancementCoordinatePoint
    {
        /// <summary> Initializes a new instance of AzureGroundingEnhancementCoordinatePoint. </summary>
        /// <param name="x"> The x-coordinate (horizontal axis) of the point. </param>
        /// <param name="y"> The y-coordinate (vertical axis) of the point. </param>
        internal AzureGroundingEnhancementCoordinatePoint(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary> The x-coordinate (horizontal axis) of the point. </summary>
        public float X { get; }
        /// <summary> The y-coordinate (vertical axis) of the point. </summary>
        public float Y { get; }
    }
}
