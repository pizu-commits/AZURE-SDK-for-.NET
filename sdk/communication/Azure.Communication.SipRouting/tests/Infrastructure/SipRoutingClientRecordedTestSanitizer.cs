﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.RegularExpressions;
using Azure.Communication.Pipeline;

namespace Azure.Communication.SipRouting.Tests.Infrastructure
{
    public class SipRoutingClientRecordedTestSanitizer : CommunicationRecordedTestSanitizer
    {
        public override string SanitizeUri(string uri)
        {
            return Regex.Replace(uri, "https://([^/?])*.communication", "https://sanitized.communication");
        }
    }
}
