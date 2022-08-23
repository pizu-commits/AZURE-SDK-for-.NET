// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Data.Batch.Models
{
    public interface IFileStagingArtifact
    {
        string NamingFragment { get; set; }
    }
}
