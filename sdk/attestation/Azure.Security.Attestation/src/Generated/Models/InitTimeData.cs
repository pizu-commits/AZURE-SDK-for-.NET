// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.Attestation
{
    /// <summary> Defines the "initialization time data" used to provision the attestation target for use by the MAA. </summary>
    internal partial class InitTimeData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InitTimeData"/>. </summary>
        public InitTimeData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InitTimeData"/>. </summary>
        /// <param name="data"> UTF-8 encoded Initialization Data passed into the trusted environment when it is created. </param>
        /// <param name="dataType"> The type of data contained within the "data" field. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InitTimeData(byte[] data, DataType? dataType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Data = data;
            DataType = dataType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> UTF-8 encoded Initialization Data passed into the trusted environment when it is created. </summary>
        public byte[] Data { get; set; }
        /// <summary> The type of data contained within the "data" field. </summary>
        public DataType? DataType { get; set; }
    }
}
