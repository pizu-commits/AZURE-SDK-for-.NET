// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkDnsZoneCollection
    {
        // WorkloadNetworks_ListDnsZones
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WorkloadNetworksListDnsZones()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_ListDnsZones.json
            // this example is just showing the usage of "WorkloadNetworks_ListDnsZones" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDnsZoneResource
            WorkloadNetworkDnsZoneCollection collection = workloadNetwork.GetWorkloadNetworkDnsZones();

            // invoke the operation and iterate over the result
            await foreach (WorkloadNetworkDnsZoneResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkDnsZoneData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkloadNetworks_GetDnsZone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkloadNetworksGetDnsZone()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetDnsZone.json
            // this example is just showing the usage of "WorkloadNetworks_GetDnsZone" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDnsZoneResource
            WorkloadNetworkDnsZoneCollection collection = workloadNetwork.GetWorkloadNetworkDnsZones();

            // invoke the operation
            string dnsZoneId = "dnsZone1";
            WorkloadNetworkDnsZoneResource result = await collection.GetAsync(dnsZoneId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDnsZoneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_GetDnsZone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WorkloadNetworksGetDnsZone()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetDnsZone.json
            // this example is just showing the usage of "WorkloadNetworks_GetDnsZone" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDnsZoneResource
            WorkloadNetworkDnsZoneCollection collection = workloadNetwork.GetWorkloadNetworkDnsZones();

            // invoke the operation
            string dnsZoneId = "dnsZone1";
            bool result = await collection.ExistsAsync(dnsZoneId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WorkloadNetworks_GetDnsZone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_WorkloadNetworksGetDnsZone()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetDnsZone.json
            // this example is just showing the usage of "WorkloadNetworks_GetDnsZone" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDnsZoneResource
            WorkloadNetworkDnsZoneCollection collection = workloadNetwork.GetWorkloadNetworkDnsZones();

            // invoke the operation
            string dnsZoneId = "dnsZone1";
            NullableResponse<WorkloadNetworkDnsZoneResource> response = await collection.GetIfExistsAsync(dnsZoneId);
            WorkloadNetworkDnsZoneResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkDnsZoneData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // WorkloadNetworks_CreateDnsZone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WorkloadNetworksCreateDnsZone()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_CreateDnsZone.json
            // this example is just showing the usage of "WorkloadNetworks_CreateDnsZone" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkDnsZoneResource
            WorkloadNetworkDnsZoneCollection collection = workloadNetwork.GetWorkloadNetworkDnsZones();

            // invoke the operation
            string dnsZoneId = "dnsZone1";
            WorkloadNetworkDnsZoneData data = new WorkloadNetworkDnsZoneData()
            {
                DisplayName = "dnsZone1",
                Domain =
{
},
                DnsServerIPs =
{
IPAddress.Parse("1.1.1.1")
},
                SourceIP = IPAddress.Parse("8.8.8.8"),
                Revision = 1L,
            };
            ArmOperation<WorkloadNetworkDnsZoneResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dnsZoneId, data);
            WorkloadNetworkDnsZoneResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDnsZoneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
