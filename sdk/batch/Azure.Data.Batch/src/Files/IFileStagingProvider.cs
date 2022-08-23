// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Data.Batch.Models
{
    public interface IFileStagingProvider
    {
        IEnumerable<ResourceFile> StagedFiles { get; }
        void Validate();
        IFileStagingArtifact CreateStagingArtifact();
    }
}
