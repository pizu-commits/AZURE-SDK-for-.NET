﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.Core.TestFramework;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.EventHubs;
using Azure.ResourceManager.EventHubs.Tests.Helpers;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Tests.Tests
{
    public class DisasterRecoveryTests : EventHubTestBase
    {
        private ResourceGroup _resourceGroup;
        public DisasterRecoveryTests(bool isAsync) : base(isAsync)
        {
        }
        [TearDown]
        public async Task ClearNamespaces()
        {
            //remove all namespaces under current resource group
            if (_resourceGroup != null)
            {
                EHNamespaceContainer namespaceContainer = _resourceGroup.GetEHNamespaces();
                List<EHNamespace> namespaceList = await namespaceContainer.GetAllAsync().ToEnumerableAsync();
                foreach (EHNamespace eHNamespace in namespaceList)
                {
                    await eHNamespace.DeleteAsync();
                }
                _resourceGroup = null;
            }
        }
        [Test]
        [RecordedTest]
        public async Task CreateGetUpdateDeleteDisasterRecovery()
        {
            _resourceGroup = await CreateResourceGroupAsync();
            //create namespace1
            string namespaceName1 = await CreateValidNamespaceName("testnamespacemgmt");
            EHNamespaceContainer namespaceContainer = _resourceGroup.GetEHNamespaces();
            EHNamespace eHNamespace1 = (await namespaceContainer.CreateOrUpdateAsync(namespaceName1, new EHNamespaceData(DefaultLocation))).Value;

            //create namespace2 with a different location
            string namespaceName2 = await CreateValidNamespaceName("testnamespacemgmt");
            EHNamespace eHNamespace2 = (await namespaceContainer.CreateOrUpdateAsync(namespaceName2, new EHNamespaceData(Location.EastUS))).Value;

            //create authorization rule on namespace1
            string ruleName = Recording.GenerateAssetName("authorizationrule");
            AuthorizationRuleData ruleParameter = new AuthorizationRuleData()
            {
                Rights = { AccessRights.Listen, AccessRights.Send }
            };
            AuthorizationRuleNamespace authorizationRule = (await eHNamespace1.GetAuthorizationRuleNamespaces().CreateOrUpdateAsync(ruleName, ruleParameter)).Value;
            Assert.NotNull(authorizationRule);
            Assert.AreEqual(authorizationRule.Data.Rights.Count, ruleParameter.Rights.Count);

            //create a disaster recovery
            string disaterRecoveryName = Recording.GenerateAssetName("disasterrecovery");
            ArmDisasterRecoveryData parameter = new ArmDisasterRecoveryData()
            {
                PartnerNamespace = eHNamespace2.Id
            };
            ArmDisasterRecovery armDisasterRecovery = (await eHNamespace1.GetArmDisasterRecoveries().CreateOrUpdateAsync(disaterRecoveryName, parameter)).Value;
            Assert.NotNull(armDisasterRecovery);
            Assert.AreEqual(armDisasterRecovery.Id.Name, disaterRecoveryName);
            Assert.AreEqual(armDisasterRecovery.Data.PartnerNamespace, eHNamespace2.Id.ToString());

            //get the disaster recovery - primary
            armDisasterRecovery = await eHNamespace1.GetArmDisasterRecoveries().GetAsync(disaterRecoveryName);
            Assert.AreEqual(armDisasterRecovery.Data.Role, RoleDisasterRecovery.Primary);

            //get the disaster recovery - secondary
            ArmDisasterRecovery armDisasterRecoverySec = await eHNamespace2.GetArmDisasterRecoveries().GetAsync(disaterRecoveryName);
            Assert.AreEqual(armDisasterRecoverySec.Data.Role, RoleDisasterRecovery.Secondary);

            //wait for completion
            armDisasterRecovery = await eHNamespace1.GetArmDisasterRecoveries().GetAsync(disaterRecoveryName);
            int i = 0;
            while (armDisasterRecovery.Data.ProvisioningState != ProvisioningStateDR.Succeeded || i > 100)
            {
                if (Mode != RecordedTestMode.Playback)
                {
                    await Task.Delay(5000);
                }
                i++;
                armDisasterRecovery = await eHNamespace1.GetArmDisasterRecoveries().GetAsync(disaterRecoveryName);
            }

            //check name availability
            CheckNameAvailabilityResult nameAavailability = await eHNamespace1.CheckDisasterRecoveryConfigNameAvailabilityAsync(new CheckNameAvailabilityParameter(disaterRecoveryName));
            Assert.IsFalse(nameAavailability.NameAvailable);

            List<AuthorizationRuleDisasterRecoveryConfig> rules = await armDisasterRecovery.GetAuthorizationRuleDisasterRecoveryConfigs().GetAllAsync().ToEnumerableAsync();
            Assert.IsTrue(rules.Count > 0);

            //break pairing and wait for competion
            await armDisasterRecovery.BreakPairingAsync();
            armDisasterRecovery = await eHNamespace1.GetArmDisasterRecoveries().GetAsync(disaterRecoveryName);
            i = 0;
            while (armDisasterRecovery.Data.ProvisioningState != ProvisioningStateDR.Succeeded || i > 100)
            {
                if (Mode != RecordedTestMode.Playback)
                {
                    await Task.Delay(5000);
                }
                i++;
                armDisasterRecovery = await eHNamespace1.GetArmDisasterRecoveries().GetAsync(disaterRecoveryName);
            }

            //get all disaster recoveries for a name space
            List<ArmDisasterRecovery> disasterRcoveries = await eHNamespace1.GetArmDisasterRecoveries().GetAllAsync().ToEnumerableAsync();
            Assert.IsTrue(disasterRcoveries.Count >= 1);

            //delete disaster recovery;
            await armDisasterRecovery.DeleteAsync();
        }
    }
}
