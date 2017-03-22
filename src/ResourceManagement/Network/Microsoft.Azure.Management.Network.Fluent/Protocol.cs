﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    public class Protocol : ExpandableStringEnum<Protocol>
    {
        public static readonly Protocol TCP = Parse("TCP");
        public static readonly Protocol UDP = Parse("UDP");
    }
}
