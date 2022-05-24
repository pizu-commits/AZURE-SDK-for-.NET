﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Models;
using Azure.Communication.JobRouter.Tests.Infrastructure;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.Samples
{
    public class Sample2_ClassificationWithQueueSelectorAsync : SamplesBase<RouterTestEnvironment>
    {
        [Test]
        public async Task QueueSelection_ById()
        {
            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_QueueSelectionById
            // In this scenario we are going to use a classification policy while submitting a job.
            // We are going to utilize the 'QueueSelectors' attribute on the classification policy to determine
            // which queue a job should be enqueued in. For this scenario, we are going to demonstrate
            // StaticLabelSelector to select a queue directly by its unique ID through the classification policy
            // Steps
            // 1. Create 2 Queues - Queue1(For Office 365 related jobs), Queue2(For XBox related jobs)
            // 2. Create 2 classification policies - CP1(For Office 365 related jobs), CP2(For XBox related jobs)
            // 3. Create 2 jobs - Job1 (with CP1), Job2 (with CP2)
            //
            // Output:
            // 1. Job1 is enqueued in Queue1
            // 2. Job2 is enqueued in Queue2

#if !SNIPPET
            var routerClient = new RouterClient(Environment.GetEnvironmentVariable("AZURE_COMMUNICATION_SERVICE_CONNECTION_STRING"));
#endif
            var distributionPolicy = await routerClient.SetDistributionPolicyAsync(
                id: "distribution-policy-id-2",
                name: "My LongestIdle Distribution Policy",
                offerTtlSeconds: 30,
                mode: new LongestIdleMode()
                );

            var queue1 = await routerClient.SetQueueAsync(
                id: "Queue-1",
                name: "Queue_365",
                distributionPolicyId: distributionPolicy.Value.Id);

            var queue2 = await routerClient.SetQueueAsync(
                id: "Queue-2",
                name: "Queue_XBox",
                distributionPolicyId: distributionPolicy.Value.Id);

            var cp1QueueLabelAttachments = new List<QueueSelectorAttachment>()
            {
                new StaticQueueSelector(new QueueSelector("Id", LabelOperator.Equal, queue1.Value.Id))
            };
            var cp1 = await routerClient.SetClassificationPolicyAsync(
                id: "classification-policy-o365",
                name: "Classification_Policy_O365",
                queueSelectors: cp1QueueLabelAttachments);

            var cp2QueueLabelAttachments = new List<QueueSelectorAttachment>()
            {
                new StaticQueueSelector(new QueueSelector("Id", LabelOperator.Equal, queue2.Value.Id))
            };
            var cp2 = await routerClient.SetClassificationPolicyAsync(
                id: "classification-policy-xbox",
                name: "Classification_Policy_XBox",
                queueSelectors: cp2QueueLabelAttachments);

            var jobO365 = await routerClient.SetJobWithClassificationPolicyAsync(
                id: "jobO365",
                channelId: "general",
                classificationPolicyId: cp1.Value.Id,
                channelReference: "12345");

            var jobXbox = await routerClient.SetJobWithClassificationPolicyAsync(
                id: "jobXbox",
                channelId: "general",
                classificationPolicyId: cp2.Value.Id,
                channelReference: "12345");

#if !SNIPPET
            bool condition = false;
            var startTime = DateTimeOffset.UtcNow;
            var maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                var jobO365Dto = await routerClient.GetJobAsync(jobO365.Value.Id);
                var jobXBoxDto = await routerClient.GetJobAsync(jobXbox.Value.Id);
                condition = jobO365Dto.Value.JobStatus == JobStatus.Queued &&
                            jobXBoxDto.Value.JobStatus == JobStatus.Queued;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            var jobO365Result = await routerClient.GetJobAsync(jobO365.Value.Id);
            var jobXBoxResult = await routerClient.GetJobAsync(jobXbox.Value.Id);

            Console.WriteLine($"O365 job has been enqueued in queue: {queue1.Value.Id}. Status: {jobO365Result.Value.QueueId == queue1.Value.Id}");
            Console.WriteLine($"XBox job has been enqueued in queue: {queue2.Value.Id}. Status: {jobXBoxResult.Value.QueueId == queue2.Value.Id}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_QueueSelectionById

        }

        [Test]
        public async Task QueueSelection_ByCondition()
        {
            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_QueueSelectionByConditionalLabelAttachments
            // In this scenario we are going to use a classification policy while submitting a job.
            // We are going to utilize the 'QueueSelectors' attribute on the classification policy to determine
            // which queue a job should be enqueued in. For this scenario, we are going to demonstrate
            // ConditionalLabelSelector to select a queue based on labels associated with a queue
            // Steps
            // 1. Create 2 Queues
            //     - Queue1(For Office 365 related jobs) - with label {ProductDetail = 'Office_Support'},
            //     - Queue2(For XBox related jobs) - with label {ProductDetail = 'XBox_Support'},
            // 2. Create 1 classification policy
            //    - Set condition: If job.Product == O365, then attach label {ProductDetail = 'Office_Support'}
            //                     Else if job.Product == XBx, then attach labels {ProductDetail = 'XBox_Support'}
            // 3. Create 2 jobs
            //     - Job1 - with label {Product = 'O365'}
            //     - Job2 - with labels {Product = 'XBx'}
            //
            // Output:
            // 1. Job1 is enqueued in Queue1
            // 2. Job2 is enqueued in Queue2

#if !SNIPPET
            var routerClient = new RouterClient(Environment.GetEnvironmentVariable("AZURE_COMMUNICATION_SERVICE_CONNECTION_STRING"));
#endif
            var distributionPolicy = await routerClient.SetDistributionPolicyAsync(
                id: "distribution-policy-id-3",
                name: "My LongestIdle Distribution Policy",
                offerTtlSeconds: 30,
                mode: new LongestIdleMode()
                );

            var queue1 = await routerClient.SetQueueAsync(
                id: "Queue-1",
                name: "Queue_365",
                distributionPolicyId: distributionPolicy.Value.Id,
                labels: new LabelCollection()
                {
                    ["ProductDetail"] = "Office_Support"
                });

            var queue2 = await routerClient.SetQueueAsync(
                id: "Queue-2",
                name: "Queue_XBox",
                distributionPolicyId: distributionPolicy.Value.Id,
                labels: new LabelCollection()
                {
                    ["ProductDetail"] = "XBox_Support"
                });

            var queueSelectorAttachments = new List<QueueSelectorAttachment>()
            {
                new ConditionalQueueSelector(
                    condition: new ExpressionRule("If(job.Product = \"O365\", true, false)"),
                    labelSelectors: new List<QueueSelector>()
                    {
                        new QueueSelector("ProductDetail", LabelOperator.Equal, "Office_Support")
                    }),
                new ConditionalQueueSelector(
                    condition: new ExpressionRule("If(job.Product = \"XBx\", true, false)"),
                    labelSelectors: new List<QueueSelector>()
                    {
                        new QueueSelector("ProductDetail", LabelOperator.Equal, "XBox_Support")
                    })
            };

            var classificationPolicy = await routerClient.SetClassificationPolicyAsync(
                id: "classification-policy",
                name: "Classification_Policy_O365_And_XBox",
                queueSelectors: queueSelectorAttachments
                );

            var jobO365 = await routerClient.SetJobWithClassificationPolicyAsync(
                id: "jobO365",
                channelId: "general",
                classificationPolicyId: classificationPolicy.Value.Id,
                channelReference: "12345",
                labels: new LabelCollection()
                {
                    ["Language"] = "en",
                    ["Product"] = "O365",
                    ["Geo"] = "North America",
                });

            var jobXbox = await routerClient.SetJobWithClassificationPolicyAsync(
                id: "jobXbox",
                channelId: "general",
                classificationPolicyId: classificationPolicy.Value.Id,
                channelReference: "12345",
                labels: new LabelCollection()
                {
                    ["Language"] = "en",
                    ["Product"] = "XBx",
                    ["Geo"] = "North America",
                });

#if !SNIPPET
            bool condition = false;
            var startTime = DateTimeOffset.UtcNow;
            var maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                var jobO365Dto = await routerClient.GetJobAsync(jobO365.Value.Id);
                var jobXBoxDto = await routerClient.GetJobAsync(jobXbox.Value.Id);
                condition = jobO365Dto.Value.JobStatus == JobStatus.Queued &&
                            jobXBoxDto.Value.JobStatus == JobStatus.Queued;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            var jobO365Result = await routerClient.GetJobAsync(jobO365.Value.Id);
            var jobXBoxResult = await routerClient.GetJobAsync(jobXbox.Value.Id);

            Console.WriteLine($"O365 job has been enqueued in queue: {queue1.Value.Id}. Status: {jobO365Result.Value.QueueId == queue1.Value.Id}");
            Console.WriteLine($"XBox job has been enqueued in queue: {queue2.Value.Id}. Status: {jobXBoxResult.Value.QueueId == queue2.Value.Id}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_QueueSelectionByConditionalLabelAttachments
        }

        [Test]
        public async Task QueueSelection_ByPassThroughValues()
        {
            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_QueueSelectionByPassThroughLabelAttachments
            // In this scenario we are going to use a classification policy while submitting a job.
            // We are going to utilize the 'QueueSelectors' attribute on the classification policy to determine
            // which queue a job should be enqueued in. For this scenario, we are going to demonstrate
            // PassThroughLabelSelector to select a queue based on labels associated with a queue and the incoming job
            // Steps
            // 1. Create 3 Queues
            //     - Queue1(For Office 365 related jobs - EN - EMEA) - with labels {ProductDetail = 'Office_Support', Language = 'en', Region = 'EMEA'},
            //     - Queue2(For Office 365 related jobs - FR - EMEA) - with labels {ProductDetail = 'Office_Support', Language = 'fr', Region = 'EMEA'},
            //     - Queue3(For Office 365 related jobs - EN - NA) - with labels {ProductDetail = 'Office_Support', Language = 'en', Region = 'NA'},
            // 2. Create 1 classification policy
            //    - Set condition: Pass through the following properties from job: ProductDetail, Language, Region
            // 3. Create 3 jobs
            //     - Job1 - with labels {Product = 'O365', ProductDetail = 'Office_Support', Language = 'en', Region = 'EMEA'}
            //     - Job2 - with labels {Product = 'O365', ProductDetail = 'Office_Support', Language = 'fr', Region = 'EMEA'}
            //     - Job3 - with labels {Product = 'O365', ProductDetail = 'Office_Support', Language = 'en', Region = 'NA'}
            //
            // Output:
            // 1. Job1 is enqueued in Queue1
            // 2. Job2 is enqueued in Queue2
            // 3. Job3 is enqueued in Queue3

#if !SNIPPET
            var routerClient = new RouterClient(Environment.GetEnvironmentVariable("AZURE_COMMUNICATION_SERVICE_CONNECTION_STRING"));
#endif
            var distributionPolicy = await routerClient.SetDistributionPolicyAsync(
                id: "distribution-policy-id-3",
                name: "My LongestIdle Distribution Policy",
                offerTtlSeconds: 30,
                mode: new LongestIdleMode()
                );

            var queue1 = await routerClient.SetQueueAsync(
                id: "Queue-1",
                name: "Queue_365_EN_EMEA",
                distributionPolicyId: distributionPolicy.Value.Id,
                labels: new LabelCollection()
                {
                    ["ProductDetail"] = "Office_Support",
                    ["Language"] = "en",
                    ["Region"] = "EMEA",
                });

            var queue2 = await routerClient.SetQueueAsync(
                id: "Queue-2",
                name: "Queue_365_FR_EMEA",
                distributionPolicyId: distributionPolicy.Value.Id,
                labels: new LabelCollection()
                {
                    ["ProductDetail"] = "Office_Support",
                    ["Language"] = "fr",
                    ["Region"] = "EMEA",
                });

            var queue3 = await routerClient.SetQueueAsync(
                id: "Queue-3",
                name: "Queue_365_EN_NA",
                distributionPolicyId: distributionPolicy.Value.Id,
                labels: new LabelCollection()
                {
                    ["ProductDetail"] = "Office_Support",
                    ["Language"] = "en",
                    ["Region"] = "NA",
                });

            var queueSelectorAttachments = new List<QueueSelectorAttachment>()
            {
                new PassThroughQueueSelector("ProductDetail", LabelOperator.Equal),
                new PassThroughQueueSelector("Language", LabelOperator.Equal),
                new PassThroughQueueSelector("Region", LabelOperator.Equal),
            };

            var classificationPolicy = await routerClient.SetClassificationPolicyAsync(
                id: "classification-policy",
                name: "Classification_Policy_O365_EMEA_NA",
                queueSelectors: queueSelectorAttachments
                );

            var jobENEmea = await routerClient.SetJobWithClassificationPolicyAsync(
                id: "jobENEmea",
                channelId: "general",
                classificationPolicyId: classificationPolicy.Value.Id,
                channelReference: "12345",
                labels: new LabelCollection()
                {
                    ["Language"] = "en",
                    ["Product"] = "O365",
                    ["Geo"] = "Europe, Middle East, Africa",
                    ["ProductDetail"] = "Office_Support",
                    ["Region"] = "EMEA",
                });

            var jobFREmea = await routerClient.SetJobWithClassificationPolicyAsync(
                id: "jobFREmea",
                channelId: "general",
                classificationPolicyId: classificationPolicy.Value.Id,
                channelReference: "12345",
                labels: new LabelCollection()
                {
                    ["Language"] = "fr",
                    ["Product"] = "O365",
                    ["Geo"] = "Europe, Middle East, Africa",
                    ["ProductDetail"] = "Office_Support",
                    ["Region"] = "EMEA",
                });

            var jobENNa = await routerClient.SetJobWithClassificationPolicyAsync(
                id: "jobENNa",
                channelId: "general",
                classificationPolicyId: classificationPolicy.Value.Id,
                channelReference: "12345",
                labels: new LabelCollection()
                {
                    ["Language"] = "en",
                    ["Product"] = "O365",
                    ["Geo"] = "North America",
                    ["ProductDetail"] = "Office_Support",
                    ["Region"] = "NA",
                });

#if !SNIPPET
            bool condition = false;
            var startTime = DateTimeOffset.UtcNow;
            var maxWaitTime = TimeSpan.FromSeconds(10);
            while (!condition && DateTimeOffset.UtcNow.Subtract(startTime) <= maxWaitTime)
            {
                var jobEnEmeaDto = await routerClient.GetJobAsync(jobENEmea.Value.Id);
                var jobFrEmeaDto = await routerClient.GetJobAsync(jobFREmea.Value.Id);
                var jobEnNaDto = await routerClient.GetJobAsync(jobENNa.Value.Id);
                condition = jobEnEmeaDto.Value.JobStatus == JobStatus.Queued &&
                            jobFrEmeaDto.Value.JobStatus == JobStatus.Queued &&
                            jobEnNaDto.Value.JobStatus == JobStatus.Queued;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
#endif

            var jobENEmeaResult = await routerClient.GetJobAsync(jobENEmea.Value.Id);
            var jobFREmeaResult = await routerClient.GetJobAsync(jobFREmea.Value.Id);
            var jobENNaResult = await routerClient.GetJobAsync(jobENNa.Value.Id);

            Console.WriteLine($"O365 EN EMEA job has been enqueued in queue: {queue1.Value.Id}. Status: {jobENEmeaResult.Value.QueueId == queue1.Value.Id}");
            Console.WriteLine($"O365 FR EMEA job has been enqueued in queue: {queue2.Value.Id}. Status: {jobFREmeaResult.Value.QueueId == queue2.Value.Id}");
            Console.WriteLine($"O365 EN NA job has been enqueued in queue: {queue3.Value.Id}. Status: {jobENEmeaResult.Value.QueueId == queue3.Value.Id}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Classification_QueueSelectionByPassThroughLabelAttachments
        }

        // TODO
        /*[Test]
        public async Task QueueSelection_ByRuleEngineLabels()
        {
            throw new NotImplementedException();
        }*/
    }
}
