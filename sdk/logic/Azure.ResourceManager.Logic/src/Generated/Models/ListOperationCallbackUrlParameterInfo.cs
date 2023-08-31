// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The callback url parameters. </summary>
    public partial class ListOperationCallbackUrlParameterInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListOperationCallbackUrlParameterInfo"/>. </summary>
        public ListOperationCallbackUrlParameterInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ListOperationCallbackUrlParameterInfo"/>. </summary>
        /// <param name="notAfter"> The expiry time. </param>
        /// <param name="keyType"> The key type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListOperationCallbackUrlParameterInfo(DateTimeOffset? notAfter, LogicKeyType? keyType, Dictionary<string, BinaryData> rawData)
        {
            NotAfter = notAfter;
            KeyType = keyType;
            _rawData = rawData;
        }

        /// <summary> The expiry time. </summary>
        public DateTimeOffset? NotAfter { get; set; }
        /// <summary> The key type. </summary>
        public LogicKeyType? KeyType { get; set; }
    }
}
