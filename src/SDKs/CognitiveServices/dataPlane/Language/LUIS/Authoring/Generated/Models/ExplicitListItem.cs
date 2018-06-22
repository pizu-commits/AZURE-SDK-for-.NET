// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Explicit list item
    /// </summary>
    public partial class ExplicitListItem
    {
        /// <summary>
        /// Initializes a new instance of the ExplicitListItem class.
        /// </summary>
        public ExplicitListItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExplicitListItem class.
        /// </summary>
        /// <param name="id">The explicit list item ID.</param>
        /// <param name="explicitListItemProperty">The explicit list item
        /// value.</param>
        public ExplicitListItem(long? id = default(long?), string explicitListItemProperty = default(string))
        {
            Id = id;
            ExplicitListItemProperty = explicitListItemProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the explicit list item ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets the explicit list item value.
        /// </summary>
        [JsonProperty(PropertyName = "explicitListItem")]
        public string ExplicitListItemProperty { get; set; }

    }
}
