// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// N-Cross validations value.
    /// Please note <see cref="NCrossValidations"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AutoNCrossValidations"/> and <see cref="CustomNCrossValidations"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownNCrossValidations))]
    public abstract partial class NCrossValidations
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NCrossValidations"/>. </summary>
        protected NCrossValidations()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NCrossValidations"/>. </summary>
        /// <param name="mode"> [Required] Mode for determining N-Cross validations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NCrossValidations(NCrossValidationsMode mode, Dictionary<string, BinaryData> rawData)
        {
            Mode = mode;
            _rawData = rawData;
        }

        /// <summary> [Required] Mode for determining N-Cross validations. </summary>
        internal NCrossValidationsMode Mode { get; set; }
    }
}
