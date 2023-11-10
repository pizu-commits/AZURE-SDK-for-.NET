// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The UnknownTokenFilter. </summary>
    internal partial class UnknownTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of UnknownTokenFilter. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal UnknownTokenFilter(string oDataType, string name) : base(oDataType, name)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
