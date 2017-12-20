﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Rest;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using ResourceGroups.Tests;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Azure.Management.BotService;
using Microsoft.Azure.Management.BotService.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Xunit;

namespace BotService.Tests.Helpers
{
    public static class BotServiceManagementTestUtilities
    {
        public static bool IsTestTenant = false;
        private static HttpClientHandler Handler = null;

        private const string testSubscription = null;
        private static Uri testUri = null;

        // These are used to create default accounts
        public const string DefaultLocation = "global";
        public const string DefaultSkuName = SkuName.S1;
        public const string DefaultKind = Kind.Sdk;

        public static Dictionary<string, string> DefaultTags = new Dictionary<string, string>
            {
                {"key1","value1"},
                {"key2","value2"}
            };

        public static ResourceManagementClient GetResourceManagementClient(MockContext context, RecordedDelegatingHandler handler)
        {
            if (IsTestTenant)
            {
                return null;
            }
            else
            {
                handler.IsPassThrough = true;
                ResourceManagementClient resourcesClient = context.GetServiceClient<ResourceManagementClient>(handlers: handler);
                return resourcesClient;
            }
        }

        public static AzureBotServiceClient GetBotServiceManagementClient(MockContext context, RecordedDelegatingHandler handler)
        {
            AzureBotServiceClient botClient;
            if (IsTestTenant)
            {
                botClient = new AzureBotServiceClient(new TokenCredentials("xyz"), GetHandler());
                botClient.SubscriptionId = testSubscription;
                botClient.BaseUri = testUri;
            }
            else
            {
                handler.IsPassThrough = true;
                botClient = context.GetServiceClient<AzureBotServiceClient>(handlers: handler);
                botClient.HttpClient.DefaultRequestHeaders.Add("x-ms-client-principal-name", "test@microsoft.com");
            }
            return botClient;
        }

        private static HttpClientHandler GetHandler()
        {
            return Handler;
        }

        public static BotResource CreateDefaultBotResource()
        {
            return new BotResource()
            {
                Kind = DefaultKind,
                Location = DefaultLocation,
                Sku = new Microsoft.Azure.Management.BotService.Models.Sku(DefaultSkuName),
                Tags = DefaultTags,
                Properties = new BotResourceProperties()
                {
                    Description = "Default bot description",
                    DisplayName = "Default bot display name",
                    Endpoint = "https://mybot.coffee",
                    MsaAppId = Guid.NewGuid().ToString()
                }
            };
        }

        public static string CreateResourceGroup(ResourceManagementClient resourcesClient)
        {
            const string testPrefix = "res";
            var rgname = TestUtilities.GenerateName(testPrefix);

            if (!IsTestTenant)
            {
                var resourceGroup = resourcesClient.ResourceGroups.CreateOrUpdate(
                    rgname,
                    new ResourceGroup
                    {
                        Location = "centralus"
                    });
            }

            return rgname;
        }

        public static BotResource CreateAndValidateBot(AzureBotServiceClient botServiceMgmtClient, string rgname, string kind = null)
        {
            string botid = TestUtilities.GenerateName("botservice");

            BotResource resource = CreateDefaultBotResource();

            if (!string.IsNullOrEmpty(kind))
            {
                resource.Kind = kind;
            }
            
            var responseResource =
                botServiceMgmtClient.BotServices.CreateWithHttpMessagesAsync(rgname, botid, resource).GetAwaiter().GetResult().Body;


            VerifyBotServiceProperties(resource, responseResource);

            return responseResource;
        }

        public static void VerifyBotServiceProperties(BotResource expected, BotResource actual, bool isCreation = false)
        {
            Assert.NotNull(actual);
            Assert.NotNull(actual.Id);
            Assert.NotNull(actual.Location);
            Assert.NotNull(actual.Name);
            Assert.NotNull(actual.Etag);
            Assert.NotNull(actual.Kind);

            Assert.NotNull(actual.Sku);
            Assert.NotNull(actual.Sku.Name);

            Assert.NotNull(actual.Properties);

            Assert.Equal(expected.Properties.Description, actual.Properties.Description);
            Assert.Equal(expected.Properties.DisplayName, actual.Properties.DisplayName);
            Assert.Equal(expected.Properties.Endpoint, actual.Properties.Endpoint);
        }

        public static void ValidateExpectedException(Action action, string expectedErrorCode)
        {
            try
            {
                action();
                Assert.True(false, "Expected an Exception");
            }
            catch (ErrorException e)
            {
                Assert.Equal(expectedErrorCode, e.Body.ErrorProperty.Code);
            }
        }
    }
}