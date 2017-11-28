// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a script action on role on the cluster.
    /// </summary>
    public partial class ScriptAction
    {
        /// <summary>
        /// Initializes a new instance of the ScriptAction class.
        /// </summary>
        public ScriptAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptAction class.
        /// </summary>
        /// <param name="name">The name of the script action.</param>
        /// <param name="uri">The URI to the script.</param>
        /// <param name="parameters">The parameters for the script
        /// provided.</param>
        public ScriptAction(string name, string uri, string parameters)
        {
            Name = name;
            Uri = uri;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the script action.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URI to the script.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the parameters for the script provided.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public string Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
            if (Parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parameters");
            }
        }
    }
}
