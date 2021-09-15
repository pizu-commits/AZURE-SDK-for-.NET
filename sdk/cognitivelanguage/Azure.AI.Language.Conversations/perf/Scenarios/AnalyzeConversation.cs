﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Azure.AI.Language.Conversations.Models;
using Azure.AI.Language.Conversations.Perf.Infrastructure;
using Azure.Test.Perf;
using CommandLine;

namespace Azure.AI.Language.Conversations.Perf.Scenarios
{
    public class AnalyzeConversation : AnalysisScenarioBase<AnalyzeConversation.ConversationAnalysisClient>
    {
        public AnalyzeConversation(ConversationAnalysisClient options) : base(options)
        {
        }

        public override void Run(CancellationToken cancellationToken)
        {
            AnalyzeConversationOptions options = new("We'll have 2 plates of seared salmon nigiri.");
            Client.AnalyzeConversation(TestEnvironment.ProjectName, options);
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            AnalyzeConversationOptions options = new("We'll have 2 plates of seared salmon nigiri.");
            await Client.AnalyzeConversationAsync(TestEnvironment.ProjectName, options);
        }

        public class ConversationAnalysisClient : PerfOptions
        {
            // TODO: Replace with actual options.
            [Option("delay", Default = 100, HelpText = "Delay between gets (milliseconds)")]
            public int Delay { get; set; }
        }
    }
}
