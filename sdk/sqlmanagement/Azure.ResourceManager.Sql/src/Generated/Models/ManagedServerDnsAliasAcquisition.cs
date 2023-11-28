// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A managed server DNS alias acquisition request. </summary>
    public partial class ManagedServerDnsAliasAcquisition
    {
        /// <summary> Initializes a new instance of <see cref="ManagedServerDnsAliasAcquisition"/>. </summary>
        /// <param name="oldManagedServerDnsAliasResourceId"> The resource ID of the managed server DNS alias that will be acquired to point to this managed server instead. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="oldManagedServerDnsAliasResourceId"/> is null. </exception>
        public ManagedServerDnsAliasAcquisition(ResourceIdentifier oldManagedServerDnsAliasResourceId)
        {
            Argument.AssertNotNull(oldManagedServerDnsAliasResourceId, nameof(oldManagedServerDnsAliasResourceId));

            OldManagedServerDnsAliasResourceId = oldManagedServerDnsAliasResourceId;
        }

        /// <summary> The resource ID of the managed server DNS alias that will be acquired to point to this managed server instead. </summary>
        public ResourceIdentifier OldManagedServerDnsAliasResourceId { get; }
    }
}
