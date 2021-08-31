// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource quota limit value.
    /// </summary>
    public partial class LimitObject
    {
        /// <summary>
        /// Initializes a new instance of the LimitObject class.
        /// </summary>
        public LimitObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LimitObject class.
        /// </summary>
        /// <param name="value">The quota/limit value</param>
        /// <param name="limitObjectType">Possible values include:
        /// 'LimitValue'</param>
        /// <param name="limitType">Possible values include: 'Independent',
        /// 'Shared'</param>
        public LimitObject(int value, string limitObjectType = default(string), string limitType = default(string))
        {
            Value = value;
            LimitObjectType = limitObjectType;
            LimitType = limitType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the quota/limit value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'LimitValue'
        /// </summary>
        [JsonProperty(PropertyName = "limitObjectType")]
        public string LimitObjectType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Independent', 'Shared'
        /// </summary>
        [JsonProperty(PropertyName = "limitType")]
        public string LimitType { get; set; }

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
