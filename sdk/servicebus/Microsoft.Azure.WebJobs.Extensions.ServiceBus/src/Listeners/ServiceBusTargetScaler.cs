// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Messaging.ServiceBus;
using Azure.Messaging.ServiceBus.Administration;
using Microsoft.Azure.WebJobs.Extensions.ServiceBus.Config;
using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.Azure.WebJobs.ServiceBus.Listeners;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Listeners
{
    public class ServiceBusTargetScaler : ITargetScaler
    {
        private readonly string _functionId;
        private readonly ServiceBusMetricsProvider _serviceBusMetricsProvider;
        private readonly ServiceBusOptions _options;
        private readonly bool _isSessionsEnabled;
        private readonly TargetScalerDescriptor _targetScalerDescriptor;
        private readonly string _entityPath;
        private readonly ILogger _logger;

        public ServiceBusTargetScaler(
            string functionId,
            string entityPath,
            ServiceBusEntityType entityType,
            Lazy<ServiceBusReceiver> receiver,
            Lazy<ServiceBusAdministrationClient> administrationClient,
            ServiceBusOptions options,
            bool isSessionsEnabled,
            ILoggerFactory loggerFactory
            )
        {
            _functionId = functionId;
            _serviceBusMetricsProvider = new ServiceBusMetricsProvider(entityPath, entityType, receiver, administrationClient, loggerFactory);
            _entityPath = entityPath;
            _targetScalerDescriptor = new TargetScalerDescriptor(functionId)
            {
                ConfigurationKeyName = "servicebusqueue_targetbasedscale"
            };
            _logger = loggerFactory.CreateLogger<ServiceBusTargetScaler>();
            _options = options;
            _isSessionsEnabled = isSessionsEnabled;
        }

        public TargetScalerDescriptor TargetScalerDescriptor => _targetScalerDescriptor;

        public async Task<TargetScalerResult> GetScaleResultAsync(TargetScalerContext context)
        {
            ServiceBusTriggerMetrics metrics = await _serviceBusMetricsProvider.GetMetricsAsync(true).ConfigureAwait(false);
            return GetScaleResultInternal(context, metrics.MessageCount);
        }

        internal TargetScalerResult GetScaleResultInternal(TargetScalerContext context, long messageCount)
        {
            int concurrency;
            if (!context.InstanceConcurrency.HasValue)
            {
                if (_isSessionsEnabled)
                {
                    concurrency = _options.MaxConcurrentSessions;
                }
                else
                {
                    concurrency = _options.MaxConcurrentCalls;
                }
            }
            else
            {
                concurrency = context.InstanceConcurrency.Value;
            }

            int targetWorkerCount = (int)Math.Ceiling(messageCount / (decimal)concurrency);
            _logger.LogInformation($"'Target worker count for function '{_functionId}' is '{targetWorkerCount}' (EntityPath='{_entityPath}', MessageCount ='{messageCount}', Concurrecny='{concurrency}').");

            return new TargetScalerResult
            {
                TargetWorkerCount = targetWorkerCount
            };
        }
    }
}
