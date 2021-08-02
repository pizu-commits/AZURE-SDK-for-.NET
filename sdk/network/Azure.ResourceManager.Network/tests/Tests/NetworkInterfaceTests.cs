﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Network.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Tests.Tests
{
    public class NetworkInterfaceTests : NetworkServiceClientTestBase
    {
        public NetworkInterfaceTests(bool isAsync) : base(isAsync)
        {
        }

        [SetUp]
        public void ClearChallengeCacheforRecord()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                Initialize();
            }
        }

        //[TearDown]
        //public async Task CleanupResourceGroup()
        //{
        //    await CleanupResourceGroupsAsync();
        //}

        [Test]
        public async Task NetworkInterfaceApiTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create publicIP
            string publicIpName = Recording.GenerateAssetName("azsmnet");
            string domainNameLabel = Recording.GenerateAssetName("azsmnet");

            var publicIp = new PublicIPAddressData()
            {
                Location = location,
                Tags =
                    {
                       {"key","value"}
                    },
                PublicIPAllocationMethod = IPAllocationMethod.Dynamic,
                DnsSettings = new PublicIPAddressDnsSettings()
                {
                    DomainNameLabel = domainNameLabel
                }
            };

            // Put PublicIPAddress
            var publicIPAddressContainer = GetPublicIPAddressContainer(resourceGroupName);
            PublicIPAddressesCreateOrUpdateOperation putPublicIpAddressResponseOperation = await publicIPAddressContainer.StartCreateOrUpdateAsync(publicIpName, publicIp);
            Response<PublicIPAddress> putPublicIpAddressResponse = await putPublicIpAddressResponseOperation.WaitForCompletionAsync();;
            Assert.AreEqual("Succeeded", putPublicIpAddressResponse.Value.Data.ProvisioningState.ToString());

            Response<PublicIPAddress> getPublicIpAddressResponse = await publicIPAddressContainer.GetAsync(publicIpName);

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,

                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.0.0.0/16", }
                },
                DhcpOptions = new DhcpOptions()
                {
                    DnsServers = { "10.1.1.1", "10.1.2.4" }
                },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24" } }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            var vnetResponse = await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnetResponse = await vnetResponse.Value.GetSubnets().GetAsync(subnetName);

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        PublicIPAddress = new PublicIPAddressData()
                        {
                            Id = getPublicIpAddressResponse.Value.Id
                        },
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    }
                }
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());
            Assert.Null(getNicResponse.Value.Data.VirtualMachine);
            Assert.Null(getNicResponse.Value.Data.MacAddress);

            //if single CA, primary flag will be set
            Assert.True(getNicResponse.Value.Data.IpConfigurations[0].Primary);
            Assert.AreEqual(1, getNicResponse.Value.Data.IpConfigurations.Count);
            Assert.AreEqual(ipConfigName, getNicResponse.Value.Data.IpConfigurations[0].Name);
            Assert.AreEqual(getPublicIpAddressResponse.Value.Data.Id, getNicResponse.Value.Data.IpConfigurations[0].PublicIPAddress.Id);
            Assert.AreEqual(getSubnetResponse.Value.Data.Id, getNicResponse.Value.Data.IpConfigurations[0].Subnet.Id);
            Assert.NotNull(getNicResponse.Value.Data.ResourceGuid);

            // Verify List IpConfigurations in NetworkInterface
            var networkInterfaceOperations = GetNetworkInterfaceContainer(resourceGroupName).Get(nicName).Value;
            AsyncPageable<NetworkInterfaceIPConfiguration> listNicIpConfigurationsAP = networkInterfaceOperations.GetNetworkInterfaceIPConfigurationsAsync();
            List<NetworkInterfaceIPConfiguration> listNicIpConfigurations = await listNicIpConfigurationsAP.ToEnumerableAsync();
            Assert.AreEqual(ipConfigName, listNicIpConfigurations.First().Name);
            Assert.NotNull(listNicIpConfigurations.First().Etag);

            // Verify Get IpConfiguration in NetworkInterface
            // TODO: Update after ADO 5975
            Response<NetworkInterfaceIPConfiguration> getNicIpConfiguration = await networkInterfaceOperations.GetNetworkInterfaceIPConfigurationAsync();
            Assert.AreEqual(ipConfigName, getNicIpConfiguration.Value.Name);
            Assert.NotNull(getNicIpConfiguration.Value.Etag);

            // Verify List LoadBalancers in NetworkInterface
            AsyncPageable<LoadBalancerData> listNicLoadBalancersAP = getNicResponse.Value.GetNetworkInterfaceLoadBalancersAsync();
            List<LoadBalancerData> listNicLoadBalancers = await listNicLoadBalancersAP.ToEnumerableAsync();
            Assert.IsEmpty(listNicLoadBalancers);

            // Get all Nics
            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.AreEqual(getNicResponse.Value.Data.Name, getListNicResponse.First().Data.Name);
            Assert.AreEqual(getNicResponse.Value.Data.Etag, getListNicResponse.First().Data.Etag);
            Assert.AreEqual(getNicResponse.Value.Data.IpConfigurations[0].Etag, getListNicResponse.First().Data.IpConfigurations[0].Etag);

            // Get all Nics in subscription
            AsyncPageable<NetworkInterface> listNicSubscriptionAP = ArmClient.DefaultSubscription.GetNetworkInterfacesAsync();
            List<NetworkInterface> listNicSubscription = await listNicSubscriptionAP.ToEnumerableAsync();
            Assert.IsNotEmpty(listNicSubscription);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete PublicIPAddress
            await getPublicIpAddressResponse.Value.StartDeleteAsync();

            // Delete VirtualNetwork
            await vnetResponse.Value.StartDeleteAsync();
        }

        [Test]
        public async Task NetworkInterfaceWithAcceleratedNetworkingTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,

                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.0.0.0/16", }
                },
                DhcpOptions = new DhcpOptions()
                {
                    DnsServers = { "10.1.1.1", "10.1.2.4" }
                },
                Subnets = {
                    new SubnetData()
                    {
                        Name = subnetName,
                        AddressPrefix = "10.0.0.0/24",
                    }
                }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnetResponse = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName);

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            // IDnsSuffix is a read-only property, hence not specified below
            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                EnableAcceleratedNetworking = true,
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Primary = true,
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        PrivateIPAddressVersion = IPVersion.IPv4,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    },
                }
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());
            Assert.Null(getNicResponse.Value.Data.VirtualMachine);
            Assert.Null(getNicResponse.Value.Data.MacAddress);
            Assert.AreEqual(1, getNicResponse.Value.Data.IpConfigurations.Count);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        [Test]
        public async Task NetworkInterfaceMultiIpConfigTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create publicIP
            string publicIpName = Recording.GenerateAssetName("azsmnet");
            string domainNameLabel = Recording.GenerateAssetName("azsmnet");

            var publicIp = new PublicIPAddressData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                PublicIPAllocationMethod = IPAllocationMethod.Dynamic,
                DnsSettings = new PublicIPAddressDnsSettings()
                {
                    DomainNameLabel = domainNameLabel
                }
            };

            // Put PublicIPAddress
            var publicIPAddressContainer = GetPublicIPAddressContainer(resourceGroupName);
            PublicIPAddressesCreateOrUpdateOperation putPublicIpAddressResponseOperation = await publicIPAddressContainer.StartCreateOrUpdateAsync(publicIpName, publicIp);
            Response<PublicIPAddress> putPublicIpAddressResponse = await putPublicIpAddressResponseOperation.WaitForCompletionAsync();;
            Assert.AreEqual("Succeeded", putPublicIpAddressResponse.Value.Data.ProvisioningState.ToString());

            Response<PublicIPAddress> getPublicIpAddressResponse = await publicIPAddressContainer.GetAsync(publicIpName);

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,
                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.0.0.0/16", }
                },
                DhcpOptions = new DhcpOptions()
                {
                    DnsServers = { "10.1.1.1", "10.1.2.4" }
                },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24" } }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnetResponse = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName);

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");
            string ipconfigName2 = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Primary = true,
                        PublicIPAddress = new PublicIPAddressData()
                        {
                            Id = getPublicIpAddressResponse.Value.Id
                        },
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    },
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipconfigName2,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Primary = false,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    }
                }
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());
            Assert.Null(getNicResponse.Value.Data.VirtualMachine);
            Assert.Null(getNicResponse.Value.Data.MacAddress);
            Assert.True(getNicResponse.Value.Data.IpConfigurations[0].Primary);
            Assert.AreEqual(2, getNicResponse.Value.Data.IpConfigurations.Count);
            Assert.AreEqual(ipConfigName, getNicResponse.Value.Data.IpConfigurations[0].Name);
            Assert.AreEqual(ipconfigName2, getNicResponse.Value.Data.IpConfigurations[1].Name);
            Assert.False(getNicResponse.Value.Data.IpConfigurations[1].Primary);
            Assert.AreEqual(getPublicIpAddressResponse.Value.Id, getNicResponse.Value.Data.IpConfigurations[0].PublicIPAddress.Id);
            Assert.AreEqual(getSubnetResponse.Value.Id, getNicResponse.Value.Data.IpConfigurations[0].Subnet.Id);
            Assert.AreEqual(getSubnetResponse.Value.Id, getNicResponse.Value.Data.IpConfigurations[1].Subnet.Id);
            Assert.NotNull(getNicResponse.Value.Data.ResourceGuid);

            // Get all Nics
            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.AreEqual(getNicResponse.Value.Data.Name, getListNicResponse.First().Data.Name);
            Assert.AreEqual(getNicResponse.Value.Data.Etag, getListNicResponse.First().Data.Etag);
            Assert.AreEqual(getNicResponse.Value.Data.IpConfigurations[0].Etag, getListNicResponse.First().Data.IpConfigurations[0].Etag);
            Assert.AreEqual(getNicResponse.Value.Data.IpConfigurations[1].Etag, getListNicResponse.First().Data.IpConfigurations[1].Etag);

            // Get all Nics in subscription
            AsyncPageable<NetworkInterface> listNicSubscriptionAP = ArmClient.DefaultSubscription.GetNetworkInterfacesAsync();
            List<NetworkInterface> listNicSubscription = await listNicSubscriptionAP.ToEnumerableAsync();
            Assert.IsNotEmpty(listNicSubscription);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete PublicIPAddress
            await getPublicIpAddressResponse.Value.StartDeleteAsync();

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        [Test]
        public async Task AssertMultiIpConfigOnDifferentSubnetFails()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName2 = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,

                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.0.0.0/16", }
                },
                Subnets = {
                    new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24", },
                    new SubnetData() { Name = subnetName2, AddressPrefix = "10.0.1.0/24" }
                }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnet1Response = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName);
            Response<Subnet> getSubnet2Response = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName2);

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");
            string ipconfigName2 = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Primary = true,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnet1Response.Value.Id
                        }
                    },
                        new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipconfigName2,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Primary = false,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnet2Response.Value.Id
                        }
                    }
                }
            };

            try
            {
                // Test NIC apis
                NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await GetNetworkInterfaceContainer(resourceGroupName).StartCreateOrUpdateAsync(nicName, nicParameters);
                Response<NetworkInterface> putNicResponse = await putNicResponseOperation.WaitForCompletionAsync();;
            }
            catch (Exception ex)
            {
                Assert.True(ex.Message.Contains("cannot belong to different subnets"));
            }
        }

        [Test]
        public async Task NetworkInterfaceDnsSettingsTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,
                AddressSpace = new AddressSpace() { AddressPrefixes = { "10.0.0.0/16", } },
                DhcpOptions = new DhcpOptions() { DnsServers = { "10.1.1.1", "10.1.2.4" } },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24", } }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnetResponse = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName);

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    }
                },
                DnsSettings = new NetworkInterfaceDnsSettings()
                {
                    DnsServers = { "1.0.0.1", "1.0.0.2" },
                    InternalDnsNameLabel = "idnstest",
                }
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());
            Assert.Null(getNicResponse.Value.Data.VirtualMachine);
            Assert.Null(getNicResponse.Value.Data.MacAddress);
            Assert.AreEqual(1, getNicResponse.Value.Data.IpConfigurations.Count);
            Assert.AreEqual(ipConfigName, getNicResponse.Value.Data.IpConfigurations[0].Name);
            Assert.AreEqual(2, getNicResponse.Value.Data.DnsSettings.DnsServers.Count);
            Assert.IsTrue(getNicResponse.Value.Data.DnsSettings.DnsServers.Contains("1.0.0.1"));
            Assert.IsTrue(getNicResponse.Value.Data.DnsSettings.DnsServers.Contains("1.0.0.2"));
            Assert.AreEqual("idnstest", getNicResponse.Value.Data.DnsSettings.InternalDnsNameLabel);
            Assert.AreEqual(0, getNicResponse.Value.Data.DnsSettings.AppliedDnsServers.Count);
            Assert.True(getNicResponse.Value.Data.IpConfigurations[0].Primary);
            Assert.NotNull(getNicResponse.Value.Data.DnsSettings.InternalFqdn);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        /// currently this test is failing because of nrp valdiation check:cannot have multiple IPv4 IpConfigurations if it specifies a Ipv6 IpConfigurations. Ipv4 Ipconfig Count: 2
        /// will remove ignore tag once the check in nrp is removed.
        [Test]
        public async Task NetworkInterfaceApiIPv6MultiCATest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces", Network.Tests.Helpers.FeaturesInfo.Type.All);
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create publicIP
            string publicIpName = Recording.GenerateAssetName("azsmnet");
            string domainNameLabel = Recording.GenerateAssetName("azsmnet");

            var publicIp = new PublicIPAddressData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                PublicIPAllocationMethod = IPAllocationMethod.Dynamic,
                DnsSettings = new PublicIPAddressDnsSettings()
                {
                    DomainNameLabel = domainNameLabel
                }
            };

            // Put PublicIPAddress
            var publicIPAddressContainer = GetPublicIPAddressContainer(resourceGroupName);
            PublicIPAddressesCreateOrUpdateOperation putPublicIpAddressResponseOperation = await publicIPAddressContainer.StartCreateOrUpdateAsync(publicIpName, publicIp);
            Response<PublicIPAddress> putPublicIpAddressResponse = await putPublicIpAddressResponseOperation.WaitForCompletionAsync();;
            Assert.AreEqual("Succeeded", putPublicIpAddressResponse.Value.Data.ProvisioningState.ToString());

            await publicIPAddressContainer.GetAsync(publicIpName);

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,

                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.0.0.0/16", }
                },
                DhcpOptions = new DhcpOptions()
                {
                    DnsServers = { "10.1.1.1", "10.1.2.4" }
                },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24" } }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnetResponse = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName);

            // Create Nic
            string nicName = Recording.GenerateAssetName("dualstacknic");
            string ipConfigName = Recording.GenerateAssetName("ipv4ipconfig");
            string ipv6IpConfigName = Recording.GenerateAssetName("ipv6ipconfig");
            string ipConfigName2 = Recording.GenerateAssetName("ipv4ipconfig2");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Primary = true,
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        PrivateIPAddressVersion = IPVersion.IPv4,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    },
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipv6IpConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        PrivateIPAddressVersion = IPVersion.IPv6,
                    },

                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName2,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        PrivateIPAddressVersion = IPVersion.IPv4,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    }
                }
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());
            Assert.Null(getNicResponse.Value.Data.VirtualMachine);
            Assert.Null(getNicResponse.Value.Data.MacAddress);
            Assert.AreEqual(ipConfigName, getNicResponse.Value.Data.IpConfigurations[0].Name);
            Assert.NotNull(getNicResponse.Value.Data.ResourceGuid);
            Assert.AreEqual(getSubnetResponse.Value.Id, getNicResponse.Value.Data.IpConfigurations[0].Subnet.Id);
            Assert.AreEqual(IPVersion.IPv4, getNicResponse.Value.Data.IpConfigurations[0].PrivateIPAddressVersion);

            // Ipv6 specific asserts
            Assert.AreEqual(3, getNicResponse.Value.Data.IpConfigurations.Count);
            Assert.AreEqual(ipv6IpConfigName, getNicResponse.Value.Data.IpConfigurations[1].Name);
            Assert.True(getNicResponse.Value.Data.IpConfigurations[0].Primary);
            Assert.Null(getNicResponse.Value.Data.IpConfigurations[1].Subnet);
            Assert.AreEqual(IPVersion.IPv6, getNicResponse.Value.Data.IpConfigurations[1].PrivateIPAddressVersion);

            // Get all Nics
            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.AreEqual(getNicResponse.Value.Data.Name, getListNicResponse.First().Data.Name);
            Assert.AreEqual(getNicResponse.Value.Data.Etag, getListNicResponse.First().Data.Etag);
            Assert.AreEqual(getNicResponse.Value.Data.IpConfigurations[0].Etag, getListNicResponse.First().Data.IpConfigurations[0].Etag);
            Assert.AreEqual(getNicResponse.Value.Data.IpConfigurations[1].Etag, getListNicResponse.First().Data.IpConfigurations[1].Etag);

            // Get all Nics in subscription
            AsyncPageable<NetworkInterface> listNicSubscriptionAP = ArmClient.DefaultSubscription.GetNetworkInterfacesAsync();
            List<NetworkInterface> listNicSubscription = await listNicSubscriptionAP.ToEnumerableAsync();
            Assert.IsNotEmpty(listNicSubscription);

            // Delete Nic
            NetworkInterfacesDeleteOperation deleteOperation = await getNicResponse.Value.StartDeleteAsync();
            await deleteOperation.WaitForCompletionResponseAsync();;
            getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete PublicIPAddress
            await putPublicIpAddressResponse.Value.StartDeleteAsync();

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        [Test]
        public async Task NetworkInterfaceDnsSettingsTestIdnsSuffix()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,
                AddressSpace = new AddressSpace() { AddressPrefixes = { "10.0.0.0/16", } },
                DhcpOptions = new DhcpOptions() { DnsServers = { "10.1.1.1", "10.1.2.4" } },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24" } }
            };

            var virtualNetworkContainer = GetResourceGroup(resourceGroupName).GetVirtualNetworks();
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnetResponse = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName);

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            // IDnsSuffix is a read-only property, hence not specified below
            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    }
                },
                DnsSettings = new NetworkInterfaceDnsSettings()
                {
                    DnsServers = { "1.0.0.1", "1.0.0.2" },
                    InternalDnsNameLabel = "idnstest",
                }
            };

            // Test NIC apis
            var networkInterfaceContainer = GetResourceGroup(resourceGroupName).GetNetworkInterfaces();
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());
            Assert.Null(getNicResponse.Value.Data.VirtualMachine);
            Assert.Null(getNicResponse.Value.Data.MacAddress);
            Assert.AreEqual(1, getNicResponse.Value.Data.IpConfigurations.Count);
            Assert.AreEqual(ipConfigName, getNicResponse.Value.Data.IpConfigurations[0].Name);
            Assert.AreEqual(2, getNicResponse.Value.Data.DnsSettings.DnsServers.Count);
            Assert.IsTrue(getNicResponse.Value.Data.DnsSettings.DnsServers.Contains("1.0.0.1"));
            Assert.IsTrue(getNicResponse.Value.Data.DnsSettings.DnsServers.Contains("1.0.0.2"));
            Assert.AreEqual("idnstest", getNicResponse.Value.Data.DnsSettings.InternalDnsNameLabel);
            Assert.AreEqual(0, getNicResponse.Value.Data.DnsSettings.AppliedDnsServers.Count);
            Assert.NotNull(getNicResponse.Value.Data.DnsSettings.InternalFqdn);

            // IDnsSuffix is a read-only property. Ensure the response contains some value.
            Assert.NotNull(getNicResponse.Value.Data.DnsSettings.InternalDomainNameSuffix);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        [Test]
        public async Task NetworkInterfaceEnableIPForwardingTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,
                AddressSpace = new AddressSpace() { AddressPrefixes = { "10.0.0.0/16", } },
                DhcpOptions = new DhcpOptions() { DnsServers = { "10.1.1.1", "10.1.2.4" } },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24", } }
            };

            var virtualNetworkContainer = GetResourceGroup(resourceGroupName).GetVirtualNetworks();
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            await putVnetResponseOperation.WaitForCompletionAsync();;
            Response<Subnet> getSubnetResponse = await putVnetResponseOperation.Value.GetSubnets().GetAsync(subnetName);

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Subnet = new SubnetData()
                        {
                            Id = getSubnetResponse.Value.Id
                        }
                    }
                },
                EnableIPForwarding = false,
            };

            // Test NIC apis
            var networkInterfaceContainer = GetResourceGroup(resourceGroupName).GetNetworkInterfaces();
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());
            Assert.Null(getNicResponse.Value.Data.VirtualMachine);
            Assert.Null(getNicResponse.Value.Data.MacAddress);
            Assert.AreEqual(1, getNicResponse.Value.Data.IpConfigurations.Count);
            Assert.AreEqual(ipConfigName, getNicResponse.Value.Data.IpConfigurations[0].Name);
            Assert.False(getNicResponse.Value.Data.EnableIPForwarding);

            getNicResponse.Value.Data.EnableIPForwarding = true;
            await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, getNicResponse.Value.Data);
            getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual(getNicResponse.Value.Data.Name, nicName);
            Assert.True(getNicResponse.Value.Data.EnableIPForwarding);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        [Test]
        public async Task NetworkInterfaceNetworkSecurityGroupTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");
            string networkSecurityGroupName = Recording.GenerateAssetName("azsmnet");
            string securityRule1 = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,
                AddressSpace = new AddressSpace() { AddressPrefixes = { "10.0.0.0/16", } },
                DhcpOptions = new DhcpOptions() { DnsServers = { "10.1.1.1", "10.1.2.4" } },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24", } }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            Response<VirtualNetwork> putVnetResponse = await putVnetResponseOperation.WaitForCompletionAsync();;
            // Create network security group
            string destinationPortRange = "123-3500";
            var networkSecurityGroup = new NetworkSecurityGroupData()
            {
                Location = location,
                SecurityRules = {
                    new SecurityRuleData()
                    {
                        Name = securityRule1,
                        Access = SecurityRuleAccess.Allow,
                        Description = "Test security rule",
                        DestinationAddressPrefix = "*",
                        DestinationPortRange = destinationPortRange,
                        Direction = SecurityRuleDirection.Inbound,
                        Priority = 500,
                        Protocol = SecurityRuleProtocol.Tcp,
                        SourceAddressPrefix = "*",
                        SourcePortRange = "655"
                    }
                }
            };

            // Put Nsg
            var networkSecurityGroupContainer = GetNetworkSecurityGroupContainer(resourceGroupName);
            NetworkSecurityGroupsCreateOrUpdateOperation putNsgResponseOperation = await networkSecurityGroupContainer.StartCreateOrUpdateAsync(networkSecurityGroupName, networkSecurityGroup);
            Response<NetworkSecurityGroup> putNsgResponse = await putNsgResponseOperation.WaitForCompletionAsync();;
            Assert.AreEqual("Succeeded", putNsgResponse.Value.Data.ProvisioningState.ToString());

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Subnet = new SubnetData()
                        {
                            Id = putVnetResponse.Value.Data.Subnets[0].Id
                        }
                    }
                },
                NetworkSecurityGroup = putNsgResponse.Value.Data
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());

            Response<NetworkSecurityGroup> getNsgResponse = await networkSecurityGroupContainer.GetAsync(networkSecurityGroupName);

            // Verify nic - nsg association
            Assert.AreEqual(getNicResponse.Value.Data.NetworkSecurityGroup.Id, getNsgResponse.Value.Id);
            Assert.AreEqual(getNsgResponse.Value.Data.NetworkInterfaces[0].Id, getNicResponse.Value.Id);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete NSG
            await getNsgResponse.Value.StartDeleteAsync();

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        [Test]
        [Ignore("Track2: Need to use an existing virtual machine, but not create it in test case ")]
        public async Task NetworkInterfaceEffectiveNetworkSecurityGroupTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");
            string networkSecurityGroupName = Recording.GenerateAssetName("azsmnet");
            string securityRule1 = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,
                AddressSpace = new AddressSpace() { AddressPrefixes = { "10.0.0.0/16", } },
                DhcpOptions = new DhcpOptions() { DnsServers = { "10.1.1.1", "10.1.2.4" } },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24", } }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            Response<VirtualNetwork> putVnetResponse = await putVnetResponseOperation.WaitForCompletionAsync();;
            // Create network security group
            string destinationPortRange = "123-3500";
            var networkSecurityGroup = new NetworkSecurityGroupData()
            {
                Location = location,
                SecurityRules = {
                    new SecurityRuleData()
                    {
                        Name = securityRule1,
                        Access = SecurityRuleAccess.Allow,
                        Description = "Test security rule",
                        DestinationAddressPrefix = "*",
                        DestinationPortRange = destinationPortRange,
                        Direction = SecurityRuleDirection.Inbound,
                        Priority = 500,
                        Protocol = SecurityRuleProtocol.Tcp,
                        SourceAddressPrefix = "*",
                        SourcePortRange = "655"
                    }
                }
            };

            // Put Nsg
            var networkSecurityGroupContainer = GetNetworkSecurityGroupContainer(resourceGroupName);
            NetworkSecurityGroupsCreateOrUpdateOperation putNsgResponseOperation = await networkSecurityGroupContainer.StartCreateOrUpdateAsync(networkSecurityGroupName, networkSecurityGroup);
            Response<NetworkSecurityGroup> putNsgResponse = await putNsgResponseOperation.WaitForCompletionAsync();;
            Assert.AreEqual("Succeeded", putNsgResponse.Value.Data.ProvisioningState.ToString());

            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Subnet = new SubnetData()
                        {
                            Id = putVnetResponse.Value.Data.Subnets[0].Id
                        }
                    }
                },
                NetworkSecurityGroup = putNsgResponse.Value.Data
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());

            Response<NetworkSecurityGroup> getNsgResponse = await networkSecurityGroupContainer.GetAsync(networkSecurityGroupName);

            // Verify nic - nsg association
            Assert.AreEqual(getNicResponse.Value.Data.NetworkSecurityGroup.Id, getNsgResponse.Value.Id);
            Assert.AreEqual(getNsgResponse.Value.Data.NetworkInterfaces[0].Id, getNicResponse.Value.Id);

            // Get effective NSGs
            NetworkInterfacesGetEffectiveNetworkSecurityGroupsOperation effectiveNsgsOperation = await getNicResponse.Value.StartGetEffectiveNetworkSecurityGroupsAsync();
            Response<EffectiveNetworkSecurityGroupListResult> effectiveNsgs = await effectiveNsgsOperation.WaitForCompletionAsync();;
            Assert.NotNull(effectiveNsgs);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete NSG
            await getNsgResponse.Value.StartDeleteAsync();

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }

        [Test]
        [Ignore("Track2: Need to use an existing virtual machine, but not create it in test case ")]
        public async Task NetworkInterfaceEffectiveRouteTableTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/networkInterfaces");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new Resources.Models.ResourceGroup(location));

            // Create Vnet
            // Populate parameter for Put Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");
            string routeTableName = Recording.GenerateAssetName("azsmnet");
            string route1Name = Recording.GenerateAssetName("azsmnet");

            var routeTable = new RouteTableData() { Location = location, };

            var route1 = new RouteData()
            {
                AddressPrefix = "192.168.1.0/24",
                Name = route1Name,
                NextHopIpAddress = "23.108.1.1",
                NextHopType = RouteNextHopType.VirtualAppliance
            };

            routeTable.Routes.Add(route1);

            // Put RouteTable
            var routeTableContainer = GetRouteTableContainer(resourceGroupName);
            RouteTablesCreateOrUpdateOperation putRouteTableResponseOperation = await routeTableContainer.StartCreateOrUpdateAsync(routeTableName, routeTable);
            Response<RouteTable> putRouteTableResponse = await putRouteTableResponseOperation.WaitForCompletionAsync();;
            Assert.AreEqual("Succeeded", putRouteTableResponse.Value.Data.ProvisioningState.ToString());

            var vnet = new VirtualNetworkData()
            {
                Location = location,
                AddressSpace = new AddressSpace() { AddressPrefixes = { "10.0.0.0/16", } },
                DhcpOptions = new DhcpOptions() { DnsServers = { "10.1.1.1", "10.1.2.4" } },
                Subnets = { new SubnetData() { Name = subnetName, AddressPrefix = "10.0.0.0/24", RouteTable = putRouteTableResponse.Value.Data } }
            };

            var virtualNetworkContainer = GetVirtualNetworkContainer(resourceGroupName);
            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await virtualNetworkContainer.StartCreateOrUpdateAsync(vnetName, vnet);
            Response<VirtualNetwork> putVnetResponse = await putVnetResponseOperation.WaitForCompletionAsync();;
            // Create Nic
            string nicName = Recording.GenerateAssetName("azsmnet");
            string ipConfigName = Recording.GenerateAssetName("azsmnet");

            var nicParameters = new NetworkInterfaceData()
            {
                Location = location,
                Tags = { { "key", "value" } },
                IpConfigurations = {
                    new NetworkInterfaceIPConfiguration()
                    {
                        Name = ipConfigName,
                        PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
                        Subnet = new SubnetData()
                        {
                            Id = putVnetResponse.Value.Data.Subnets[0].Id
                        }
                    }
                }
            };

            // Test NIC apis
            var networkInterfaceContainer = GetNetworkInterfaceContainer(resourceGroupName);
            NetworkInterfacesCreateOrUpdateOperation putNicResponseOperation = await networkInterfaceContainer.StartCreateOrUpdateAsync(nicName, nicParameters);
            await putNicResponseOperation.WaitForCompletionAsync();;
            Response<NetworkInterface> getNicResponse = await networkInterfaceContainer.GetAsync(nicName);
            Assert.AreEqual("Succeeded", getNicResponse.Value.Data.ProvisioningState.ToString());

            // Get effective NSGs
            NetworkInterfacesGetEffectiveRouteTableOperation effectiveRouteTableOperation = await getNicResponse.Value.StartGetEffectiveRouteTableAsync();
            Response<EffectiveRouteListResult> effectiveRouteTable = await effectiveRouteTableOperation.WaitForCompletionAsync();;
            Assert.NotNull(effectiveRouteTable);

            // Delete Nic
            await getNicResponse.Value.StartDeleteAsync();

            AsyncPageable<NetworkInterface> getListNicResponseAP = networkInterfaceContainer.GetAllAsync();
            List<NetworkInterface> getListNicResponse = await getListNicResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(getListNicResponse);

            // Delete routetable
            await putRouteTableResponse.Value.StartDeleteAsync();

            // Delete VirtualNetwork
            await putVnetResponseOperation.Value.StartDeleteAsync();
        }
    }
}
