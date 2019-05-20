// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A2A unprotected disk details.
    /// </summary>
    public partial class A2AUnprotectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AUnprotectedDiskDetails class.
        /// </summary>
        public A2AUnprotectedDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AUnprotectedDiskDetails class.
        /// </summary>
        /// <param name="diskLunId">The source lun Id for the data
        /// disk.</param>
        public A2AUnprotectedDiskDetails(int? diskLunId = default(int?))
        {
            DiskLunId = diskLunId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source lun Id for the data disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskLunId")]
        public int? DiskLunId { get; set; }

    }
}
