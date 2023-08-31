// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The set trigger state action definition. </summary>
    public partial class LogicWorkflowTriggerStateActionContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerStateActionContent"/>. </summary>
        /// <param name="source"> The source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public LogicWorkflowTriggerStateActionContent(LogicWorkflowTriggerReference source)
        {
            Argument.AssertNotNull(source, nameof(source));

            Source = source;
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerStateActionContent"/>. </summary>
        /// <param name="source"> The source. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowTriggerStateActionContent(LogicWorkflowTriggerReference source, Dictionary<string, BinaryData> rawData)
        {
            Source = source;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerStateActionContent"/> for deserialization. </summary>
        internal LogicWorkflowTriggerStateActionContent()
        {
        }

        /// <summary> The source. </summary>
        public LogicWorkflowTriggerReference Source { get; }
    }
}
