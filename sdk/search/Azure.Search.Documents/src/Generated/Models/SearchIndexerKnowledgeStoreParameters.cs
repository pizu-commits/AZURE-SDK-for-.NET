// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A dictionary of knowledge store-specific configuration properties. Each name is the name of a specific property. Each value must be of a primitive type. </summary>
    internal partial class SearchIndexerKnowledgeStoreParameters
    {
        /// <summary> Initializes a new instance of <see cref="SearchIndexerKnowledgeStoreParameters"/>. </summary>
        internal SearchIndexerKnowledgeStoreParameters()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchIndexerKnowledgeStoreParameters"/>. </summary>
        /// <param name="synthesizeGeneratedKeyName"> Whether or not projections should synthesize a generated key name if one isn't already present. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SearchIndexerKnowledgeStoreParameters(bool? synthesizeGeneratedKeyName, IReadOnlyDictionary<string, object> additionalProperties)
        {
            SynthesizeGeneratedKeyName = synthesizeGeneratedKeyName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Whether or not projections should synthesize a generated key name if one isn't already present. </summary>
        public bool? SynthesizeGeneratedKeyName { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
