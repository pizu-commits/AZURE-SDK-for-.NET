// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Diagnostics information to help inspect the states of a model or variable. </summary>
    public partial class DiagnosticsInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiagnosticsInfo"/>. </summary>
        public DiagnosticsInfo()
        {
            VariableStates = new ChangeTrackingList<VariableState>();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticsInfo"/>. </summary>
        /// <param name="modelState"> Model status. </param>
        /// <param name="variableStates"> Variable status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticsInfo(ModelState modelState, IList<VariableState> variableStates, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelState = modelState;
            VariableStates = variableStates;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Model status. </summary>
        public ModelState ModelState { get; set; }
        /// <summary> Variable status. </summary>
        public IList<VariableState> VariableStates { get; }
    }
}
