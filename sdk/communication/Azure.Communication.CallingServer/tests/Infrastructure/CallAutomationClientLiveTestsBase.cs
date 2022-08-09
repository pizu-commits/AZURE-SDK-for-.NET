﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Communication.Identity;
using Azure.Core.TestFramework;
using Azure.Core.TestFramework.Models;

namespace Azure.Communication.CallingServer.Tests.Infrastructure
{
    public class CallAutomationClientLiveTestsBase : RecordedTestBase<CallAutomationClientTestEnvironment>
    {
        private const string URIDomainRegEx = @"https://([^/?]+)";

        public CallAutomationClientLiveTestsBase(bool isAsync) : base(isAsync)
        {
            SanitizedHeaders.Add("x-ms-content-sha256");
            SanitizedHeaders.Add("X-FORWARDED-HOST");
            JsonPathSanitizers.Add("$..id");
            JsonPathSanitizers.Add("$..rawId");
            JsonPathSanitizers.Add("$..value");
            UriRegexSanitizers.Add(new UriRegexSanitizer(URIDomainRegEx, "https://sanitized.skype.com"));
        }

        public bool SkipCallingServerInteractionLiveTests
            => TestEnvironment.Mode == RecordedTestMode.Live && Environment.GetEnvironmentVariable("SKIP_CALLINGSERVER_INTERACTION_LIVE_TESTS") == "TRUE";

        /// <summary>
        /// Creates a <see cref="CallingServerClient" />
        /// </summary>
        /// <returns>The instrumented <see cref="CallingServerClient" />.</returns>
        protected CallAutomationClient CreateInstrumentedCallingServerClientWithConnectionString()
        {
            var connectionString = TestEnvironment.LiveTestStaticConnectionString;

            CallAutomationClient callingServerClient;
            if (TestEnvironment.PMAEndpoint == null || TestEnvironment.PMAEndpoint.Length == 0)
            {
                callingServerClient = new CallAutomationClient(connectionString, CreateServerCallingClientOptionsWithCorrelationVectorLogs());
            }
            else
            {
                callingServerClient = new CallAutomationClient(new Uri(TestEnvironment.PMAEndpoint), connectionString, CreateServerCallingClientOptionsWithCorrelationVectorLogs());
            }

            return InstrumentClient(callingServerClient);
        }

        /// <summary>
        /// Creates a <see cref="CallingServerClientOptions" />
        /// </summary>
        /// <returns>The instrumented <see cref="CallingServerClientOptions" />.</returns>
        private CallAutomationClientOptions CreateServerCallingClientOptionsWithCorrelationVectorLogs()
        {
            CallAutomationClientOptions callClientOptions = new CallAutomationClientOptions();
            callClientOptions.Diagnostics.LoggedHeaderNames.Add("MS-CV");
            return InstrumentClientOptions(callClientOptions);
        }

        protected async Task WaitForOperationCompletion(int milliSeconds = 10000)
        {
            if (TestEnvironment.Mode != RecordedTestMode.Playback)
                await Task.Delay(milliSeconds);
        }

        protected string GetResourceId()
        {
            return TestEnvironment.ResourceIdentifier;
        }

        /// <summary>
        /// Creates a <see cref="CommunicationIdentityClient" /> with the connectionstring via environment
        /// variables and instruments it to make use of the Azure Core Test Framework functionalities.
        /// </summary>
        /// <returns>The instrumented <see cref="CommunicationIdentityClient" />.</returns>
        protected CommunicationIdentityClient CreateInstrumentedCommunicationIdentityClient()
            => InstrumentClient(
                new CommunicationIdentityClient(
                    TestEnvironment.LiveTestStaticConnectionString,
                    InstrumentClientOptions(new CommunicationIdentityClientOptions(CommunicationIdentityClientOptions.ServiceVersion.V2021_03_07))));

        protected async Task<CommunicationUserIdentifier> CreateIdentityUserAsync()
        {
            CommunicationIdentityClient communicationIdentityClient = CreateInstrumentedCommunicationIdentityClient();
            return await communicationIdentityClient.CreateUserAsync().ConfigureAwait(false);
        }
    }
}
