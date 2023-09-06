// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow run action repetition index. </summary>
    public partial class LogicWorkflowRepetitionIndex
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRepetitionIndex"/>. </summary>
        /// <param name="itemIndex"> The index. </param>
        public LogicWorkflowRepetitionIndex(int itemIndex)
        {
            ItemIndex = itemIndex;
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRepetitionIndex"/>. </summary>
        /// <param name="scopeName"> The scope. </param>
        /// <param name="itemIndex"> The index. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowRepetitionIndex(string scopeName, int itemIndex, Dictionary<string, BinaryData> rawData)
        {
            ScopeName = scopeName;
            ItemIndex = itemIndex;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRepetitionIndex"/> for deserialization. </summary>
        internal LogicWorkflowRepetitionIndex()
        {
        }

        /// <summary> The scope. </summary>
        public string ScopeName { get; set; }
        /// <summary> The index. </summary>
        public int ItemIndex { get; set; }
    }
}
