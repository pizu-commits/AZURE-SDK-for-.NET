// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_DevOpsProjectCollection
    {
        // List_AzureDevOpsProjects
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAzureDevOpsProjects()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/ListAzureDevOpsProjects_example.json
            // this example is just showing the usage of "AzureDevOpsProjects_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsOrgResource created on azure
            // for more information of creating DevOpsOrgResource, please refer to the document of DevOpsOrgResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            ResourceIdentifier devOpsOrgResourceId = DevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName);
            DevOpsOrgResource devOpsOrg = client.GetDevOpsOrgResource(devOpsOrgResourceId);

            // get the collection of this DevOpsProjectResource
            DevOpsProjectCollection collection = devOpsOrg.GetDevOpsProjects();

            // invoke the operation and iterate over the result
            await foreach (DevOpsProjectResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevOpsProjectData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get_AzureDevOpsProjects
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureDevOpsProjects()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsProjects_example.json
            // this example is just showing the usage of "AzureDevOpsProjects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsOrgResource created on azure
            // for more information of creating DevOpsOrgResource, please refer to the document of DevOpsOrgResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            ResourceIdentifier devOpsOrgResourceId = DevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName);
            DevOpsOrgResource devOpsOrg = client.GetDevOpsOrgResource(devOpsOrgResourceId);

            // get the collection of this DevOpsProjectResource
            DevOpsProjectCollection collection = devOpsOrg.GetDevOpsProjects();

            // invoke the operation
            string projectName = "myAzDevOpsProject";
            DevOpsProjectResource result = await collection.GetAsync(projectName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get_AzureDevOpsProjects
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAzureDevOpsProjects()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsProjects_example.json
            // this example is just showing the usage of "AzureDevOpsProjects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsOrgResource created on azure
            // for more information of creating DevOpsOrgResource, please refer to the document of DevOpsOrgResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            ResourceIdentifier devOpsOrgResourceId = DevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName);
            DevOpsOrgResource devOpsOrg = client.GetDevOpsOrgResource(devOpsOrgResourceId);

            // get the collection of this DevOpsProjectResource
            DevOpsProjectCollection collection = devOpsOrg.GetDevOpsProjects();

            // invoke the operation
            string projectName = "myAzDevOpsProject";
            bool result = await collection.ExistsAsync(projectName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get_AzureDevOpsProjects
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAzureDevOpsProjects()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsProjects_example.json
            // this example is just showing the usage of "AzureDevOpsProjects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsOrgResource created on azure
            // for more information of creating DevOpsOrgResource, please refer to the document of DevOpsOrgResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            ResourceIdentifier devOpsOrgResourceId = DevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName);
            DevOpsOrgResource devOpsOrg = client.GetDevOpsOrgResource(devOpsOrgResourceId);

            // get the collection of this DevOpsProjectResource
            DevOpsProjectCollection collection = devOpsOrg.GetDevOpsProjects();

            // invoke the operation
            string projectName = "myAzDevOpsProject";
            NullableResponse<DevOpsProjectResource> response = await collection.GetIfExistsAsync(projectName);
            DevOpsProjectResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevOpsProjectData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate_AzureDevOpsProjects
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAzureDevOpsProjects()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/CreateOrUpdateAzureDevOpsProjects_example.json
            // this example is just showing the usage of "AzureDevOpsProjects_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsOrgResource created on azure
            // for more information of creating DevOpsOrgResource, please refer to the document of DevOpsOrgResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            ResourceIdentifier devOpsOrgResourceId = DevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName);
            DevOpsOrgResource devOpsOrg = client.GetDevOpsOrgResource(devOpsOrgResourceId);

            // get the collection of this DevOpsProjectResource
            DevOpsProjectCollection collection = devOpsOrg.GetDevOpsProjects();

            // invoke the operation
            string projectName = "myAzDevOpsProject";
            DevOpsProjectData data = new DevOpsProjectData()
            {
                Properties = new DevOpsProjectProperties()
                {
                    OnboardingState = ResourceOnboardingState.NotApplicable,
                    ActionableRemediation = new ActionableRemediation()
                    {
                        State = ActionableRemediationState.Enabled,
                    },
                },
            };
            ArmOperation<DevOpsProjectResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, projectName, data);
            DevOpsProjectResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
