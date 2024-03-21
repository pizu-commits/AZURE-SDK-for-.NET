// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> Details of storage account sas token . </summary>
    public partial class AccountSasToken
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

        /// <summary> Initializes a new instance of <see cref="AccountSasToken"/>. </summary>
        /// <param name="storageAccountSasToken"> Field to specify storage account sas token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountSasToken"/> is null. </exception>
        internal AccountSasToken(string storageAccountSasToken)
        {
            Argument.AssertNotNull(storageAccountSasToken, nameof(storageAccountSasToken));

            StorageAccountSasToken = storageAccountSasToken;
        }

        /// <summary> Initializes a new instance of <see cref="AccountSasToken"/>. </summary>
        /// <param name="storageAccountSasToken"> Field to specify storage account sas token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AccountSasToken(string storageAccountSasToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageAccountSasToken = storageAccountSasToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AccountSasToken"/> for deserialization. </summary>
        internal AccountSasToken()
        {
        }

        /// <summary> Field to specify storage account sas token. </summary>
        public string StorageAccountSasToken { get; }
    }
}
