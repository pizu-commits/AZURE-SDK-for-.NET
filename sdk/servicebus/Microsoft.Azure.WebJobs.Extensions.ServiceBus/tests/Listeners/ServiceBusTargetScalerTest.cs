// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Messaging.ServiceBus;
using Microsoft.Azure.WebJobs.Extensions.ServiceBus.Listeners;
using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.Azure.WebJobs.ServiceBus.Listeners;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Tests.Listeners
{
    public class ServiceBusTargetScalerTest
    {
        [TestCase(100, false, null, 2, 4)]
        [TestCase(100, true, null, 2, 2)]
        [TestCase(100, false, 19, 8, -2)]
        public void ServiceBusTargetScaler_Returns_Expected(int messageCount, bool isSessionEnabled, int? concurrecny, int workerCount, int expected)
        {
            ServiceBusOptions options = new ServiceBusOptions
            {
                MaxConcurrentCalls = 19,
                MaxConcurrentSessions = 29
            };

            ServiceBusTriggerMetrics metrics = new ServiceBusTriggerMetrics()
            {
                MessageCount = messageCount
            };

            TargetScaleStatusContext context = new TargetScaleStatusContext
            {
                InstanceConcurrency = concurrecny,
                WorkerCount = workerCount
            };

            ServiceBusTargetScaler targetScaler = new ServiceBusTargetScaler("functionId", "entityPath", null, options, isSessionEnabled);
            TargetScalerResult result = targetScaler.GetScaleResultInternal(context, metrics);

            Assert.AreEqual(result.WorkerCountDifference, expected);
        }
    }
}
