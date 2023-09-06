// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Raw Graphical Runbook content. </summary>
    public partial class RawGraphicalRunbookContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RawGraphicalRunbookContent"/>. </summary>
        public RawGraphicalRunbookContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RawGraphicalRunbookContent"/>. </summary>
        /// <param name="schemaVersion"> Schema version of the serializer. </param>
        /// <param name="runbookDefinition"> Serialized Graphical runbook. </param>
        /// <param name="runbookType"> Runbook Type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RawGraphicalRunbookContent(string schemaVersion, string runbookDefinition, GraphRunbookType? runbookType, Dictionary<string, BinaryData> rawData)
        {
            SchemaVersion = schemaVersion;
            RunbookDefinition = runbookDefinition;
            RunbookType = runbookType;
            _rawData = rawData;
        }

        /// <summary> Schema version of the serializer. </summary>
        public string SchemaVersion { get; set; }
        /// <summary> Serialized Graphical runbook. </summary>
        public string RunbookDefinition { get; set; }
        /// <summary> Runbook Type. </summary>
        public GraphRunbookType? RunbookType { get; set; }
    }
}
