// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> SasPolicy assigned to the storage account. </summary>
    public partial class StorageAccountSasPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountSasPolicy"/>. </summary>
        /// <param name="sasExpirationPeriod"> The SAS expiration period, DD.HH:MM:SS. </param>
        /// <param name="expirationAction"> The SAS expiration action. Can only be Log. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasExpirationPeriod"/> is null. </exception>
        public StorageAccountSasPolicy(string sasExpirationPeriod, ExpirationAction expirationAction)
        {
            Argument.AssertNotNull(sasExpirationPeriod, nameof(sasExpirationPeriod));

            SasExpirationPeriod = sasExpirationPeriod;
            ExpirationAction = expirationAction;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountSasPolicy"/>. </summary>
        /// <param name="sasExpirationPeriod"> The SAS expiration period, DD.HH:MM:SS. </param>
        /// <param name="expirationAction"> The SAS expiration action. Can only be Log. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountSasPolicy(string sasExpirationPeriod, ExpirationAction expirationAction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SasExpirationPeriod = sasExpirationPeriod;
            ExpirationAction = expirationAction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountSasPolicy"/> for deserialization. </summary>
        internal StorageAccountSasPolicy()
        {
        }

        /// <summary> The SAS expiration period, DD.HH:MM:SS. </summary>
        public string SasExpirationPeriod { get; set; }
        /// <summary> The SAS expiration action. Can only be Log. </summary>
        public ExpirationAction ExpirationAction { get; set; }
    }
}
