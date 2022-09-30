// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs.Extensions.ServiceBus.Listeners;
using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Azure.WebJobs.Host.TestCommon;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Tests.Listeners
{
    public class ServiceBusTargetScalerTests
    {
        private ILoggerFactory _loggerFactory;
        private TestLoggerProvider _loggerProvider;

        [SetUp]
        public void Setup()
        {
            _loggerFactory = new LoggerFactory();
            _loggerProvider = new TestLoggerProvider();
            _loggerFactory.AddProvider(_loggerProvider);
        }

        [TestCase(100, false, null, 6)]
        [TestCase(100, true, null,  4)]
        [TestCase(100, false, 19, 6)]
        public void ServiceBusTargetScaler_Returns_Expected(int messageCount, bool isSessionEnabled, int? concurrecny,int expected)
        {
            ServiceBusOptions options = new ServiceBusOptions
            {
                MaxConcurrentCalls = 19,
                MaxConcurrentSessions = 29
            };

            TargetScalerContext context = new TargetScalerContext
            {
                InstanceConcurrency = concurrecny
            };

            _loggerFactory = new LoggerFactory();
            _loggerProvider = new TestLoggerProvider();
            _loggerFactory.AddProvider(_loggerProvider);

            ServiceBusTargetScaler targetScaler = new ServiceBusTargetScaler(
                "functionId",
                "entityPath",
                ServiceBusEntityType.Queue,
                null,
                null,
                options,
                isSessionEnabled,
                _loggerFactory
                );
            TargetScalerResult result = targetScaler.GetScaleResultInternal(context, messageCount);

            Assert.AreEqual(result.TargetWorkerCount, expected);
        }
    }
}
