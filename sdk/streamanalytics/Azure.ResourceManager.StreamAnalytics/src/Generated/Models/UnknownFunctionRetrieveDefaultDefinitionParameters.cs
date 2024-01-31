// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownFunctionRetrieveDefaultDefinitionParameters. </summary>
    internal partial class UnknownFunctionRetrieveDefaultDefinitionParameters : FunctionRetrieveDefaultDefinitionContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFunctionRetrieveDefaultDefinitionParameters"/>. </summary>
        /// <param name="bindingType"> Indicates the function binding type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownFunctionRetrieveDefaultDefinitionParameters(string bindingType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(bindingType, serializedAdditionalRawData)
        {
            BindingType = bindingType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFunctionRetrieveDefaultDefinitionParameters"/> for deserialization. </summary>
        internal UnknownFunctionRetrieveDefaultDefinitionParameters()
        {
        }
    }
}
