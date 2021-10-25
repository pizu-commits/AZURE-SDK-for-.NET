﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceBus.Models;
using Azure.ResourceManager.ServiceBus.Tests.Helpers;

namespace Azure.ResourceManager.ServiceBus.Tests
{
    public class TopicTests : ServiceBusTestBase
    {
        private ResourceGroup _resourceGroup;
        private SBTopicContainer _topicContainer;
        public TopicTests(bool isAsync): base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateNamespaceAndGetTopicContainer()
        {
            _resourceGroup = await CreateResourceGroupAsync();
            string namespaceName = await CreateValidNamespaceName("testnamespacemgmt");
            SBNamespaceContainer namespaceContainer = _resourceGroup.GetSBNamespaces();
            SBNamespaceData parameters = new SBNamespaceData(DefaultLocation)
            {
                Sku = new SBSku(SkuName.Premium)
                {
                    Tier = SkuTier.Premium
                }
            };
            SBNamespace sBNamespace = (await namespaceContainer.CreateOrUpdateAsync(namespaceName, parameters)).Value;
            _topicContainer = sBNamespace.GetSBTopics();
        }

        [TearDown]
        public async Task ClearNamespaces()
        {
            //remove all namespaces under current resource group
            if (_resourceGroup != null)
            {
                SBNamespaceContainer namespaceContainer = _resourceGroup.GetSBNamespaces();
                List<SBNamespace> namespaceList = await namespaceContainer.GetAllAsync().ToEnumerableAsync();
                foreach (SBNamespace sBNamespace in namespaceList)
                {
                    await sBNamespace.DeleteAsync();
                }
                _resourceGroup = null;
            }
        }

        [Test]
        [RecordedTest]
        public async Task CreateDeleteTopic()
        {
            //create topic
            string topicName = Recording.GenerateAssetName("topic");
            SBTopic topic = (await _topicContainer.CreateOrUpdateAsync(topicName, new SBTopicData())).Value;
            Assert.NotNull(topic);
            Assert.AreEqual(topic.Id.Name, topicName);

            //validate if created successfully
            topic = await _topicContainer.GetIfExistsAsync(topicName);
            Assert.NotNull(topic);
            Assert.IsTrue(await _topicContainer.CheckIfExistsAsync(topicName));

            //delete topic
            await topic.DeleteAsync();

            //validate
            topic = await _topicContainer.GetIfExistsAsync(topicName);
            Assert.Null(topic);
            Assert.IsFalse(await _topicContainer.CheckIfExistsAsync(topicName));
        }

        [Test]
        [RecordedTest]
        public async Task GetAllTopics()
        {
            //create two topics
            string topicName1 = Recording.GenerateAssetName("topic1");
            string topicName2 = Recording.GenerateAssetName("topic2");
            _ = (await _topicContainer.CreateOrUpdateAsync(topicName1, new SBTopicData())).Value;
            _ = (await _topicContainer.CreateOrUpdateAsync(topicName2, new SBTopicData())).Value;

            //validate
            int count = 0;
            SBTopic topic1 = null;
            SBTopic topic2 = null;
            await foreach (SBTopic topic in _topicContainer.GetAllAsync())
            {
                count++;
                if (topic.Id.Name == topicName1)
                    topic1 = topic;
                if (topic.Id.Name == topicName2)
                    topic2 = topic;
            }
            Assert.AreEqual(count, 2);
            Assert.NotNull(topic1);
            Assert.NotNull(topic2);
        }

        [Test]
        [RecordedTest]
        public async Task UpdateTopic()
        {
            //create topic
            string topicName = Recording.GenerateAssetName("topic");
            SBTopic topic = (await _topicContainer.CreateOrUpdateAsync(topicName, new SBTopicData())).Value;
            Assert.NotNull(topic);
            Assert.AreEqual(topic.Id.Name, topicName);

            //update topic
            topic.Data.MaxMessageSizeInKilobytes = 13312;
            topic = (await _topicContainer.CreateOrUpdateAsync(topicName, topic.Data)).Value;
            Assert.AreEqual(topic.Data.MaxMessageSizeInKilobytes, 13312);
        }

