// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using System.Linq;

    /// <summary>
    /// Defines reference to NSG.
    /// </summary>
    public partial class NsgReference : AzureResourceReference
    {
        /// <summary>
        /// Initializes a new instance of the NsgReference class.
        /// </summary>
        public NsgReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NsgReference class.
        /// </summary>
        /// <param name="sourceArmResourceId">Gets the ARM resource ID of the
        /// tracked resource being referenced.</param>
        public NsgReference(string sourceArmResourceId)
            : base(sourceArmResourceId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
