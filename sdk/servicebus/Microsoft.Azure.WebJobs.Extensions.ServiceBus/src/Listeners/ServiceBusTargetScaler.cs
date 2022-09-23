// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.Azure.WebJobs.ServiceBus.Listeners;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Listeners
{
    internal class ServiceBusTargetScaler : ITargetScaler
    {
        private readonly string _functionId;
        private readonly string _entityPath;
        private readonly ServiceBusMetricsReceiver _serviceBusMetricsReceiver;
        private readonly ServiceBusOptions _options;
        private readonly bool _isSessionsEnabled;
        private readonly TargetScalerDescriptor _targetScalerDescriptor;

        public ServiceBusTargetScaler(string functionId, string entityPath, ServiceBusMetricsReceiver serviceBusMetricsReceiver, ServiceBusOptions options, bool isSessionsEnabled)
        {
            _functionId = functionId;
            _entityPath = entityPath;
            _serviceBusMetricsReceiver = serviceBusMetricsReceiver;
            _options = options;
            _isSessionsEnabled = isSessionsEnabled;
            _targetScalerDescriptor = new TargetScalerDescriptor($"{_functionId}-ServiceBusTrigger-{_entityPath}".ToLower(CultureInfo.InvariantCulture), functionId);
        }

        public TargetScalerDescriptor TargetScalerDescriptor => _targetScalerDescriptor;

        public async Task<TargetScalerResult> GetScaleResultAsync(TargetScaleStatusContext context)
        {
            ServiceBusTriggerMetrics metrics = await _serviceBusMetricsReceiver.GetMetricsAsync().ConfigureAwait(false);
            return GetScaleResultInternal(context, metrics);
        }

        internal TargetScalerResult GetScaleResultInternal(TargetScaleStatusContext context, ServiceBusTriggerMetrics metrics)
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

            return new TargetScalerResult
            {
                WorkerCountDifference = (int)Math.Ceiling((metrics.MessageCount - context.WorkerCount * concurrency) / (decimal)concurrency)
            };
        }
    }
}
