﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using System.ComponentModel;
using System;

namespace Azure.ResourceManager.ManagedServiceIdentities.Models
{
    public partial class IdentityAssociatedResourceData : Azure.ResourceManager.Models.ResourceData
    {
        [Obsolete("This method is obsolete and will be removed in a future release", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal IdentityAssociatedResourceData() { }
        public string ResourceGroup { get { throw null; } }
        public string SubscriptionDisplayName { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore CA1822 // Mark members as static
