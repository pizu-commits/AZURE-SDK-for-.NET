// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for inputs to a Job.
    /// Please note <see cref="MediaJobInputBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MediaJobInputAsset"/>, <see cref="MediaJobInputClip"/>, <see cref="MediaJobInputHttp"/>, <see cref="MediaJobInputSequence"/> and <see cref="MediaJobInputs"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownJobInput))]
    public abstract partial class MediaJobInputBasicProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MediaJobInputBasicProperties"/>. </summary>
        protected MediaJobInputBasicProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobInputBasicProperties"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobInputBasicProperties(string odataType, Dictionary<string, BinaryData> rawData)
        {
            OdataType = odataType;
            _rawData = rawData;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
