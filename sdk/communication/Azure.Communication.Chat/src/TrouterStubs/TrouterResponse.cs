// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Communication.Chat.TrouterStubs
{
    internal class TrouterResponse
    {
        public Dictionary<string, string> Headers { get; } = new Dictionary<string, string>();
        public int Status { get; set; } = 200;
    }
}
