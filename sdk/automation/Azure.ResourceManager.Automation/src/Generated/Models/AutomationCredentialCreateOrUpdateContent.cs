// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update credential operation. </summary>
    public partial class AutomationCredentialCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="AutomationCredentialCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the credential. </param>
        /// <param name="userName"> Gets or sets the user name of the credential. </param>
        /// <param name="password"> Gets or sets the password of the credential. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public AutomationCredentialCreateOrUpdateContent(string name, string userName, string password)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            Name = name;
            UserName = userName;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCredentialCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the credential. </param>
        /// <param name="userName"> Gets or sets the user name of the credential. </param>
        /// <param name="password"> Gets or sets the password of the credential. </param>
        /// <param name="description"> Gets or sets the description of the credential. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationCredentialCreateOrUpdateContent(string name, string userName, string password, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            UserName = userName;
            Password = password;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCredentialCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationCredentialCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the credential. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the user name of the credential. </summary>
        public string UserName { get; }
        /// <summary> Gets or sets the password of the credential. </summary>
        public string Password { get; }
        /// <summary> Gets or sets the description of the credential. </summary>
        public string Description { get; set; }
    }
}
