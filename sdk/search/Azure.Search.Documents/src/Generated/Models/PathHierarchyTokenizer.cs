// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Tokenizer for path-like hierarchies. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class PathHierarchyTokenizer : LexicalTokenizer
    {
        /// <summary> Initializes a new instance of PathHierarchyTokenizer. </summary>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PathHierarchyTokenizer(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.PathHierarchyTokenizerV2";
        }

        /// <summary> Initializes a new instance of PathHierarchyTokenizer. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="delimiter"> The delimiter character to use. Default is "/". </param>
        /// <param name="replacement"> A value that, if set, replaces the delimiter character. Default is "/". </param>
        /// <param name="maxTokenLength"> The maximum token length. Default and maximum is 300. </param>
        /// <param name="reverseTokenOrder"> A value indicating whether to generate tokens in reverse order. Default is false. </param>
        /// <param name="numberOfTokensToSkip"> The number of initial tokens to skip. Default is 0. </param>
        internal PathHierarchyTokenizer(string oDataType, string name, char? delimiter, char? replacement, int? maxTokenLength, bool? reverseTokenOrder, int? numberOfTokensToSkip) : base(oDataType, name)
        {
            Delimiter = delimiter;
            Replacement = replacement;
            MaxTokenLength = maxTokenLength;
            ReverseTokenOrder = reverseTokenOrder;
            NumberOfTokensToSkip = numberOfTokensToSkip;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.PathHierarchyTokenizerV2";
        }

        /// <summary> The delimiter character to use. Default is "/". </summary>
        public char? Delimiter { get; set; }
        /// <summary> A value that, if set, replaces the delimiter character. Default is "/". </summary>
        public char? Replacement { get; set; }
        /// <summary> The maximum token length. Default and maximum is 300. </summary>
        public int? MaxTokenLength { get; set; }
        /// <summary> A value indicating whether to generate tokens in reverse order. Default is false. </summary>
        public bool? ReverseTokenOrder { get; set; }
        /// <summary> The number of initial tokens to skip. Default is 0. </summary>
        public int? NumberOfTokensToSkip { get; set; }
    }
}
