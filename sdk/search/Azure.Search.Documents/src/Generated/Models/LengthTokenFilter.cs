// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Removes words that are too long or too short. This token filter is implemented using Apache Lucene. </summary>
    public partial class LengthTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of LengthTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public LengthTokenFilter(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            ODataType = "#Microsoft.Azure.Search.LengthTokenFilter";
        }

        /// <summary> Initializes a new instance of LengthTokenFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="min"> The minimum length in characters. Default is 0. Maximum is 300. Must be less than the value of max. </param>
        /// <param name="max"> The maximum length in characters. Default and maximum is 300. </param>
        internal LengthTokenFilter(string oDataType, string name, int? min, int? max) : base(oDataType, name)
        {
            Min = min;
            Max = max;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.LengthTokenFilter";
        }

        /// <summary> The minimum length in characters. Default is 0. Maximum is 300. Must be less than the value of max. </summary>
        public int? Min { get; set; }
        /// <summary> The maximum length in characters. Default and maximum is 300. </summary>
        public int? Max { get; set; }
    }
}
