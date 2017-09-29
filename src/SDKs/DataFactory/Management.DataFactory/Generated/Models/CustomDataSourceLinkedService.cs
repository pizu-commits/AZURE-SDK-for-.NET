// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Custom linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("CustomDataSource")]
    public partial class CustomDataSourceLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the CustomDataSourceLinkedService
        /// class.
        /// </summary>
        public CustomDataSourceLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDataSourceLinkedService
        /// class.
        /// </summary>
        /// <param name="typeProperties">Custom linked service
        /// properties.</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        public CustomDataSourceLinkedService(object typeProperties, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string))
            : base(connectVia, description)
        {
            TypeProperties = typeProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets custom linked service properties.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties")]
        public object TypeProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (TypeProperties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeProperties");
            }
        }
    }
}
