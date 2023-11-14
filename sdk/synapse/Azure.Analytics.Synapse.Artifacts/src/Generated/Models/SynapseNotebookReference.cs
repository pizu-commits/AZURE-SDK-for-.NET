// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Synapse notebook reference type. </summary>
    public partial class SynapseNotebookReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookReference"/>. </summary>
        /// <param name="type"> Synapse notebook reference type. </param>
        /// <param name="referenceName"> Reference notebook name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SynapseNotebookReference(NotebookReferenceType type, object referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookReference"/>. </summary>
        /// <param name="type"> Synapse notebook reference type. </param>
        /// <param name="referenceName"> Reference notebook name. Type: string (or Expression with resultType string). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseNotebookReference(NotebookReferenceType type, object referenceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            ReferenceName = referenceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookReference"/> for deserialization. </summary>
        internal SynapseNotebookReference()
        {
        }

        /// <summary> Synapse notebook reference type. </summary>
        public NotebookReferenceType Type { get; set; }
        /// <summary> Reference notebook name. Type: string (or Expression with resultType string). </summary>
        public object ReferenceName { get; set; }
    }
}
