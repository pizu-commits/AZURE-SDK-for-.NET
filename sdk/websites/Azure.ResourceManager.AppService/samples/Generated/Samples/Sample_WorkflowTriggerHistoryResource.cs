// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WorkflowTriggerHistoryResource
    {
        // Get a workflow trigger history
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAWorkflowTriggerHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/WorkflowTriggerHistories_Get.json
            // this example is just showing the usage of "WorkflowTriggerHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowTriggerHistoryResource created on azure
            // for more information of creating WorkflowTriggerHistoryResource, please refer to the document of WorkflowTriggerHistoryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroup";
            string name = "test-name";
            string workflowName = "testWorkflowName";
            string triggerName = "testTriggerName";
            string historyName = "08586676746934337772206998657CU22";
            ResourceIdentifier workflowTriggerHistoryResourceId = WorkflowTriggerHistoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, triggerName, historyName);
            WorkflowTriggerHistoryResource workflowTriggerHistory = client.GetWorkflowTriggerHistoryResource(workflowTriggerHistoryResourceId);

            // invoke the operation
            WorkflowTriggerHistoryResource result = await workflowTriggerHistory.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkflowTriggerHistoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Resubmit a workflow run based on the trigger history
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Resubmit_ResubmitAWorkflowRunBasedOnTheTriggerHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/WorkflowTriggerHistories_Resubmit.json
            // this example is just showing the usage of "WorkflowTriggerHistories_Resubmit" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowTriggerHistoryResource created on azure
            // for more information of creating WorkflowTriggerHistoryResource, please refer to the document of WorkflowTriggerHistoryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroup";
            string name = "test-name";
            string workflowName = "testWorkflowName";
            string triggerName = "testTriggerName";
            string historyName = "testHistoryName";
            ResourceIdentifier workflowTriggerHistoryResourceId = WorkflowTriggerHistoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, triggerName, historyName);
            WorkflowTriggerHistoryResource workflowTriggerHistory = client.GetWorkflowTriggerHistoryResource(workflowTriggerHistoryResourceId);

            // invoke the operation
            await workflowTriggerHistory.ResubmitAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
