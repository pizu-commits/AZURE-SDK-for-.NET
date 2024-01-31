// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Properties of the target dictionary language. </summary>
    public partial class TargetDictionaryLanguage
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TargetDictionaryLanguage"/>. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <param name="code"> Language code identifying the target language. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="nativeName"/>, <paramref name="dir"/> or <paramref name="code"/> is null. </exception>
        internal TargetDictionaryLanguage(string name, string nativeName, string dir, string code)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(nativeName, nameof(nativeName));
            Argument.AssertNotNull(dir, nameof(dir));
            Argument.AssertNotNull(code, nameof(code));

            Name = name;
            NativeName = nativeName;
            Dir = dir;
            Code = code;
        }

        /// <summary> Initializes a new instance of <see cref="TargetDictionaryLanguage"/>. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <param name="code"> Language code identifying the target language. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetDictionaryLanguage(string name, string nativeName, string dir, string code, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            NativeName = nativeName;
            Dir = dir;
            Code = code;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TargetDictionaryLanguage"/> for deserialization. </summary>
        internal TargetDictionaryLanguage()
        {
        }

        /// <summary> Display name of the language in the locale requested via Accept-Language header. </summary>
        public string Name { get; }
        /// <summary> Display name of the language in the locale native for this language. </summary>
        public string NativeName { get; }
        /// <summary> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </summary>
        public string Dir { get; }
        /// <summary> Language code identifying the target language. </summary>
        public string Code { get; }
    }
}
