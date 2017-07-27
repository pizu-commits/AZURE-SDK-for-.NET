// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the properties of a Run Command metadata.
    /// </summary>
    public partial class RunCommandDocumentBase
    {
        /// <summary>
        /// Initializes a new instance of the RunCommandDocumentBase class.
        /// </summary>
        public RunCommandDocumentBase() { }

        /// <summary>
        /// Initializes a new instance of the RunCommandDocumentBase class.
        /// </summary>
        /// <param name="schema">The VM run command schema.</param>
        /// <param name="id">The VM run command id.</param>
        /// <param name="osType">The Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="label">The VM run command label.</param>
        /// <param name="description">The VM run command description.</param>
        public RunCommandDocumentBase(string schema, string id, OperatingSystemTypes osType, string label, string description)
        {
            Schema = schema;
            Id = id;
            OsType = osType;
            Label = label;
            Description = description;
        }

        /// <summary>
        /// Gets or sets the VM run command schema.
        /// </summary>
        [JsonProperty(PropertyName = "$schema")]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the VM run command id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OperatingSystemTypes OsType { get; set; }

        /// <summary>
        /// Gets or sets the VM run command label.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the VM run command description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Schema == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schema");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Label == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Label");
            }
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
        }
    }
}

