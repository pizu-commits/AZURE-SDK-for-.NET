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
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Dns.Tests.Scenario
{
    internal class RecordSetCaaTests : DnsServiceClientTestBase
    {
        private ResourceGroupResource _resourceGroup;
        private DnsZoneResource _dnsZone;
        public RecordSetCaaTests(bool isAsync) : base(isAsync)
        {
        }

        [OneTimeSetUp]
        public async Task OnetimeSetup()
        {
            string rgName = SessionRecording.GenerateAssetName("Dns-RG-");
            var rgLro = await GlobalClient.GetDefaultSubscriptionAsync().Result.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, new ResourceGroupData(AzureLocation.WestUS2));
            _resourceGroup = rgLro.Value;

            // TODO: TestFramework cannot get DnsCollection.Temporary disable global _dnsZone.
            // Create Dns Zone
            //string dnsZoneName = $"{DateTime.Now.ToString("yyyyMMddhhmmss")}.a.com";
            //_dnsZone = await CreateADnsZone(dnsZoneName, _resourceGroup);

            await StopSessionRecordingAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            var list = await _dnsZone.GetRecordSetCaas().GetAllAsync().ToEnumerableAsync();
            foreach (var item in list)
            {
                await item.DeleteAsync(WaitUntil.Completed);
            }
        }

        [Test]
        [Ignore("Castle.DynamicProxy.Generators.GeneratorException")]
        public async Task Create()
        {
            string dnsZoneName = $"{SessionRecording.GenerateAssetName("sample")}.com";
            _dnsZone = await CreateADnsZone(dnsZoneName, _resourceGroup);
            var collection = _dnsZone.GetRecordSetCaas();
            string name = "caa";
            var recordSetCaaResource = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, new CaaRecordSetData() { });
            Assert.IsNotNull(recordSetCaaResource);
            Assert.IsNotNull(recordSetCaaResource.Value.Data.ETag);
            Assert.AreEqual(name, recordSetCaaResource.Value.Data.Name);
            Assert.AreEqual("Succeeded", recordSetCaaResource.Value.Data.ProvisioningState);
            Assert.AreEqual("dnszones/CAA", recordSetCaaResource.Value.Data.ResourceType.Type);
        }

        [Test]
        [Ignore("Castle.DynamicProxy.Generators.GeneratorException")]
        public async Task Delete()
        {
            string dnsZoneName = $"{SessionRecording.GenerateAssetName("sample")}.com";
            _dnsZone = await CreateADnsZone(dnsZoneName, _resourceGroup);
            var collection = _dnsZone.GetRecordSetCaas();
            string name = "caa";
            var recordSetCaaResource = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, new CaaRecordSetData() { });
            Assert.IsTrue(collection.Exists(name));

            await recordSetCaaResource.Value.DeleteAsync(WaitUntil.Completed);
            Assert.IsFalse(collection.Exists(name));
        }

        [Test]
        [Ignore("Castle.DynamicProxy.Generators.GeneratorException")]
        public async Task Exist()
        {
            string dnsZoneName = $"{SessionRecording.GenerateAssetName("sample")}.com";
            _dnsZone = await CreateADnsZone(dnsZoneName, _resourceGroup);
            var collection = _dnsZone.GetRecordSetCaas();
            string name = "caa";
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, new CaaRecordSetData() { });
            Assert.IsTrue(collection.Exists(name));
        }

        [Test]
        [Ignore("Castle.DynamicProxy.Generators.GeneratorException")]
        public async Task Get()
        {
            string dnsZoneName = $"{SessionRecording.GenerateAssetName("sample")}.com";
            _dnsZone = await CreateADnsZone(dnsZoneName, _resourceGroup);
            var collection = _dnsZone.GetRecordSetCaas();
            string name = "caa";
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, new CaaRecordSetData() { });

            var recordSetCaaResource = await collection.GetAsync(name);
            Assert.IsNotNull(recordSetCaaResource);
            Assert.AreEqual(name, recordSetCaaResource.Value.Data.Name);
            Assert.AreEqual("Succeeded", recordSetCaaResource.Value.Data.ProvisioningState);
            Assert.AreEqual("dnszones/CAA", recordSetCaaResource.Value.Data.ResourceType.Type);
            Assert.AreEqual(300, recordSetCaaResource.Value.Data.TtlInSeconds);
        }

        [Test]
        [Ignore("Castle.DynamicProxy.Generators.GeneratorException")]
        public async Task GetAll()
        {
            string dnsZoneName = $"{SessionRecording.GenerateAssetName("sample")}.com";
            _dnsZone = await CreateADnsZone(dnsZoneName, _resourceGroup);
            var collection = _dnsZone.GetRecordSetCaas();
            string name = "caa";
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, new CaaRecordSetData() { });

            var list = await collection.GetAllAsync().ToEnumerableAsync();
            Assert.IsNotNull(list);
            Assert.AreEqual(name, list.FirstOrDefault().Data.Name);
        }
    }
}
