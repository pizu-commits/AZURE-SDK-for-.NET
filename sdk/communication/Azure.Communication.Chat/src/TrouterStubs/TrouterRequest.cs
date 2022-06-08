// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Communication.Chat.TrouterStubs
{
    internal class TrouterRequest
    {
        public string Method { get; }
        public string Path { get; }
        public Dictionary<string, string> Headers { get; }
        public string Body { get; }
    }
}
