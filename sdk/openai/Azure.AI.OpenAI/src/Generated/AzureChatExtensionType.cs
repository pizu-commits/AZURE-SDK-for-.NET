// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary>
    ///   A representation of configuration data for a single Azure OpenAI chat extension. This will be used by a chat
    ///   completions request that should use Azure OpenAI chat extensions to augment the response behavior.
    ///   The use of this configuration is compatible only with Azure OpenAI.
    /// </summary>
    public readonly partial struct AzureChatExtensionType : IEquatable<AzureChatExtensionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureChatExtensionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureChatExtensionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureCognitiveSearchValue = "AzureCognitiveSearch";
        private const string AzureMachineLearningIndexValue = "AzureMLIndex";
        private const string AzureCosmosDBValue = "AzureCosmosDB";
        private const string ElasticsearchValue = "Elasticsearch";
        private const string PineconeValue = "Pinecone";

        /// <summary> Represents the use of Azure Cognitive Search as an Azure OpenAI chat extension. </summary>
        public static AzureChatExtensionType AzureCognitiveSearch { get; } = new AzureChatExtensionType(AzureCognitiveSearchValue);
        /// <summary> Represents the use of Azure Machine Learning index as an Azure OpenAI chat extension. </summary>
        public static AzureChatExtensionType AzureMachineLearningIndex { get; } = new AzureChatExtensionType(AzureMachineLearningIndexValue);
        /// <summary> Represents the use of Azure Cosmos DB as an Azure OpenAI chat extension. </summary>
        public static AzureChatExtensionType AzureCosmosDB { get; } = new AzureChatExtensionType(AzureCosmosDBValue);
        /// <summary> Represents the use of Elasticsearch® index as an Azure OpenAI chat extension. </summary>
        public static AzureChatExtensionType Elasticsearch { get; } = new AzureChatExtensionType(ElasticsearchValue);
        /// <summary> Represents the use of Pinecone index as an Azure OpenAI chat extension. </summary>
        public static AzureChatExtensionType Pinecone { get; } = new AzureChatExtensionType(PineconeValue);
        /// <summary> Determines if two <see cref="AzureChatExtensionType"/> values are the same. </summary>
        public static bool operator ==(AzureChatExtensionType left, AzureChatExtensionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureChatExtensionType"/> values are not the same. </summary>
        public static bool operator !=(AzureChatExtensionType left, AzureChatExtensionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureChatExtensionType"/>. </summary>
        public static implicit operator AzureChatExtensionType(string value) => new AzureChatExtensionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureChatExtensionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureChatExtensionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
