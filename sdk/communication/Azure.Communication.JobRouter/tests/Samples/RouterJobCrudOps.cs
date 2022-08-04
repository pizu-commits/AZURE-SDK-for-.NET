﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Tests.Infrastructure;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.Samples
{
    public class RouterJobCrudOps : SamplesBase<RouterTestEnvironment>
    {
        [Test]
        public void RouterCrudOps()
        {
#if !SNIPPET
            // create a client
            var routerClient = new RouterClient(Environment.GetEnvironmentVariable("AZURE_COMMUNICATION_SERVICE_CONNECTION_STRING"));
            var routerAdministrationClient = new RouterAdministrationClient(Environment.GetEnvironmentVariable("AZURE_COMMUNICATION_SERVICE_CONNECTION_STRING"));
#endif
            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CreateRouterJob
            // We need to create a distribution policy + queue as a pre-requisite to start creating job
            // We are going to create a distribution policy with a simple longest idle distribution mode
            var distributionPolicy =
                routerAdministrationClient.CreateDistributionPolicy(new CreateDistributionPolicyOptions("distribution-policy-id", TimeSpan.FromMinutes(5), new LongestIdleMode()));

            var jobQueue = routerAdministrationClient.CreateQueue(new CreateQueueOptions("job-queue-id", distributionPolicy.Value.Id));

            var jobId = "router-job-id";

            var job = routerClient.CreateJob(
                options: new CreateJobOptions(
                    jobId: jobId,
                    channelId: "general",
                    queueId: jobQueue.Value.Id)
                {
                    Priority = 10,
                    ChannelReference = "12345",
                });

            Console.WriteLine($"Job has been successfully created with status: {job.Value.JobStatus}"); // "Queued"

            // Alternatively, a job can also be created while specifying a classification policy
            // As a pre-requisite, we would need to create a classification policy first
            var classificationPolicy = routerAdministrationClient.CreateClassificationPolicy(
                new CreateClassificationPolicyOptions("classification-policy-id")
                {
                    QueueSelectors = new List<QueueSelectorAttachment>()
                    {
                        new StaticQueueSelectorAttachment(new QueueSelector("Id", LabelOperator.Equal,
                            new LabelValue(jobQueue.Value.Id))),
                    },
                    PrioritizationRule = new StaticRule(new LabelValue(10))
                });

            var jobWithCpId = "job-with-cp-id";

            var jobWithCp = routerClient.CreateJob(
                options: new CreateJobWithClassificationPolicyOptions(
                        jobId: jobWithCpId,
                        channelId: "general",
                        classificationPolicyId: classificationPolicy.Value.Id)  // this is optional
                {
                    ChannelReference = "12345",
                });

            Console.WriteLine($"Job has been successfully created with status: {jobWithCp.Value.JobStatus}"); // "PendingClassification"

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CreateRouterJob

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetRouterJob

            var queriedJob = routerClient.GetJob(jobId);

            Console.WriteLine($"Successfully retrieved job with id: {queriedJob.Value.Id}"); // "router-job-id"

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetRouterJob

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetRouterJobPosition

            var jobPositionDetails = routerClient.GetQueuePosition(jobId);

            Console.WriteLine($"Job position for id `{jobPositionDetails.Value.JobId}` successfully retrieved. JobPosition: {jobPositionDetails.Value.Position}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetRouterJobPosition

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_UpdateRouterJob

            var updatedJob = routerClient.UpdateJob(
                options: new UpdateJobOptions(jobId: jobId)
                {
                    // one or more job properties can be updated
                    ChannelReference = "45678",
                });

            Console.WriteLine($"Job has been successfully updated. Current value of channelReference: {updatedJob.Value.ChannelReference}"); // "45678"

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_UpdateRouterJob

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_ReclassifyRouterJob

            var reclassifyJob = routerClient.ReclassifyJob(jobWithCpId);

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_ReclassifyRouterJob

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_AcceptJobOffer

            // in order for the jobs to be router to a worker, we would need to create a worker with the appropriate queue and channel association
            var worker = routerClient.CreateWorker(
                options: new CreateWorkerOptions(
                    workerId: "router-worker-id",
                    totalCapacity: 100)
                {
                    AvailableForOffers = true, // if a worker is not registered, no offer will be issued
                    ChannelConfigurations =
                        new Dictionary<string, ChannelConfiguration>()
                        {
                            ["general"] = new ChannelConfiguration(100),
                        },
                    QueueIds = new Dictionary<string, QueueAssignment>()
                    {
                        [jobQueue.Value.Id] = new QueueAssignment(),
                    },
                });

            // now that we have a registered worker, we can expect offer to be sent to the worker
            // this is an asynchronous process, so we might need to wait for a while

            while (routerClient.GetWorker(worker.Value.Id).Value.Offers.All(offer => offer.JobId != jobId))
            {
                Task.Delay(TimeSpan.FromSeconds(1));
            }

            var queriedWorker = routerClient.GetWorker(worker.Value.Id);

            var issuedOffer = queriedWorker.Value.Offers.First(offer => offer.JobId == jobId);

            Console.WriteLine($"Worker has been successfully issued to worker with offerId: {issuedOffer.Id} and offer expiry time: {issuedOffer.ExpiryTimeUtc}");

            // now we accept the offer

            var acceptedJobOffer = routerClient.AcceptJobOffer(worker.Value.Id, issuedOffer.Id);

            // job has been assigned to the worker

            queriedJob = routerClient.GetJob(jobId);

            Console.WriteLine($"Job has been successfully assigned to worker. Current job status: {queriedJob.Value.JobStatus}"); // "Assigned"
            Console.WriteLine($"Job has been successfully assigned with a worker with assignment id: {acceptedJobOffer.Value.AssignmentId}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_AcceptJobOffer

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_DeclineJobOffer

            // A worker can also choose to decline an offer

            var declineOffer = routerClient.DeclineJobOffer(worker.Value.Id, issuedOffer.Id);

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_DeclineJobOffer

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CompleteRouterJob

            // Once a worker completes the job, it needs to mark the job as completed

            var completedJobResult = routerClient.CompleteJob(new CompleteJobOptions(jobId, acceptedJobOffer.Value.AssignmentId));

            queriedJob = routerClient.GetJob(jobId);
            Console.WriteLine($"Job has been successfully completed. Current status: {queriedJob.Value.JobStatus}"); // "Completed"

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CompleteRouterJob

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CloseRouterJob

            var closeJobResult = routerClient.CloseJob(new CloseJobOptions(jobId, acceptedJobOffer.Value.AssignmentId));

            queriedJob = routerClient.GetJob(jobId);
            Console.WriteLine($"Job has been successfully closed. Current status: {queriedJob.Value.JobStatus}"); // "Closed"

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CloseRouterJob

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetRouterJobs

            var routerJobs = routerClient.GetJobs();
            foreach (var asPage in routerJobs.AsPages(pageSizeHint: 10))
            {
                foreach (var _job in asPage.Values)
                {
                    Console.WriteLine($"Listing router job with id: {_job.RouterJob.Id}");
                }
            }

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetRouterJobs

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_DeleteRouterJob

            _ = routerClient.DeleteJob(jobId);

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_DeleteRouterJob
        }
    }
}
