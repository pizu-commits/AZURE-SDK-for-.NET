// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Long run operation status of governance rule over a given scope
    /// </summary>
    public partial class OperationResult1
    {
        /// <summary>
        /// Initializes a new instance of the OperationResult1 class.
        /// </summary>
        public OperationResult1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationResult1 class.
        /// </summary>
        /// <param name="status">The status of the long run operation result of
        /// governance rule. Possible values include: 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        public OperationResult1(string status = default(string))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status of the long run operation result of governance
        /// rule. Possible values include: 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}
