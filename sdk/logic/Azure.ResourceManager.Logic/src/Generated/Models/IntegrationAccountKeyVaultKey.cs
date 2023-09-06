// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The key vault key. </summary>
    public partial class IntegrationAccountKeyVaultKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountKeyVaultKey"/>. </summary>
        internal IntegrationAccountKeyVaultKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountKeyVaultKey"/>. </summary>
        /// <param name="keyId"> The key id. </param>
        /// <param name="isEnabled"> Whether the key is enabled or not. </param>
        /// <param name="createdOn"> When the key was created. </param>
        /// <param name="updatedOn"> When the key was updated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountKeyVaultKey(Uri keyId, bool? isEnabled, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, Dictionary<string, BinaryData> rawData)
        {
            KeyId = keyId;
            IsEnabled = isEnabled;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            _rawData = rawData;
        }

        /// <summary> The key id. </summary>
        public Uri KeyId { get; }
        /// <summary> Whether the key is enabled or not. </summary>
        public bool? IsEnabled { get; }
        /// <summary> When the key was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> When the key was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}
