// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Data.Batch.Models.Files
{
    public class SimpleFileStagingProvider : IFileStagingProvider
    {
        public IEnumerable<ResourceFile> StagedFiles => new List<ResourceFile>();

        public IFileStagingArtifact CreateStagingArtifact()
        {
            return new SimpleStagingArtifact();
        }

        public void Validate()
        {
        }
    }
}
