// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The embedding dependency based on model id. </summary>
    public partial class OnYourDataEmbeddingModelIdDependency : OnYourDataEmbeddingDependency
    {
        /// <summary> Initializes a new instance of OnYourDataEmbeddingModelIdDependency. </summary>
        /// <param name="modelId"> The embedding model id build inside the search service. Currently only supported by Elasticsearch. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public OnYourDataEmbeddingModelIdDependency(string modelId)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            Type = OnYourDataEmbeddingDependencyType.ModelId;
            ModelId = modelId;
        }

        /// <summary> Initializes a new instance of OnYourDataEmbeddingModelIdDependency. </summary>
        /// <param name="type"> Embedding dependency types for vector search. </param>
        /// <param name="modelId"> The embedding model id build inside the search service. Currently only supported by Elasticsearch. </param>
        internal OnYourDataEmbeddingModelIdDependency(OnYourDataEmbeddingDependencyType type, string modelId) : base(type)
        {
            ModelId = modelId;
        }

        /// <summary> The embedding model id build inside the search service. Currently only supported by Elasticsearch. </summary>
        public string ModelId { get; }
    }
}
