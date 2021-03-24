// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The DiagnosticsInfo. </summary>
    public partial class DiagnosticsInfo
    {
        /// <summary> Initializes a new instance of DiagnosticsInfo. </summary>
        internal DiagnosticsInfo()
        {
            VariableStates = new ChangeTrackingList<VariableState>();
        }

        /// <summary> Initializes a new instance of DiagnosticsInfo. </summary>
        /// <param name="modelState"> . </param>
        /// <param name="variableStates"> . </param>
        internal DiagnosticsInfo(ModelState modelState, IReadOnlyList<VariableState> variableStates)
        {
            ModelState = modelState;
            VariableStates = variableStates;
        }

        public ModelState ModelState { get; }
        public IReadOnlyList<VariableState> VariableStates { get; }
    }
}
