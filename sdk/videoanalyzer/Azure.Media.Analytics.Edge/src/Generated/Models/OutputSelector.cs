// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Allows for the selection of particular streams from another node. </summary>
    public partial class OutputSelector
    {
        /// <summary> Initializes a new instance of OutputSelector. </summary>
        public OutputSelector()
        {
        }

        /// <summary> Initializes a new instance of OutputSelector. </summary>
        /// <param name="property"> The stream property to compare with. </param>
        /// <param name="operator"> The operator to compare streams by. </param>
        /// <param name="value"> Value to compare against. </param>
        internal OutputSelector(OutputSelectorProperty? property, OutputSelectorOperator? @operator, string value)
        {
            Property = property;
            Operator = @operator;
            Value = value;
        }

        /// <summary> The stream property to compare with. </summary>
        public OutputSelectorProperty? Property { get; set; }
        /// <summary> The operator to compare streams by. </summary>
        public OutputSelectorOperator? Operator { get; set; }
        /// <summary> Value to compare against. </summary>
        public string Value { get; set; }
    }
}
