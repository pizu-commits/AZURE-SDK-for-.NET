// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary> A representation of the available options for the Azure OpenAI optical character recognition (OCR) enhancement. </summary>
    public partial class AzureChatOCREnhancementConfiguration
    {
        /// <summary> Initializes a new instance of AzureChatOCREnhancementConfiguration. </summary>
        /// <param name="enabled"> Specifies whether the enhancement is enabled. </param>
        public AzureChatOCREnhancementConfiguration(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Specifies whether the enhancement is enabled. </summary>
        public bool Enabled { get; }
    }
}
