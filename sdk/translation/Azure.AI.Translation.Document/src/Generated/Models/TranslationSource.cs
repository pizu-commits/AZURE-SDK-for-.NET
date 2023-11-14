// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.Translation.Document.Models;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    /// <summary> Source of the input documents. </summary>
    public partial class TranslationSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TranslationSource"/>. </summary>
        /// <param name="sourceUri"> Location of the folder / container or single file with your documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceUri"/> is null. </exception>
        public TranslationSource(Uri sourceUri)
        {
            Argument.AssertNotNull(sourceUri, nameof(sourceUri));

            SourceUri = sourceUri;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationSource"/>. </summary>
        /// <param name="sourceUri"> Location of the folder / container or single file with your documents. </param>
        /// <param name="filter"></param>
        /// <param name="languageCode">
        /// Language code
        /// If none is specified, we will perform auto detect on the document
        /// </param>
        /// <param name="storageSource"> Storage Source. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslationSource(Uri sourceUri, DocumentFilter filter, string languageCode, string storageSource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceUri = sourceUri;
            Filter = filter;
            LanguageCode = languageCode;
            StorageSource = storageSource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationSource"/> for deserialization. </summary>
        internal TranslationSource()
        {
        }
    }
}
