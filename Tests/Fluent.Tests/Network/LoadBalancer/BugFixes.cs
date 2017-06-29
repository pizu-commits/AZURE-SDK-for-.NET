﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Tests;
using Azure.Tests.Common;
using Fluent.Tests.Common;
using Microsoft.Azure.Management.Compute.Fluent;
using Microsoft.Azure.Management.Network.Fluent;
using Microsoft.Azure.Management.Network.Fluent.Models;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit;

namespace Fluent.Tests.Network.LoadBalancer
{
    public class LoadBalancerBugFixes
    {
        [Fact]
        public void WithExistingPublicIpAddressTest()
        {
            using (var context = FluentMockContext.Start(GetType().FullName))
            {
                var testId = TestUtilities.GenerateName("");
                string rgName = "rg" + testId;
                string lbName = "lb" + testId;
                string publicIPName = "pip-" + lbName;
                Region region = Region.USEast;

                var azure = TestHelper.CreateRollupClient();
                IPublicIPAddress publicIPAddress = azure.PublicIPAddresses
                    .Define(publicIPName)
                    .WithRegion(region)
                    .WithNewResourceGroup(rgName)
                    .WithLeafDomainLabel(publicIPName)
                    .Create();

                var loadBalancerDef = azure.LoadBalancers.Define(lbName)
                    .WithRegion(region)
                    .WithExistingResourceGroup(rgName)
                    .DefinePublicFrontend("frontend")
                    .WithExistingPublicIPAddress(publicIPAddress)
                        .Attach()
                    .DefineBackend("backend")
                        .Attach()
                    .DefineTcpProbe("probe10225")
                        .WithPort(10225)
                        .WithIntervalInSeconds(5)
                        .WithNumberOfProbes(3)
                        .Attach()
                    .DefineHttpProbe("redisprobe")
                        .WithRequestPath("/api/redisprobe")
                        .WithPort(8500)
                        .WithIntervalInSeconds(5)
                        .WithNumberOfProbes(3)
                        .Attach()
                    .DefineLoadBalancingRule("tcp6379")
                        .WithProtocol(TransportProtocol.Tcp)
                        .WithFrontend("frontend").WithFrontendPort(6379) // 'RedisPublic'
                        .WithProbe("redisprobe")
                        .WithBackend("backend").WithBackendPort(6379)
                        .WithIdleTimeoutInMinutes(20)
                        .Attach()
                    .DefineLoadBalancingRule("tcp6380")
                        .WithProtocol(TransportProtocol.Tcp)
                        .WithFrontend("frontend").WithFrontendPort(6380) // 'RedisSecure'
                        .WithProbe("redisprobe")
                        .WithBackend("backend").WithBackendPort(6380)
                        .WithIdleTimeoutInMinutes(20)
                        .Attach()
                    .DefineLoadBalancingRule("tcp10225")
                        .WithProtocol(TransportProtocol.Tcp)
                        .WithFrontend("frontend")
                        .WithFrontendPort(10225) // 'PublicHttpPort'
                        .WithProbe("probe10225")
                        .WithBackend("backend").WithBackendPort(10225)
                        .WithIdleTimeoutInMinutes(20)
                        .Attach()
                    .DefineInboundNatPool("pool330XX")
                    .WithProtocol(TransportProtocol.Tcp)
                        .WithFrontend("frontend")
                        .WithFrontendPortRange(33000, 33019)
                        .WithBackendPort(3389)
                        .Attach()
                        .DefineInboundNatPool("pool160XX")
                    .WithProtocol(TransportProtocol.Tcp)
                        .WithFrontend("frontend")
                        .WithFrontendPortRange(16000, 16019)
                        .WithBackendPort(10126)
                        .Attach()
                        .DefineInboundNatPool("pool130XX")
                    .WithProtocol(TransportProtocol.Tcp)
                        .WithFrontend("frontend")
                        .WithFrontendPortRange(13000, 13019)
                        .WithBackendPort(10227)
                        .Attach()
                        .DefineInboundNatPool("pool150XX")
                    .WithProtocol(TransportProtocol.Tcp)
                        .WithFrontend("frontend")
                        .WithFrontendPortRange(15000, 15019)
                        .WithBackendPort(10221)
                        .Attach();

                var ret = loadBalancerDef
                    .WithTag("redis", "OwnerName")
                    .CreateAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                azure.ResourceGroups.BeginDeleteByName(rgName);
            }
        }

        [Fact]
        public void WithExistingNetworkSecurityGroupTest()
        {
            using (var context = FluentMockContext.Start(GetType().FullName))
            {
                var testId = TestUtilities.GenerateName("");
                string rgName = "rg" + testId;
                string nic = "nic" + testId;
                string vnet1BackEndSubnetNsgName = "backendnsg";
                Region region = Region.USEast;

                var azure = TestHelper.CreateRollupClient();
                INetworkSecurityGroup nsg = azure.NetworkSecurityGroups
                    .Define(vnet1BackEndSubnetNsgName)
                    .WithRegion(Region.USEast)
                    .WithNewResourceGroup(rgName)
                    .DefineRule("DenyInternetInComing")
                        .DenyInbound()
                        .FromAddress("INTERNET")
                        .FromAnyPort()
                        .ToAnyAddress()
                        .ToAnyPort()
                        .WithAnyProtocol()
                        .Attach()
                    .DefineRule("DenyInternetOutGoing")
                        .DenyOutbound()
                        .FromAnyAddress()
                        .FromAnyPort()
                        .ToAddress("INTERNET")
                        .ToAnyPort()
                        .WithAnyProtocol()
                        .Attach()
                    .Create();

                var vnet = azure.Networks.Define(nic)
                    .WithRegion(region)
                    .WithExistingResourceGroup(rgName)
                    .WithTag("redis", "OwnerName")
                    .WithAddressSpace("172.16.0.0/12")
                    .DefineSubnet("subnet")
                        .WithAddressPrefix("172.16.0.0/16")
                        .WithExistingNetworkSecurityGroup(nsg)
                        .Attach()
                    .CreateAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                azure.ResourceGroups.BeginDeleteByName(rgName);
            }
        }
    }
}
