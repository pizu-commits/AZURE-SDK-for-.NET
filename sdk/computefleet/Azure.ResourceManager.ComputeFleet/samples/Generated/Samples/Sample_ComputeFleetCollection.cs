// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ComputeFleet.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ComputeFleet.Samples
{
    public partial class Sample_ComputeFleetCollection
    {
        // Fleets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FleetsGet()
        {
            // Generated from example definition: 2024-05-01-preview/Fleets_Get.json
            // this example is just showing the usage of "Fleets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1DC2F28C-A625-4B0E-9748-9885A3C9E9EB";
            string resourceGroupName = "rgazurefleet";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ComputeFleetResource
            ComputeFleetCollection collection = resourceGroupResource.GetComputeFleets();

            // invoke the operation
            string fleetName = "testFleet";
            ComputeFleetResource result = await collection.GetAsync(fleetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ComputeFleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Fleets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FleetsGet()
        {
            // Generated from example definition: 2024-05-01-preview/Fleets_Get.json
            // this example is just showing the usage of "Fleets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1DC2F28C-A625-4B0E-9748-9885A3C9E9EB";
            string resourceGroupName = "rgazurefleet";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ComputeFleetResource
            ComputeFleetCollection collection = resourceGroupResource.GetComputeFleets();

            // invoke the operation
            string fleetName = "testFleet";
            bool result = await collection.ExistsAsync(fleetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Fleets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FleetsGet()
        {
            // Generated from example definition: 2024-05-01-preview/Fleets_Get.json
            // this example is just showing the usage of "Fleets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1DC2F28C-A625-4B0E-9748-9885A3C9E9EB";
            string resourceGroupName = "rgazurefleet";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ComputeFleetResource
            ComputeFleetCollection collection = resourceGroupResource.GetComputeFleets();

            // invoke the operation
            string fleetName = "testFleet";
            NullableResponse<ComputeFleetResource> response = await collection.GetIfExistsAsync(fleetName);
            ComputeFleetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ComputeFleetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Fleets_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FleetsCreateOrUpdate()
        {
            // Generated from example definition: 2024-05-01-preview/Fleets_CreateOrUpdate.json
            // this example is just showing the usage of "Fleets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1DC2F28C-A625-4B0E-9748-9885A3C9E9EB";
            string resourceGroupName = "rgazurefleet";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ComputeFleetResource
            ComputeFleetCollection collection = resourceGroupResource.GetComputeFleets();

            // invoke the operation
            string fleetName = "testFleet";
            ComputeFleetData data = new ComputeFleetData(new AzureLocation("westus"))
            {
                Properties = new ComputeFleetProperties(new ComputeFleetVmSizeProfile[]
            {
new ComputeFleetVmSizeProfile("Standard_d1_v2")
{
Rank = 19225,
}
            }, new ComputeFleetComputeProfile(new ComputeFleetVmProfile()
            {
                OSProfile = new ComputeFleetVmssOSProfile()
                {
                    ComputerNamePrefix = "o",
                    AdminUsername = "nrgzqciiaaxjrqldbmjbqkyhntp",
                    AdminPassword = "adfbrdxpv",
                    CustomData = "xjjib",
                    WindowsConfiguration = new ComputeFleetWindowsConfiguration()
                    {
                        IsVmAgentProvisioned = true,
                        IsAutomaticUpdatesEnabled = true,
                        TimeZone = "hlyjiqcfksgrpjrct",
                        AdditionalUnattendContent =
            {
new WindowsSetupAdditionalInformation()
{
PassName = WindowsSetupAdditionalInformationPassName.OobeSystem,
ComponentName = WindowsSetupAdditionalInformationComponentName.MicrosoftWindowsShellSetup,
SettingName = AdditionalInformationSettingName.AutoLogon,
Content = "bubmqbxjkj",
}
            },
                        PatchSettings = new ComputeFleetVmGuestPatchSettings()
                        {
                            PatchMode = ComputeFleetWindowsVmGuestPatchMode.Manual,
                            IsHotPatchingEnabled = true,
                            AssessmentMode = ComputeFleetWindowsPatchAssessmentMode.ImageDefault,
                            AutomaticByPlatformSettings = new ComputeFleetWindowsVmGuestPatchAutomaticByPlatformSettings()
                            {
                                RebootSetting = ComputeFleetWindowsVmGuestPatchAutomaticByPlatformRebootSetting.Unknown,
                                IsBypassPlatformSafetyChecksOnUserScheduleEnabled = true,
                            },
                        },
                        WinRMListeners =
            {
new ComputeFleetWinRMListener()
{
Protocol = ComputeFleetProtocolType.Https,
CertificateUri = new Uri("https://myVaultName.vault.azure.net/secrets/myCertName"),
}
            },
                        IsVmAgentPlatformUpdatesEnabled = true,
                    },
                    LinuxConfiguration = new ComputeFleetLinuxConfiguration()
                    {
                        IsPasswordAuthenticationDisabled = true,
                        SshPublicKeys =
            {
new ComputeFleetSshPublicKey()
{
Path = "kmqz",
KeyData = "kivgsubusvpprwqaqpjcmhsv",
}
            },
                        IsVmAgentProvisioned = true,
                        PatchSettings = new ComputeFleetLinuxPatchSettings()
                        {
                            PatchMode = ComputeFleetLinuxVmGuestPatchMode.ImageDefault,
                            AssessmentMode = ComputeFleetLinuxPatchAssessmentMode.ImageDefault,
                            AutomaticByPlatformSettings = new ComputeFleetLinuxVmGuestPatchAutomaticByPlatformSettings()
                            {
                                RebootSetting = ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting.Unknown,
                                IsBypassPlatformSafetyChecksOnUserScheduleEnabled = true,
                            },
                        },
                        IsVmAgentPlatformUpdatesEnabled = true,
                    },
                    Secrets =
            {
new ComputeFleetVaultSecretGroup()
{
SourceVaultId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}"),
VaultCertificates =
{
new ComputeFleetVaultCertificate()
{
CertificateUri = new Uri("https://myVaultName.vault.azure.net/secrets/myCertName"),
CertificateStore = "nlxrwavpzhueffxsshlun",
}
},
}
            },
                    AreExtensionOperationsAllowed = true,
                    IsGuestProvisionSignalRequired = true,
                },
                StorageProfile = new ComputeFleetVmssStorageProfile()
                {
                    ImageReference = new ComputeFleetImageReference()
                    {
                        Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}/versions/{versionName}"),
                        Publisher = "mqxgwbiyjzmxavhbkd",
                        Offer = "isxgumkarlkomp",
                        Sku = "eojmppqcrnpmxirtp",
                        Version = "wvpcqefgtmqdgltiuz",
                        SharedGalleryImageId = "kmkgihoxwlawuuhcinfirktdwkmx",
                        CommunityGalleryImageId = "vlqe",
                    },
                    OSDisk = new ComputeFleetVmssOSDisk(ComputeFleetDiskCreateOptionType.FromImage)
                    {
                        Name = "wfttw",
                        Caching = ComputeFleetCachingType.None,
                        IsWriteAcceleratorEnabled = true,
                        DiffDiskSettings = new ComputeFleetDiffDiskSettings()
                        {
                            Option = ComputeFleetDiffDiskOption.Local,
                            Placement = ComputeFleetDiffDiskPlacement.CacheDisk,
                        },
                        DiskSizeGB = 14,
                        OSType = ComputeFleetOperatingSystemType.Windows,
                        ImageUri = new Uri("https://myStorageAccountName.blob.core.windows.net/myContainerName/myVhdName.vhd"),
                        VhdContainers =
            {
"tkzcwddtinkfpnfklatw"
            },
                        ManagedDisk = new ComputeFleetVmssManagedDisk()
                        {
                            StorageAccountType = ComputeFleetStorageAccountType.StandardLrs,
                            DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}"),
                            SecurityProfile = new ComputeFleetVmDiskSecurityProfile()
                            {
                                SecurityEncryptionType = ComputeFleetSecurityEncryptionType.VmGuestStateOnly,
                                DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}"),
                            },
                        },
                        DeleteOption = ComputeFleetDiskDeleteOptionType.Delete,
                    },
                    DataDisks =
            {
new ComputeFleetVmssDataDisk(14,ComputeFleetDiskCreateOptionType.FromImage)
{
Name = "eogiykmdmeikswxmigjws",
Caching = ComputeFleetCachingType.None,
IsWriteAcceleratorEnabled = true,
DiskSizeGB = 6,
ManagedDisk = new ComputeFleetVmssManagedDisk()
{
StorageAccountType = ComputeFleetStorageAccountType.StandardLrs,
DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}"),
SecurityProfile = new ComputeFleetVmDiskSecurityProfile()
{
SecurityEncryptionType = ComputeFleetSecurityEncryptionType.VmGuestStateOnly,
DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}"),
},
},
DiskIopsReadWrite = 27L,
DiskMbpsReadWrite = 2L,
DeleteOption = ComputeFleetDiskDeleteOptionType.Delete,
}
            },
                },
                NetworkProfile = new ComputeFleetVmssNetworkProfile()
                {
                    HealthProbeId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}"),
                    NetworkInterfaceConfigurations =
            {
new ComputeFleetVmssNetworkConfiguration("i")
{
Properties = new ComputeFleetVmssNetworkConfigurationProperties(new ComputeFleetVmssIPConfiguration[]
{
new ComputeFleetVmssIPConfiguration("oezqhkidfhyywlfzwuotilrpbqnjg")
{
Properties = new ComputeFleetVmssIPConfigurationProperties()
{
SubnetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}"),
IsPrimary = true,
PublicIPAddressConfiguration = new ComputeFleetVmssPublicIPAddressConfiguration("fvpqf")
{
Properties = new ComputeFleetVmssPublicIPAddressConfigurationProperties()
{
IdleTimeoutInMinutes = 9,
DnsSettings = new ComputeFleetVmssPublicIPAddressDnsSettings("ukrddzvmorpmfsczjwtbvp")
{
DomainNameLabelScope = ComputeFleetDomainNameLabelScopeType.TenantReuse,
},
IPTags =
{
new ComputeFleetVmssIPTag()
{
IPTagType = "sddgsoemnzgqizale",
Tag = "wufmhrjsakbiaetyara",
}
},
PublicIPPrefixId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}"),
PublicIPAddressVersion = ComputeFleetIPVersion.IPv4,
DeleteOption = ComputeFleetVmDeleteOption.Delete,
},
Sku = new ComputeFleetPublicIPAddressSku()
{
Name = ComputeFleetPublicIPAddressSkuName.Basic,
Tier = ComputeFleetPublicIPAddressSkuTier.Regional,
},
},
PrivateIPAddressVersion = ComputeFleetIPVersion.IPv4,
ApplicationGatewayBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/backendAddressPools/{backendAddressPoolName}"),
}
},
ApplicationSecurityGroups =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}"),
}
},
LoadBalancerBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}"),
}
},
LoadBalancerInboundNatPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatPools/{inboundNatPoolName}"),
}
},
},
}
})
{
IsPrimary = true,
IsAcceleratedNetworkingEnabled = true,
IsTcpStateTrackingDisabled = true,
IsFpgaEnabled = true,
NetworkSecurityGroupId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}"),
DnsServers =
{
"nxmmfolhclsesu"
},
IsIPForwardingEnabled = true,
DeleteOption = ComputeFleetVmDeleteOption.Delete,
AuxiliaryMode = ComputeFleetNetworkInterfaceAuxiliaryMode.None,
AuxiliarySku = ComputeFleetNetworkInterfaceAuxiliarySku.None,
},
}
            },
                    NetworkApiVersion = ComputeFleetNetworkApiVersion.V20201101,
                },
                SecurityProfile = new ComputeFleetSecurityProfile()
                {
                    UefiSettings = new ComputeFleetUefiSettings()
                    {
                        IsSecureBootEnabled = true,
                        IsVTpmEnabled = true,
                    },
                    IsEncryptionAtHostEnabled = true,
                    SecurityType = ComputeFleetSecurityType.TrustedLaunch,
                    UserAssignedIdentityResourceId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{userAssignedIdentityName}"),
                    ProxyAgentSettings = new ComputeFleetProxyAgentSettings()
                    {
                        IsEnabled = true,
                        Mode = ProxyAgentExecuteMode.Audit,
                        KeyIncarnationId = 20,
                    },
                },
                BootDiagnostics = new ComputeFleetBootDiagnostics()
                {
                    IsEnabled = true,
                    StorageUri = new Uri("http://myStorageAccountName.blob.core.windows.net"),
                },
                ExtensionProfile = new ComputeFleetVmssExtensionProfile()
                {
                    Extensions =
            {
new ComputeFleetVmssExtension()
{
Name = "bndxuxx",
Properties = new ComputeFleetVmssExtensionProperties()
{
ForceUpdateTag = "yhgxw",
Publisher = "kpxtirxjfprhs",
ExtensionType = "pgjilctjjwaa",
TypeHandlerVersion = "zevivcoilxmbwlrihhhibq",
ShouldAutoUpgradeMinorVersion = true,
IsAutomaticUpgradeEnabled = true,
Settings =
{
},
ProtectedSettings =
{
},
ProvisionAfterExtensions =
{
"nftzosroolbcwmpupujzqwqe"
},
IsSuppressFailuresEnabled = true,
ProtectedSettingsFromKeyVault = new ComputeFleetKeyVaultSecretReference(new Uri("https://myvaultName.vault.azure.net/secrets/secret/mySecretName"),new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}"),
}),
},
}
            },
                    ExtensionsTimeBudget = "mbhjahtdygwgyszdwjtvlvtgchdwil",
                },
                LicenseType = "v",
                ScheduledEventsProfile = new ComputeFleetScheduledEventsProfile()
                {
                    TerminateNotificationProfile = new ComputeFleetTerminateNotificationProfile()
                    {
                        NotBeforeTimeout = "iljppmmw",
                        IsEnabled = true,
                    },
                    OSImageNotificationProfile = new ComputeFleetOSImageNotificationProfile()
                    {
                        NotBeforeTimeout = "olbpadmevekyczfokodtfprxti",
                        IsEnabled = true,
                    },
                },
                UserData = "s",
                CapacityReservationGroupId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}"),
                GalleryApplications =
            {
new ComputeFleetVmGalleryApplication(new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{applicationName}/versions/{versionName}"))
{
Tags = "eyrqjbib",
Order = 5,
ConfigurationReference = "ulztmiavpojpbpbddgnuuiimxcpau",
IsTreatFailureAsDeploymentFailureEnabled = true,
IsAutomaticUpgradeEnabled = true,
}
            },
                HardwareVmSizeProperties = new ComputeFleetVmSizeProperties()
                {
                    VCPUsAvailable = 16,
                    VCPUsPerCore = 23,
                },
                ServiceArtifactReferenceId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactsName}/vmArtifactsProfiles/{vmArtifactsProfileName}"),
                SecurityPostureReference = new ComputeFleetSecurityPostureReference()
                {
                    Id = "/CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest",
                    ExcludeExtensions =
            {
"{securityPostureVMExtensionName}"
            },
                    IsOverridable = true,
                },
            })
            {
                ComputeApiVersion = "2023-07-01",
                PlatformFaultDomainCount = 1,
            })
                {
                    SpotPriorityProfile = new SpotPriorityProfile()
                    {
                        Capacity = 20,
                        MinCapacity = 10,
                        MaxPricePerVm = 0.00865F,
                        EvictionPolicy = ComputeFleetEvictionPolicy.Delete,
                        AllocationStrategy = SpotAllocationStrategy.PriceCapacityOptimized,
                        IsMaintainEnabled = true,
                    },
                    RegularPriorityProfile = new RegularPriorityProfile()
                    {
                        Capacity = 20,
                        MinCapacity = 10,
                        AllocationStrategy = RegularPriorityAllocationStrategy.LowestPrice,
                    },
                },
                Zones =
{
"zone1","zone2"
},
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("key9851")] = new UserAssignedIdentity(),
},
                },
                Plan = new ArmPlan("jwgrcrnrtfoxn", "iozjbiqqckqm", "cgopbyvdyqikahwyxfpzwaqk")
                {
                    PromotionCode = "naglezezplcaruqogtxnuizslqnnbr",
                    Version = "wa",
                },
                Tags =
{
["key3518"] = "luvrnuvsgdpbuofdskkcoqhfh",
},
            };
            ArmOperation<ComputeFleetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fleetName, data);
            ComputeFleetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ComputeFleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Fleets_CreateOrUpdate_MinimumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FleetsCreateOrUpdateMinimumSet()
        {
            // Generated from example definition: 2024-05-01-preview/Fleets_CreateOrUpdate_MinimumSet.json
            // this example is just showing the usage of "Fleets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1DC2F28C-A625-4B0E-9748-9885A3C9E9EB";
            string resourceGroupName = "rgazurefleet";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ComputeFleetResource
            ComputeFleetCollection collection = resourceGroupResource.GetComputeFleets();

            // invoke the operation
            string fleetName = "testFleet";
            ComputeFleetData data = new ComputeFleetData(new AzureLocation("eastus2euap"))
            {
                Properties = new ComputeFleetProperties(new ComputeFleetVmSizeProfile[]
            {
new ComputeFleetVmSizeProfile("Standard_D2s_v3"),new ComputeFleetVmSizeProfile("Standard_D4s_v3"),new ComputeFleetVmSizeProfile("Standard_E2s_v3")
            }, new ComputeFleetComputeProfile(new ComputeFleetVmProfile()
            {
                OSProfile = new ComputeFleetVmssOSProfile()
                {
                    ComputerNamePrefix = "prefix",
                    AdminUsername = "azureuser",
                    AdminPassword = "TestPassword$0",
                    LinuxConfiguration = new ComputeFleetLinuxConfiguration()
                    {
                        IsPasswordAuthenticationDisabled = false,
                    },
                },
                StorageProfile = new ComputeFleetVmssStorageProfile()
                {
                    ImageReference = new ComputeFleetImageReference()
                    {
                        Publisher = "canonical",
                        Offer = "0001-com-ubuntu-server-focal",
                        Sku = "20_04-lts-gen2",
                        Version = "latest",
                    },
                    OSDisk = new ComputeFleetVmssOSDisk(ComputeFleetDiskCreateOptionType.FromImage)
                    {
                        Caching = ComputeFleetCachingType.ReadWrite,
                        OSType = ComputeFleetOperatingSystemType.Linux,
                        ManagedDisk = new ComputeFleetVmssManagedDisk()
                        {
                            StorageAccountType = ComputeFleetStorageAccountType.StandardLrs,
                        },
                    },
                },
                NetworkProfile = new ComputeFleetVmssNetworkProfile()
                {
                    NetworkInterfaceConfigurations =
            {
new ComputeFleetVmssNetworkConfiguration("vmNameTest")
{
Properties = new ComputeFleetVmssNetworkConfigurationProperties(new ComputeFleetVmssIPConfiguration[]
{
new ComputeFleetVmssIPConfiguration("vmNameTest")
{
Properties = new ComputeFleetVmssIPConfigurationProperties()
{
SubnetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}"),
IsPrimary = true,
LoadBalancerBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}"),
}
},
},
}
})
{
IsPrimary = true,
IsAcceleratedNetworkingEnabled = false,
IsIPForwardingEnabled = true,
},
}
            },
                },
            })
            {
                ComputeApiVersion = "2023-09-01",
                PlatformFaultDomainCount = 1,
            })
                {
                    SpotPriorityProfile = new SpotPriorityProfile()
                    {
                        Capacity = 2,
                        MinCapacity = 1,
                        EvictionPolicy = ComputeFleetEvictionPolicy.Delete,
                        AllocationStrategy = SpotAllocationStrategy.PriceCapacityOptimized,
                        IsMaintainEnabled = true,
                    },
                    RegularPriorityProfile = new RegularPriorityProfile()
                    {
                        Capacity = 2,
                        MinCapacity = 1,
                        AllocationStrategy = RegularPriorityAllocationStrategy.LowestPrice,
                    },
                },
                Tags =
{
["key"] = "fleets-test",
},
            };
            ArmOperation<ComputeFleetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fleetName, data);
            ComputeFleetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ComputeFleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Fleets_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FleetsListByResourceGroup()
        {
            // Generated from example definition: 2024-05-01-preview/Fleets_ListByResourceGroup.json
            // this example is just showing the usage of "Fleet_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1DC2F28C-A625-4B0E-9748-9885A3C9E9EB";
            string resourceGroupName = "rgazurefleet";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ComputeFleetResource
            ComputeFleetCollection collection = resourceGroupResource.GetComputeFleets();

            // invoke the operation and iterate over the result
            await foreach (ComputeFleetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ComputeFleetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
