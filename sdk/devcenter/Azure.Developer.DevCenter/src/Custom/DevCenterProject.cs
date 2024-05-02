// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevCenterProject
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterProject"/>. </summary>
        /// <param name="name"> Name of the project. </param>
        /// <param name="description"> Description of the project. </param>
        /// <param name="maxDevBoxesPerUser">
        /// When specified, indicates the maximum number of Dev Boxes a single user can
        /// create across all pools in the project.
        /// </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DevCenterProject(string name, string description, int? maxDevBoxesPerUser)
        {
            Name = name;
            Description = description;
            MaxDevBoxesPerUser = maxDevBoxesPerUser;
        }
    }
}
