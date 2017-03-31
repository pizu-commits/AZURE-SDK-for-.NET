// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using System.Collections.Generic;

    internal partial class SrvRecordSetsImpl 
    {
        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <return>List of resources.</return>
        IEnumerable<Microsoft.Azure.Management.Dns.Fluent.ISrvRecordSet> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.Dns.Fluent.ISrvRecordSet>.List()
        {
            return this.List();
        }

        IDnsZone IHasParent<IDnsZone>.Parent
        {
            get
            {
                return Parent();
            }
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name within the current resource group.
        /// </summary>
        /// <param name="name">The name of the resource. (Note, this is not the resource ID.).</param>
        /// <return>An immutable representation of the resource.</return>
        Microsoft.Azure.Management.Dns.Fluent.ISrvRecordSet Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByName<Microsoft.Azure.Management.Dns.Fluent.ISrvRecordSet>.GetByName(string name)
        {
            return this.GetByName(name) as Microsoft.Azure.Management.Dns.Fluent.ISrvRecordSet;
        }
    }
}