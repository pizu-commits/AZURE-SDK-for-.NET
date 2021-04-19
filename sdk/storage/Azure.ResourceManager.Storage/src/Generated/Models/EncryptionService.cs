// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> A service that allows server-side encryption to be used. </summary>
    public partial class EncryptionService
    {
        /// <summary> Initializes a new instance of EncryptionService. </summary>
        public EncryptionService()
        {
        }

        /// <summary> Initializes a new instance of EncryptionService. </summary>
        /// <param name="enabled"> A boolean indicating whether or not the service encrypts the data as it is stored. </param>
        /// <param name="lastEnabledTime"> Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate. </param>
        /// <param name="keyType"> Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped encryption key will be used. &apos;Service&apos; key type implies that a default service key is used. </param>
        internal EncryptionService(bool? enabled, DateTimeOffset? lastEnabledTime, KeyType? keyType)
        {
            Enabled = enabled;
            LastEnabledTime = lastEnabledTime;
            KeyType = keyType;
        }

        /// <summary> A boolean indicating whether or not the service encrypts the data as it is stored. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate. </summary>
        public DateTimeOffset? LastEnabledTime { get; }
        /// <summary> Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped encryption key will be used. &apos;Service&apos; key type implies that a default service key is used. </summary>
        public KeyType? KeyType { get; set; }
    }
}
