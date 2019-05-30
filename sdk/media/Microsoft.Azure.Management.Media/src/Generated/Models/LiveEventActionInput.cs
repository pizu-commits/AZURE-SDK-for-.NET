// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The LiveEvent action input parameter definition.
    /// </summary>
    public partial class LiveEventActionInput
    {
        /// <summary>
        /// Initializes a new instance of the LiveEventActionInput class.
        /// </summary>
        public LiveEventActionInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LiveEventActionInput class.
        /// </summary>
        /// <param name="removeOutputsOnStop">The flag indicates if remove
        /// LiveOutputs on Stop.</param>
        public LiveEventActionInput(bool? removeOutputsOnStop = default(bool?))
        {
            RemoveOutputsOnStop = removeOutputsOnStop;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the flag indicates if remove LiveOutputs on Stop.
        /// </summary>
        [JsonProperty(PropertyName = "removeOutputsOnStop")]
        public bool? RemoveOutputsOnStop { get; set; }

    }
}
