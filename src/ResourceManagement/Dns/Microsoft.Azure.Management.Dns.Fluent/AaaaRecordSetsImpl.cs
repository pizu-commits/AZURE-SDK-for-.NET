// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent
{
    using ResourceManager.Fluent.Core;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation of AaaaRecordSets.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmRucy5pbXBsZW1lbnRhdGlvbi5BYWFhUmVjb3JkU2V0c0ltcGw=
    internal partial class AaaaRecordSetsImpl  :
        ReadableWrappers<IAaaaRecordSet,AaaaRecordSetImpl,RecordSetInner>,
        IAaaaRecordSets
    {
        private DnsZoneImpl dnsZone;
        private const RecordType AaaaRecordType = RecordType.AAAA;

        public async Task<IAaaaRecordSet> GetByNameAsync(string name, CancellationToken cancellationToken)
        {
            RecordSetInner inner = await dnsZone.Manager.Inner.RecordSets.GetAsync(
                dnsZone.ResourceGroupName,
                dnsZone.Name,
                name,
                AaaaRecordType,
                cancellationToken);
            return new AaaaRecordSetImpl(dnsZone, inner);
        }

        private DnsZoneImpl Parent()
        {
            return dnsZone;
        }

        ///GENMHASH:5C58E472AE184041661005E7B2D7EE30:10EBCE64285B15A348EA16D2076F49EE
        public IAaaaRecordSet GetByName(string name)
        {
            return GetByNameAsync(name, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        ///GENMHASH:DA1A37E97601F129EF3AF921419B0A9C:93DD647D9AB0DB30D017785882D88829
        internal  AaaaRecordSetsImpl(DnsZoneImpl dnsZone)
        {
            this.dnsZone = dnsZone;
        }

        ///GENMHASH:7D6013E8B95E991005ED921F493EFCE4:E0A75605560E78B8C503E86A302DCB32
        public IEnumerable<IAaaaRecordSet> List()
        {
            return WrapList(dnsZone.Manager.Inner.RecordSets
                .ListByType(dnsZone.ResourceGroupName,dnsZone.Name, AaaaRecordType)
                .AsContinuousCollection(link => dnsZone.Manager.Inner.RecordSets.ListByTypeNext(link)));
        }

        ///GENMHASH:A65D7F670CB73E56248FA5B252060BCD:583D2C6D497AA58FD8B23595EF66DCF0
        protected override IAaaaRecordSet WrapModel(RecordSetInner inner)
        {
            return new AaaaRecordSetImpl(dnsZone, inner);
        }

        public async Task<IPagedCollection<IAaaaRecordSet>> ListAsync(bool loadAllPages = true, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await PagedCollection<IAaaaRecordSet, RecordSetInner>.LoadPage(
                async (cancellation) => await dnsZone.Manager.Inner.RecordSets.ListByTypeAsync(dnsZone.ResourceGroupName, dnsZone.Name, AaaaRecordType, cancellationToken: cancellationToken),
                dnsZone.Manager.Inner.RecordSets.ListByTypeNextAsync,
                WrapModel, loadAllPages, cancellationToken);
        }
    }
}
