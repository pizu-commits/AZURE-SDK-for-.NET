﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.ResourceManager.Dns.Tests.Helpers;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Dns.Tests.Scenario
{
    internal class RecordSetSoaTests : DnsCutomizeTestBase //: DnsServiceClientTestBase
    {
        private ResourceGroupResource _resourceGroup;
        private DnsZoneResource _dnsZone;

        [OneTimeSetUp]
        public async Task OnetimeSetup()
        {
            #region TODO: When we solve the [Castle.DynamicProxy.Generators.GeneratorException], should uncomment this region and delete other code of OnetimeSetup
            //string rgName = SessionRecording.GenerateAssetName("Dns-RG-");
            //var rgLro = await GlobalClient.GetDefaultSubscriptionAsync().Result.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, new ResourceGroupData(AzureLocation.WestUS2));
            //_resourceGroup = rgLro.Value;

            //// Create Dns Zone
            //string dnsZoneName = $"{DateTime.Now.ToString("yyyyMMddhhmmss")}.a.com";
            //_dnsZone = await CreateADnsZone(dnsZoneName, _resourceGroup);

            //await StopSessionRecordingAsync();
            #endregion
            string rgName = GenerateAssetName("Dns-RG-");
            _resourceGroup = await CreateAResourceGroup(rgName);
            _dnsZone = await CreateADnsZone(_resourceGroup);
        }

        [Test]
        public async Task Exist()
        {
            bool result = await _dnsZone.GetRecordSetSoas().ExistsAsync("@");
            Assert.IsTrue(result);
        }

        [Test]
        public async Task Get()
        {
            var recordSetSoaResource = await _dnsZone.GetRecordSetSoas().GetAsync("@");
            Assert.IsNotNull(recordSetSoaResource);
            Assert.AreEqual("@", recordSetSoaResource.Value.Data.Name);
            Assert.AreEqual("Succeeded", recordSetSoaResource.Value.Data.ProvisioningState);
            Assert.AreEqual("dnszones/SOA", recordSetSoaResource.Value.Data.ResourceType.Type);
        }

        [Test]
        public async Task GetAll()
        {
            var list = await _dnsZone.GetRecordSetSoas().GetAllAsync().ToEnumerableAsync();
            Assert.IsNotNull(list);
            Assert.AreEqual("@", list.FirstOrDefault().Data.Name);
        }
    }
}
