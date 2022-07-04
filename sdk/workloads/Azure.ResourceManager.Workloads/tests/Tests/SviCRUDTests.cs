﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Workloads.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Microsoft.CSharp.RuntimeBinder;
using System.Threading;
using System.Drawing.Design;
using System.Reflection;

namespace Azure.ResourceManager.Workloads.Tests.Tests
{
    public class SviCRUDTests : WorkloadsManagementTestBase
    {
        public SviCRUDTests(bool isAsync) : base(isAsync)
        {  }

        [OneTimeTearDown]
        public void Cleanup()
        {
            CleanupResourceGroups();
        }

        /// <summary>
        /// The Get Ops Extension Status Interval.
        /// </summary>
        private const int GetStatusIntervalinMillis = 10000;

        /// <summary>
        /// The SVI CRUD test that creates and installs
        /// an SVI.
        /// </summary>
        [TestCase]
        [RecordedTest]
        public async Task TestSVICrudOperations()
        {
            string SviName = "F97";
            // Create Test RG
            var resourceGroupName = Recording.GenerateAssetName("SdkRg-SVICrud");
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(
                subscription,
                resourceGroupName,
                AzureLocation.EastUS);

            SapVirtualInstanceData SviCreatePayload = this.GetSingleServerPayloadToPut(rg.Data.Name, false);

            // Create SVI
            try
            {
                ArmOperation<SapVirtualInstanceResource> resource = await rg.GetSapVirtualInstances().CreateOrUpdateAsync(
                    waitUntil: WaitUntil.Completed,
                    sapVirtualInstanceName: SviName,
                    data: SviCreatePayload);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            SapVirtualInstanceData SviInstallPayload = this.GetSingleServerPayloadToPut(rg.Data.Name, true);

            // Install SVI
            try
            {
                ArmOperation<SapVirtualInstanceResource> resource = await rg.GetSapVirtualInstances().CreateOrUpdateAsync(
                    waitUntil: WaitUntil.Completed,
                    sapVirtualInstanceName: SviName,
                    data: SviInstallPayload);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            var sviObject1 = await rg.GetSapVirtualInstanceAsync(SviName);

            // Delete RG
            await rg.DeleteAsync(WaitUntil.Completed);
        }

        [TestCase]
        [RecordedTest]
        public async Task TestSVIStartStopOperations()
        {
            string sviName = "E61";
            string rgName = "svi-loop-test-register-30Jun-avzone-44";

            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            var lro = await subscription.GetResourceGroups().GetAsync(rgName);
            ResourceGroupResource rg = lro.Value;

            // Stop operation
            var sviObject1 = await lro.Value.GetSapVirtualInstanceAsync(sviName);
            await sviObject1.Value.StopAsync(WaitUntil.Completed);
            var sviObjectstatus = await lro.Value.GetSapVirtualInstanceAsync(sviName);
            Assert.AreEqual(sviObjectstatus.Value.Data.Status, SapVirtualInstanceStatus.Offline);

            // Start operation
            await sviObject1.Value.StartAsync(WaitUntil.Completed);
            sviObjectstatus = await lro.Value.GetSapVirtualInstanceAsync(sviName);
            Assert.AreEqual(sviObjectstatus.Value.Data.Status, SapVirtualInstanceStatus.Running);
        }

        [TestCase]
        [RecordedTest]
        public async Task TestSVIPatchCall()
        {
            string sviName = "B83";
            string rgName = "svi-loop-test-register-02Jul-singleserver-88";
            string subID = "49d64d54-e966-4c46-a868-1999802b762c";

            ResourceIdentifier SviResourceID = SapVirtualInstanceResource.CreateResourceIdentifier(subID, rgName, sviName);
            ResourceIdentifier AppServerResourceID =
                SapApplicationServerInstanceResource.CreateResourceIdentifier(subID, rgName, sviName, "app0");
            ResourceIdentifier DbServerResourceID =
                SapDatabaseInstanceResource.CreateResourceIdentifier(subID, rgName, sviName, "db0");
            ResourceIdentifier CsServerResourceID =
                SapCentralServerInstanceResource.CreateResourceIdentifier(subID, rgName, sviName, "cs0");

            SapVirtualInstanceResource sapVirtualInstance = await Client.GetSapVirtualInstanceResource(SviResourceID).GetAsync();
            SapDatabaseInstanceResource sapDatabaseInstanceResource =
                await Client.GetSapDatabaseInstanceResource(DbServerResourceID).GetAsync();
            SapApplicationServerInstanceResource sapApplicationServerInstanceResource =
                await Client.GetSapApplicationServerInstanceResource(AppServerResourceID).GetAsync();
            SapCentralServerInstanceResource sapCentralServerInstanceResource =
                await Client.GetSapCentralServerInstanceResource(CsServerResourceID).GetAsync();

            // Patch call for SVI and child resources
            await sapVirtualInstance.AddTagAsync("TestKey1", "TestValue1");
            await sapApplicationServerInstanceResource.AddTagAsync("TestKey1", "TestValue1");
            await sapCentralServerInstanceResource.AddTagAsync("TestKey1", "TestValue1");
            await sapDatabaseInstanceResource.AddTagAsync("TestKey1", "TestValue1");

            Thread.Sleep(GetStatusIntervalinMillis);

            sapVirtualInstance =
                await Client.GetSapVirtualInstanceResource(SviResourceID).GetAsync();
            sapDatabaseInstanceResource =
                await Client.GetSapDatabaseInstanceResource(DbServerResourceID).GetAsync();
            sapApplicationServerInstanceResource =
                await Client.GetSapApplicationServerInstanceResource(AppServerResourceID).GetAsync();
            sapCentralServerInstanceResource =
                await Client.GetSapCentralServerInstanceResource(CsServerResourceID).GetAsync();

            var firsttag = sapVirtualInstance.Data.Tags.Values.GetEnumerator();
            firsttag.MoveNext();
            Assert.AreEqual(firsttag.Current, "TestValue1");

            firsttag = sapDatabaseInstanceResource.Data.Tags.Values.GetEnumerator();
            firsttag.MoveNext();
            Assert.AreEqual(firsttag.Current, "TestValue1");
            await sapDatabaseInstanceResource.GetTagResource().DeleteAsync(WaitUntil.Completed);

            firsttag = sapCentralServerInstanceResource.Data.Tags.Values.GetEnumerator();
            firsttag.MoveNext();
            Assert.AreEqual(firsttag.Current, "TestValue1");
            await sapCentralServerInstanceResource.GetTagResource().DeleteAsync(WaitUntil.Completed);

            firsttag = sapApplicationServerInstanceResource.Data.Tags.Values.GetEnumerator();
            firsttag.MoveNext();
            Assert.AreEqual(firsttag.Current, "TestValue1");
            await sapApplicationServerInstanceResource.GetTagResource().DeleteAsync(WaitUntil.Completed);
        }

        /// <summary>
        /// Gets an object of SAP Workload Resource for Single Server that should be used for PUT call.
        /// </summary>
        /// <param name="infraRgName"> Contains the infra RG
        /// used as app resource group. </param>
        /// <returns>PHP Workload Resource.</returns>
        private SapVirtualInstanceData GetSingleServerPayloadToPut(string infraRgName, bool isInstall)
        {
            string sshPrivateKey = File.ReadAllText(Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SshKeyPrivate.txt"));

            string sshPublicKey = File.ReadAllText(Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SshKeyPublic.txt"));

            if (isInstall)
            {
                var testSapWorkloadJson = File.ReadAllText(Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SingleServerInstall.json"));

                dynamic DynamicObject = JsonConvert.DeserializeObject<dynamic>(testSapWorkloadJson);

                DynamicObject.properties.configuration.infrastructureConfiguration.appResourceGroup =
                    infraRgName;
                DynamicObject.properties.configuration.infrastructureConfiguration.
                    virtualMachineConfiguration.osProfile.osConfiguration.ssh.publicKeys[0].keyData =
                        sshPublicKey;
                DynamicObject.properties.configuration.softwareConfiguration.sshPrivateKey =
                    sshPrivateKey;

                var sapPayloadJson = JsonDocument.Parse(JsonConvert.SerializeObject(DynamicObject)).RootElement;

                SapVirtualInstanceData testSapWorkload = SapVirtualInstanceData.DeserializeSapVirtualInstanceData(
                    sapPayloadJson);

                return testSapWorkload;
            }
            else
            {
                var testSapWorkloadJson = File.ReadAllText(Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SingleServerCreate.json"));

                dynamic DynamicObject = JsonConvert.DeserializeObject<dynamic>(testSapWorkloadJson);

                DynamicObject.properties.configuration.infrastructureConfiguration.appResourceGroup =
                    infraRgName;
                DynamicObject.properties.configuration.infrastructureConfiguration.
                    virtualMachineConfiguration.osProfile.osConfiguration.ssh.publicKeys[0].keyData =
                        sshPublicKey;

                var sapPayloadJson = JsonDocument.Parse(JsonConvert.SerializeObject(DynamicObject)).RootElement;

                SapVirtualInstanceData testSapWorkload = SapVirtualInstanceData.DeserializeSapVirtualInstanceData(
                    sapPayloadJson);

                return testSapWorkload;
            }
        }
    }
}
