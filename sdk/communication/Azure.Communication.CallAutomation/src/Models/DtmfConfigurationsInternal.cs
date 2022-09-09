// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    [CodeGenModel("DtmfConfigurations")]
    internal partial class DtmfConfigurationsInternal
    {
        [CodeGenMember("StopTones")]
        public IList<Tone> StopTones { get; set; }
    }
}
