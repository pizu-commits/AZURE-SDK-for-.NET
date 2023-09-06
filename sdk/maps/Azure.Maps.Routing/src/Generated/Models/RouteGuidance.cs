// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Contains guidance related elements. This field is present only when guidance was requested and is available. </summary>
    public partial class RouteGuidance
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RouteGuidance"/>. </summary>
        internal RouteGuidance()
        {
            Instructions = new ChangeTrackingList<RouteInstruction>();
            InstructionGroups = new ChangeTrackingList<RouteInstructionGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteGuidance"/>. </summary>
        /// <param name="instructions"> A list of instructions describing maneuvers. </param>
        /// <param name="instructionGroups"> Groups a sequence of instruction elements which are related to each other. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteGuidance(IReadOnlyList<RouteInstruction> instructions, IReadOnlyList<RouteInstructionGroup> instructionGroups, Dictionary<string, BinaryData> rawData)
        {
            Instructions = instructions;
            InstructionGroups = instructionGroups;
            _rawData = rawData;
        }

        /// <summary> A list of instructions describing maneuvers. </summary>
        public IReadOnlyList<RouteInstruction> Instructions { get; }
        /// <summary> Groups a sequence of instruction elements which are related to each other. </summary>
        public IReadOnlyList<RouteInstructionGroup> InstructionGroups { get; }
    }
}
