// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The parameters schema of integration account map.
    /// Serialized Name: IntegrationAccountMapPropertiesParametersSchema
    /// </summary>
    internal partial class IntegrationAccountMapPropertiesParametersSchema
    {
        /// <summary> Initializes a new instance of IntegrationAccountMapPropertiesParametersSchema. </summary>
        public IntegrationAccountMapPropertiesParametersSchema()
        {
        }

        /// <summary> Initializes a new instance of IntegrationAccountMapPropertiesParametersSchema. </summary>
        /// <param name="ref">
        /// The reference name.
        /// Serialized Name: IntegrationAccountMapPropertiesParametersSchema.ref
        /// </param>
        internal IntegrationAccountMapPropertiesParametersSchema(string @ref)
        {
            Ref = @ref;
        }

        /// <summary>
        /// The reference name.
        /// Serialized Name: IntegrationAccountMapPropertiesParametersSchema.ref
        /// </summary>
        public string Ref { get; set; }
    }
}
