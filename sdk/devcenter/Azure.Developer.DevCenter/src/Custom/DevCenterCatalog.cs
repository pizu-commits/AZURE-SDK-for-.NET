// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevCenterCatalog
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterCatalog"/>. </summary>
        /// <param name="name"> Name of the catalog. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DevCenterCatalog(string name)
        {
            Name = name;
        }
    }
}
