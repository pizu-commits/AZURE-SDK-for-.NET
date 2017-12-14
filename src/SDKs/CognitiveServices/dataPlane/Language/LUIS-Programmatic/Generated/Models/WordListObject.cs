// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sublist of items for a Closed list.
    /// </summary>
    public partial class WordListObject
    {
        /// <summary>
        /// Initializes a new instance of the WordListObject class.
        /// </summary>
        public WordListObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WordListObject class.
        /// </summary>
        /// <param name="canonicalForm">The standard form that the list
        /// represents.</param>
        /// <param name="list">List of synonym words.</param>
        public WordListObject(string canonicalForm = default(string), IList<string> list = default(IList<string>))
        {
            CanonicalForm = canonicalForm;
            List = list;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the standard form that the list represents.
        /// </summary>
        [JsonProperty(PropertyName = "canonicalForm")]
        public string CanonicalForm { get; set; }

        /// <summary>
        /// Gets or sets list of synonym words.
        /// </summary>
        [JsonProperty(PropertyName = "list")]
        public IList<string> List { get; set; }

    }
}
