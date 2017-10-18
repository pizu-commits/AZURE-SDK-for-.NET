// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base class for all control activities like IfCondition, ForEach ,
    /// Until.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Container")]
    public partial class ControlActivity : Activity
    {
        /// <summary>
        /// Initializes a new instance of the ControlActivity class.
        /// </summary>
        public ControlActivity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ControlActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        public ControlActivity(string name, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>))
            : base(name, description, dependsOn)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
