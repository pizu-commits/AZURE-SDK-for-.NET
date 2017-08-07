// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 message filter for odata query.
    /// </summary>
    public partial class X12MessageFilter
    {
        /// <summary>
        /// Initializes a new instance of the X12MessageFilter class.
        /// </summary>
        public X12MessageFilter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12MessageFilter class.
        /// </summary>
        /// <param name="messageFilterType">The message filter type. Possible
        /// values include: 'NotSpecified', 'Include', 'Exclude'</param>
        public X12MessageFilter(MessageFilterType messageFilterType)
        {
            MessageFilterType = messageFilterType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the message filter type. Possible values include:
        /// 'NotSpecified', 'Include', 'Exclude'
        /// </summary>
        [JsonProperty(PropertyName = "messageFilterType")]
        public MessageFilterType MessageFilterType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
