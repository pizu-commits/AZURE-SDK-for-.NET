// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Contains guidance related elements. This field is present only when guidance was requested and is available. </summary>
    public partial class RouteGuidance
    {
        /// <summary> Initializes a new instance of RouteGuidance. </summary>
        internal RouteGuidance()
        {
            Instructions = new Core.ChangeTrackingList<RouteInstruction>();
            InstructionGroups = new Core.ChangeTrackingList<RouteInstructionGroup>();
        }

        /// <summary> Initializes a new instance of RouteGuidance. </summary>
        /// <param name="instructions"> A list of instructions describing maneuvers. </param>
        /// <param name="instructionGroups"> Groups a sequence of instruction elements which are related to each other. </param>
        internal RouteGuidance(IReadOnlyList<RouteInstruction> instructions, IReadOnlyList<RouteInstructionGroup> instructionGroups)
        {
            Instructions = instructions;
            InstructionGroups = instructionGroups;
        }

        /// <summary> A list of instructions describing maneuvers. </summary>
        public IReadOnlyList<RouteInstruction> Instructions { get; }
        /// <summary> Groups a sequence of instruction elements which are related to each other. </summary>
        public IReadOnlyList<RouteInstructionGroup> InstructionGroups { get; }
    }
}
