// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An parameter that the script will accept
    /// </summary>
    public partial class ScriptParameter
    {
        /// <summary>
        /// Initializes a new instance of the ScriptParameter class.
        /// </summary>
        public ScriptParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptParameter class.
        /// </summary>
        /// <param name="type">The type of parameter the script is expecting.
        /// psCredential is a PSCredentialObject. Possible values include:
        /// 'String', 'SecureString', 'Credential', 'Int', 'Bool',
        /// 'Float'</param>
        /// <param name="name">The parameter name that the script will expect a
        /// parameter value for</param>
        /// <param name="description">User friendly description of the
        /// parameter</param>
        /// <param name="visibility">Should this parameter be visible to arm
        /// and passed in the parameters argument when executing. Possible
        /// values include: 'Visible', 'Hidden'</param>
        /// <param name="optional">Is this parameter required or optional.
        /// Possible values include: 'Optional', 'Required'</param>
        public ScriptParameter(string type = default(string), string name = default(string), string description = default(string), string visibility = default(string), string optional = default(string))
        {
            Type = type;
            Name = name;
            Description = description;
            Visibility = visibility;
            Optional = optional;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of parameter the script is expecting. psCredential is
        /// a PSCredentialObject. Possible values include: 'String',
        /// 'SecureString', 'Credential', 'Int', 'Bool', 'Float'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the parameter name that the script will expect a
        /// parameter value for
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets user friendly description of the parameter
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets should this parameter be visible to arm and passed in the
        /// parameters argument when executing. Possible values include:
        /// 'Visible', 'Hidden'
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public string Visibility { get; private set; }

        /// <summary>
        /// Gets is this parameter required or optional. Possible values
        /// include: 'Optional', 'Required'
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public string Optional { get; private set; }

    }
}
