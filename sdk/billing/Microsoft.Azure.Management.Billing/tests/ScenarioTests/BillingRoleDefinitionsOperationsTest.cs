﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Billing.Tests.Helpers;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Net;
using Xunit;
using Microsoft.Azure.Management.Billing;
using Microsoft.Azure.Test.HttpRecorder;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Billing.Tests.ScenarioTests
{
    public class BillingRoleDefinitionsOperationsTest : TestBase
    {
        private const string BillingAccountName = "723c8ce0-33ba-5ba7-ef23-e1b72f15f1d8:4ce5b530-c82b-44e8-97ec-49f3cce9f14d_2019-05-31";
        private const string BillingAccountRoleDefinitionName = "50000000-aaaa-bbbb-cccc-100000000000_5c4fad53-9cfb-4e22-9635-e7f420ab3ca7";
        private const string BillingProfileName = "H6RI-TXWC-BG7-PGB";
        private const string BillingProfileRoleDefinitionName = "40000000-aaaa-bbbb-cccc-100000000000_5c4fad53-9cfb-4e22-9635-e7f420ab3ca7";
        private const string InvoiceSectionName = "ICYS-ZE5B-PJA-PGB";
        private const string InvoiceSectionRoleDefinitionName = "30000000-aaaa-bbbb-cccc-100000000000_5c4fad53-9cfb-4e22-9635-e7f420ab3ca7";

        [Fact]
        public void GetBillingRoleDefinitionByBillingAccountTest()
        {
            var something = typeof(Billing.Tests.ScenarioTests.OperationsTests);
            string executingAssemblyPath = something.GetTypeInfo().Assembly.Location;
            HttpMockServer.RecordsDirectory = Path.Combine(Path.GetDirectoryName(executingAssemblyPath), "SessionRecords");

            using (MockContext context = MockContext.Start(this.GetType()))
            {
                // Create client
                var billingMgmtClient = BillingTestUtilities.GetBillingManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // Get the billing role Definition
                var billingRoleDefinition = billingMgmtClient.BillingRoleDefinitions.GetByBillingAccount(BillingAccountName, BillingAccountRoleDefinitionName);

                // Verify the response
                Assert.NotNull(billingRoleDefinition);
                Assert.Equal(BillingAccountRoleDefinitionName, billingRoleDefinition.Name);
            }
        }

        [Fact]
        public void GetBillingRoleDefinitionByBillingProfileTest()
        {
            var something = typeof(Billing.Tests.ScenarioTests.OperationsTests);
            string executingAssemblyPath = something.GetTypeInfo().Assembly.Location;
            HttpMockServer.RecordsDirectory = Path.Combine(Path.GetDirectoryName(executingAssemblyPath), "SessionRecords");

            using (MockContext context = MockContext.Start(this.GetType()))
            {
                // Create client
                var billingMgmtClient = BillingTestUtilities.GetBillingManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // Get the billing role Definition
                var billingRoleDefinition = billingMgmtClient.BillingRoleDefinitions.GetByBillingProfile(BillingAccountName, BillingProfileName, BillingProfileRoleDefinitionName);

                // Verify the response
                Assert.NotNull(billingRoleDefinition);
                Assert.Equal(BillingProfileRoleDefinitionName, billingRoleDefinition.Name);
            }
        }

        [Fact]
        public void GetBillingRoleDefinitionByInvoiceSectionTest()
        {
            var something = typeof(Billing.Tests.ScenarioTests.OperationsTests);
            string executingAssemblyPath = something.GetTypeInfo().Assembly.Location;
            HttpMockServer.RecordsDirectory = Path.Combine(Path.GetDirectoryName(executingAssemblyPath), "SessionRecords");

            using (MockContext context = MockContext.Start(this.GetType()))
            {
                // Create client
                var billingMgmtClient = BillingTestUtilities.GetBillingManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // Get the billing role Definition
                var billingRoleDefinition = billingMgmtClient.BillingRoleDefinitions.GetByInvoiceSection(BillingAccountName, BillingProfileName, InvoiceSectionName, InvoiceSectionRoleDefinitionName);

                // Verify the response
                Assert.NotNull(billingRoleDefinition);
                Assert.Equal(InvoiceSectionRoleDefinitionName, billingRoleDefinition.Name);
            }
        }

        [Fact]
        public void ListBillingRoleDefinitionsByBillingAccountTest()
        {
            var something = typeof(Billing.Tests.ScenarioTests.OperationsTests);
            string executingAssemblyPath = something.GetTypeInfo().Assembly.Location;
            HttpMockServer.RecordsDirectory = Path.Combine(Path.GetDirectoryName(executingAssemblyPath), "SessionRecords");

            using (MockContext context = MockContext.Start(this.GetType()))
            {
                // Create client
                var billingMgmtClient = BillingTestUtilities.GetBillingManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // Get the billing role Definitions
                var billingRoleDefinitions = billingMgmtClient.BillingRoleDefinitions.ListByBillingAccount(BillingAccountName);

                // Verify the response
                //Assert.NotNull(billingRoleDefinitions);
                //Assert.True(billingRoleDefinitions.Value.Count > 0);
               // Assert.Contains(billingRoleDefinitions.Value, role => role.Name == BillingAccountRoleDefinitionName);
            }
        }

        [Fact]
        public void ListBillingRoleDefinitionsByBillingProfileTest()
        {
            var something = typeof(Billing.Tests.ScenarioTests.OperationsTests);
            string executingAssemblyPath = something.GetTypeInfo().Assembly.Location;
            HttpMockServer.RecordsDirectory = Path.Combine(Path.GetDirectoryName(executingAssemblyPath), "SessionRecords");

            using (MockContext context = MockContext.Start(this.GetType()))
            {
                // Create client
                var billingMgmtClient = BillingTestUtilities.GetBillingManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // Get the billing role Definitions
                var billingRoleDefinitions = billingMgmtClient.BillingRoleDefinitions.ListByBillingProfile(BillingAccountName, BillingProfileName);

                // Verify the response
                Assert.NotNull(billingRoleDefinitions);
                Assert.True(billingRoleDefinitions.Value.Count > 0);
                //Assert.Contains(billingRoleDefinitions.Value, role => role.Name == BillingProfileRoleDefinitionName);
            }
        }

        [Fact]
        public void ListBillingRoleDefinitionsByInvoiceSectionTest()
        {
            var something = typeof(Billing.Tests.ScenarioTests.OperationsTests);
            string executingAssemblyPath = something.GetTypeInfo().Assembly.Location;
            HttpMockServer.RecordsDirectory = Path.Combine(Path.GetDirectoryName(executingAssemblyPath), "SessionRecords");

            using (MockContext context = MockContext.Start(this.GetType()))
            {
                // Create client
                var billingMgmtClient = BillingTestUtilities.GetBillingManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // Get the billing role Definitions
                var billingRoleDefinitions = billingMgmtClient.BillingRoleDefinitions.ListByInvoiceSection(BillingAccountName, BillingProfileName, InvoiceSectionName);

                // Verify the response
                Assert.NotNull(billingRoleDefinitions);
                Assert.True(billingRoleDefinitions.Value.Count > 0);
                //Assert.Contains(billingRoleDefinitions.Value, role => role.Name == InvoiceSectionRoleDefinitionName);
            }
        }
    }
}
