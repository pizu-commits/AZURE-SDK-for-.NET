// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> A description of the properties of a pipeline topology. </summary>
    public partial class PipelineTopologyProperties
    {
        /// <summary> Initializes a new instance of PipelineTopologyProperties. </summary>
        public PipelineTopologyProperties()
        {
            Parameters = new ChangeTrackingList<ParameterDeclaration>();
            Sources = new ChangeTrackingList<SourceNodeBase>();
            Processors = new ChangeTrackingList<ProcessorNodeBase>();
            Sinks = new ChangeTrackingList<SinkNodeBase>();
        }

        /// <summary> Initializes a new instance of PipelineTopologyProperties. </summary>
        /// <param name="description"> A description of a pipeline topology. It is recommended to use this to describe the expected use of the pipeline topology. </param>
        /// <param name="parameters"> The list of parameters defined in the pipeline topology. The value for these parameters are supplied by streams of this pipeline topology. </param>
        /// <param name="sources"> The list of source nodes in this pipeline topology. </param>
        /// <param name="processors"> The list of processor nodes in this pipeline topology. </param>
        /// <param name="sinks"> The list of sink nodes in this pipeline topology. </param>
        internal PipelineTopologyProperties(string description, IList<ParameterDeclaration> parameters, IList<SourceNodeBase> sources, IList<ProcessorNodeBase> processors, IList<SinkNodeBase> sinks)
        {
            Description = description;
            Parameters = parameters;
            Sources = sources;
            Processors = processors;
            Sinks = sinks;
        }

        /// <summary> A description of a pipeline topology. It is recommended to use this to describe the expected use of the pipeline topology. </summary>
        public string Description { get; set; }
        /// <summary> The list of parameters defined in the pipeline topology. The value for these parameters are supplied by streams of this pipeline topology. </summary>
        public IList<ParameterDeclaration> Parameters { get; }
        /// <summary> The list of source nodes in this pipeline topology. </summary>
        public IList<SourceNodeBase> Sources { get; }
        /// <summary> The list of processor nodes in this pipeline topology. </summary>
        public IList<ProcessorNodeBase> Processors { get; }
        /// <summary> The list of sink nodes in this pipeline topology. </summary>
        public IList<SinkNodeBase> Sinks { get; }
    }
}
