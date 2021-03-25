﻿using System;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using Azure.Core.Pipeline;
using System.Threading;
using Azure.Core.TestFramework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.Core.Tests
{
    public class ClientContextTests : ResourceManagerTestBase
    {
        public ClientContextTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task TestClientContextPolicy()
        {
            AzureResourceManagerClientOptions options1 = new AzureResourceManagerClientOptions();
            var dummyPolicy1 = new dummyPolicy();
            var dummyPolicy2 = new dummyPolicy2();
            options1.AddPolicy(dummyPolicy1, HttpPipelinePosition.PerCall);
            var client1 = GetArmClient(options1);
            
            Console.WriteLine("-----Client 1-----");
            await foreach (var sub in client1.GetSubscriptionContainer().ListAsync())
            {
                Console.WriteLine($"Found {sub.Data.DisplayName}");
            }
            Assert.AreEqual(dummyPolicy1.numMsgGot, 2);

            //client1.DefaultSubscription.ClientOptions = //set accessor is inaccessible
            client1.DefaultSubscription.ClientOptions.AddPolicy(dummyPolicy2, HttpPipelinePosition.PerCall);

            Assert.AreEqual(dummyPolicy1.numMsgGot, 2);
            Console.WriteLine("\nPASSED\n");
        }

        private class dummyPolicy : HttpPipelineSynchronousPolicy
        {
            public int numMsgGot = 0;

            public override void OnReceivedResponse(HttpMessage message)
            {
                Interlocked.Increment(ref numMsgGot);
            }
        }

        private class dummyPolicy2 : HttpPipelineSynchronousPolicy
        {
            public int numMsgGot = 0;

            public override void OnReceivedResponse(HttpMessage message)
            {
                Interlocked.Add(ref numMsgGot, 2);
            }
        }
    }
}
