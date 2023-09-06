// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The ArcPasswordCredential. </summary>
    public partial class ArcPasswordCredential
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ArcPasswordCredential"/>. </summary>
        internal ArcPasswordCredential()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArcPasswordCredential"/>. </summary>
        /// <param name="secretText"></param>
        /// <param name="keyId"></param>
        /// <param name="startOn"></param>
        /// <param name="endOn"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ArcPasswordCredential(string secretText, string keyId, DateTimeOffset? startOn, DateTimeOffset? endOn, Dictionary<string, BinaryData> rawData)
        {
            SecretText = secretText;
            KeyId = keyId;
            StartOn = startOn;
            EndOn = endOn;
            _rawData = rawData;
        }

        /// <summary> Gets the secret text. </summary>
        public string SecretText { get; }
        /// <summary> Gets the key id. </summary>
        public string KeyId { get; }
        /// <summary> Gets the start on. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets the end on. </summary>
        public DateTimeOffset? EndOn { get; }
    }
}