        [Test]
        [RecordedTest]
        public async Task TopicCreateGetUpdateDeleteAuthorizationRule()
        {
            //create topic
            string topicName = Recording.GenerateAssetName("topic");
            SBTopic topic = (await _topicContainer.CreateOrUpdateAsync(topicName, new SBTopicData())).Value;

            //create an authorization rule
            string ruleName = Recording.GenerateAssetName("authorizationrule");
            SBAuthorizationRuleTopicContainer ruleContainer = topic.GetSBAuthorizationRuleTopics();
            SBAuthorizationRuleData parameter = new SBAuthorizationRuleData()
            {
                Rights = { AccessRights.Listen, AccessRights.Send }
            };
            SBAuthorizationRuleTopic authorizationRule = (await ruleContainer.CreateOrUpdateAsync(ruleName, parameter)).Value;
            Assert.NotNull(authorizationRule);
            Assert.AreEqual(authorizationRule.Data.Rights.Count, parameter.Rights.Count);

            //get authorization rule
            authorizationRule = await ruleContainer.GetAsync(ruleName);
            Assert.AreEqual(authorizationRule.Id.Name, ruleName);
            Assert.NotNull(authorizationRule);
            Assert.AreEqual(authorizationRule.Data.Rights.Count, parameter.Rights.Count);

            //get all authorization rules
            List<SBAuthorizationRuleTopic> rules = await ruleContainer.GetAllAsync().ToEnumerableAsync();

            //validate
            Assert.True(rules.Count == 1);
            bool isContainAuthorizationRuleName = false;
            foreach (SBAuthorizationRuleTopic rule in rules)
            {
                if (rule.Id.Name == ruleName)
                {
                    isContainAuthorizationRuleName = true;
                }
            }
            Assert.True(isContainAuthorizationRuleName);

            //update authorization rule
            parameter.Rights.Add(AccessRights.Manage);
            authorizationRule = (await ruleContainer.CreateOrUpdateAsync(ruleName, parameter)).Value;
            Assert.NotNull(authorizationRule);
            Assert.AreEqual(authorizationRule.Data.Rights.Count, parameter.Rights.Count);

            //delete authorization rule
            await authorizationRule.DeleteAsync();

            //validate if deleted
            Assert.IsFalse(await ruleContainer.CheckIfExistsAsync(ruleName));
            rules = await ruleContainer.GetAllAsync().ToEnumerableAsync();
            Assert.True(rules.Count == 0);
        }

        [Test]
        [RecordedTest]
        public async Task TopicAuthorizationRuleRegenerateKey()
        {
            //create topic
            string topicName = Recording.GenerateAssetName("topic");
            SBTopic topic = (await _topicContainer.CreateOrUpdateAsync(topicName, new SBTopicData())).Value;
            SBAuthorizationRuleTopicContainer ruleContainer = topic.GetSBAuthorizationRuleTopics();

            //create authorization rule
            string ruleName = Recording.GenerateAssetName("authorizationrule");
            SBAuthorizationRuleData parameter = new SBAuthorizationRuleData()
            {
                Rights = { AccessRights.Listen, AccessRights.Send }
            };
            SBAuthorizationRuleTopic authorizationRule = (await ruleContainer.CreateOrUpdateAsync(ruleName, parameter)).Value;
            Assert.NotNull(authorizationRule);
            Assert.AreEqual(authorizationRule.Data.Rights.Count, parameter.Rights.Count);

            AccessKeys keys1 = await authorizationRule.GetKeysAsync();
            Assert.NotNull(keys1);
            Assert.NotNull(keys1.PrimaryConnectionString);
            Assert.NotNull(keys1.SecondaryConnectionString);

            AccessKeys keys2 = await authorizationRule.RegenerateKeysAsync(new RegenerateAccessKeyParameters(KeyType.PrimaryKey));

            //the recordings are sanitized therefore cannot be compared
            if (Mode != RecordedTestMode.Playback)
            {
                Assert.AreNotEqual(keys1.PrimaryKey, keys2.PrimaryKey);
                Assert.AreEqual(keys1.SecondaryKey, keys2.SecondaryKey);
            }

            AccessKeys keys3 = await authorizationRule.RegenerateKeysAsync(new RegenerateAccessKeyParameters(KeyType.SecondaryKey));
            if (Mode != RecordedTestMode.Playback)
            {
                Assert.AreEqual(keys2.PrimaryKey, keys3.PrimaryKey);
                Assert.AreNotEqual(keys2.SecondaryKey, keys3.SecondaryKey);
            }
        }
    }
}
