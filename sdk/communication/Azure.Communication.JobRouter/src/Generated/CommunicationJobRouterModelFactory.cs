// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> Model factory for models. </summary>
    public static partial class CommunicationJobRouterModelFactory
    {
        /// <summary> Initializes a new instance of Oauth2ClientCredential. </summary>
        /// <param name="clientId"> ClientId for Contoso Authorization server. </param>
        /// <param name="clientSecret"> Client secret for Contoso Authorization server. </param>
        /// <returns> A new <see cref="JobRouter.Oauth2ClientCredential"/> instance for mocking. </returns>
        public static Oauth2ClientCredential Oauth2ClientCredential(string clientId = null, string clientSecret = null)
        {
            return new Oauth2ClientCredential(clientId, clientSecret);
        }

        /// <summary> Initializes a new instance of ScoringRuleOptions. </summary>
        /// <param name="batchSize">
        /// (Optional) Set batch size when AllowScoringBatchOfWorkers is set to true.
        /// Defaults to 20 if not configured.
        /// </param>
        /// <param name="scoringParameters">
        /// (Optional) List of extra parameters from the job that will be sent as part of
        /// the payload to scoring rule.
        /// If not set, the job's labels (sent in the payload
        /// as `job`) and the job's worker selectors (sent in the payload as
        /// `selectors`)
        /// are added to the payload of the scoring rule by default.
        /// Note:
        /// Worker labels are always sent with scoring payload.
        /// </param>
        /// <param name="allowScoringBatchOfWorkers">
        /// (Optional)
        /// If set to true, will score workers in batches, and the parameter
        /// name of the worker labels will be sent as `workers`.
        /// By default, set to false
        /// and the parameter name for the worker labels will be sent as `worker`.
        /// Note: If
        /// enabled, use BatchSize to set batch size.
        /// </param>
        /// <param name="descendingOrder">
        /// (Optional)
        /// If false, will sort scores by ascending order. By default, set to
        /// true.
        /// </param>
        /// <returns> A new <see cref="JobRouter.ScoringRuleOptions"/> instance for mocking. </returns>
        public static ScoringRuleOptions ScoringRuleOptions(int? batchSize = null, IEnumerable<ScoringRuleParameterSelector> scoringParameters = null, bool? allowScoringBatchOfWorkers = null, bool? descendingOrder = null)
        {
            scoringParameters ??= new List<ScoringRuleParameterSelector>();

            return new ScoringRuleOptions(batchSize, scoringParameters?.ToList(), allowScoringBatchOfWorkers, descendingOrder);
        }

        /// <summary> Initializes a new instance of QueueWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="queueSelectors">
        /// A collection of queue selectors that will be applied if this allocation is
        /// selected.
        /// </param>
        /// <returns> A new <see cref="JobRouter.QueueWeightedAllocation"/> instance for mocking. </returns>
        public static QueueWeightedAllocation QueueWeightedAllocation(double weight = default, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new QueueWeightedAllocation(weight, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of WorkerWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="workerSelectors">
        /// A collection of worker selectors that will be applied if this allocation is
        /// selected.
        /// </param>
        /// <returns> A new <see cref="JobRouter.WorkerWeightedAllocation"/> instance for mocking. </returns>
        public static WorkerWeightedAllocation WorkerWeightedAllocation(double weight = default, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new WorkerWeightedAllocation(weight, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of ExceptionRule. </summary>
        /// <param name="trigger">
        /// The trigger for this exception rule
        /// Please note <see cref="ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
        /// </param>
        /// <param name="actions">
        /// A dictionary collection of actions to perform once the exception is triggered.
        /// Key is the Id of each exception action.
        /// Please note <see cref="ExceptionAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CancelExceptionAction"/>, <see cref="ManualReclassifyExceptionAction"/> and <see cref="ReclassifyExceptionAction"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trigger"/> or <paramref name="actions"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.ExceptionRule"/> instance for mocking. </returns>
        public static ExceptionRule ExceptionRule(ExceptionTrigger trigger = null, IDictionary<string, ExceptionAction> actions = null)
        {
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            actions ??= new Dictionary<string, ExceptionAction>();

            return new ExceptionRule(trigger, actions);
        }

        /// <summary> Initializes a new instance of RouterJobAssignment. </summary>
        /// <param name="assignmentId"> The Id of the job assignment. </param>
        /// <param name="workerId"> The Id of the Worker assigned to the job. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <param name="completedAt"> The time the job was marked as completed after being assigned in UTC. </param>
        /// <param name="closedAt"> The time the job was marked as closed after being completed in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobAssignment"/> instance for mocking. </returns>
        public static RouterJobAssignment RouterJobAssignment(string assignmentId = null, string workerId = null, DateTimeOffset assignedAt = default, DateTimeOffset? completedAt = null, DateTimeOffset? closedAt = null)
        {
            return new RouterJobAssignment(assignmentId, workerId, assignedAt, completedAt, closedAt);
        }

        /// <summary> Initializes a new instance of UnassignJobResult. </summary>
        /// <param name="jobId"> The Id of the job unassigned. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new UnassignJobResult(jobId, unassignmentCount);
        }

        /// <summary> Initializes a new instance of AcceptJobOfferResult. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="workerId"> The Id of the worker that has been assigned this job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/>, <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return new AcceptJobOfferResult(assignmentId, jobId, workerId);
        }

        /// <summary> Initializes a new instance of RouterQueueStatistics. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimeMinutes">
        /// The estimated wait time of this queue rounded up to the nearest minute, grouped
        /// by job priority
        /// </param>
        /// <param name="longestJobWaitTimeMinutes"> The wait time of the job that has been enqueued in this queue for the longest. </param>
        /// <returns> A new <see cref="JobRouter.RouterQueueStatistics"/> instance for mocking. </returns>
        public static RouterQueueStatistics RouterQueueStatistics(string queueId = null, int length = default, IReadOnlyDictionary<string, double> estimatedWaitTimeMinutes = null, double? longestJobWaitTimeMinutes = null)
        {
            estimatedWaitTimeMinutes ??= new Dictionary<string, double>();

            return new RouterQueueStatistics(queueId, length, estimatedWaitTimeMinutes, longestJobWaitTimeMinutes);
        }

        /// <summary> Initializes a new instance of ChannelConfiguration. </summary>
        /// <param name="capacityCostPerJob">
        /// The amount of capacity that an instance of a job of this channel will consume
        /// of the total worker capacity.
        /// </param>
        /// <param name="maxNumberOfJobs"> The maximum number of jobs that can be supported concurrently for this channel. </param>
        /// <returns> A new <see cref="JobRouter.ChannelConfiguration"/> instance for mocking. </returns>
        public static ChannelConfiguration ChannelConfiguration(int capacityCostPerJob = default, int? maxNumberOfJobs = null)
        {
            return new ChannelConfiguration(capacityCostPerJob, maxNumberOfJobs);
        }

        /// <summary> Initializes a new instance of RouterJobOffer. </summary>
        /// <param name="offerId"> The Id of the offer. </param>
        /// <param name="jobId"> The Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offeredAt"> The time the offer was created in UTC. </param>
        /// <param name="expiresAt"> The time that the offer will expire in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobOffer"/> instance for mocking. </returns>
        public static RouterJobOffer RouterJobOffer(string offerId = null, string jobId = null, int capacityCost = default, DateTimeOffset? offeredAt = null, DateTimeOffset? expiresAt = null)
        {
            return new RouterJobOffer(offerId, jobId, capacityCost, offeredAt, expiresAt);
        }

        /// <summary> Initializes a new instance of RouterWorkerAssignment. </summary>
        /// <param name="assignmentId"> The Id of the assignment. </param>
        /// <param name="jobId"> The Id of the Job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/> or <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.RouterWorkerAssignment"/> instance for mocking. </returns>
        public static RouterWorkerAssignment RouterWorkerAssignment(string assignmentId = null, string jobId = null, int capacityCost = default, DateTimeOffset assignedAt = default)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt);
        }

        /// <summary> Initializes a new instance of BestWorkerMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors">
        /// (Optional)
        /// If set to true, then router will match workers to jobs even if they
        /// don't match label selectors.
        /// Warning: You may get workers that are not
        /// qualified for the job they are matched with if you set this
        /// variable to true.
        /// This flag is intended more for temporary usage.
        /// By default, set to false.
        /// </param>
        /// <param name="scoringRule">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule
        /// providing static rules that always return the same result, regardless of
        /// input.
        /// DirectMapRule:  A rule that return the same labels as the input
        /// labels.
        /// ExpressionRule: A rule providing inline expression
        /// rules.
        /// FunctionRule: A rule providing a binding to an HTTP Triggered Azure
        /// Function.
        /// WebhookRule: A rule providing a binding to a webserver following
        /// OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="scoringRuleOptions">
        /// Encapsulates all options that can be passed as parameters for scoring rule with
        /// BestWorkerMode
        /// </param>
        /// <returns> A new <see cref="JobRouter.BestWorkerMode"/> instance for mocking. </returns>
        public static BestWorkerMode BestWorkerMode(int minConcurrentOffers = default, int maxConcurrentOffers = default, bool? bypassSelectors = null, RouterRule scoringRule = null, ScoringRuleOptions scoringRuleOptions = null)
        {
            return new BestWorkerMode("best-worker", minConcurrentOffers, maxConcurrentOffers, bypassSelectors, scoringRule, scoringRuleOptions);
        }

        /// <summary> Initializes a new instance of ExpressionRouterRule. </summary>
        /// <param name="language"> The expression language to compile to and execute. </param>
        /// <param name="expression">
        /// The string containing the expression to evaluate. Should contain return
        /// statement with calculated values.
        /// </param>
        /// <returns> A new <see cref="JobRouter.ExpressionRouterRule"/> instance for mocking. </returns>
        public static ExpressionRouterRule ExpressionRouterRule(string language = null, string expression = null)
        {
            return new ExpressionRouterRule("expression-rule", language, expression);
        }

        /// <summary> Initializes a new instance of FunctionRouterRule. </summary>
        /// <param name="functionUri"> URL for Azure Function. </param>
        /// <param name="credential"> Credentials used to access Azure function rule. </param>
        /// <returns> A new <see cref="JobRouter.FunctionRouterRule"/> instance for mocking. </returns>
        public static FunctionRouterRule FunctionRouterRule(Uri functionUri = null, FunctionRouterRuleCredential credential = null)
        {
            return new FunctionRouterRule("azure-function-rule", functionUri, credential);
        }

        /// <summary> Initializes a new instance of WebhookRouterRule. </summary>
        /// <param name="authorizationServerUri"> Uri for Authorization Server. </param>
        /// <param name="clientCredential">
        /// OAuth2.0 Credentials used to Contoso's Authorization server.
        /// Reference:
        /// https://www.oauth.com/oauth2-servers/access-tokens/client-credentials/
        /// </param>
        /// <param name="webhookUri"> Uri for Contoso's Web Server. </param>
        /// <returns> A new <see cref="JobRouter.WebhookRouterRule"/> instance for mocking. </returns>
        public static WebhookRouterRule WebhookRouterRule(Uri authorizationServerUri = null, Oauth2ClientCredential clientCredential = null, Uri webhookUri = null)
        {
            return new WebhookRouterRule("webhook-rule", authorizationServerUri, clientCredential, webhookUri);
        }

        /// <summary> Initializes a new instance of ConditionalQueueSelectorAttachment. </summary>
        /// <param name="condition">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule
        /// providing static rules that always return the same result, regardless of
        /// input.
        /// DirectMapRule:  A rule that return the same labels as the input
        /// labels.
        /// ExpressionRule: A rule providing inline expression
        /// rules.
        /// FunctionRule: A rule providing a binding to an HTTP Triggered Azure
        /// Function.
        /// WebhookRule: A rule providing a binding to a webserver following
        /// OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="queueSelectors"> The queue selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalQueueSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalQueueSelectorAttachment ConditionalQueueSelectorAttachment(RouterRule condition = null, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new ConditionalQueueSelectorAttachment("conditional", condition, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of PassThroughQueueSelectorAttachment. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <returns> A new <see cref="JobRouter.PassThroughQueueSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughQueueSelectorAttachment PassThroughQueueSelectorAttachment(string key = null, LabelOperator labelOperator = default)
        {
            return new PassThroughQueueSelectorAttachment("pass-through", key, labelOperator);
        }

        /// <summary> Initializes a new instance of RuleEngineQueueSelectorAttachment. </summary>
        /// <param name="rule">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule
        /// providing static rules that always return the same result, regardless of
        /// input.
        /// DirectMapRule:  A rule that return the same labels as the input
        /// labels.
        /// ExpressionRule: A rule providing inline expression
        /// rules.
        /// FunctionRule: A rule providing a binding to an HTTP Triggered Azure
        /// Function.
        /// WebhookRule: A rule providing a binding to a webserver following
        /// OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineQueueSelectorAttachment RuleEngineQueueSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineQueueSelectorAttachment("rule-engine", rule);
        }

        /// <summary> Initializes a new instance of StaticQueueSelectorAttachment. </summary>
        /// <param name="queueSelector">
        /// Describes a condition that must be met against a set of labels for queue
        /// selection
        /// </param>
        /// <returns> A new <see cref="JobRouter.StaticQueueSelectorAttachment"/> instance for mocking. </returns>
        public static StaticQueueSelectorAttachment StaticQueueSelectorAttachment(RouterQueueSelector queueSelector = null)
        {
            return new StaticQueueSelectorAttachment("static", queueSelector);
        }

        /// <summary> Initializes a new instance of WeightedAllocationQueueSelectorAttachment. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationQueueSelectorAttachment WeightedAllocationQueueSelectorAttachment(IEnumerable<QueueWeightedAllocation> allocations = null)
        {
            allocations ??= new List<QueueWeightedAllocation>();

            return new WeightedAllocationQueueSelectorAttachment("weighted-allocation-queue-selector", allocations?.ToList());
        }

        /// <summary> Initializes a new instance of ConditionalWorkerSelectorAttachment. </summary>
        /// <param name="condition">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule
        /// providing static rules that always return the same result, regardless of
        /// input.
        /// DirectMapRule:  A rule that return the same labels as the input
        /// labels.
        /// ExpressionRule: A rule providing inline expression
        /// rules.
        /// FunctionRule: A rule providing a binding to an HTTP Triggered Azure
        /// Function.
        /// WebhookRule: A rule providing a binding to a webserver following
        /// OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalWorkerSelectorAttachment ConditionalWorkerSelectorAttachment(RouterRule condition = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ConditionalWorkerSelectorAttachment("conditional", condition, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of RuleEngineWorkerSelectorAttachment. </summary>
        /// <param name="rule">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule
        /// providing static rules that always return the same result, regardless of
        /// input.
        /// DirectMapRule:  A rule that return the same labels as the input
        /// labels.
        /// ExpressionRule: A rule providing inline expression
        /// rules.
        /// FunctionRule: A rule providing a binding to an HTTP Triggered Azure
        /// Function.
        /// WebhookRule: A rule providing a binding to a webserver following
        /// OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineWorkerSelectorAttachment RuleEngineWorkerSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineWorkerSelectorAttachment("rule-engine", rule);
        }

        /// <summary> Initializes a new instance of StaticWorkerSelectorAttachment. </summary>
        /// <param name="workerSelector">
        /// Describes a condition that must be met against a set of labels for worker
        /// selection
        /// </param>
        /// <returns> A new <see cref="JobRouter.StaticWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static StaticWorkerSelectorAttachment StaticWorkerSelectorAttachment(RouterWorkerSelector workerSelector = null)
        {
            return new StaticWorkerSelectorAttachment("static", workerSelector);
        }

        /// <summary> Initializes a new instance of WeightedAllocationWorkerSelectorAttachment. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationWorkerSelectorAttachment WeightedAllocationWorkerSelectorAttachment(IEnumerable<WorkerWeightedAllocation> allocations = null)
        {
            allocations ??= new List<WorkerWeightedAllocation>();

            return new WeightedAllocationWorkerSelectorAttachment("weighted-allocation-worker-selector", allocations?.ToList());
        }

        /// <summary> Initializes a new instance of QueueLengthExceptionTrigger. </summary>
        /// <param name="threshold"> Threshold of number of jobs ahead in the queue to for this trigger to fire. </param>
        /// <returns> A new <see cref="JobRouter.QueueLengthExceptionTrigger"/> instance for mocking. </returns>
        public static QueueLengthExceptionTrigger QueueLengthExceptionTrigger(int threshold = default)
        {
            return new QueueLengthExceptionTrigger("queue-length", threshold);
        }

        /// <summary> Initializes a new instance of ScheduleAndSuspendMode. </summary>
        /// <param name="scheduleAt"> Scheduled time. </param>
        /// <returns> A new <see cref="JobRouter.ScheduleAndSuspendMode"/> instance for mocking. </returns>
        public static ScheduleAndSuspendMode ScheduleAndSuspendMode(DateTimeOffset scheduleAt = default)
        {
            return new ScheduleAndSuspendMode("schedule-and-suspend", scheduleAt);
        }
    }
}
