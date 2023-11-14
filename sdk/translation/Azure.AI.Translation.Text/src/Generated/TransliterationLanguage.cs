// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary>
    /// The value of the transliteration property is a dictionary of (key, value) pairs.
    /// Each key is a BCP 47 language tag. A key identifies a language for which text can be converted from one script
    /// to another script.
    /// </summary>
    public partial class TransliterationLanguage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TransliterationLanguage"/>. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="scripts"> List of scripts to convert from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="nativeName"/> or <paramref name="scripts"/> is null. </exception>
        internal TransliterationLanguage(string name, string nativeName, IEnumerable<TransliterableScript> scripts)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(nativeName, nameof(nativeName));
            Argument.AssertNotNull(scripts, nameof(scripts));

            Name = name;
            NativeName = nativeName;
            Scripts = scripts.ToList();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="TransliterationLanguage"/>. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="scripts"> List of scripts to convert from. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TransliterationLanguage(string name, string nativeName, IReadOnlyList<TransliterableScript> scripts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            NativeName = nativeName;
            Scripts = scripts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TransliterationLanguage"/> for deserialization. </summary>
        internal TransliterationLanguage()
        {
        }

        /// <summary> Display name of the language in the locale requested via Accept-Language header. </summary>
        public string Name { get; }
        /// <summary> Display name of the language in the locale native for this language. </summary>
        public string NativeName { get; }
        /// <summary> List of scripts to convert from. </summary>
        public IReadOnlyList<TransliterableScript> Scripts { get; }
    }
}
